namespace PHP
{
    partial class DeleteSale
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
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SaleIDLabel = new System.Windows.Forms.Label();
            this.SaleID = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(315, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(313, 241);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(168, 42);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SaleIDLabel
            // 
            this.SaleIDLabel.AutoSize = true;
            this.SaleIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaleIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleIDLabel.Location = new System.Drawing.Point(149, 198);
            this.SaleIDLabel.Name = "SaleIDLabel";
            this.SaleIDLabel.Size = new System.Drawing.Size(118, 33);
            this.SaleIDLabel.TabIndex = 4;
            this.SaleIDLabel.Text = "Sale ID:";
            // 
            // SaleID
            // 
            this.SaleID.Location = new System.Drawing.Point(278, 205);
            this.SaleID.Name = "SaleID";
            this.SaleID.Size = new System.Drawing.Size(224, 20);
            this.SaleID.TabIndex = 5;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(713, 415);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DeleteSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Sales1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaleID);
            this.Controls.Add(this.SaleIDLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label1);
            this.Name = "DeleteSale";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.DeleteSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label SaleIDLabel;
        private System.Windows.Forms.TextBox SaleID;
        private System.Windows.Forms.Button CloseButton;
    }
}