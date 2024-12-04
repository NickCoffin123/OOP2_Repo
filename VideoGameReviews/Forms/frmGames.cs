using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoGameReviews.DBAL;
using VideoGameReviews.Forms;

namespace VideoGameReviews
{
    public partial class frmGames : Form
    {

        #region Global Variables
        #endregion

        #region Constructors
        public frmGames()
        {
            InitializeComponent();
        }
        #endregion

        #region Control Event Handelers
        #endregion

        #region Custom UI Functions and Methods
        private void frmGames_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //frmLogin frm = new frmLogin();
            //frm.ShowDialog();

            try
            {
                Game.PopulateGames();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            dgvGames.DataSource = DBAL.Game.games;

            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.DataSource = Country.countries;

        }
        #endregion
        

        
    }
}
