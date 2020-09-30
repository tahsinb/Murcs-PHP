﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public DeleteSale(PHPRepo pHPRepo)
        {
            InitializeComponent();

            _pHPRepo = pHPRepo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(textBox1.Text, out id);
            sale = _pHPRepo.GetSaleById(id);
            _pHPRepo.RemoveSales(sale);
            MessageBox.Show("Sucessful", "Sale has been deleted", MessageBoxButtons.OK, MessageBoxIcon.None);
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
    }
}