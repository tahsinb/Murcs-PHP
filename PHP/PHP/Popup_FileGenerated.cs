using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP
{
    public partial class Popup_FileGenerated : Form
    {
        public Popup_FileGenerated(string filepath)
        {
            InitializeComponent();
            FileLocation.Text += filepath;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
