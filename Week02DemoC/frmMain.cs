using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02DemoC
{
    public partial class frmMain : Form
    {

        #region Startup

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            this.nudNumSquares.Minimum = Settings.MIN_NUMSQUARES;
            this.nudNumSquares.Maximum = Settings.MAX_NUMSQUARES;
            this.nudNumSquares.Value = Settings.DEF_NUMSQUARES;
        }



        #endregion

        #region Custom Methods

        private void ProgWorkFlow(int numLabels)
        {
            // Clear any previous squares.
            ClearForm();
            // Create new squares.
            CreateLabels(numLabels);
            // Show squares.
            ShowLabels(numLabels);
        }

        private void ClearForm()
        {
            foreach (Label label in Settings.labels) this.Controls.Remove(label);

        }

        private void CreateLabels(int numLabels)
        {
            for (int y = 0; y < numLabels; y++)
            {
                for (int x = 0; x < numLabels; x++)
                {
                    // Create label.
                    Label label = new Label();
                    Color col = new Color();
                    col = Tools.RandomColor();
                    label.BackColor = col;
                    label.ForeColor = GetForeColor(col);

                    // Size.
                    label.Height = Settings.DEF_SQUARESIZE;
                    label.Width = Settings.DEF_SQUARESIZE;

                    // Location.
                    label.Top = Settings.DEF_TOPMARGIN + Settings.DEF_LAYOUTMARGIN + y * (Settings.DEF_SQUARESIZE +
                        Settings.DEF_SPACING);
                    label.Left = Settings.DEF_LAYOUTMARGIN + x * (Settings.DEF_SQUARESIZE + Settings.DEF_SPACING);

                    // Text.
                    label.Text = "(" + (int)col.R + "," + (int)col.G + "," + (int)col.B + ")";

                    // Add the label to array of labels
                    Settings.labels[x, y] = label;


                }
            }
        }

        private void ShowLabels(int numLabels)
        {
            ClearForm();
            // Long way.
            for (int y = 0; y < numLabels; y++)
                {
                for (int x = 0; x < numLabels; x++)
                    {
                    this.Controls.Add(Settings.labels[x, y]);
                    }
            }

            // Short way.

            // foreach (Label label in Settings.labels) this.Controls.Add(label);
        }

        private Color GetForeColor(Color col)
        {
            double average = 0;
            average = ((int)col.R + (int)col.G + (int)col.B) / 3.0;

            if (average < 128) return Color.White;
            else return Color.Black;
        }

        #endregion

        #region General Evetns
        
        private void btnGo_Click(object sender, EventArgs e)
        {
            ProgWorkFlow((int)this.nudNumSquares.Value);
        }


        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
