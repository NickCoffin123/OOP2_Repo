﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02DemoB
{
    public partial class fmrMain : Form
    {
        public fmrMain()
        {
            InitializeComponent();
        }

        private void fmrMain_Load(object sender, EventArgs e)
        {
            Initiate();
        }

        private void Initiate()
        {
            LoadCombos();
        }

        private void LoadCombos()
        {
            String[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            foreach (string month in months)
            {
                cboThemeProg.Items.Add(month);
            }

            int mth = DateTime.Now.Month;

            if (cboThemeProg.Items.Count > mth)
                cboThemeProg.SelectedIndex = mth - 1;
        }

        private void cboThemeProg_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cboThemeProg.SelectedIndex;
            if (i != -1)
            {
                switch (i)
                {
                    case 0: this.BackColor = Color.White; break; // Jan
                    case 1: this.BackColor = Color.Pink; break; // Feb
                    case 2: this.BackColor = Color.Green; break; // Mar
                    case 3: this.BackColor = Color.Blue; break; // Apr
                    case 4: this.BackColor = Color.Yellow; break; // May
                    case 5: this.BackColor = Color.Maroon; break; // Jun
                    case 6: this.BackColor = Color.Red; break; // Jul
                    case 7: this.BackColor = Color.Brown; break; // Aug
                    case 8: this.BackColor = Color.Gray; break; // Sep
                    case 9: this.BackColor = Color.Orange; break; // Oct
                    case 10: this.BackColor = Color.FromArgb(255, 255, 210, 0); break; // Nov
                    case 11: this.BackColor = Color.DarkGreen; break; // Dec
                    default:
                        this.BackColor = Color.Silver; break;
                } // End switch
            } // End if
        }
    }
}
