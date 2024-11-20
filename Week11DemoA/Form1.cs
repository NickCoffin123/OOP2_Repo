using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week11DemoA.Classes;

namespace Week11DemoA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSampleDataSetJoined.countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.employeeSampleDataSetJoined.countries);
            // TODO: This line of code loads data into the 'employeeSampleDataSetJoined.EmployeeInfo' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.employeeSampleDataSetJoined.EmployeeInfo);

        }

        private void InheritenceTest()
        {
            Car car = new Car(001, "Merc", "E350", 2012, Color.Silver, "Coup", 2);
            Truck truck = new Truck(002, "Ford", "F150", 2022, Color.Black, 2000, 2, 4000);

        }

    }
}
