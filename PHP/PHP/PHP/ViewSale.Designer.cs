namespace PHP
{
    partial class ViewSale
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
            this.label1 = new System.Windows.Forms.Label();
            this.SaleIDtext = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Header1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleTable = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(66, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sale ID";
            // 
            // SaleIDtext
            // 
            this.SaleIDtext.Location = new System.Drawing.Point(69, 164);
            this.SaleIDtext.Name = "SaleIDtext";
            this.SaleIDtext.Size = new System.Drawing.Size(100, 20);
            this.SaleIDtext.TabIndex = 8;
            this.SaleIDtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaleID_Search);
            // 
            // Header1
            // 
            this.Header1.Text = "Sale ID";
            this.Header1.Width = 75;
            // 
            // Header2
            // 
            this.Header2.Text = "Sale Date";
            this.Header2.Width = 150;
            // 
            // Header3
            // 
            this.Header3.Text = "Total Cost";
            this.Header3.Width = 100;
            // 
            // Header4
            // 
            this.Header4.Text = "Customer Name";
            this.Header4.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Employee ID";
            this.columnHeader2.Width = 100;
            // 
            // SaleTable
            // 
            this.SaleTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Header1,
            this.Header2,
            this.Header3,
            this.Header4,
            this.columnHeader1,
            this.columnHeader2});
            this.SaleTable.GridLines = true;
            this.SaleTable.HideSelection = false;
            this.SaleTable.Location = new System.Drawing.Point(175, 56);
            this.SaleTable.Name = "SaleTable";
            this.SaleTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaleTable.Size = new System.Drawing.Size(613, 297);
            this.SaleTable.TabIndex = 12;
            this.SaleTable.UseCompatibleStateImageBehavior = false;
            this.SaleTable.View = System.Windows.Forms.View.Details;
            // 
            // ViewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Sales1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaleTable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaleIDtext);
            this.Controls.Add(this.label1);
            this.Name = "ViewSale";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SaleIDtext;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ColumnHeader Header1;
        private System.Windows.Forms.ColumnHeader Header2;
        private System.Windows.Forms.ColumnHeader Header3;
        private System.Windows.Forms.ColumnHeader Header4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView SaleTable;
    }
}