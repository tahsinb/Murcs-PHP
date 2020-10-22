namespace PHP
{
    partial class AddItem
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
            this.StockLabel = new System.Windows.Forms.Label();
            this.StockLevelLabel = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StockList
            // 
            this.StockList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Header1,
            this.Header2,
            this.Header3,
            this.Header4});
            this.StockList.HideSelection = false;
            this.StockList.Location = new System.Drawing.Point(244, 79);
            this.StockList.Name = "StockList";
            this.StockList.Size = new System.Drawing.Size(568, 297);
            this.StockList.TabIndex = 24;
            this.StockList.UseCompatibleStateImageBehavior = false;
            this.StockList.View = System.Windows.Forms.View.Details;
            this.StockList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Header1
            // 
            this.Header1.Text = "Name";
            this.Header1.Width = 150;
            // 
            // Header2
            // 
            this.Header2.Text = "ID";
            this.Header2.Width = 150;
            // 
            // Header3
            // 
            this.Header3.Text = "Price";
            this.Header3.Width = 150;
            // 
            // Header4
            // 
            this.Header4.Text = "Stock Level";
            this.Header4.Width = 150;
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.BackColor = System.Drawing.Color.Transparent;
            this.StockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.StockLabel.Location = new System.Drawing.Point(464, 9);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(131, 51);
            this.StockLabel.TabIndex = 25;
            this.StockLabel.Text = "Stock";
            this.StockLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // StockLevelLabel
            // 
            this.StockLevelLabel.AutoSize = true;
            this.StockLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.StockLevelLabel.Location = new System.Drawing.Point(43, 252);
            this.StockLevelLabel.Name = "StockLevelLabel";
            this.StockLevelLabel.Size = new System.Drawing.Size(64, 13);
            this.StockLevelLabel.TabIndex = 23;
            this.StockLevelLabel.Text = "Stock Level";
            this.StockLevelLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(113, 212);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 22;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceLabel.Location = new System.Drawing.Point(67, 215);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 21;
            this.PriceLabel.Text = "Price";
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(113, 249);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(100, 20);
            this.Stock.TabIndex = 20;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Location = new System.Drawing.Point(72, 183);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "Name";
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(113, 305);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(100, 38);
            this.AddItemButton.TabIndex = 17;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(113, 176);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 14;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(737, 448);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 26;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(737, 9);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 23);
            this.LogOutButton.TabIndex = 27;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Sales1;
            this.ClientSize = new System.Drawing.Size(826, 483);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StockList);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.StockLevelLabel);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.Name);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView StockList;
        public System.Windows.Forms.ColumnHeader Header1;
        private System.Windows.Forms.ColumnHeader Header2;
        private System.Windows.Forms.ColumnHeader Header3;
        private System.Windows.Forms.ColumnHeader Header4;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.Label StockLevelLabel;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox Stock;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}