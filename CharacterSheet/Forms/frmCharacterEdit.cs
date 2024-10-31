/* Nick Coffin - 100555045.
 * OOP - Assignment 3 Character Sheet.
 * October 31, 2024.
 * Edit character form for project.
 */
using CharacterSheet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    public partial class frmCharacterEdit : Form
    {
        public frmCharacterEdit()
        {
            InitializeComponent();
            Class.InitializeDefaultClasses();
            PopulateClassComboBox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateClassComboBox()
        {
            cbxClass.Items.Clear();
            foreach (Class cls in Class.GetClasses())
            {
                cbxClass.Items.Add(cls.Name);
            }
        }
    }
}
