using System.Drawing;

namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>F
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomToFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spreadsheetTransparencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spreadsheetScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDevices = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OKNGBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OKNGBox2 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.OCRRes = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BlobRes = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CA1 = new System.Windows.Forms.Label();
            this.CY1 = new System.Windows.Forms.Label();
            this.CX1 = new System.Windows.Forms.Label();
            this.cvsInSightDisplay1 = new Cognex.InSight.Controls.Display.CvsInSightDisplay();
            this.cvsFilmstrip = new Cognex.InSight.Controls.Filmstrip.CvsFilmstrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkPlay = new System.Windows.Forms.CheckBox();
            this.btnFreeze = new System.Windows.Forms.CheckBox();
            this.chkRecord = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPC = new System.Windows.Forms.RadioButton();
            this.rbSensor = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.imgFile = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnEx = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnOnline = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnZoomFit = new System.Windows.Forms.Button();
            this.btnZoom1 = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnLive = new System.Windows.Forms.Button();
            this.btnTgg = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.ScaleValue = new System.Windows.Forms.Label();
            this.OpacityValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.cboFilesList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFileConnect = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.sensorToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1666, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openJobToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openJobToolStripMenuItem
            // 
            this.openJobToolStripMenuItem.Name = "openJobToolStripMenuItem";
            this.openJobToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.openJobToolStripMenuItem.Text = "&Open Job";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customViewToolStripMenuItem,
            this.overlayToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // customViewToolStripMenuItem
            // 
            this.customViewToolStripMenuItem.Name = "customViewToolStripMenuItem";
            this.customViewToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.customViewToolStripMenuItem.Text = "&Custom View";
            // 
            // overlayToolStripMenuItem
            // 
            this.overlayToolStripMenuItem.Name = "overlayToolStripMenuItem";
            this.overlayToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.overlayToolStripMenuItem.Text = "&Overlay";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualTriggerToolStripMenuItem,
            this.liveModeToolStripMenuItem,
            this.toolStripSeparator1,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoom11ToolStripMenuItem,
            this.toolStripSeparator2,
            this.zoomToFitToolStripMenuItem,
            this.zoomToFillToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.imageToolStripMenuItem.Text = "&Image";
            // 
            // manualTriggerToolStripMenuItem
            // 
            this.manualTriggerToolStripMenuItem.Name = "manualTriggerToolStripMenuItem";
            this.manualTriggerToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.manualTriggerToolStripMenuItem.Text = "&Manual Trigger";
            // 
            // liveModeToolStripMenuItem
            // 
            this.liveModeToolStripMenuItem.Name = "liveModeToolStripMenuItem";
            this.liveModeToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.liveModeToolStripMenuItem.Text = "&Live Mode";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.zoomInToolStripMenuItem.Text = "Zoom &In";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.zoomOutToolStripMenuItem.Text = "Zoom &Out";
            // 
            // zoom11ToolStripMenuItem
            // 
            this.zoom11ToolStripMenuItem.Name = "zoom11ToolStripMenuItem";
            this.zoom11ToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.zoom11ToolStripMenuItem.Text = "Zoom &1:1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(234, 6);
            // 
            // zoomToFitToolStripMenuItem
            // 
            this.zoomToFitToolStripMenuItem.Name = "zoomToFitToolStripMenuItem";
            this.zoomToFitToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.zoomToFitToolStripMenuItem.Text = "Zoom To Fi&t";
            // 
            // zoomToFillToolStripMenuItem
            // 
            this.zoomToFillToolStripMenuItem.Name = "zoomToFillToolStripMenuItem";
            this.zoomToFillToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.zoomToFillToolStripMenuItem.Text = "&Zoom To Fill";
            // 
            // sensorToolStripMenuItem
            // 
            this.sensorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineToolStripMenuItem});
            this.sensorToolStripMenuItem.Name = "sensorToolStripMenuItem";
            this.sensorToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.sensorToolStripMenuItem.Text = "&Sensor";
            // 
            // onlineToolStripMenuItem
            // 
            this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
            this.onlineToolStripMenuItem.Size = new System.Drawing.Size(166, 34);
            this.onlineToolStripMenuItem.Text = "&Online";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spreadsheetTransparencyToolStripMenuItem,
            this.spreadsheetScaleToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // spreadsheetTransparencyToolStripMenuItem
            // 
            this.spreadsheetTransparencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseToolStripMenuItem,
            this.decreaseToolStripMenuItem});
            this.spreadsheetTransparencyToolStripMenuItem.Name = "spreadsheetTransparencyToolStripMenuItem";
            this.spreadsheetTransparencyToolStripMenuItem.Size = new System.Drawing.Size(328, 34);
            this.spreadsheetTransparencyToolStripMenuItem.Text = "Spreadsheet &Transparency";
            // 
            // increaseToolStripMenuItem
            // 
            this.increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            this.increaseToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.increaseToolStripMenuItem.Text = "Increase";
            // 
            // decreaseToolStripMenuItem
            // 
            this.decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            this.decreaseToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.decreaseToolStripMenuItem.Text = "Decrease";
            // 
            // spreadsheetScaleToolStripMenuItem
            // 
            this.spreadsheetScaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem1,
            this.zoomOutToolStripMenuItem1});
            this.spreadsheetScaleToolStripMenuItem.Name = "spreadsheetScaleToolStripMenuItem";
            this.spreadsheetScaleToolStripMenuItem.Size = new System.Drawing.Size(328, 34);
            this.spreadsheetScaleToolStripMenuItem.Text = "Spreadsheet &Scale";
            // 
            // zoomInToolStripMenuItem1
            // 
            this.zoomInToolStripMenuItem1.Name = "zoomInToolStripMenuItem1";
            this.zoomInToolStripMenuItem1.Size = new System.Drawing.Size(198, 34);
            this.zoomInToolStripMenuItem1.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem1
            // 
            this.zoomOutToolStripMenuItem1.Name = "zoomOutToolStripMenuItem1";
            this.zoomOutToolStripMenuItem1.Size = new System.Drawing.Size(198, 34);
            this.zoomOutToolStripMenuItem1.Text = "Zoom Out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "In-Sigtht Device :";
            // 
            // cboDevices
            // 
            this.cboDevices.FormattingEnabled = true;
            this.cboDevices.Location = new System.Drawing.Point(169, 125);
            this.cboDevices.Name = "cboDevices";
            this.cboDevices.Size = new System.Drawing.Size(269, 26);
            this.cboDevices.Sorted = true;
            this.cboDevices.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(444, 118);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(125, 39);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.OKNGBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.OKNGBox2);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.cvsInSightDisplay1);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1643, 1005);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // OKNGBox
            // 
            this.OKNGBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OKNGBox.AutoSize = true;
            this.OKNGBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OKNGBox.Location = new System.Drawing.Point(1518, 446);
            this.OKNGBox.Name = "OKNGBox";
            this.OKNGBox.Size = new System.Drawing.Size(69, 18);
            this.OKNGBox.TabIndex = 0;
            this.OKNGBox.Text = "OK/NG";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(1318, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Blob :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(1318, 689);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "OCRMax :";
            // 
            // OKNGBox2
            // 
            this.OKNGBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OKNGBox2.AutoSize = true;
            this.OKNGBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OKNGBox2.Location = new System.Drawing.Point(1518, 689);
            this.OKNGBox2.Name = "OKNGBox2";
            this.OKNGBox2.Size = new System.Drawing.Size(69, 18);
            this.OKNGBox2.TabIndex = 0;
            this.OKNGBox2.Text = "OK/NG";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.OCRRes);
            this.groupBox8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox8.Location = new System.Drawing.Point(1293, 510);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(344, 148);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "OCRMax";
            // 
            // OCRRes
            // 
            this.OCRRes.AutoSize = true;
            this.OCRRes.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OCRRes.Location = new System.Drawing.Point(149, 73);
            this.OCRRes.Name = "OCRRes";
            this.OCRRes.Size = new System.Drawing.Size(63, 18);
            this.OCRRes.TabIndex = 0;
            this.OCRRes.Text = "Result";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.BlobRes);
            this.groupBox7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox7.Location = new System.Drawing.Point(1293, 273);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(344, 148);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Blob";
            // 
            // BlobRes
            // 
            this.BlobRes.AutoSize = true;
            this.BlobRes.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BlobRes.Location = new System.Drawing.Point(149, 71);
            this.BlobRes.Name = "BlobRes";
            this.BlobRes.Size = new System.Drawing.Size(63, 18);
            this.BlobRes.TabIndex = 0;
            this.BlobRes.Text = "Result";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.CA1);
            this.groupBox6.Controls.Add(this.CY1);
            this.groupBox6.Controls.Add(this.CX1);
            this.groupBox6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(1293, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(344, 240);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Match";
            // 
            // CA1
            // 
            this.CA1.AutoSize = true;
            this.CA1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CA1.Location = new System.Drawing.Point(25, 176);
            this.CA1.Name = "CA1";
            this.CA1.Size = new System.Drawing.Size(79, 18);
            this.CA1.TabIndex = 0;
            this.CA1.Text = "Angle : ";
            // 
            // CY1
            // 
            this.CY1.AutoSize = true;
            this.CY1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CY1.Location = new System.Drawing.Point(25, 119);
            this.CY1.Name = "CY1";
            this.CY1.Size = new System.Drawing.Size(41, 18);
            this.CY1.TabIndex = 0;
            this.CY1.Text = "Y : ";
            // 
            // CX1
            // 
            this.CX1.AutoSize = true;
            this.CX1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CX1.Location = new System.Drawing.Point(25, 59);
            this.CX1.Name = "CX1";
            this.CX1.Size = new System.Drawing.Size(41, 18);
            this.CX1.TabIndex = 0;
            this.CX1.Text = "X : ";
            // 
            // cvsInSightDisplay1
            // 
            this.cvsInSightDisplay1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cvsInSightDisplay1.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional;
            this.cvsInSightDisplay1.DialogIcon = null;
            this.cvsInSightDisplay1.Location = new System.Drawing.Point(7, 27);
            this.cvsInSightDisplay1.Name = "cvsInSightDisplay1";
            this.cvsInSightDisplay1.PreferredCropScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplayCropScaleMode.Default;
            this.cvsInSightDisplay1.Size = new System.Drawing.Size(1280, 960);
            this.cvsInSightDisplay1.TabIndex = 0;
            this.cvsInSightDisplay1.ResultsChanged += new System.EventHandler(this.CvsInSightDisplay1_ResultsChanged);
            // 
            // cvsFilmstrip
            // 
            this.cvsFilmstrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cvsFilmstrip.BackColor = System.Drawing.Color.Transparent;
            this.cvsFilmstrip.FilmQueue = null;
            this.cvsFilmstrip.FirstThumbnailIndex = 0;
            this.cvsFilmstrip.HeightScale = Cognex.InSight.Controls.Filmstrip.CvsFilmstripScale.One;
            this.cvsFilmstrip.ImageIndex = 0;
            this.cvsFilmstrip.Location = new System.Drawing.Point(26, 19);
            this.cvsFilmstrip.Name = "cvsFilmstrip";
            this.cvsFilmstrip.SelectedIndex = -1;
            this.cvsFilmstrip.ShowSummary = false;
            this.cvsFilmstrip.ShowThumbnailImage = true;
            this.cvsFilmstrip.Size = new System.Drawing.Size(1152, 103);
            this.cvsFilmstrip.StatusLevelStyle = Cognex.InSight.CvsStatusLevelStyle.Geometric;
            this.cvsFilmstrip.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 1175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1637, 172);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.chkPlay);
            this.groupBox5.Controls.Add(this.btnFreeze);
            this.groupBox5.Controls.Add(this.chkRecord);
            this.groupBox5.Controls.Add(this.btnClear);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Controls.Add(this.btnLast);
            this.groupBox5.Controls.Add(this.btnNextPage);
            this.groupBox5.Controls.Add(this.btnPrevPage);
            this.groupBox5.Controls.Add(this.btnFirst);
            this.groupBox5.Location = new System.Drawing.Point(1349, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 133);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // chkPlay
            // 
            this.chkPlay.AutoSize = true;
            this.chkPlay.Location = new System.Drawing.Point(6, 91);
            this.chkPlay.Name = "chkPlay";
            this.chkPlay.Size = new System.Drawing.Size(68, 22);
            this.chkPlay.TabIndex = 4;
            this.chkPlay.Text = "Play";
            this.chkPlay.UseVisualStyleBackColor = true;
            this.chkPlay.Visible = false;
            this.chkPlay.CheckedChanged += new System.EventHandler(this.chkPlay_CheckedChanged);
            // 
            // btnFreeze
            // 
            this.btnFreeze.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnFreeze.Enabled = false;
            this.btnFreeze.Location = new System.Drawing.Point(5, 82);
            this.btnFreeze.Name = "btnFreeze";
            this.btnFreeze.Size = new System.Drawing.Size(87, 38);
            this.btnFreeze.TabIndex = 3;
            this.btnFreeze.Text = "&Freeze";
            this.btnFreeze.UseVisualStyleBackColor = true;
            this.btnFreeze.Visible = false;
            // 
            // chkRecord
            // 
            this.chkRecord.AutoSize = true;
            this.chkRecord.Location = new System.Drawing.Point(148, 91);
            this.chkRecord.Name = "chkRecord";
            this.chkRecord.Size = new System.Drawing.Size(92, 22);
            this.chkRecord.TabIndex = 2;
            this.chkRecord.Text = "Record";
            this.chkRecord.UseVisualStyleBackColor = true;
            this.chkRecord.Visible = false;
            this.chkRecord.CheckedChanged += new System.EventHandler(this.chkRecord_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(190, 82);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 38);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(98, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Enabled = false;
            this.btnLast.Location = new System.Drawing.Point(212, 23);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(63, 41);
            this.btnLast.TabIndex = 0;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Enabled = false;
            this.btnNextPage.Location = new System.Drawing.Point(143, 23);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(63, 41);
            this.btnNextPage.TabIndex = 0;
            this.btnNextPage.Text = ">>";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Enabled = false;
            this.btnPrevPage.Location = new System.Drawing.Point(74, 23);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(63, 41);
            this.btnPrevPage.TabIndex = 0;
            this.btnPrevPage.Text = "<<";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Enabled = false;
            this.btnFirst.Location = new System.Drawing.Point(5, 23);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(63, 41);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.cvsFilmstrip);
            this.groupBox4.Location = new System.Drawing.Point(142, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1201, 133);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbPC);
            this.groupBox3.Controls.Add(this.rbSensor);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(7, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 133);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // rbPC
            // 
            this.rbPC.AutoSize = true;
            this.rbPC.Location = new System.Drawing.Point(20, 41);
            this.rbPC.Name = "rbPC";
            this.rbPC.Size = new System.Drawing.Size(56, 22);
            this.rbPC.TabIndex = 1;
            this.rbPC.TabStop = true;
            this.rbPC.Text = "PC";
            this.rbPC.UseVisualStyleBackColor = true;
            this.rbPC.CheckedChanged += new System.EventHandler(this.rbPC_CheckedChanged);
            // 
            // rbSensor
            // 
            this.rbSensor.AutoSize = true;
            this.rbSensor.Location = new System.Drawing.Point(20, 90);
            this.rbSensor.Name = "rbSensor";
            this.rbSensor.Size = new System.Drawing.Size(91, 22);
            this.rbSensor.TabIndex = 0;
            this.rbSensor.TabStop = true;
            this.rbSensor.Text = "Sensor";
            this.rbSensor.UseVisualStyleBackColor = true;
            this.rbSensor.CheckedChanged += new System.EventHandler(this.rbSensor_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusCurrent});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1666, 32);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(61, 25);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // statusCurrent
            // 
            this.statusCurrent.Name = "statusCurrent";
            this.statusCurrent.Size = new System.Drawing.Size(123, 25);
            this.statusCurrent.Text = "Disconnected";
            // 
            // imgFile
            // 
            this.imgFile.Name = "imgFile";
            this.imgFile.Size = new System.Drawing.Size(40, 30);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(40, 30);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnEx);
            this.groupBox9.Controls.Add(this.btnOpen);
            this.groupBox9.Location = new System.Drawing.Point(12, 36);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(110, 69);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            // 
            // btnEx
            // 
            this.btnEx.Image = ((System.Drawing.Image)(resources.GetObject("btnEx.Image")));
            this.btnEx.Location = new System.Drawing.Point(57, 19);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(39, 39);
            this.btnEx.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnEx, "Excel");
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(12, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(39, 39);
            this.btnOpen.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnOpen, "OpenJob");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnOnline
            // 
            this.btnOnline.BackColor = System.Drawing.Color.White;
            this.btnOnline.Image = ((System.Drawing.Image)(resources.GetObject("btnOnline.Image")));
            this.btnOnline.Location = new System.Drawing.Point(15, 19);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(39, 39);
            this.btnOnline.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnOnline, "Online");
            this.btnOnline.UseVisualStyleBackColor = false;
            this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
            // 
            // btnFill
            // 
            this.btnFill.Image = ((System.Drawing.Image)(resources.GetObject("btnFill.Image")));
            this.btnFill.Location = new System.Drawing.Point(282, 19);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(39, 39);
            this.btnFill.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnFill, "Zoom Fill");
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnZoomFit
            // 
            this.btnZoomFit.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomFit.Image")));
            this.btnZoomFit.Location = new System.Drawing.Point(237, 19);
            this.btnZoomFit.Name = "btnZoomFit";
            this.btnZoomFit.Size = new System.Drawing.Size(39, 39);
            this.btnZoomFit.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnZoomFit, "Zoom Fit");
            this.btnZoomFit.UseVisualStyleBackColor = true;
            this.btnZoomFit.Click += new System.EventHandler(this.btnZoomFit_Click);
            // 
            // btnZoom1
            // 
            this.btnZoom1.Image = ((System.Drawing.Image)(resources.GetObject("btnZoom1.Image")));
            this.btnZoom1.Location = new System.Drawing.Point(192, 19);
            this.btnZoom1.Name = "btnZoom1";
            this.btnZoom1.Size = new System.Drawing.Size(39, 39);
            this.btnZoom1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnZoom1, "Zoom 1:1");
            this.btnZoom1.UseVisualStyleBackColor = true;
            this.btnZoom1.Click += new System.EventHandler(this.btnZoom1_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.Location = new System.Drawing.Point(147, 19);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(39, 39);
            this.btnZoomOut.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnZoomOut, "Zoom Out");
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.Location = new System.Drawing.Point(102, 19);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(39, 39);
            this.btnZoomIn.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnZoomIn, "Zoom In");
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnLive
            // 
            this.btnLive.Image = ((System.Drawing.Image)(resources.GetObject("btnLive.Image")));
            this.btnLive.Location = new System.Drawing.Point(57, 19);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(39, 39);
            this.btnLive.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnLive, "Live");
            this.btnLive.UseVisualStyleBackColor = true;
            this.btnLive.Click += new System.EventHandler(this.btnLive_Click);
            // 
            // btnTgg
            // 
            this.btnTgg.Image = ((System.Drawing.Image)(resources.GetObject("btnTgg.Image")));
            this.btnTgg.Location = new System.Drawing.Point(12, 19);
            this.btnTgg.Name = "btnTgg";
            this.btnTgg.Size = new System.Drawing.Size(39, 39);
            this.btnTgg.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnTgg, "Trigger");
            this.btnTgg.UseVisualStyleBackColor = true;
            this.btnTgg.Click += new System.EventHandler(this.btnTgg_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnFill);
            this.groupBox11.Controls.Add(this.btnZoomFit);
            this.groupBox11.Controls.Add(this.btnZoom1);
            this.groupBox11.Controls.Add(this.btnZoomOut);
            this.groupBox11.Controls.Add(this.btnZoomIn);
            this.groupBox11.Controls.Add(this.btnLive);
            this.groupBox11.Controls.Add(this.btnTgg);
            this.groupBox11.Location = new System.Drawing.Point(128, 36);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(334, 69);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnOnline);
            this.groupBox10.Location = new System.Drawing.Point(468, 36);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(69, 69);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.ScaleValue);
            this.groupBox12.Controls.Add(this.OpacityValue);
            this.groupBox12.Controls.Add(this.label5);
            this.groupBox12.Controls.Add(this.label2);
            this.groupBox12.Controls.Add(this.hScrollBar2);
            this.groupBox12.Controls.Add(this.hScrollBar1);
            this.groupBox12.Location = new System.Drawing.Point(543, 36);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1111, 69);
            this.groupBox12.TabIndex = 9;
            this.groupBox12.TabStop = false;
            // 
            // ScaleValue
            // 
            this.ScaleValue.Location = new System.Drawing.Point(776, 29);
            this.ScaleValue.Name = "ScaleValue";
            this.ScaleValue.Size = new System.Drawing.Size(64, 23);
            this.ScaleValue.TabIndex = 32;
            this.ScaleValue.Text = "25%";
            this.ScaleValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OpacityValue
            // 
            this.OpacityValue.Location = new System.Drawing.Point(148, 29);
            this.OpacityValue.Name = "OpacityValue";
            this.OpacityValue.Size = new System.Drawing.Size(64, 23);
            this.OpacityValue.TabIndex = 32;
            this.OpacityValue.Text = "75%";
            this.OpacityValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(651, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Grid Scale:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Grid Opacity:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(852, 27);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(243, 26);
            this.hScrollBar2.TabIndex = 0;
            this.hScrollBar2.Value = 25;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(227, 27);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(243, 26);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Value = 75;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // cboFilesList
            // 
            this.cboFilesList.Enabled = false;
            this.cboFilesList.FormattingEnabled = true;
            this.cboFilesList.Location = new System.Drawing.Point(727, 125);
            this.cboFilesList.Name = "cboFilesList";
            this.cboFilesList.Size = new System.Drawing.Size(269, 26);
            this.cboFilesList.Sorted = true;
            this.cboFilesList.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "In-Sigtht Files :";
            // 
            // btnFileConnect
            // 
            this.btnFileConnect.Location = new System.Drawing.Point(1003, 118);
            this.btnFileConnect.Name = "btnFileConnect";
            this.btnFileConnect.Size = new System.Drawing.Size(125, 39);
            this.btnFileConnect.TabIndex = 3;
            this.btnFileConnect.Text = "&FileConnect";
            this.btnFileConnect.UseVisualStyleBackColor = true;
            this.btnFileConnect.Click += new System.EventHandler(this.btnFileConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 1393);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFileConnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboFilesList);
            this.Controls.Add(this.cboDevices);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "In-Sight Filmstrip control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDevices;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private Cognex.InSight.Controls.Display.CvsInSightDisplay cvsInSightDisplay1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusCurrent;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbSensor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.CheckBox chkRecord;
        private Cognex.InSight.Controls.Filmstrip.CvsFilmstrip cvsFilmstrip;
        private System.Windows.Forms.ToolStripMenuItem openJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualTriggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoom11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem zoomToFitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spreadsheetTransparencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spreadsheetScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem1;
        private System.Windows.Forms.CheckBox btnFreeze;
        private System.Windows.Forms.CheckBox chkPlay;
        private System.Windows.Forms.RadioButton rbPC;
        private System.Windows.Forms.Label OKNGBox2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label OCRRes;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label BlobRes;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label CA1;
        private System.Windows.Forms.Label CY1;
        private System.Windows.Forms.Label CX1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OKNGBox;
        private System.Windows.Forms.ToolStripMenuItem imgFile;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btnTgg;
        private System.Windows.Forms.Button btnLive;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoom1;
        private System.Windows.Forms.Button btnZoomFit;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        internal System.Windows.Forms.Label OpacityValue;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label ScaleValue;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.ComboBox cboFilesList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFileConnect;
    }
}

