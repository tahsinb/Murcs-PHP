namespace PHP
{
    partial class SalesPrediction
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
            this.ProductTypeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PredictWeekly = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TotalCostText = new System.Windows.Forms.TextBox();
            this.SalesPredictionText = new System.Windows.Forms.TextBox();
            this.PredictionPeriod = new System.Windows.Forms.TextBox();
            this.ProductTypeTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductTypeText
            // 
            this.ProductTypeText.Location = new System.Drawing.Point(89, 159);
            this.ProductTypeText.Name = "ProductTypeText";
            this.ProductTypeText.Size = new System.Drawing.Size(100, 20);
            this.ProductTypeText.TabIndex = 10;
            this.ProductTypeText.TextChanged += new System.EventHandler(this.ProductType_changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(86, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product Type";
            // 
            // PredictWeekly
            // 
            this.PredictWeekly.Location = new System.Drawing.Point(76, 202);
            this.PredictWeekly.Name = "PredictWeekly";
            this.PredictWeekly.Size = new System.Drawing.Size(128, 35);
            this.PredictWeekly.TabIndex = 18;
            this.PredictWeekly.Text = "Predict Weekly Sales";
            this.PredictWeekly.UseVisualStyleBackColor = true;
            this.PredictWeekly.Click += new System.EventHandler(this.PredictWeeklySales);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Predict Monthly Sales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PredictMonthlySales);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(276, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Product Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(432, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Prediction Period";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(589, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Predicted Units Sold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(705, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total Cost";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.Controls.Add(this.TotalCostText, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.SalesPredictionText, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PredictionPeriod, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProductTypeTextBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(257, 202);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 26);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // TotalCostText
            // 
            this.TotalCostText.Location = new System.Drawing.Point(438, 3);
            this.TotalCostText.Name = "TotalCostText";
            this.TotalCostText.Size = new System.Drawing.Size(70, 20);
            this.TotalCostText.TabIndex = 28;
            // 
            // SalesPredictionText
            // 
            this.SalesPredictionText.Location = new System.Drawing.Point(326, 3);
            this.SalesPredictionText.Name = "SalesPredictionText";
            this.SalesPredictionText.Size = new System.Drawing.Size(106, 20);
            this.SalesPredictionText.TabIndex = 27;
            // 
            // PredictionPeriod
            // 
            this.PredictionPeriod.Location = new System.Drawing.Point(120, 3);
            this.PredictionPeriod.Name = "PredictionPeriod";
            this.PredictionPeriod.Size = new System.Drawing.Size(200, 20);
            this.PredictionPeriod.TabIndex = 26;
            // 
            // ProductTypeTextBox
            // 
            this.ProductTypeTextBox.Location = new System.Drawing.Point(3, 3);
            this.ProductTypeTextBox.Name = "ProductTypeTextBox";
            this.ProductTypeTextBox.Size = new System.Drawing.Size(111, 20);
            this.ProductTypeTextBox.TabIndex = 25;
            // 
            // SalesPrediction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Sales1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PredictWeekly);
            this.Controls.Add(this.ProductTypeText);
            this.Controls.Add(this.label1);
            this.Name = "SalesPrediction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SalesPrediction";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductTypeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PredictWeekly;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TotalCostText;
        private System.Windows.Forms.TextBox SalesPredictionText;
        private System.Windows.Forms.TextBox PredictionPeriod;
        private System.Windows.Forms.TextBox ProductTypeTextBox;
    }
}