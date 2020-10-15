namespace PHP
{
    partial class ViewStock
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
            this.ProductTable = new System.Windows.Forms.ListView();
            this.Header1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProdIDLabel = new System.Windows.Forms.Label();
            this.ProdIDInput = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductTable
            // 
            this.ProductTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Header1,
            this.Header2,
            this.Header3,
            this.Header4});
            this.ProductTable.GridLines = true;
            this.ProductTable.HideSelection = false;
            this.ProductTable.Location = new System.Drawing.Point(310, 59);
            this.ProductTable.Name = "ProductTable";
            this.ProductTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductTable.Size = new System.Drawing.Size(429, 297);
            this.ProductTable.TabIndex = 13;
            this.ProductTable.UseCompatibleStateImageBehavior = false;
            this.ProductTable.View = System.Windows.Forms.View.Details;
            this.ProductTable.SelectedIndexChanged += new System.EventHandler(this.ProductTable_SelectedIndexChanged);
            // 
            // Header1
            // 
            this.Header1.Text = "Product ID";
            this.Header1.Width = 75;
            // 
            // Header2
            // 
            this.Header2.Text = "Product Name";
            this.Header2.Width = 150;
            // 
            // Header3
            // 
            this.Header3.Text = "Price";
            this.Header3.Width = 100;
            // 
            // Header4
            // 
            this.Header4.Text = "Stock Count";
            this.Header4.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Employee ID";
            this.columnHeader2.Width = 100;
            // 
            // ProdIDLabel
            // 
            this.ProdIDLabel.AutoSize = true;
            this.ProdIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProdIDLabel.Location = new System.Drawing.Point(43, 166);
            this.ProdIDLabel.Name = "ProdIDLabel";
            this.ProdIDLabel.Size = new System.Drawing.Size(58, 13);
            this.ProdIDLabel.TabIndex = 14;
            this.ProdIDLabel.Text = "Product ID";
            // 
            // ProdIDInput
            // 
            this.ProdIDInput.Location = new System.Drawing.Point(46, 182);
            this.ProdIDInput.Name = "ProdIDInput";
            this.ProdIDInput.Size = new System.Drawing.Size(100, 20);
            this.ProdIDInput.TabIndex = 15;
            this.ProdIDInput.TextChanged += new System.EventHandler(this.ProdIDInput_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SearchButton.Location = new System.Drawing.Point(46, 218);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 49);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ViewStock
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Sales1;
            this.ClientSize = new System.Drawing.Size(808, 405);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ProdIDInput);
            this.Controls.Add(this.ProdIDLabel);
            this.Controls.Add(this.ProductTable);
            this.MinimumSize = new System.Drawing.Size(760, 400);
            this.Name = "ViewStock";
            this.Text = "ViewStock";
            this.Load += new System.EventHandler(this.ViewStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ProductTable;
        public System.Windows.Forms.ColumnHeader Header1;
        private System.Windows.Forms.ColumnHeader Header2;
        private System.Windows.Forms.ColumnHeader Header3;
        private System.Windows.Forms.ColumnHeader Header4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label ProdIDLabel;
        private System.Windows.Forms.TextBox ProdIDInput;
        private System.Windows.Forms.Button SearchButton;
    }
}