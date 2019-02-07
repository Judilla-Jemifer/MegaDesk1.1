using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace MegaDesk_3_JemiferJudilla
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            // create List for the material combobox
            List<DeskMaterial> MaterialList = Enum.GetValues(typeof(DeskMaterial)).Cast<DeskMaterial>().ToList();
            SearchComboBox.DataSource = MaterialList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {


                string MaterialSelected = SearchComboBox.SelectedItem.ToString();


                using (StreamReader file = new StreamReader(@"quotes.txt"))


                {
                    

                    string line;

                    while ((line = file.ReadLine()) != null)
                   
                    {

                       
                            

                            if (line.Contains(MaterialSelected))
                     
                        { 
                            

                                listSearchQuotes.Items.Add(line);

                            }
                            

                        }
                        file.Close();

                    }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, there was an error.", "Error");
            }
        }
    }
}
