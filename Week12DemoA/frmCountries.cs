using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12DemoA
{
    public partial class frmCountries : Form
    {
        public frmCountries()
        {
            InitializeComponent();
        }

        private void frmCountries_Load(object sender, EventArgs e)
        {
            try
            {
                Country.PopulateCountries();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Country.countries;


        }

        private void UpdateTheCountries()
        {
            Country c = new Country();
            c.CountryName = "Republic of Nick";
            c.CountryID = "NC";
            c.RegionID = 1;

            try
            {
                if (c.UpdateCountry()) { MessageBox.Show("Country successfully updated"); }
                else { MessageBox.Show("Country was not updated"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
