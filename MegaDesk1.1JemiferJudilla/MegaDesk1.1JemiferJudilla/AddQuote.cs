using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk_3_JemiferJudilla
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void btnCancelAddQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                //Show error
                this.errorProvider1.SetError(txtName, "Name is required");
            }
            else
            {
                this.errorProvider1.SetError(txtName, "");
            }
        }

        private void txtWidth_Validating(object sender, CancelEventArgs e)
        {
            int input = 0;
            bool isNUm = Int32.TryParse(txtWidth.Text, out input);

            if (!isNUm || input < 24 || input > 96)
            
            {
                //Show error
                this.errorProvider2.SetError(txtWidth, "Width should be between 24 and 96");
            }
            else
            {
                this.errorProvider2.SetError(txtWidth, "");
            }
        }

        private void txtDepth_Validating(object sender, CancelEventArgs e)
        {
            int input = 0;
            bool isNUm = Int32.TryParse(txtDepth.Text, out input);

            if (!isNUm || input < 28 || input > 48)

            {
                //Show error
                this.errorProvider3.SetError(txtDepth, "Depth should be between 28 and 48");
            }
            else
            {
                this.errorProvider3.SetError(txtDepth, "");
            }
        }

        private void txtNumDrawers_Validating(object sender, CancelEventArgs e)
        {
            int input = 0;
            bool isNUm = Int32.TryParse(txtNumDrawers.Text, out input);

            if (!isNUm || input < 0 || input > 7)

            {
                //Show error
                this.errorProvider4.SetError(txtNumDrawers, "Drawers should be between 0 and 7");
            }
            else
            {
                this.errorProvider4.SetError(txtNumDrawers, "");
            }
        }

        
    }
}
