namespace PHP
{
    partial class DeleteItem
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
            this.RemoveButton = new System.Windows.Forms.Button();
            this.StockLabel = new System.Windows.Forms.Label();
            this.StockList = new System.Windows.Forms.ListView();
            this.Product_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductID = new System.Windows.Forms.TextBox();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(160, 232);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(110, 33);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.BackColor = System.Drawing.Color.Transparent;
            this.StockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.StockLabel.Location = new System.Drawing.Point(452, 19);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(131, 51);
            this.StockLabel.TabIndex = 5;
            this.StockLabel.Text = "Stock";
            this.StockLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // StockList
            // 
            this.StockList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product_ID,
            this.Product_Name,
            this.Price,
            this.Stock_Count});
            this.StockList.HideSelection = false;
            this.StockList.Location = new System.Drawing.Point(331, 85);
            this.StockList.Name = "StockList";
            this.StockList.Size = new System.Drawing.Size(406, 287);
            this.StockList.TabIndex = 4;
            this.StockList.UseCompatibleStateImageBehavior = false;
            this.StockList.View = System.Windows.Forms.View.Details;
            this.StockList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Product_ID
            // 
            this.Product_ID.Text = "Product ID";
            this.Product_ID.Width = 100;
            // 
            // Product_Name
            // 
            this.Product_Name.Text = "Product Name";
            this.Product_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Product_Name.Width = 100;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 100;
            // 
            // Stock_Count
            // 
            this.Stock_Count.Text = "Stock_Count";
            this.Stock_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Stock_Count.Width = 100;
            // 
            // ProductID
            // 
            this.ProductID.Location = new System.Drawing.Point(160, 188);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(110, 20);
            this.ProductID.TabIndex = 7;
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLabel.Location = new System.Drawing.Point(18, 182);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(131, 29);
            this.ProductIDLabel.TabIndex = 8;
            this.ProductIDLabel.Text = "Product ID:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(713, 415);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DeleteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Sales1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.StockList);
            this.Name = "DeleteItem";
            this.Text = "DeleteItem";
            this.Load += new System.EventHandler(this.DeleteItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.ListView StockList;
        private System.Windows.Forms.ColumnHeader Product_ID;
        private System.Windows.Forms.ColumnHeader Product_Name;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Stock_Count;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Button CloseButton;
    }
}