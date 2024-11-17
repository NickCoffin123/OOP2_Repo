/* Nick Coffin - 100555045.
 * OOP - Assignment 4 Read Write Settings.
 * November 12, 2024.
 * Splash page for project.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadWriteSettings
{
    /// <summary>
    /// Main method for form
    /// </summary>
    public partial class frmSplashPage : Form
    {
        /// <summary>
        /// Initial form constructor
        /// </summary>
        public frmSplashPage()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
            PlaySound();
            frmSettings settingsForm = new frmSettings();
            //settingsForm.ShowDialog();
            //this.Close();

        }

        /// <summary>
        /// Timer for splash page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            frmSettings settingsForm = new frmSettings();
            settingsForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Music player
        /// </summary>
        public void PlaySound()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources._04_The_Moonlighter);
            player.Play();
        }

    }






}
