using Cognex.InSight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class OpenJobForm : Form
    {
        public CvsInSight _inSight;

        private string[] oFileList;

        public OpenJobForm()
        {
            InitializeComponent();

            CvsInSightSoftwareDevelopmentKit.Initialize();
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            btnOpen_Click(sender, e);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            bool bState;
            
            if (_inSight != null)
            {
                bState = _inSight.SoftOnline;

                _inSight.SoftOnline = false;

                if (listBox1.SelectedIndex >= 0)
                {
                    string selectedFile = listBox1.SelectedItem.ToString();
                    _inSight.File.LoadJobFile(selectedFile);
                }

                _inSight.SoftOnline = bState;
            }
        }

        private void OpenJobForm_Load(object sender, EventArgs e)
        {
            long i;
            if (_inSight != null)
            {
                oFileList = _inSight.File.GetFileList();
                for (i = 0; i < oFileList.Length; i++)
                {
                    if (oFileList[i].Substring(oFileList[i].Length - 4).ToUpper() == ".JOB")
                    {
                        listBox1.Items.Add(oFileList[i]);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
