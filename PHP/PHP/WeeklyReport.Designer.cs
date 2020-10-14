namespace PHP
{
    partial class WeeklyReport
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
            this.TotalRevanue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SaleTable = new System.Windows.Forms.ListView();
            this.SaleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.TotalSales = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotalRevanue
            // 
            this.TotalRevanue.Location = new System.Drawing.Point(603, 347);
            this.TotalRevanue.Name = "TotalRevanue";
            this.TotalRevanue.Size = new System.Drawing.Size(100, 20);
            this.TotalRevanue.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(600, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Weekly revenue";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Export CSV";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SaleTable
            // 
            this.SaleTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SaleID,
            this.SaleDate,
            this.TotalCost,
            this.CustomerName});
            this.SaleTable.GridLines = true;
            this.SaleTable.HideSelection = false;
            this.SaleTable.Location = new System.Drawing.Point(168, 70);
            this.SaleTable.Name = "SaleTable";
            this.SaleTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaleTable.Size = new System.Drawing.Size(429, 297);
            this.SaleTable.TabIndex = 13;
            this.SaleTable.UseCompatibleStateImageBehavior = false;
            this.SaleTable.View = System.Windows.Forms.View.Details;
            // 
            // SaleID
            // 
            this.SaleID.Text = "Sale ID";
            this.SaleID.Width = 75;
            // 
            // SaleDate
            // 
            this.SaleDate.Text = "Sale Date";
            this.SaleDate.Width = 150;
            // 
            // TotalCost
            // 
            this.TotalCost.Text = "Total Cost";
            this.TotalCost.Width = 100;
            // 
            // CustomerName
            // 
            this.CustomerName.Text = "Customer Name";
            this.CustomerName.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Weekly Sales Report";
            // 
            // TotalSales
            // 
            this.TotalSales.Location = new System.Drawing.Point(603, 304);
            this.TotalSales.Name = "TotalSales";
            this.TotalSales.Size = new System.Drawing.Size(100, 20);
            this.TotalSales.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(600, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Weekly sales";
            // 
            // WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Sales1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalSales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaleTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TotalRevanue);
            this.Controls.Add(this.label1);
            this.Name = "WeeklyReport";
            this.Text = "WeeklyReport";
            this.Load += new System.EventHandler(this.WeeklyReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TotalRevanue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView SaleTable;
        public System.Windows.Forms.ColumnHeader SaleID;
        private System.Windows.Forms.ColumnHeader SaleDate;
        private System.Windows.Forms.ColumnHeader TotalCost;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalSales;
        private System.Windows.Forms.Label label2;
    }
}