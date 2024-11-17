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
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadWriteSettings
{
    public partial class frmSettings : Form
    {

        #region Global Variables
        private GameSettings currentSettings;
        private PlayerProfile playerProfile = new PlayerProfile();
        #endregion

        #region Constructors

        /// <summary>
        /// Initial constructor for the form
        /// </summary>
        public frmSettings()
        {
            InitializeComponent();

        }

        #endregion

        #region Control Event Handelers

        /// <summary>
        /// Method to cancel the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method to keep the sensitivity locked depending on other settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Method to unlock the use of ray tracing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Method to save a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                UpdatePlayerProfileFromForm();

                string outputContent = playerProfile.BuildProfileOutput();
                saveFileDialog1.Filter = "Text Files|*.txt|CSV Files|*.csv";
                saveFileDialog1.Title = "Save a file";
                saveFileDialog1.FileName = txtFileName.Text;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog1.FileName;
                    txtFileName.Text = filePath;

                    if (string.IsNullOrWhiteSpace(filePath))
                    {
                        MessageBox.Show("Please enter a valid file path.", "Validation Error");
                        return;
                    }
                    Tools.WriteToFile(filePath, outputContent);

                    MessageBox.Show("Settings saved successfully!", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving file");
            }
        }

        /// <summary>
        /// Method to load a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Text Files|*.txt|CSV Files|*.csv";
                openFileDialog1.Title = "Open a file";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    txtFileName.Text = filePath;
                    string fileContent = Tools.ReadFromFile(filePath);
                    UpdatePlayerProfileFromContent(fileContent);
                    UpdateFormFromPlayerProfile();

                    MessageBox.Show("Settings loaded successfully!", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error reading file");
            }
        }

        /// <summary>
        /// Method to save as a binary file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveBinary_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatePlayerProfileFromForm();

                saveFileDialog1.Filter = "Binary Files|*.bin";
                saveFileDialog1.Title = "Save as Binary";
                saveFileDialog1.FileName = "Settings.bin";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog1.FileName;
                    txtFileName.Text = filePath;

                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(fs, playerProfile);
                    }

                    MessageBox.Show("Settings saved as binary successfully!", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving binary file");
            }
        }


        #endregion

        #region Custom UI Functions and Methods

        /// <summary>
        /// Method to set the defaults when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        #region Custom Methods

        /// <summary>
        /// Parses the content read from a file and updates the player profile.
        /// </summary>
        /// <param name="content">The file content as a string.</param>
        private void UpdatePlayerProfileFromContent(string content)
        {
            string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length != 2) continue;

                string key = parts[0].Trim();
                string value = parts[1].Trim();

                switch (key)
                {
                    case "Input Device":
                        playerProfile.Settings.InputDevice = (Defaults.InputDeviceOptions)Enum.Parse(typeof(Defaults.InputDeviceOptions), value);
                        break;
                    case "Auto Jump":
                        playerProfile.Settings.AutoJump = bool.Parse(value);
                        break;
                    case "Mouse Sensitivity":
                        playerProfile.Settings.MouseSensitivity = int.Parse(value);
                        break;
                    case "Controller Sensitivity":
                        playerProfile.Settings.ConstollerSensitivity = int.Parse(value);
                        break;
                    case "Invert Y-Axis":
                        playerProfile.Settings.InvertYAxis = bool.Parse(value);
                        break;
                    case "Brightness":
                        playerProfile.Settings.Brightness = int.Parse(value);
                        break;
                    case "Fancy Graphics":
                        playerProfile.Settings.FancyGraphics = bool.Parse(value);
                        break;
                    case "V-Sync":
                        playerProfile.Settings.VSync = bool.Parse(value);
                        break;
                    case "Fullscreen":
                        playerProfile.Settings.FullScreen = bool.Parse(value);
                        break;
                    case "Render Distance":
                        playerProfile.Settings.RenderDistance = int.Parse(value);
                        break;
                    case "Field Of View":
                        playerProfile.Settings.FieldOfView = int.Parse(value);
                        break;
                    case "Ray Tracing":
                        playerProfile.Settings.RayTracing = bool.Parse(value);
                        break;
                    case "Upscaling":
                        playerProfile.Settings.Upscaling = bool.Parse(value);
                        break;
                    case "Music":
                        playerProfile.Settings.Music = int.Parse(value);
                        break;
                    case "Sound":
                        playerProfile.Settings.Sound = int.Parse(value);
                        break;
                    case "HUDD Transparency":
                        playerProfile.Settings.HUDDTransparency = int.Parse(value);
                        break;
                    case "Show Coordinates":
                        playerProfile.Settings.ShowCoordinates = bool.Parse(value);
                        break;
                    case "Camera Perspective":
                        playerProfile.Settings.CameraPerspective = (Defaults.CameraPerspective)Enum.Parse(typeof(Defaults.CameraPerspective), value);
                        break;


                }
            }
        }

        /// <summary>
        /// Updates the form's controls to reflect the current player profile settings.
        /// </summary>
        private void UpdateFormFromPlayerProfile()
        {
            cboInputDevice.SelectedIndex = (int)playerProfile.Settings.InputDevice;
            cboAutoJump.SelectedIndex = playerProfile.Settings.AutoJump ? 0 : 1;
            nudMouse.Value = playerProfile.Settings.MouseSensitivity;
            nudControler.Value = playerProfile.Settings.ConstollerSensitivity;
            cboInvertYAxis.SelectedIndex = playerProfile.Settings.InvertYAxis ? 0 : 1;
            nudBrightness.Value = playerProfile.Settings.Brightness;
            cboFancyGraphics.SelectedIndex = playerProfile.Settings.FancyGraphics ? 0 : 1;
            cboVSync.SelectedIndex = playerProfile.Settings.VSync ? 0 : 1;
            cboFullscreen.SelectedIndex = playerProfile.Settings.FullScreen ? 0 : 1;
            cboRayTracing.SelectedIndex = playerProfile.Settings.RayTracing ? 0 : 1;
            cboUpscaling.SelectedIndex = playerProfile.Settings.Upscaling ? 0 : 1;
            nudMusic.Value = playerProfile.Settings.Music;
            nudSound.Value = playerProfile.Settings.Sound;
            nudHUDTransparency.Value = playerProfile.Settings.HUDDTransparency;
            cboShowCoordinates.SelectedIndex = playerProfile.Settings.ShowCoordinates ? 0 : 1;
            cboCameraPerspective.SelectedIndex = (int)playerProfile.Settings.CameraPerspective;
        }

        /// <summary>
        /// Method to update the form when the file is loaded
        /// </summary>
        private void UpdatePlayerProfileFromForm()
        {
            playerProfile.Settings.InputDevice = (Defaults.InputDeviceOptions)cboInputDevice.SelectedIndex;
            playerProfile.Settings.AutoJump = cboAutoJump.SelectedIndex == 0;
            playerProfile.Settings.MouseSensitivity = (int)nudMouse.Value;
            playerProfile.Settings.ConstollerSensitivity = (int)nudControler.Value;
            playerProfile.Settings.InvertYAxis = cboInvertYAxis.SelectedIndex == 0;
            playerProfile.Settings.Brightness = (int)nudBrightness.Value;
            playerProfile.Settings.FancyGraphics = cboFancyGraphics.SelectedIndex == 0;
            playerProfile.Settings.VSync = cboVSync.SelectedIndex == 0;
            playerProfile.Settings.FullScreen = cboFullscreen.SelectedIndex == 0;
            playerProfile.Settings.RenderDistance = (int)nudRenderDistance.Value;
            playerProfile.Settings.FieldOfView = (int)nudFieldofView.Value;
            playerProfile.Settings.RayTracing = cboRayTracing.SelectedIndex == 0;
            playerProfile.Settings.Upscaling = cboUpscaling.SelectedIndex == 0;
            playerProfile.Settings.Music = (int)nudMusic.Value;
            playerProfile.Settings.Sound = (int)nudSound.Value;
            playerProfile.Settings.HUDDTransparency = (int)nudHUDTransparency.Value;
            playerProfile.Settings.ShowCoordinates = cboShowCoordinates.SelectedIndex == 0;
            playerProfile.Settings.CameraPerspective = (Defaults.CameraPerspective)cboCameraPerspective.SelectedIndex;
        }





        #endregion

        #endregion

       

    }
}
