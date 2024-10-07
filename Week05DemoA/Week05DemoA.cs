using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week05DemoA.Properties;

namespace Week05DemoA
{
    public partial class Week05DemoA : Form
    {
        // Array
        private String[] studentsOld = {"John" , "Raj" , "Harmondeep" , "Sally" , "Wai" , "Jenny" , "George"};
        private String[] friendsOld = new String[7];
        // 2D Array
        private int[,] scores = new int[5, 19]; // Using an extra player as the par score.
        // List
        private List<String> students = new List<String>();
        private List<String> friends = new List<String>();


        public Week05DemoA()
        {
            InitializeComponent();
        }

        private void Week05DemoA_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("The author of this demo is " + Resources.AUTHOR);

            students.Clear();
            students.Add("John");
            students.Add("Raj");
            students.Add("Harmondeep");
            students.Add("Sally");
            students.Add("Wai");
            students.Add("Jenny");
            students.Add("George");

            UpdateLists();      

            

        }

        private void UpdateLists()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;

            listBox1.DataSource = students;
            listBox2.DataSource = friends;

            label1.Text = students.Count.ToString();
            label2.Text = friends.Count.ToString();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                String str = listBox1.SelectedItem.ToString();
                friends.Add(str);
                students.Remove(str);

                UpdateLists();

                String value = friends.Contains("John").ToString();
                MessageBox.Show(value);

                
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                students.Add(listBox2.SelectedItem.ToString());
                friends.Remove(listBox2.SelectedItem.ToString());

                UpdateLists();
            }
        }
    }
}
