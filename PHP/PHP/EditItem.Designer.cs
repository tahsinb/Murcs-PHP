namespace PHP
{
    partial class EditItem
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
            this.StockList = new System.Windows.Forms.ListView();
            this.Header1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = new System.Windows.Forms.TextBox();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StockLabel = new System.Windows.Forms.Label();
            this.Product_ID = new System.Windows.Forms.TextBox();
            this.Product_Name = new System.Windows.Forms.TextBox();
            this.Product_Price = new System.Windows.Forms.TextBox();
            this.Product_Stock = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StockList
            // 
            this.StockList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Header1,
            this.Header2,
            this.Header3,
            this.Header4});
            this.StockList.GridLines = true;
            this.StockList.HideSelection = false;
            this.StockList.Location = new System.Drawing.Point(332, 64);
            this.StockList.Name = "StockList";
            this.StockList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StockList.Size = new System.Drawing.Size(429, 297);
            this.StockList.TabIndex = 14;
            this.StockList.UseCompatibleStateImageBehavior = false;
            this.StockList.View = System.Windows.Forms.View.Details;
            this.StockList.SelectedIndexChanged += new System.EventHandler(this.ProductTable_SelectedIndexChanged);
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
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(161, 205);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(128, 20);
            this.ID.TabIndex = 15;
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLabel.Location = new System.Drawing.Point(37, 200);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(118, 25);
            this.ProductIDLabel.TabIndex = 16;
            this.ProductIDLabel.Text = "Product ID:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(161, 241);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(128, 35);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.BackColor = System.Drawing.Color.Transparent;
            this.StockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLabel.Location = new System.Drawing.Point(503, 22);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(105, 39);
            this.StockLabel.TabIndex = 18;
            this.StockLabel.Text = "Stock";
            // 
            // Product_ID
            // 
            this.Product_ID.Enabled = false;
            this.Product_ID.Location = new System.Drawing.Point(329, 382);
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.Size = new System.Drawing.Size(72, 20);
            this.Product_ID.TabIndex = 19;
            this.Product_ID.TextChanged += new System.EventHandler(this.Product_ID_TextChanged);
            // 
            // Product_Name
            // 
            this.Product_Name.Enabled = false;
            this.Product_Name.Location = new System.Drawing.Point(407, 382);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(145, 20);
            this.Product_Name.TabIndex = 20;
            // 
            // Product_Price
            // 
            this.Product_Price.Enabled = false;
            this.Product_Price.Location = new System.Drawing.Point(558, 382);
            this.Product_Price.Name = "Product_Price";
            this.Product_Price.Size = new System.Drawing.Size(94, 20);
            this.Product_Price.TabIndex = 21;
            // 
            // Product_Stock
            // 
            this.Product_Stock.Enabled = false;
            this.Product_Stock.Location = new System.Drawing.Point(658, 382);
            this.Product_Stock.Name = "Product_Stock";
            this.Product_Stock.Size = new System.Drawing.Size(94, 20);
            this.Product_Stock.TabIndex = 22;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(488, 415);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 23);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(713, 415);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Sales1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Product_Stock);
            this.Controls.Add(this.Product_Price);
            this.Controls.Add(this.Product_Name);
            this.Controls.Add(this.Product_ID);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.StockList);
            this.Name = "EditItem";
            this.Text = "EditItem";
            this.Load += new System.EventHandler(this.EditItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView StockList;
        public System.Windows.Forms.ColumnHeader Header1;
        private System.Windows.Forms.ColumnHeader Header2;
        private System.Windows.Forms.ColumnHeader Header3;
        private System.Windows.Forms.ColumnHeader Header4;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.TextBox Product_ID;
        private System.Windows.Forms.TextBox Product_Name;
        private System.Windows.Forms.TextBox Product_Price;
        private System.Windows.Forms.TextBox Product_Stock;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
    }
}