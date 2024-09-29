using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Week04DemoA
{
    public partial class Form1 : Form
    {

        public const int Y = 15; // Global Scope (not truely... in wrong file iykyk)
        private const int X = 12; // Class Scope
        private static int w = 10; // Class Scope
        private int z = 14; // Class Scope (instance)

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            w = Tools.RandomInt(0, 255);
            label1.Text = w.ToString();

            z = Tools.RandomInt(0, 255);
            label2.Text = z.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // w = Tools.RandomInt(0, 255);

            label1.Text = w.ToString();
            label2.Text = z.ToString();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            label1.Text = w.ToString();
            label2.Text = z.ToString();

            if (w > 128)
            {
                int w = 20;
                label3.Text = w.ToString();
            }

            label1.Text = w.ToString();
        }

        private void DoStuff()
        {
            int total = 0;
            for (int i = 0; i < 100; i++)
            {
                total += i * 2;
                MessageBox.Show(total.ToString());

                for (int j = 0; j < 100; j++)
                {
                    int c = j * 2;
                    total += c;
                    MessageBox.Show(i.ToString());
                }
            }
        }
    }
}
