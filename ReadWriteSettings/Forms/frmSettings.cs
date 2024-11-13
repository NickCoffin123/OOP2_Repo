/* Nick Coffin - 100555045.
 * OOP - Assignment 4 Read Write Settings.
 * November 12, 2024.
 * Settings form for project.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadWriteSettings
{
    public partial class frmSettings : Form
    {

        #region Global Variables
        #endregion

        #region Constructors

        public frmSettings()
        {
            InitializeComponent();
        }

        #endregion

        #region Control Event Handelers

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboInputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboInputDevice.SelectedIndex == 0)
            {
                nudControler.Enabled = false;
                nudMouse.Enabled = true;
            }
            else if (cboInputDevice.SelectedIndex == 1)
            {
                nudControler.Enabled = true;
                nudMouse.Enabled = false;
            }
            else
            {
                nudMouse.Enabled = false;
                nudControler.Enabled = false;
            }
        }

        private void cboRayTracing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRayTracing.SelectedIndex == 1)
            {
                cboUpscaling.Enabled = false;
                cboUpscaling.SelectedIndex = 1;
            }
            else
            {
                cboUpscaling.Enabled = true;
            }
        }

        #endregion

        #region Custom UI Functions and Methods

        private void frmSettings_Load(object sender, EventArgs e)
        {
            #region Movement
            cboInputDevice.SelectedIndex = 0;
            cboAutoJump.SelectedIndex = 0;
            cboInvertYAxis.SelectedIndex = 1;
            #endregion

            #region Video
            cboFancyGraphics.SelectedIndex = 0;
            cboVSync.SelectedIndex = 0;
            cboFullscreen.SelectedIndex = 1;
            cboRayTracing.SelectedIndex = 1;
            cboUpscaling.SelectedIndex = 1;
            #endregion

            #region Interface
            cboShowCoordinates.SelectedIndex = 1;
            cboCameraPerspective.SelectedIndex = 0;
            #endregion
        }

        #endregion

        //private void btnLoad_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1.Filter = "Text Files|*.txt|CSV Files|*.csv";
        //    openFileDialog1.Title = "Open a file";
        //    openFileDialog1.FileName = txtFileName.Text;
        //    openFileDialog1.ShowDialog();
        //    txtFileName.Text = openFileDialog1.FileName;

        //    try
        //    {
        //        rtbContent.Text = MyFiles.ReadFromFile(txtfilepath.Text);
        //        saveContent = rtbContent.Text;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error reading file");
        //    }
        //}
    }
}
