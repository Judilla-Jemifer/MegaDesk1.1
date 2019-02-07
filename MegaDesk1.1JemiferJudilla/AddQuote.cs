using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;




namespace MegaDesk_3_JemiferJudilla
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            // create List for the material combobox
            List<DeskMaterial> MaterialList = Enum.GetValues(typeof(DeskMaterial)).Cast<DeskMaterial>().ToList();
            MaterialComboBox.DataSource = MaterialList;
            
        }

        private void btnCancelAddQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtCustName.Text.Length == 0)
            {
                //Show error
                this.errorProvider1.SetError(txtCustName, "Name is required");
            }
            else
            {
                this.errorProvider1.SetError(txtCustName, "");
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

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            try
            {
                Desk dc = new Desk();
                dc.CustomerName = txtCustName.Text;
                dc.Width = int.Parse(txtWidth.Text);
                dc.Depth = int.Parse(txtDepth.Text);
                dc.NumberOfDrawers = int.Parse(txtNumDrawers.Text);
                dc.Material = ((DeskMaterial)MaterialComboBox.SelectedValue).ToString();
               
                
                if (rad3days.Checked)
                    dc.RushDays = int.Parse(rad3days.Text);
                else if (rad5days.Checked)
                    dc.RushDays = int.Parse(rad5days.Text);
                else if (rad7days.Checked)
                    dc.RushDays = int.Parse(rad7days.Text);


                DeskQuote dq = new DeskQuote();
                string DeskQuoteRecord = dc.CustomerName + "," + dq.QuoteTotal() + "," + DateTime.Now + "," + dc.Width + "," + dc.Depth + "," + dc.NumberOfDrawers + "," + dc.Material + "," + dc.RushDays; ;

                string DeskQuoteFile = @"quotes.txt";
                if (!File.Exists(DeskQuoteFile))
                {
                    using (StreamWriter sw = File.CreateText(DeskQuoteFile))
                    {
                        sw.WriteLine(DeskQuoteRecord);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(DeskQuoteFile))
                    {
                        sw.WriteLine(DeskQuoteRecord);
                    }
                }


            }
            catch (Exception)
            {
                if ((txtCustName.Text == "") || (txtWidth.Text == "") || (txtDepth.Text == "") || (txtNumDrawers.Text == "")  || (MaterialComboBox.SelectedIndex == -1))
                    MessageBox.Show("Please ensure that your entries are complete", "Error");
            }

            

        }
    }
}
