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
    public partial class Login : Form
    {
        PHPRepo _pHPRepo;
        private HelpProvider helpProvider;

        public Login(PHPRepo pHPRepo)
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
            string path = Path.Combine(exeDir, "..\\..\\Resources\\Login.htm");
            helpProvider.HelpNamespace = path;
            helpProvider.SetHelpNavigator(login_id_box, HelpNavigator.TableOfContents);
            helpProvider.SetHelpNavigator(login_pass_box, HelpNavigator.TableOfContents);
        }

        private bool LoginValid(int id, string password)
        {
            return _pHPRepo.VerifyPassword(id, password);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(login_id_box.Text, out id);

            if (LoginValid(id, login_pass_box.Text))
            {
                //hide login window
                this.Hide();
                // Load main application window
                ParentMDI main = new ParentMDI(_pHPRepo);
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear_btn_Click(sender, e);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            login_id_box.Clear();
            login_pass_box.Clear();
            login_id_box.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
