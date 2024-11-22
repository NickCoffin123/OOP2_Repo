/* Nick Coffin - 100555045.
 * OOP - In class assignment 3 data binding.
 * November 22, 2024.
 * Main form.
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

namespace In_Class3
{
    public partial class TeamPlayer : Form
    {
        /// <summary>
        /// Main constructor
        /// </summary>
        public TeamPlayer()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Load event for the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeamPlayer_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'sportleaguesDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.sportleaguesDataSet.DataTable1);
            // TODO: This line of code loads data into the 'sportleaguesDataSet.players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.sportleaguesDataSet.players);
            try
            {
                this.teamsTableAdapter.Fill(this.sportleaguesDataSet.teams);

                if (cboPick.Items.Count > 0)
                {
                    cboPick.SelectedIndex = 0;
                }

                if (cboPick.SelectedValue != null)
                {
                    int selectedTeamID = Convert.ToInt32(cboPick.SelectedValue);
                    this.dataTable1TableAdapter.FillByTeamID(sportleaguesDataSet.DataTable1, selectedTeamID);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occourred: " + ex.Message);
            }
        }




        /// <summary>
        /// Method to update the player info based on the team selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboPick.SelectedValue != null)
                {
                    int selectedTeamID = Convert.ToInt32(cboPick.SelectedValue);
                    this.dataTable1TableAdapter.FillByTeamID(sportleaguesDataSet.DataTable1, selectedTeamID);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occourred: " + ex.Message);
            }
        }


    }
}