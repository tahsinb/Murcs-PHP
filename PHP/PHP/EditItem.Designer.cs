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
            this.ListView1 = new System.Windows.Forms.ListView();
            this.Header1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Product_ID = new System.Windows.Forms.TextBox();
            this.Product_Name = new System.Windows.Forms.TextBox();
            this.Product_Price = new System.Windows.Forms.TextBox();
            this.Product_Stock = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Header1,
            this.Header2,
            this.Header3,
            this.Header4});
            this.ListView1.GridLines = true;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(332, 64);
            this.ListView1.Name = "ListView1";
            this.ListView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListView1.Size = new System.Drawing.Size(429, 297);
            this.ListView1.TabIndex = 14;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ProductTable_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "Stock";
            // 
            // Product_ID
            // 
            this.Product_ID.Enabled = false;
            this.Product_ID.Location = new System.Drawing.Point(329, 382);
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.Size = new System.Drawing.Size(72, 20);
            this.Product_ID.TabIndex = 19;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(713, 12);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 23);
            this.LogOutButton.TabIndex = 25;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Sales1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Product_Stock);
            this.Controls.Add(this.Product_Price);
            this.Controls.Add(this.Product_Name);
            this.Controls.Add(this.Product_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.ListView1);
            this.Name = "EditItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EditItem";
            this.Load += new System.EventHandler(this.EditItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView1;
        public System.Windows.Forms.ColumnHeader Header1;
        private System.Windows.Forms.ColumnHeader Header2;
        private System.Windows.Forms.ColumnHeader Header3;
        private System.Windows.Forms.ColumnHeader Header4;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Product_ID;
        private System.Windows.Forms.TextBox Product_Name;
        private System.Windows.Forms.TextBox Product_Price;
        private System.Windows.Forms.TextBox Product_Stock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}