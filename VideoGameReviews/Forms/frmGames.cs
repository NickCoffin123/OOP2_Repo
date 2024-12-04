using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoGameReviews.Forms;

namespace VideoGameReviews
{
    public partial class frmGames : Form
    {
        public frmGames()
        {
            InitializeComponent();
        }

        private void frmGames_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
    }
}
