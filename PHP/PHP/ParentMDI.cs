using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHP.Database;

namespace PHP
{
	public partial class ParentMDI : Form
	{
		PHPRepo _pHPRepo;
		public ParentMDI(PHPRepo pHPRepo)
		{
			InitializeComponent();
			_pHPRepo = pHPRepo;
		}

        private void addSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
			foreach (Form frm in this.MdiChildren)
			{
				frm.Visible = false;
				frm.Dispose();
			}
			bool isOpen = false;
			foreach (Form f in Application.OpenForms)
            {
				if (f.Text == "AddTransaction")
                {
					isOpen = true;
					f.Focus();
					break;
                }
            }
			if (isOpen == false)
            {
				AddTransaction AddTransaction = new AddTransaction(_pHPRepo);
				AddTransaction.MdiParent = this;
				AddTransaction.Show();
            }
			
		}

        private void editSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
			foreach (Form frm in this.MdiChildren)
			{
				frm.Visible = false;
				frm.Dispose();
			}
			bool isOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "EditSale")
				{
					isOpen = true;
					f.Focus();
					break;
				}
			}
			if (isOpen == false)
			{
				EditSale EditSaleRecord = new EditSale(_pHPRepo);
				EditSaleRecord.MdiParent = this;
				EditSaleRecord.Show();
			}
		}

        private void viewSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
			foreach (Form frm in this.MdiChildren)
			{
				frm.Visible = false;
				frm.Dispose();
			}
			bool isOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "ViewSale")
				{
					isOpen = true;
					f.Focus();
					break;
				}
			}
			if (isOpen == false)
			{
				ViewSale ViewSaleRecord = new ViewSale(_pHPRepo);
				ViewSaleRecord.MdiParent = this;
				ViewSaleRecord.Show();
			}
		}

        private void deleteSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
			
			foreach (Form frm in this.MdiChildren)
			{
				frm.Visible = false;
				frm.Dispose();
			}
			bool isOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "DeleteSale")
				{
					isOpen = true;
					f.Focus();
					break;
				}
			}
			if (isOpen == false)
			{
				DeleteSale DeleteSaleRecord = new DeleteSale(_pHPRepo);
				DeleteSaleRecord.MdiParent = this;
				DeleteSaleRecord.Show();
			}

		}

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
			foreach (Form frm in this.MdiChildren)
			{
				frm.Visible = false;
				frm.Dispose();
			}
			bool isOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "AddItem")
				{
					isOpen = true;
					f.Focus();
					break;
				}
			}
			if (isOpen == false)
			{
				AddItem AddItemStock = new AddItem();
				AddItemStock.MdiParent = this;
				AddItemStock.Show();
			}
		}

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
			foreach (Form frm in this.MdiChildren)
			{
				frm.Visible = false;
				frm.Dispose();
			}
			bool isOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "EditItem")
				{
					isOpen = true;
					f.Focus();
					break;
				}
			}
			if (isOpen == false)
			{
				EditItem EditItemStock = new EditItem();
				EditItemStock.MdiParent = this;
				EditItemStock.Show();
			}
		}

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
			foreach (Form frm in this.MdiChildren)
			{
				frm.Visible = false;
				frm.Dispose();
			}
			bool isOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "DeleteItem")
				{
					isOpen = true;
					f.Focus();
					break;
				}
			}
			if (isOpen == false)
			{
				DeleteItem DeleteItemStock = new DeleteItem();
				DeleteItemStock.MdiParent = this;
				DeleteItemStock.Show();
			}
		}

        private void lowStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
			foreach (Form frm in this.MdiChildren)
			{
				frm.Visible = false;
				frm.Dispose();
			}
			bool isOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "LowStock")
				{
					isOpen = true;
					f.Focus();
					break;
				}
			}
			if (isOpen == false)
			{
				LowStock LowStockItems = new LowStock();
				LowStockItems.MdiParent = this;
				LowStockItems.Show();
			}
		}

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
			foreach (Form frm in this.MdiChildren)
			{
				frm.Visible = false;
				frm.Dispose();
			}
			bool isOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "ViewStock")
				{
					isOpen = true;
					f.Focus();
					break;
				}
			}
			if (isOpen == false)
			{
				ViewStock ViewStockItems = new ViewStock();
				ViewStockItems.MdiParent = this;
				ViewStockItems.Show();
			}
		}

        private void ParentMDI_Load(object sender, EventArgs e)
        {

        }
    }
}
