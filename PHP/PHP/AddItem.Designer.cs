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
            this.Label_Stock = new System.Windows.Forms.Label();
            this.Label_StockLevel = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.Label_Price = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.TextBox();
            this.Label_ID = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
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
            this.StockList.HideSelection = false;
            this.StockList.Location = new System.Drawing.Point(281, 81);
            this.StockList.Name = "StockList";
            this.StockList.Size = new System.Drawing.Size(609, 297);
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
            // Label_Stock
            // 
            this.Label_Stock.AutoSize = true;
            this.Label_Stock.BackColor = System.Drawing.Color.Transparent;
            this.Label_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.Label_Stock.Location = new System.Drawing.Point(516, 9);
            this.Label_Stock.Name = "Label_Stock";
            this.Label_Stock.Size = new System.Drawing.Size(131, 51);
            this.Label_Stock.TabIndex = 25;
            this.Label_Stock.Text = "Stock";
            this.Label_Stock.Click += new System.EventHandler(this.label5_Click);
            // 
            // Label_StockLevel
            // 
            this.Label_StockLevel.AutoSize = true;
            this.Label_StockLevel.BackColor = System.Drawing.Color.Transparent;
            this.Label_StockLevel.Location = new System.Drawing.Point(43, 252);
            this.Label_StockLevel.Name = "Label_StockLevel";
            this.Label_StockLevel.Size = new System.Drawing.Size(64, 13);
            this.Label_StockLevel.TabIndex = 23;
            this.Label_StockLevel.Text = "Stock Level";
            this.Label_StockLevel.Click += new System.EventHandler(this.label4_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(113, 212);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 8;
            // 
            // Label_Price
            // 
            this.Label_Price.AutoSize = true;
            this.Label_Price.BackColor = System.Drawing.Color.Transparent;
            this.Label_Price.Location = new System.Drawing.Point(67, 215);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(31, 13);
            this.Label_Price.TabIndex = 21;
            this.Label_Price.Text = "Price";
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(113, 249);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(100, 20);
            this.Stock.TabIndex = 7;
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.BackColor = System.Drawing.Color.Transparent;
            this.Label_ID.Location = new System.Drawing.Point(79, 173);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(18, 13);
            this.Label_ID.TabIndex = 19;
            this.Label_ID.Text = "ID";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.BackColor = System.Drawing.Color.Transparent;
            this.Label_Name.Location = new System.Drawing.Point(72, 135);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(35, 13);
            this.Label_Name.TabIndex = 18;
            this.Label_Name.Text = "Name";
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
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(113, 170);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 7;
            this.ID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(113, 128);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 8;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(815, 448);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 26;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Sales1;
            this.ClientSize = new System.Drawing.Size(902, 483);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StockList);
            this.Controls.Add(this.Label_Stock);
            this.Controls.Add(this.Label_StockLevel);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Label_Price);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Name);
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
        private System.Windows.Forms.Label Label_Stock;
        private System.Windows.Forms.Label Label_StockLevel;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label Label_Price;
        private System.Windows.Forms.TextBox Stock;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Button CloseButton;
    }
}