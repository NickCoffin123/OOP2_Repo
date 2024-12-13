/* 
 * Nick Coffin - 100555045
 * Final Assignment - AI in programming
 * December 2024
 * Splash Page
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

namespace FinalAssignment.Forms
{
    public partial class frmSplash : Form
    {
        /// <summary>
        /// timer for splash screen created by chat
        /// </summary>
        public frmSplash()
        {
            InitializeComponent();
            timer1.Interval = 5000; // 5 seconds
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        /// <summary>
        /// Close but I had to remove the creation instance of the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); // Stop the timer
             // Create a new instance of the main form
            this.Close();  // Close the splash form
        }
    }
}
