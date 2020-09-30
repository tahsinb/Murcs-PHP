namespace PHP
{
    partial class EditSale
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
            this.SaleTable = new System.Windows.Forms.ListView();
            this.Header1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Search = new System.Windows.Forms.Button();
            this.SaleIDtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaleTable
            // 
            this.SaleTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Header1,
            this.Header2,
            this.Header3,
            this.Header4,
            this.columnHeader2});
            this.SaleTable.GridLines = true;
            this.SaleTable.HideSelection = false;
            this.SaleTable.Location = new System.Drawing.Point(210, 54);
            this.SaleTable.Name = "SaleTable";
            this.SaleTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaleTable.Size = new System.Drawing.Size(535, 297);
            this.SaleTable.TabIndex = 16;
            this.SaleTable.UseCompatibleStateImageBehavior = false;
            this.SaleTable.View = System.Windows.Forms.View.Details;
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
            // columnHeader2
            // 
            this.columnHeader2.Text = "Employee ID";
            this.columnHeader2.Width = 100;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(58, 212);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 38);
            this.Search.TabIndex = 15;
            this.Search.Text = "Edit";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.SaleID_Search);
            // 
            // SaleIDtext
            // 
            this.SaleIDtext.Location = new System.Drawing.Point(58, 186);
            this.SaleIDtext.Name = "SaleIDtext";
            this.SaleIDtext.Size = new System.Drawing.Size(100, 20);
            this.SaleIDtext.TabIndex = 14;
            this.SaleIDtext.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(55, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sale ID";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(287, 389);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(142, 20);
            this.DateBox.TabIndex = 18;
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(435, 389);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(96, 20);
            this.CostBox.TabIndex = 19;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(537, 389);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(92, 20);
            this.NameBox.TabIndex = 20;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(58, 378);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(100, 38);
            this.Edit.TabIndex = 22;
            this.Edit.Text = "Confirm";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.ClickConfirm);
            // 
            // EditSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Sales1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.CostBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.SaleTable);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SaleIDtext);
            this.Controls.Add(this.label1);
            this.Name = "EditSale";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView SaleTable;
        public System.Windows.Forms.ColumnHeader Header1;
        private System.Windows.Forms.ColumnHeader Header2;
        private System.Windows.Forms.ColumnHeader Header3;
        private System.Windows.Forms.ColumnHeader Header4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SaleIDtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button Edit;
    }
}