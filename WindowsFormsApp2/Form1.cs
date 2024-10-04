using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Cognex.InSight;
using Cognex.InSight.Controls.Display;
using Cognex.InSight.Controls.Filmstrip;
using Cognex.InSight.NativeMode;
using Cognex.InSight.Net;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        // 필름 스트립 컨트롤에 표시된 이미지를 보관하는 재생 폴더
        // 현재 프로그램 폴더 안에 \bin\Debug\playbackFile 생성
        private string PlaybackFolders = Application.StartupPath + @"\playbackFiles";

        // InSigth 센서와 통신하는 개체
        private CvsInSight mInSight;

        // 네트워크의 센서를 감지하는 네트워크 모니터
        private CvsNetworkMonitor mMonitor;

        // 현재 연결된 센서
        private CvsHostSensor mSensor;

        // 필름 스트립 처리와 관련된 결과를 큐에 저장하고 관리하는 기능
        // 이미지 검사 결과를 저장하고 후속 처리를 위해 큐에 저장
        private CvsFilmstripResultsQueue mResultQueue;

        // In-Sight 개체가 지원하는 재생을 처리
        private CvsFilmstripPlayback mPlayback;

        // Native Mode Command Protocol을 사용하여 Insight에 직접 연결
        private CvsNativeModeClient cvsNativeModeClient;

        private enum ConnectStatus
        {
            Disconnected = 0,
            Connecting = 1,
            Connected = 2,
            Disconnecting = 3,
            NA = 4
        }

        public Form1()
        {
            InitializeComponent();

            // Insight Display 컨트롤을 사용하기 전에 Cognex SDK를 초기화
            CvsInSightSoftwareDevelopmentKit.Initialize();

            // 초기 상태표시
            UpdateStatus(ConnectStatus.Disconnected, null);

            // 요약 막대 표시
            cvsFilmstrip.ShowSummary = true;

            // 디스플레이 및 필름 스트립 초기화
            Init();

            this.hScrollBar1.Maximum += this.hScrollBar1.LargeChange - 1;
            this.hScrollBar2.Maximum += this.hScrollBar2.LargeChange - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cvsNativeModeClient = new CvsNativeModeClient();
            cvsNativeModeClient.ConnectCompleted += CvsNativeModeClient_ConnectCompleted;
        }

        // 센서 연결 상태 확인
        private bool IsConnected
        {
            get
            {
                if (mInSight != null)
                {
                    // true 반환
                    return mInSight.State != CvsInSightState.NotConnected;
                }
                else
                {
                    return false;
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsConnected)
                {
                    // 선택한 주소 이름을 문자열로 변환 후 해당 장치 정보를 가져와 mSensor에 담는다
                    mSensor = mMonitor.Hosts[cboDevices.SelectedItem.ToString()];

                    // mSensor 장치의 IP주소 기타 연결 정보에 접근이 가능
                    cvsInSightDisplay1.Connect(mSensor.IPAddressString, "admin", "", false);

                    cvsNativeModeClient.ConnectAsynchronous(mSensor.IPAddressString, "admin", "");

                    groupBox3.Enabled = true;
                    rbSensor.Checked = true;

                   

                }
                else
                {
                    UpdateStatus(ConnectStatus.Disconnecting);
                    cvsInSightDisplay1.Disconnect();
                    mSensor = null;
                    rbPC.Checked = false;
                    rbSensor.Checked = false;
                    groupBox3.Enabled = false;

                    BlobRes.Text = "Result";
                    OCRRes.Text = "Result";
                    CX1.Text = "X : ";
                    CY1.Text = "Y : ";
                    CA1.Text = "Angle : ";
                    OKNGBox.Text = "OK/NG";
                    OKNGBox2.Text = "OK/NG";
                }
                Refresh();
            }
            catch (CvsException cvsEx)
            {
                mMonitor.Enabled = true;
                Trace.WriteLine(cvsEx.Message);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
            UpdateControls(false);
        }

        private void UpdateStatus(ConnectStatus status)
        {
            UpdateStatus(status, null);
        }

        private void UpdateStatus(string message)
        {
            UpdateStatus(ConnectStatus.NA, message);
        }

        private void UpdateStatus(ConnectStatus status, string message)
        {
            string statusText = "";
            string titleText = "In-Sight Filmstrip control";
            statusCurrent.Tag = status;

            switch (status)
            {
                case ConnectStatus.Connecting:
                    statusText = "Connecting...";
                    break;
                case ConnectStatus.Disconnecting:
                    statusText = "Disconnecting...";
                    break;
                case ConnectStatus.Connected:
                    statusText = "Connected";
                    break;
                case ConnectStatus.Disconnected:
                    statusText = "Not Connected";
                    break;
                case ConnectStatus.NA:
                    break;
            }


            // 에러가 없거나 센서 신호가 있을때
            if (mInSight != null && status != ConnectStatus.NA)
            {
                if (mInSight.State != CvsInSightState.NotConnected)
                {
                    // Live 상태 확인
                    if (mInSight.LiveAcquisition)
                    {
                        statusText += "and in Live Mode";
                    }
                    statusText += (mInSight.State == CvsInSightState.Offline) ? " - Sensor is Offline" : " - Sensor is Online";
                    titleText += " - " + cboDevices.Text;
                }
            }

            if (message != null)
            {
                statusText += " - " + message;
            }
            statusCurrent.Text = statusText;
            this.Text = titleText;
            statusStrip1.Refresh();

        }

        private void Init()
        {
            // 네트워크 모니터를 만들고 디스플레이의 Insight이벤트에 연결
            mMonitor = new CvsNetworkMonitor();
            mMonitor.PingInterval = 0;

            mInSight = cvsInSightDisplay1.InSight;
            cvsInSightDisplay1.ShowGrid = true;
            cvsInSightDisplay1.ShowGraphics = true;
            cvsInSightDisplay1.ShowImage = true;
            cvsInSightDisplay1.ShowScrollBars = true;
            cvsInSightDisplay1.GridOpacity = 0.7;
            cvsInSightDisplay1.ImageScale = 1.0;

            // callback 이벤트 연결
            cvsInSightDisplay1.StatusInformationChanged += CvsInSightDisplay1_StatusInformationChanged;
            cvsInSightDisplay1.InSightChanged += CvsInSightDisplay1_InSightChanged;

            mMonitor.HostsChanged += MMonitor_HostsChanged;
            mMonitor.Enabled = true;

            // 폴더가 없을때 해당 경로에 폴더 생성
            if (!Directory.Exists(PlaybackFolders))
            {
                Directory.CreateDirectory(PlaybackFolders);
            }

            // 레코드 / 재생 폴더 설정
            cvsInSightDisplay1.Recorder.RecordFolder = PlaybackFolders;
            cvsInSightDisplay1.Recorder.PlaybackFolder = PlaybackFolders;

            // 결과 대기열 및 재생 연산자를 만듬
            mResultQueue = new CvsFilmstripResultsQueue(cvsFilmstrip);
            mPlayback = new CvsFilmstripPlayback(cvsFilmstrip);

            InSight = cvsInSightDisplay1.InSight;

            // 바인드 설정
            BindControls();

            // 새로고침
            UpdateControls(true);

        }

        private void CvsNativeModeClient_ConnectCompleted(object sender, CvsConnectCompletedEventArgs e)
        {
            const int ExtLen = 3;
            string response, fList;
            int dotLoc = 0;

            cvsNativeModeClient.SendCommand("get filelist");
            System.Xml.XmlDocument xDoc = new System.Xml.XmlDocument();
            response = cvsNativeModeClient.LastResponseString;
            xDoc.LoadXml(@"<?xml version=""1.0""?>" + response);

            fList = xDoc.DocumentElement.InnerText.Substring(2);

            cboFilesList.Items.Clear();

            while (fList.Length > ExtLen)
            {
                dotLoc = fList.IndexOf('.');
                if (fList.Substring(dotLoc, ExtLen + 1) == ".job")
                    cboFilesList.Items.Add(fList.Substring(0, dotLoc + ExtLen + 1));
                fList = fList.Substring(dotLoc + ExtLen + 1);

            }

            statusCurrent.Text = "Connected. [" + cvsNativeModeClient.RemoteIPAddressString + "] [" + cboDevices.Text + "]";

        }

        private void MMonitor_HostsChanged(object sender, EventArgs e)
        {
            cboDevices.Items.Clear();
            // 주소가 없을때 cboDevices 비활성화
            cboDevices.Enabled = mMonitor.Hosts.Count > 0;

            // 주소의 이름을 출력
            foreach (CvsHostSensor host in mMonitor.Hosts)
            {
                cboDevices.Items.Add(host.Name);
            }

            if (cboDevices.Items.Count > 0)
            {
                if (IsConnected)
                {
                    cboDevices.SelectedIndex = cboDevices.Items.IndexOf(mSensor.Name);
                }
                else
                {
                    cboDevices.SelectedIndex = 0;
                }
            }
            UpdateControls(true);
        }

        private void CvsInSightDisplay1_InSightChanged(object sender, EventArgs e)
        {
            InSight = cvsInSightDisplay1.InSight;

            // 재생 기능을 사용할 수 있도록 지정
            mPlayback.Recorder = cvsInSightDisplay1.Recorder;

            UpdateControls(true);
        }

        // 디스플레이의 상태 정보가 변경했을때 이벤트를 호출
        private void CvsInSightDisplay1_StatusInformationChanged(object sender, EventArgs e)
        {
            UpdateStatus(cvsInSightDisplay1.StatusInformation);
        }

        private CvsInSight InSight
        {
            get { return mInSight; }
            set
            {
                // 기존 값이 null이 아닌 경우 이벤트 해제
                if (mInSight != null)
                {
                    mInSight.StateChanged -= MInSigth_StateChanged;
                }
                // 새 값으로 설정
                mInSight = value;
                // 새로운 값이 null이 아닌 경우 이벤트 실행
                if (mInSight != null)
                {
                    mInSight.StateChanged += MInSigth_StateChanged;

                    // mResultQueue에 mInSigth를 연결
                    mResultQueue.InSight = mInSight;

                    // mResultQueue 설정 초기화
                    // 모든 결과를 큐에 저장 QueueSize가 초과되면 가장 오랜된 항목부터 제거
                    mResultQueue.Settings.Mode = CvsFilmstripResultsQueueMode.All;
                    // 큐에 저장될 최대 결과 수
                    mResultQueue.Settings.QueueSize = 20;
                    // 온라인 상태에서 큐를 비울지 여부 지정
                    mResultQueue.Settings.ClearOnline = false;
                    // 결과 큐의 유형 지정
                    // 마지막 결과를 유지
                    mResultQueue.Settings.Type = CvsFilmstripResultsQueueType.Last;

                }
            }
        }

        private void MInSigth_StateChanged(object sender, CvsStateChangedEventArgs e)
        {
            UpdateControls(true);
        }

        private void UpdateControls(bool update)
        {
            if (!IsConnected)
            {
                viewToolStripMenuItem.Enabled = false;
                imageToolStripMenuItem.Enabled = false;
                sensorToolStripMenuItem.Enabled = false;
                optionsToolStripMenuItem.Enabled = false;
                cboDevices.Enabled = mMonitor.Hosts.Count > 0;
                btnConnect.Text = "Connect";

                if (((ConnectStatus)statusCurrent.Tag == ConnectStatus.Connecting) && update)
                {
                    UpdateStatus(ConnectStatus.Disconnected, "Connection Failed");
                    MessageBox.Show(this, "Failed to Connect", "Error");
                }
                else
                {
                    UpdateStatus(ConnectStatus.Disconnected);
                }
                btnConnect.Enabled = mMonitor.Hosts.Count > 0;

                cboFilesList.Enabled = false;
                btnFileConnect.Enabled = false;
            }
            else
            {
                imageToolStripMenuItem.Enabled = true;
                sensorToolStripMenuItem.Enabled = true;
                customViewToolStripMenuItem.Checked = mInSight.JobInfo.AnyCustomViews;
                overlayToolStripMenuItem.Checked = cvsInSightDisplay1.ShowGrid;

                // Live Mode 체크
                liveModeToolStripMenuItem.Checked = mInSight.LiveAcquisition;
                if (mInSight.LiveAcquisition)
                {
                    sensorToolStripMenuItem.Enabled = false;
                    viewToolStripMenuItem.Enabled = false;
                    optionsToolStripMenuItem.Enabled = false;
                }
                else
                {
                    sensorToolStripMenuItem.Enabled = true;
                    viewToolStripMenuItem.Enabled = true;
                    optionsToolStripMenuItem.Enabled = true;
                }
                cboDevices.Enabled = false;
                btnConnect.Text = "Disconnect";
                UpdateStatus(ConnectStatus.Connected);

                // Live Mode 클릭 표시
                onlineToolStripMenuItem.Text = (mInSight.State == CvsInSightState.Offline) ? "Go Online" : "Go Offline";

                cboFilesList.Enabled = true;
                btnFileConnect.Enabled = true;

            }

        }

        // 바인드
        private void BindControls()
        {
            cvsInSightDisplay1.Edit.ManualAcquire.Bind(manualTriggerToolStripMenuItem);
            cvsInSightDisplay1.Edit.LiveAcquire.Bind(liveModeToolStripMenuItem);
            cvsInSightDisplay1.Edit.ZoomImageIn.Bind(zoomInToolStripMenuItem);
            cvsInSightDisplay1.Edit.ZoomImageOut.Bind(zoomOutToolStripMenuItem);
            cvsInSightDisplay1.Edit.ZoomImage1To1.Bind(zoom11ToolStripMenuItem);
            cvsInSightDisplay1.Edit.ZoomImageToFit.Bind(zoomToFitToolStripMenuItem);
            cvsInSightDisplay1.Edit.ZoomImageToFill.Bind(zoomToFillToolStripMenuItem);

            cvsInSightDisplay1.Edit.SoftOnline.Bind(onlineToolStripMenuItem);

            cvsInSightDisplay1.Edit.ZoomGridIn.Bind(zoomInToolStripMenuItem1);
            cvsInSightDisplay1.Edit.ZoomGridOut.Bind(zoomOutToolStripMenuItem1);

            cvsInSightDisplay1.Edit.ShowCustomView.Bind(customViewToolStripMenuItem);
            cvsInSightDisplay1.Edit.ShowGrid.Bind(overlayToolStripMenuItem);
            
            cvsInSightDisplay1.Edit.IncreaseGridOpacity.Bind(decreaseToolStripMenuItem);
            cvsInSightDisplay1.Edit.DecreaseGridOpacity.Bind(increaseToolStripMenuItem);

            cvsInSightDisplay1.Edit.OpenJob.Bind(openJobToolStripMenuItem);


        }

        private void rbPC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPC.Checked)
                cvsFilmstrip.FilmQueue = mPlayback;
            else
                cvsFilmstrip.FilmQueue = null;
            UpdateFilmstripActions(false);
        }

        private void rbSensor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSensor.Checked)
                cvsFilmstrip.FilmQueue = mResultQueue;
            else
                cvsFilmstrip.FilmQueue = null;
            UpdateFilmstripActions(true);
        }

        private void UpdateFilmstripActions(bool resultsQueueMode)
        {
            UnbindActions();

            if (resultsQueueMode)
            {
                // 센서
                btnFreeze.Visible = true;
                btnSave.Visible = true;
                btnClear.Visible = true;

                chkPlay.Visible = false;
                chkRecord.Visible = false;

                btnFirst.Enabled = true;
                btnLast.Enabled = true;
                btnNextPage.Enabled = true;
                btnPrevPage.Enabled = true;
                btnSave.Enabled = true;
                btnClear.Enabled = true;
                btnFreeze.Enabled = true;

                // mResultQueue 바인드 설정
                mResultQueue.SelectFirst.Bind(btnFirst);
                mResultQueue.SelectLast.Bind(btnLast);
                mResultQueue.SelectNext.Bind(btnNextPage);
                mResultQueue.SelectPrevious.Bind(btnPrevPage);
                mResultQueue.SaveQueue.Bind(btnSave);
                mResultQueue.ClearQueue.Bind(btnClear);
                mResultQueue.FreezeQueue.Bind(btnFreeze);

            }
            else
            {
                // PC
                btnFreeze.Visible = false;
                btnSave.Visible = false;
                btnClear.Visible = false;

                chkPlay.Visible = true;
                chkRecord.Visible = true;

                btnFirst.Enabled = true;
                btnLast.Enabled = true;
                btnNextPage.Enabled = true;
                btnPrevPage.Enabled = true;

                btnSave.Enabled = false;
                btnClear.Enabled = false;
                btnFreeze.Enabled = false;

                // mPlayback 바인드 설정
                mPlayback.SelectFirst.Bind(btnFirst);
                mPlayback.SelectLast.Bind(btnLast);
                mPlayback.SelectNext.Bind(btnNextPage);
                mPlayback.SelectPrevious.Bind(btnPrevPage);
            }
        }

        // 바인드 비활성화
        private void UnbindActions()
        {
            mResultQueue.SelectFirst.Unbind(btnFirst);
            mResultQueue.SelectLast.Unbind(btnLast);
            mResultQueue.SelectNext.Unbind(btnNextPage);
            mResultQueue.SelectPrevious.Unbind(btnPrevPage);
            mResultQueue.SaveQueue.Unbind(btnSave);
            mResultQueue.ClearQueue.Unbind(btnClear);
            mResultQueue.FreezeQueue.Unbind(btnFreeze);

            mPlayback.SelectFirst.Unbind(btnFirst);
            mPlayback.SelectLast.Unbind(btnLast);
            mPlayback.SelectNext.Unbind(btnNextPage);
            mPlayback.SelectPrevious.Unbind(btnPrevPage);
        }

        private void chkRecord_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRecord.Checked)
            {
                chkPlay.Checked = false;
            }
            else
            {
                // 녹화가 완료되고 업데이트
                mPlayback.Recorder.Refresh();
            }
            // 녹화 기능을 제어
            mPlayback.Recorder.RecordActive = chkRecord.Checked;

        }

        private void chkPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPlay.Checked)
            {
                chkRecord.Checked = false;
            }
            // 이전에 녹화된 영상을 재생하고 있는지 여부를 나타내는 값을 가져오거나 설정
            mPlayback.Recorder.PlayActive = chkPlay.Checked;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshData()
        {
            try
            {
                string xy_x = string.Format(cvsInSightDisplay1.Results.Cells["B27"].ToString(), -7);
                string xy_y = string.Format(cvsInSightDisplay1.Results.Cells["C27"].ToString(), -7);
                string angle = string.Format(cvsInSightDisplay1.Results.Cells["D27"].ToString(), -7);
                if (xy_x == null && xy_y == null && angle == null)
                {
                    CX1.Text = "X : NULL";
                    CY1.Text = "Y : NULL";
                    CA1.Text = "Angle : NULL";
                }
                else
                {
                    CX1.Text = "X : " + xy_x;
                    CY1.Text = "Y : " + xy_y;
                    CA1.Text = "Angle : " + angle;
                }

                string Blobresult = cvsInSightDisplay1.Results.Cells["B45"].ToString();
                if (Blobresult == null)
                {
                    BlobRes.Text = "NULL";
                }
                else
                {
                    BlobRes.Text = Blobresult + " 개";
                }

                string OCRresult = cvsInSightDisplay1.Results.Cells["D94"].ToString();
                if (OCRresult == null)
                {
                    OCRRes.Text = "NULL";
                }
                else
                {
                    OCRRes.Text = OCRresult;
                }

                string Bresult = cvsInSightDisplay1.Results.Cells["C47"].ToString();
                if (Bresult == null)
                {
                    OKNGBox2.Text = "OK/NG";
                }
                else
                {
                    if (Convert.ToInt32(Bresult) > 1)
                        OKNGBox.Text = "NG";
                    else
                        OKNGBox.Text = "OK";
                }

                string Oresult = cvsInSightDisplay1.Results.Cells["C168"].ToString();
                if (Oresult == null)
                {
                    OKNGBox2.Text = "OK/NG";
                }
                else
                {
                    if (Convert.ToInt32(Oresult) > 1)
                        OKNGBox2.Text = "NG";
                    else
                        OKNGBox2.Text = "OK";
                }
            }
            catch { }

        }

        private void CvsInSightDisplay1_ResultsChanged(object sender, EventArgs e)
        {
            if (IsConnected)
                RefreshData();
            cvsInSightDisplay1.AcceptUpdate();
        }

        private void UpdateTestStatus(string message)
        {
            statusCurrent.Text = message;
        }

        private void btnFileConnect_Click(object sender, EventArgs e)
        {
            bool bState;

            if (mInSight != null)
            {
                bState = mInSight.SoftOnline;

                mInSight.SoftOnline = false;

                if (cboFilesList.SelectedIndex >= 0)
                {
                    string selectedFile = cboFilesList.SelectedItem.ToString();
                    mInSight.File.LoadJobFile(selectedFile);
                }

                mInSight.SoftOnline = bState;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                OpenJobForm OJF = new OpenJobForm();
                OJF._inSight = mInSight;
                OJF.Show();
            }

            UpdateTestStatus("OpenJob " + cvsInSightDisplay1.Edit.OpenJob);
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            if (IsConnected)
                cvsInSightDisplay1.ShowGrid = !cvsInSightDisplay1.ShowGrid;
            UpdateTestStatus("Show Grid " + cvsInSightDisplay1.ShowGrid);
        }

        // 트리거
        private void btnTgg_Click(object sender, EventArgs e)
        {
            if (IsConnected)
                cvsInSightDisplay1.InSight.ManualAcquire(wait: true);

            UpdateTestStatus("ManualAcquire " + cvsInSightDisplay1.Edit.ManualAcquire);
        }

        // 라이브
        private void btnLive_Click(object sender, EventArgs e)
        {
            if (IsConnected)
                cvsInSightDisplay1.InSight.LiveAcquisition = !cvsInSightDisplay1.InSight.LiveAcquisition;
            UpdateTestStatus("LiveAcquire " + cvsInSightDisplay1.Edit.LiveAcquire.Activated);
        }

        //  줌인
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            double maxValue = 20.0;

            double currentScale = cvsInSightDisplay1.ImageScale;

            double zoomFactor = 0.1;
            double newScale = currentScale + zoomFactor;

            if (newScale > maxValue)
            {
                newScale = maxValue;
            }

            cvsInSightDisplay1.ImageScale = newScale;
            MessageBox.Show($"currentScale{currentScale} : newScale{newScale} : maxValue{maxValue}");

            UpdateTestStatus("ZoomImageIn " + cvsInSightDisplay1.Edit.ZoomImageIn);
        }

        // 줌 아웃
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            double minValue = 0.1;

            double currentScale = cvsInSightDisplay1.ImageScale;

            double zoomFactor = 0.1;
            double newScale = currentScale - zoomFactor;

            if (newScale < minValue)
            {
                newScale = minValue;
            }

            cvsInSightDisplay1.ImageScale = newScale;
            MessageBox.Show($"currentScale{currentScale} : newScale{newScale} : maxValue{minValue}");

            UpdateTestStatus("ZoomImageOut " + cvsInSightDisplay1.Edit.ZoomImageOut);
        }

        // 줌 1:1
        private void btnZoom1_Click(object sender, EventArgs e)
        {
            if (IsConnected)
                cvsInSightDisplay1.ImageScale = 1.1;
            UpdateTestStatus("ZoomImage1To1 " + cvsInSightDisplay1.Edit.ZoomImage1To1);
        }

        private void btnZoomFit_Click(object sender, EventArgs e)
        {
            if (IsConnected)
                cvsInSightDisplay1.ImageZoomMode = CvsDisplayZoom.Fit;
            UpdateTestStatus("ZoomImageToFit " + cvsInSightDisplay1.Edit.ZoomImageToFit);
        }
                
        private void btnFill_Click(object sender, EventArgs e)
        {
            if (IsConnected)
                cvsInSightDisplay1.ImageZoomMode = CvsDisplayZoom.Fill;
            UpdateTestStatus("ZoomImageToFit " + cvsInSightDisplay1.Edit.ZoomImageToFill);
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                cvsInSightDisplay1.SoftOnline = !cvsInSightDisplay1.SoftOnline;
                UpdateTestStatus("SoftOnline " + cvsInSightDisplay1.SoftOnline);
                onlineToolStripMenuItem.Text = (mInSight.State == CvsInSightState.Offline) ? "Go Online" : "Go Offline";
                if (mInSight.State == CvsInSightState.Offline)
                {
                    btnLive.Enabled = true;
                    btnOnline.BackColor = Color.White;
                }
                else
                {
                    btnLive.Enabled = false;
                    btnOnline.BackColor = Color.Green;
                }
            }

        }

        // Grid 투명도
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (IsConnected)
                cvsInSightDisplay1.GridOpacity = (double)e.NewValue / 100;
            OpacityValue.Text = Convert.ToString(cvsInSightDisplay1.GridOpacity * 100) + '%';
        }

        // Grid 확대, 축소
        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            double minValue = 0.1;
            double maxValue = 4.0;

            double scaleFactor = (double)e.NewValue / 100.0;

            cvsInSightDisplay1.GridScale = minValue + scaleFactor * (maxValue - minValue);

            ScaleValue.Text = $"{e.NewValue}%";
        }

    }
}