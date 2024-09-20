using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02DemoA
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "exit confirmation", 
                MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String soccerTeam = txtMySoccerTeam.Text;
            lbxSoccerTeams.Items.Add(soccerTeam);
            txtMySoccerTeam.Clear();
        }

        private void lbxSoccerTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selTeam = lbxSoccerTeams.SelectedIndex;
            if (selTeam >= 0) txtMySoccerTeam.Text = lbxSoccerTeams.Items[selTeam].ToString();
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            lbxSoccerTeams.SelectedItems.Clear();
            txtMySoccerTeam.Clear();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
