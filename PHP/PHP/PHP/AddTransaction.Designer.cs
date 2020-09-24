namespace PHP
{
    partial class AddTransaction
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
            this.CompanyName = new System.Windows.Forms.Label();
            this.ContentTitle1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.SaleDate = new System.Windows.Forms.DateTimePicker();
            this.InvoiceNumLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.NameEntry = new System.Windows.Forms.TextBox();
            this.ContentTitle3 = new System.Windows.Forms.Label();
            this.ContentTitle2 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ProdIDinput1 = new System.Windows.Forms.TextBox();
            this.ProdIDLabel = new System.Windows.Forms.Label();
            this.QtyLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.IDinputOne = new System.Windows.Forms.TableLayoutPanel();
            this.PriceInput5 = new System.Windows.Forms.TextBox();
            this.QTYinput5 = new System.Windows.Forms.TextBox();
            this.IDinput5 = new System.Windows.Forms.TextBox();
            this.PriceInput4 = new System.Windows.Forms.TextBox();
            this.QTYinput4 = new System.Windows.Forms.TextBox();
            this.IDinput4 = new System.Windows.Forms.TextBox();
            this.PriceInput3 = new System.Windows.Forms.TextBox();
            this.QTYinput3 = new System.Windows.Forms.TextBox();
            this.IDinput3 = new System.Windows.Forms.TextBox();
            this.PriceInput2 = new System.Windows.Forms.TextBox();
            this.QTYinput2 = new System.Windows.Forms.TextBox();
            this.IDinput2 = new System.Windows.Forms.TextBox();
            this.PriceInput1 = new System.Windows.Forms.TextBox();
            this.QTYinput1 = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalOutput = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.InvNumInput = new System.Windows.Forms.MaskedTextBox();
            this.EmpIDInput = new System.Windows.Forms.MaskedTextBox();
            this.IDinputOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyName.AutoSize = true;
            this.CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName.Location = new System.Drawing.Point(260, 9);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(241, 25);
            this.CompanyName.TabIndex = 0;
            this.CompanyName.Text = "People\'s Health Pharmacy";
            this.CompanyName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ContentTitle1
            // 
            this.ContentTitle1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentTitle1.AutoSize = true;
            this.ContentTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentTitle1.Location = new System.Drawing.Point(28, 43);
            this.ContentTitle1.Name = "ContentTitle1";
            this.ContentTitle1.Size = new System.Drawing.Size(100, 18);
            this.ContentTitle1.TabIndex = 1;
            this.ContentTitle1.Text = "Add New Sale";
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(44, 63);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(437, 15);
            this.Description.TabIndex = 2;
            this.Description.Text = "Fill out the details of the sales transaction below to add sale record to databas" +
    "e.";
            // 
            // SaleDate
            // 
            this.SaleDate.Location = new System.Drawing.Point(477, 92);
            this.SaleDate.MaxDate = new System.DateTime(2020, 9, 23, 1, 50, 46, 0);
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.Size = new System.Drawing.Size(259, 20);
            this.SaleDate.TabIndex = 3;
            this.SaleDate.Value = new System.DateTime(2020, 9, 23, 0, 0, 0, 0);
            // 
            // InvoiceNumLabel
            // 
            this.InvoiceNumLabel.AutoSize = true;
            this.InvoiceNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.InvoiceNumLabel.Location = new System.Drawing.Point(44, 91);
            this.InvoiceNumLabel.Name = "InvoiceNumLabel";
            this.InvoiceNumLabel.Size = new System.Drawing.Size(96, 15);
            this.InvoiceNumLabel.TabIndex = 4;
            this.InvoiceNumLabel.Text = "Invoice Number:";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EmployeeNameLabel.Location = new System.Drawing.Point(369, 148);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(102, 15);
            this.EmployeeNameLabel.TabIndex = 6;
            this.EmployeeNameLabel.Text = "Employee Name:";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EmployeeIDLabel.Location = new System.Drawing.Point(60, 147);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(80, 15);
            this.EmployeeIDLabel.TabIndex = 7;
            this.EmployeeIDLabel.Text = "Employee ID:";
            // 
            // NameEntry
            // 
            this.NameEntry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameEntry.Location = new System.Drawing.Point(477, 148);
            this.NameEntry.Name = "NameEntry";
            this.NameEntry.Size = new System.Drawing.Size(259, 20);
            this.NameEntry.TabIndex = 8;
            this.NameEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameEntry_KeyPress);
            this.NameEntry.Validating += new System.ComponentModel.CancelEventHandler(this.NameEntry_Validating);
            // 
            // ContentTitle3
            // 
            this.ContentTitle3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentTitle3.AutoSize = true;
            this.ContentTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ContentTitle3.Location = new System.Drawing.Point(28, 189);
            this.ContentTitle3.Name = "ContentTitle3";
            this.ContentTitle3.Size = new System.Drawing.Size(135, 18);
            this.ContentTitle3.TabIndex = 10;
            this.ContentTitle3.Text = "Transaction Details";
            // 
            // ContentTitle2
            // 
            this.ContentTitle2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContentTitle2.AutoSize = true;
            this.ContentTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ContentTitle2.Location = new System.Drawing.Point(28, 125);
            this.ContentTitle2.Name = "ContentTitle2";
            this.ContentTitle2.Size = new System.Drawing.Size(123, 18);
            this.ContentTitle2.TabIndex = 11;
            this.ContentTitle2.Text = "Employee Details";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DateLabel.Location = new System.Drawing.Point(435, 92);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(36, 15);
            this.DateLabel.TabIndex = 13;
            this.DateLabel.Text = "Date:";
            // 
            // ProdIDinput1
            // 
            this.ProdIDinput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdIDinput1.Location = new System.Drawing.Point(4, 27);
            this.ProdIDinput1.Name = "ProdIDinput1";
            this.ProdIDinput1.Size = new System.Drawing.Size(225, 20);
            this.ProdIDinput1.TabIndex = 3;
            // 
            // ProdIDLabel
            // 
            this.ProdIDLabel.AutoSize = true;
            this.ProdIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ProdIDLabel.Location = new System.Drawing.Point(4, 1);
            this.ProdIDLabel.Name = "ProdIDLabel";
            this.ProdIDLabel.Size = new System.Drawing.Size(225, 22);
            this.ProdIDLabel.TabIndex = 0;
            this.ProdIDLabel.Text = "Product ID";
            this.ProdIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QtyLabel
            // 
            this.QtyLabel.AutoSize = true;
            this.QtyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.QtyLabel.Location = new System.Drawing.Point(236, 1);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(225, 22);
            this.QtyLabel.TabIndex = 1;
            this.QtyLabel.Text = "Quantity";
            this.QtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.PriceLabel.Location = new System.Drawing.Point(468, 1);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(225, 22);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Price ($)";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDinputOne
            // 
            this.IDinputOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDinputOne.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.IDinputOne.ColumnCount = 3;
            this.IDinputOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.IDinputOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.IDinputOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.IDinputOne.Controls.Add(this.PriceInput5, 2, 5);
            this.IDinputOne.Controls.Add(this.QTYinput5, 1, 5);
            this.IDinputOne.Controls.Add(this.IDinput5, 0, 5);
            this.IDinputOne.Controls.Add(this.PriceInput4, 2, 4);
            this.IDinputOne.Controls.Add(this.QTYinput4, 1, 4);
            this.IDinputOne.Controls.Add(this.IDinput4, 0, 4);
            this.IDinputOne.Controls.Add(this.PriceInput3, 2, 3);
            this.IDinputOne.Controls.Add(this.QTYinput3, 1, 3);
            this.IDinputOne.Controls.Add(this.IDinput3, 0, 3);
            this.IDinputOne.Controls.Add(this.PriceInput2, 2, 2);
            this.IDinputOne.Controls.Add(this.QTYinput2, 1, 2);
            this.IDinputOne.Controls.Add(this.IDinput2, 0, 2);
            this.IDinputOne.Controls.Add(this.PriceInput1, 2, 1);
            this.IDinputOne.Controls.Add(this.PriceLabel, 2, 0);
            this.IDinputOne.Controls.Add(this.QtyLabel, 1, 0);
            this.IDinputOne.Controls.Add(this.ProdIDLabel, 0, 0);
            this.IDinputOne.Controls.Add(this.ProdIDinput1, 0, 1);
            this.IDinputOne.Controls.Add(this.QTYinput1, 1, 1);
            this.IDinputOne.Location = new System.Drawing.Point(43, 225);
            this.IDinputOne.Name = "IDinputOne";
            this.IDinputOne.RowCount = 6;
            this.IDinputOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.IDinputOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.IDinputOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.IDinputOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.IDinputOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.IDinputOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.IDinputOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.IDinputOne.Size = new System.Drawing.Size(697, 141);
            this.IDinputOne.TabIndex = 12;
            // 
            // PriceInput5
            // 
            this.PriceInput5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceInput5.Location = new System.Drawing.Point(468, 119);
            this.PriceInput5.Name = "PriceInput5";
            this.PriceInput5.Size = new System.Drawing.Size(225, 20);
            this.PriceInput5.TabIndex = 17;
            this.PriceInput5.TextChanged += new System.EventHandler(this.PriceInput5_TextChanged);
            // 
            // QTYinput5
            // 
            this.QTYinput5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QTYinput5.Location = new System.Drawing.Point(236, 119);
            this.QTYinput5.Name = "QTYinput5";
            this.QTYinput5.Size = new System.Drawing.Size(225, 20);
            this.QTYinput5.TabIndex = 16;
            // 
            // IDinput5
            // 
            this.IDinput5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDinput5.Location = new System.Drawing.Point(4, 119);
            this.IDinput5.Name = "IDinput5";
            this.IDinput5.Size = new System.Drawing.Size(225, 20);
            this.IDinput5.TabIndex = 15;
            // 
            // PriceInput4
            // 
            this.PriceInput4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceInput4.Location = new System.Drawing.Point(468, 96);
            this.PriceInput4.Name = "PriceInput4";
            this.PriceInput4.Size = new System.Drawing.Size(225, 20);
            this.PriceInput4.TabIndex = 14;
            this.PriceInput4.TextChanged += new System.EventHandler(this.PriceInput4_TextChanged);
            // 
            // QTYinput4
            // 
            this.QTYinput4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QTYinput4.Location = new System.Drawing.Point(236, 96);
            this.QTYinput4.Name = "QTYinput4";
            this.QTYinput4.Size = new System.Drawing.Size(225, 20);
            this.QTYinput4.TabIndex = 13;
            // 
            // IDinput4
            // 
            this.IDinput4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDinput4.Location = new System.Drawing.Point(4, 96);
            this.IDinput4.Name = "IDinput4";
            this.IDinput4.Size = new System.Drawing.Size(225, 20);
            this.IDinput4.TabIndex = 12;
            // 
            // PriceInput3
            // 
            this.PriceInput3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceInput3.Location = new System.Drawing.Point(468, 73);
            this.PriceInput3.Name = "PriceInput3";
            this.PriceInput3.Size = new System.Drawing.Size(225, 20);
            this.PriceInput3.TabIndex = 11;
            this.PriceInput3.TextChanged += new System.EventHandler(this.PriceInput3_TextChanged);
            // 
            // QTYinput3
            // 
            this.QTYinput3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QTYinput3.Location = new System.Drawing.Point(236, 73);
            this.QTYinput3.Name = "QTYinput3";
            this.QTYinput3.Size = new System.Drawing.Size(225, 20);
            this.QTYinput3.TabIndex = 10;
            // 
            // IDinput3
            // 
            this.IDinput3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDinput3.Location = new System.Drawing.Point(4, 73);
            this.IDinput3.Name = "IDinput3";
            this.IDinput3.Size = new System.Drawing.Size(225, 20);
            this.IDinput3.TabIndex = 9;
            // 
            // PriceInput2
            // 
            this.PriceInput2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceInput2.Location = new System.Drawing.Point(468, 50);
            this.PriceInput2.Name = "PriceInput2";
            this.PriceInput2.Size = new System.Drawing.Size(225, 20);
            this.PriceInput2.TabIndex = 8;
            this.PriceInput2.TextChanged += new System.EventHandler(this.PriceInput2_TextChanged);
            // 
            // QTYinput2
            // 
            this.QTYinput2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QTYinput2.Location = new System.Drawing.Point(236, 50);
            this.QTYinput2.Name = "QTYinput2";
            this.QTYinput2.Size = new System.Drawing.Size(225, 20);
            this.QTYinput2.TabIndex = 7;
            // 
            // IDinput2
            // 
            this.IDinput2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDinput2.Location = new System.Drawing.Point(4, 50);
            this.IDinput2.Name = "IDinput2";
            this.IDinput2.Size = new System.Drawing.Size(225, 20);
            this.IDinput2.TabIndex = 6;
            // 
            // PriceInput1
            // 
            this.PriceInput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceInput1.Location = new System.Drawing.Point(468, 27);
            this.PriceInput1.Name = "PriceInput1";
            this.PriceInput1.Size = new System.Drawing.Size(225, 20);
            this.PriceInput1.TabIndex = 5;
            this.PriceInput1.TextChanged += new System.EventHandler(this.PriceInput1_TextChanged);
            // 
            // QTYinput1
            // 
            this.QTYinput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QTYinput1.Location = new System.Drawing.Point(236, 27);
            this.QTYinput1.Name = "QTYinput1";
            this.QTYinput1.Size = new System.Drawing.Size(225, 20);
            this.QTYinput1.TabIndex = 4;
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TotalLabel.Location = new System.Drawing.Point(511, 394);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(37, 15);
            this.TotalLabel.TabIndex = 14;
            this.TotalLabel.Text = "Total:";
            // 
            // TotalOutput
            // 
            this.TotalOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalOutput.AutoSize = true;
            this.TotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TotalOutput.Location = new System.Drawing.Point(669, 394);
            this.TotalOutput.Name = "TotalOutput";
            this.TotalOutput.Size = new System.Drawing.Size(55, 15);
            this.TotalOutput.TabIndex = 15;
            this.TotalOutput.Text = "$ ___.__";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SaveButton.Location = new System.Drawing.Point(584, 437);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(144, 23);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save and Proceed";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // InvNumInput
            // 
            this.InvNumInput.BackColor = System.Drawing.SystemColors.Window;
            this.InvNumInput.Location = new System.Drawing.Point(146, 92);
            this.InvNumInput.Mask = "00000";
            this.InvNumInput.Name = "InvNumInput";
            this.InvNumInput.Size = new System.Drawing.Size(35, 20);
            this.InvNumInput.TabIndex = 17;
            this.InvNumInput.ValidatingType = typeof(int);
            // 
            // EmpIDInput
            // 
            this.EmpIDInput.Location = new System.Drawing.Point(146, 147);
            this.EmpIDInput.Mask = "00000";
            this.EmpIDInput.Name = "EmpIDInput";
            this.EmpIDInput.Size = new System.Drawing.Size(35, 20);
            this.EmpIDInput.TabIndex = 18;
            this.EmpIDInput.ValidatingType = typeof(int);
            // 
            // AddTransaction
            // 
            this.AcceptButton = this.SaveButton;
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(769, 491);
            this.Controls.Add(this.EmpIDInput);
            this.Controls.Add(this.InvNumInput);
            this.Controls.Add(this.SaleDate);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.InvoiceNumLabel);
            this.Controls.Add(this.TotalOutput);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.IDinputOne);
            this.Controls.Add(this.ContentTitle2);
            this.Controls.Add(this.ContentTitle3);
            this.Controls.Add(this.NameEntry);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ContentTitle1);
            this.Controls.Add(this.CompanyName);
            this.MaximumSize = new System.Drawing.Size(785, 530);
            this.MinimumSize = new System.Drawing.Size(785, 530);
            this.Name = "AddTransaction";
            this.Text = "Add Transaction";
            this.IDinputOne.ResumeLayout(false);
            this.IDinputOne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Label ContentTitle1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.DateTimePicker SaleDate;
        private System.Windows.Forms.Label InvoiceNumLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.TextBox NameEntry;
        private System.Windows.Forms.Label ContentTitle3;
        private System.Windows.Forms.Label ContentTitle2;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox ProdIDinput1;
        private System.Windows.Forms.Label ProdIDLabel;
        private System.Windows.Forms.Label QtyLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TableLayoutPanel IDinputOne;
        private System.Windows.Forms.TextBox PriceInput5;
        private System.Windows.Forms.TextBox QTYinput5;
        private System.Windows.Forms.TextBox IDinput5;
        private System.Windows.Forms.TextBox PriceInput4;
        private System.Windows.Forms.TextBox QTYinput4;
        private System.Windows.Forms.TextBox IDinput4;
        private System.Windows.Forms.TextBox PriceInput3;
        private System.Windows.Forms.TextBox QTYinput3;
        private System.Windows.Forms.TextBox IDinput3;
        private System.Windows.Forms.TextBox PriceInput2;
        private System.Windows.Forms.TextBox QTYinput2;
        private System.Windows.Forms.TextBox IDinput2;
        private System.Windows.Forms.TextBox PriceInput1;
        private System.Windows.Forms.TextBox QTYinput1;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalOutput;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MaskedTextBox InvNumInput;
        private System.Windows.Forms.MaskedTextBox EmpIDInput;
    }
}