namespace PHP
{
	partial class ParentMDI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesPredictionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSaleToolStripMenuItem,
            this.editSaleToolStripMenuItem,
            this.viewSaleToolStripMenuItem,
            this.deleteSaleToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // addSaleToolStripMenuItem
            // 
            this.addSaleToolStripMenuItem.Name = "addSaleToolStripMenuItem";
            this.addSaleToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addSaleToolStripMenuItem.Text = "Add Sale";
            this.addSaleToolStripMenuItem.Click += new System.EventHandler(this.addSaleToolStripMenuItem_Click);
            // 
            // editSaleToolStripMenuItem
            // 
            this.editSaleToolStripMenuItem.Name = "editSaleToolStripMenuItem";
            this.editSaleToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.editSaleToolStripMenuItem.Text = "Edit Sale";
            this.editSaleToolStripMenuItem.Click += new System.EventHandler(this.editSaleToolStripMenuItem_Click);
            // 
            // viewSaleToolStripMenuItem
            // 
            this.viewSaleToolStripMenuItem.Name = "viewSaleToolStripMenuItem";
            this.viewSaleToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.viewSaleToolStripMenuItem.Text = "View Sale";
            this.viewSaleToolStripMenuItem.Click += new System.EventHandler(this.viewSaleToolStripMenuItem_Click);
            // 
            // deleteSaleToolStripMenuItem
            // 
            this.deleteSaleToolStripMenuItem.Name = "deleteSaleToolStripMenuItem";
            this.deleteSaleToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deleteSaleToolStripMenuItem.Text = "Delete Sale";
            this.deleteSaleToolStripMenuItem.Click += new System.EventHandler(this.deleteSaleToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.editItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem,
            this.lowStockToolStripMenuItem,
            this.viewStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // lowStockToolStripMenuItem
            // 
            this.lowStockToolStripMenuItem.Name = "lowStockToolStripMenuItem";
            this.lowStockToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.lowStockToolStripMenuItem.Text = "Low Stock";
            this.lowStockToolStripMenuItem.Click += new System.EventHandler(this.lowStockToolStripMenuItem_Click);
            // 
            // viewStockToolStripMenuItem
            // 
            this.viewStockToolStripMenuItem.Name = "viewStockToolStripMenuItem";
            this.viewStockToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.viewStockToolStripMenuItem.Text = "View Stock";
            this.viewStockToolStripMenuItem.Click += new System.EventHandler(this.viewStockToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weeklyReportToolStripMenuItem,
            this.monthlyReportToolStripMenuItem,
            this.salesPredictionsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // weeklyReportToolStripMenuItem
            // 
            this.weeklyReportToolStripMenuItem.Name = "weeklyReportToolStripMenuItem";
            this.weeklyReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.weeklyReportToolStripMenuItem.Text = "Weekly Report";
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthlyReportToolStripMenuItem.Text = "Monthly Report";
            // 
            // salesPredictionsToolStripMenuItem
            // 
            this.salesPredictionsToolStripMenuItem.Name = "salesPredictionsToolStripMenuItem";
            this.salesPredictionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salesPredictionsToolStripMenuItem.Text = "Sales Predictions";
            this.salesPredictionsToolStripMenuItem.Click += new System.EventHandler(this.salesPredictionToolStripMenuItem_Click);
            // 
            // ParentMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PHP.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(974, 582);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentMDI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ParentMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesPredictionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStockToolStripMenuItem;
    }
}

