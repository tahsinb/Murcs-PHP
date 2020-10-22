using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHP.Database;
using PHP.Database.Classes;

namespace PHP
{
    public partial class DeleteSale : Form
    {
        PHPRepo _pHPRepo;
        Sale sale;
        private HelpProvider helpProvider;

        public DeleteSale(PHPRepo pHPRepo)
        {
            InitializeComponent();
            CreateHelpProvider();

            _pHPRepo = pHPRepo;
        }

        private void CreateHelpProvider()
        {
            helpProvider = new HelpProvider();
            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            string path = Path.Combine(exeDir, "..\\..\\Resources\\DeleteSale.htm");
            helpProvider.HelpNamespace = path;
            helpProvider.SetHelpNavigator(SaleID, HelpNavigator.TableOfContents);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(SaleID.Text, out id))
            {
                if (_pHPRepo.GetSaleById(id) != null)
                {
                    sale = _pHPRepo.GetSaleById(id);
                    _pHPRepo.RemoveSales(sale);
                    MessageBox.Show("Sucessful", "Sale has been deleted", MessageBoxButtons.OK, MessageBoxIcon.None);
                    SaleID.Clear();
                }
                else
                {
                    MessageBox.Show("Could not find Sale: " + SaleID.Text);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid ID");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteSale_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //confirm closing of forms
            if (MessageBox.Show("Are you sure you want to exit this page? All unsaved changes will be lost.", "Close form",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //confirmed exit
                this.Close();

            }
            else
            {
                //do nothing after dialog box is closed
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            DialogResult logoutResult = MessageBox.Show("Are you sure you would like to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo);
            if (logoutResult == DialogResult.Yes)
            {

                //close current page
                this.Close();

                //close homepage
                ParentMDI.ActiveForm.Close();

                //return to login page
                new Login(_pHPRepo).Show();

            }
            else if (logoutResult == DialogResult.No)
            {
                //do nothing
            }
        }
    }
}
