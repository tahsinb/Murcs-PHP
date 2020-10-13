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
            this.DateLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.EmpNameInput = new System.Windows.Forms.TextBox();
            this.CustomerNameInput = new System.Windows.Forms.TextBox();
            this.EmpIDLabel = new System.Windows.Forms.Label();
            this.CustNameLabel = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.Label();
            this.SaleIDLabel = new System.Windows.Forms.Label();
            this.DescLabel = new System.Windows.Forms.Label();
            this.SaleIDInput = new System.Windows.Forms.MaskedTextBox();
            this.EmployeeSectionLabel = new System.Windows.Forms.Label();
            this.TransactionSectionLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PriceInput5 = new System.Windows.Forms.TextBox();
            this.QtyInput5 = new System.Windows.Forms.TextBox();
            this.ProdNameInput5 = new System.Windows.Forms.TextBox();
            this.prodIDinput5 = new System.Windows.Forms.TextBox();
            this.PriceInput4 = new System.Windows.Forms.TextBox();
            this.QtyInput4 = new System.Windows.Forms.TextBox();
            this.ProdNameInput4 = new System.Windows.Forms.TextBox();
            this.prodIDinput4 = new System.Windows.Forms.TextBox();
            this.PriceInput3 = new System.Windows.Forms.TextBox();
            this.QtyInput3 = new System.Windows.Forms.TextBox();
            this.ProdNameInput3 = new System.Windows.Forms.TextBox();
            this.prodIDinput3 = new System.Windows.Forms.TextBox();
            this.PriceInput2 = new System.Windows.Forms.TextBox();
            this.QtyInput2 = new System.Windows.Forms.TextBox();
            this.ProdNameInput2 = new System.Windows.Forms.TextBox();
            this.prodIDinput2 = new System.Windows.Forms.TextBox();
            this.PriceInput1 = new System.Windows.Forms.TextBox();
            this.QtyInput1 = new System.Windows.Forms.TextBox();
            this.ProdNameInput1 = new System.Windows.Forms.TextBox();
            this.prodIDinput1 = new System.Windows.Forms.TextBox();
            this.ProdIDLabel = new System.Windows.Forms.Label();
            this.QtyLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ProdNameLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalOutput = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EmpIDInput = new System.Windows.Forms.MaskedTextBox();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Location = new System.Drawing.Point(489, 99);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Date:";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpNameLabel.Location = new System.Drawing.Point(435, 164);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(87, 13);
            this.EmpNameLabel.TabIndex = 2;
            this.EmpNameLabel.Text = "Employee Name:";
            // 
            // EmpNameInput
            // 
            this.EmpNameInput.Location = new System.Drawing.Point(544, 157);
            this.EmpNameInput.Name = "EmpNameInput";
            this.EmpNameInput.Size = new System.Drawing.Size(265, 20);
            this.EmpNameInput.TabIndex = 3;
            this.EmpNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpNameInput_KeyPress);
            this.EmpNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.EmpNameInput_Validating);
            // 
            // CustomerNameInput
            // 
            this.CustomerNameInput.Location = new System.Drawing.Point(544, 219);
            this.CustomerNameInput.Name = "CustomerNameInput";
            this.CustomerNameInput.Size = new System.Drawing.Size(265, 20);
            this.CustomerNameInput.TabIndex = 4;
            this.CustomerNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerNameInput_KeyPress);
            this.CustomerNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.CustomerNameInput_Validating);
            // 
            // EmpIDLabel
            // 
            this.EmpIDLabel.AutoSize = true;
            this.EmpIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpIDLabel.Location = new System.Drawing.Point(48, 157);
            this.EmpIDLabel.Name = "EmpIDLabel";
            this.EmpIDLabel.Size = new System.Drawing.Size(70, 13);
            this.EmpIDLabel.TabIndex = 6;
            this.EmpIDLabel.Text = "Employee ID:";
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.AutoSize = true;
            this.CustNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CustNameLabel.Location = new System.Drawing.Point(437, 226);
            this.CustNameLabel.Name = "CustNameLabel";
            this.CustNameLabel.Size = new System.Drawing.Size(85, 13);
            this.CustNameLabel.TabIndex = 7;
            this.CustNameLabel.Text = "Customer Name:";
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.BackColor = System.Drawing.Color.Transparent;
            this.CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CompanyName.Location = new System.Drawing.Point(269, 9);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(227, 25);
            this.CompanyName.TabIndex = 8;
            this.CompanyName.Text = "People Health Pharmacy";
            // 
            // SaleIDLabel
            // 
            this.SaleIDLabel.AutoSize = true;
            this.SaleIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaleIDLabel.Location = new System.Drawing.Point(73, 92);
            this.SaleIDLabel.Name = "SaleIDLabel";
            this.SaleIDLabel.Size = new System.Drawing.Size(45, 13);
            this.SaleIDLabel.TabIndex = 9;
            this.SaleIDLabel.Text = "Sale ID:";
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.BackColor = System.Drawing.Color.Transparent;
            this.DescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DescLabel.Location = new System.Drawing.Point(27, 64);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(325, 18);
            this.DescLabel.TabIndex = 12;
            this.DescLabel.Text = "Please fill out all the details below to record sale.";
            // 
            // SaleIDInput
            // 
            this.SaleIDInput.Location = new System.Drawing.Point(134, 92);
            this.SaleIDInput.Mask = "00000";
            this.SaleIDInput.Name = "SaleIDInput";
            this.SaleIDInput.Size = new System.Drawing.Size(38, 20);
            this.SaleIDInput.TabIndex = 0;
            this.SaleIDInput.ValidatingType = typeof(int);
            // 
            // EmployeeSectionLabel
            // 
            this.EmployeeSectionLabel.AutoSize = true;
            this.EmployeeSectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeSectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.EmployeeSectionLabel.Location = new System.Drawing.Point(27, 126);
            this.EmployeeSectionLabel.Name = "EmployeeSectionLabel";
            this.EmployeeSectionLabel.Size = new System.Drawing.Size(123, 18);
            this.EmployeeSectionLabel.TabIndex = 14;
            this.EmployeeSectionLabel.Text = "Employee Details";
            // 
            // TransactionSectionLabel
            // 
            this.TransactionSectionLabel.AutoSize = true;
            this.TransactionSectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.TransactionSectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TransactionSectionLabel.Location = new System.Drawing.Point(27, 194);
            this.TransactionSectionLabel.Name = "TransactionSectionLabel";
            this.TransactionSectionLabel.Size = new System.Drawing.Size(135, 18);
            this.TransactionSectionLabel.TabIndex = 15;
            this.TransactionSectionLabel.Text = "Transaction Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.PriceInput5, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.QtyInput5, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ProdNameInput5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.prodIDinput5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.PriceInput4, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.QtyInput4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ProdNameInput4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.prodIDinput4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PriceInput3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.QtyInput3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ProdNameInput3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.prodIDinput3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PriceInput2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.QtyInput2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProdNameInput2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.prodIDinput2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PriceInput1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.QtyInput1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProdNameInput1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.prodIDinput1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 280);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 170);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // PriceInput5
            // 
            this.PriceInput5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceInput5.Location = new System.Drawing.Point(627, 139);
            this.PriceInput5.Name = "PriceInput5";
            this.PriceInput5.Size = new System.Drawing.Size(152, 20);
            this.PriceInput5.TabIndex = 24;
            this.PriceInput5.TextChanged += new System.EventHandler(this.PriceInput5_TextChanged);
            // 
            // QtyInput5
            // 
            this.QtyInput5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QtyInput5.Location = new System.Drawing.Point(471, 139);
            this.QtyInput5.Name = "QtyInput5";
            this.QtyInput5.Size = new System.Drawing.Size(150, 20);
            this.QtyInput5.TabIndex = 23;
            // 
            // ProdNameInput5
            // 
            this.ProdNameInput5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdNameInput5.Location = new System.Drawing.Point(120, 139);
            this.ProdNameInput5.Name = "ProdNameInput5";
            this.ProdNameInput5.Size = new System.Drawing.Size(345, 20);
            this.ProdNameInput5.TabIndex = 22;
            // 
            // prodIDinput5
            // 
            this.prodIDinput5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodIDinput5.Location = new System.Drawing.Point(3, 139);
            this.prodIDinput5.Name = "prodIDinput5";
            this.prodIDinput5.Size = new System.Drawing.Size(111, 20);
            this.prodIDinput5.TabIndex = 21;
            // 
            // PriceInput4
            // 
            this.PriceInput4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceInput4.Location = new System.Drawing.Point(627, 105);
            this.PriceInput4.Name = "PriceInput4";
            this.PriceInput4.Size = new System.Drawing.Size(152, 20);
            this.PriceInput4.TabIndex = 20;
            this.PriceInput4.TextChanged += new System.EventHandler(this.PriceInput4_TextChanged);
            // 
            // QtyInput4
            // 
            this.QtyInput4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QtyInput4.Location = new System.Drawing.Point(471, 105);
            this.QtyInput4.Name = "QtyInput4";
            this.QtyInput4.Size = new System.Drawing.Size(150, 20);
            this.QtyInput4.TabIndex = 19;
            // 
            // ProdNameInput4
            // 
            this.ProdNameInput4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdNameInput4.Location = new System.Drawing.Point(120, 105);
            this.ProdNameInput4.Name = "ProdNameInput4";
            this.ProdNameInput4.Size = new System.Drawing.Size(345, 20);
            this.ProdNameInput4.TabIndex = 18;
            // 
            // prodIDinput4
            // 
            this.prodIDinput4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodIDinput4.Location = new System.Drawing.Point(3, 105);
            this.prodIDinput4.Name = "prodIDinput4";
            this.prodIDinput4.Size = new System.Drawing.Size(111, 20);
            this.prodIDinput4.TabIndex = 17;
            // 
            // PriceInput3
            // 
            this.PriceInput3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceInput3.Location = new System.Drawing.Point(627, 71);
            this.PriceInput3.Name = "PriceInput3";
            this.PriceInput3.Size = new System.Drawing.Size(152, 20);
            this.PriceInput3.TabIndex = 16;
            this.PriceInput3.TextChanged += new System.EventHandler(this.PriceInput3_TextChanged);
            // 
            // QtyInput3
            // 
            this.QtyInput3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QtyInput3.Location = new System.Drawing.Point(471, 71);
            this.QtyInput3.Name = "QtyInput3";
            this.QtyInput3.Size = new System.Drawing.Size(150, 20);
            this.QtyInput3.TabIndex = 15;
            // 
            // ProdNameInput3
            // 
            this.ProdNameInput3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdNameInput3.Location = new System.Drawing.Point(120, 71);
            this.ProdNameInput3.Name = "ProdNameInput3";
            this.ProdNameInput3.Size = new System.Drawing.Size(345, 20);
            this.ProdNameInput3.TabIndex = 14;
            // 
            // prodIDinput3
            // 
            this.prodIDinput3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodIDinput3.Location = new System.Drawing.Point(3, 71);
            this.prodIDinput3.Name = "prodIDinput3";
            this.prodIDinput3.Size = new System.Drawing.Size(111, 20);
            this.prodIDinput3.TabIndex = 13;
            // 
            // PriceInput2
            // 
            this.PriceInput2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceInput2.Location = new System.Drawing.Point(627, 37);
            this.PriceInput2.Name = "PriceInput2";
            this.PriceInput2.Size = new System.Drawing.Size(152, 20);
            this.PriceInput2.TabIndex = 12;
            this.PriceInput2.TextChanged += new System.EventHandler(this.PriceInput2_TextChanged);
            // 
            // QtyInput2
            // 
            this.QtyInput2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QtyInput2.Location = new System.Drawing.Point(471, 37);
            this.QtyInput2.Name = "QtyInput2";
            this.QtyInput2.Size = new System.Drawing.Size(150, 20);
            this.QtyInput2.TabIndex = 11;
            // 
            // ProdNameInput2
            // 
            this.ProdNameInput2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdNameInput2.Location = new System.Drawing.Point(120, 37);
            this.ProdNameInput2.Name = "ProdNameInput2";
            this.ProdNameInput2.Size = new System.Drawing.Size(345, 20);
            this.ProdNameInput2.TabIndex = 10;
            // 
            // prodIDinput2
            // 
            this.prodIDinput2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodIDinput2.Location = new System.Drawing.Point(3, 37);
            this.prodIDinput2.Name = "prodIDinput2";
            this.prodIDinput2.Size = new System.Drawing.Size(111, 20);
            this.prodIDinput2.TabIndex = 9;
            // 
            // PriceInput1
            // 
            this.PriceInput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceInput1.Location = new System.Drawing.Point(627, 3);
            this.PriceInput1.Name = "PriceInput1";
            this.PriceInput1.Size = new System.Drawing.Size(152, 20);
            this.PriceInput1.TabIndex = 8;
            this.PriceInput1.TextChanged += new System.EventHandler(this.PriceInput1_TextChanged);
            // 
            // QtyInput1
            // 
            this.QtyInput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QtyInput1.Location = new System.Drawing.Point(471, 3);
            this.QtyInput1.Name = "QtyInput1";
            this.QtyInput1.Size = new System.Drawing.Size(150, 20);
            this.QtyInput1.TabIndex = 7;
            // 
            // ProdNameInput1
            // 
            this.ProdNameInput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdNameInput1.Location = new System.Drawing.Point(120, 3);
            this.ProdNameInput1.Name = "ProdNameInput1";
            this.ProdNameInput1.Size = new System.Drawing.Size(345, 20);
            this.ProdNameInput1.TabIndex = 6;
            this.ProdNameInput1.TextChanged += new System.EventHandler(this.ProdNameInput1_TextChanged);
            // 
            // prodIDinput1
            // 
            this.prodIDinput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodIDinput1.Location = new System.Drawing.Point(3, 3);
            this.prodIDinput1.Name = "prodIDinput1";
            this.prodIDinput1.Size = new System.Drawing.Size(111, 20);
            this.prodIDinput1.TabIndex = 5;
            this.prodIDinput1.TextChanged += new System.EventHandler(this.prodIDinput1_TextChanged);
            // 
            // ProdIDLabel
            // 
            this.ProdIDLabel.AutoSize = true;
            this.ProdIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProdIDLabel.Location = new System.Drawing.Point(65, 261);
            this.ProdIDLabel.Name = "ProdIDLabel";
            this.ProdIDLabel.Size = new System.Drawing.Size(58, 13);
            this.ProdIDLabel.TabIndex = 17;
            this.ProdIDLabel.Text = "Product ID";
            // 
            // QtyLabel
            // 
            this.QtyLabel.AutoSize = true;
            this.QtyLabel.BackColor = System.Drawing.Color.Transparent;
            this.QtyLabel.Location = new System.Drawing.Point(556, 261);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(46, 13);
            this.QtyLabel.TabIndex = 18;
            this.QtyLabel.Text = "Quantity";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceLabel.Location = new System.Drawing.Point(718, 261);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 19;
            this.PriceLabel.Text = "Price";
            // 
            // ProdNameLabel
            // 
            this.ProdNameLabel.AutoSize = true;
            this.ProdNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProdNameLabel.Location = new System.Drawing.Point(286, 261);
            this.ProdNameLabel.Name = "ProdNameLabel";
            this.ProdNameLabel.Size = new System.Drawing.Size(75, 13);
            this.ProdNameLabel.TabIndex = 20;
            this.ProdNameLabel.Text = "Product Name";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Location = new System.Drawing.Point(654, 462);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLabel.TabIndex = 21;
            this.TotalLabel.Text = "Total:";
            // 
            // TotalOutput
            // 
            this.TotalOutput.AutoSize = true;
            this.TotalOutput.Location = new System.Drawing.Point(760, 462);
            this.TotalOutput.Name = "TotalOutput";
            this.TotalOutput.Size = new System.Drawing.Size(49, 13);
            this.TotalOutput.TabIndex = 22;
            this.TotalOutput.Text = "$ ___.__";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(657, 487);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(147, 23);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Save and Proceed";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // EmpIDInput
            // 
            this.EmpIDInput.Location = new System.Drawing.Point(134, 153);
            this.EmpIDInput.Mask = "00000";
            this.EmpIDInput.Name = "EmpIDInput";
            this.EmpIDInput.Size = new System.Drawing.Size(38, 20);
            this.EmpIDInput.TabIndex = 2;
            this.EmpIDInput.ValidatingType = typeof(int);
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateTimeLabel.Location = new System.Drawing.Point(544, 99);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(129, 13);
            this.DateTimeLabel.TabIndex = 26;
            this.DateTimeLabel.Text = "30/09/2020 09:47:00 PM";
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Sales1;
            this.ClientSize = new System.Drawing.Size(821, 513);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.EmpIDInput);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TotalOutput);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.ProdNameLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.QtyLabel);
            this.Controls.Add(this.ProdIDLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TransactionSectionLabel);
            this.Controls.Add(this.EmployeeSectionLabel);
            this.Controls.Add(this.SaleIDInput);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.SaleIDLabel);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.CustNameLabel);
            this.Controls.Add(this.EmpIDLabel);
            this.Controls.Add(this.CustomerNameInput);
            this.Controls.Add(this.EmpNameInput);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.DateLabel);
            this.Name = "AddTransaction";
            this.Text = "AddTransaction";
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.TextBox EmpNameInput;
        private System.Windows.Forms.TextBox CustomerNameInput;
        private System.Windows.Forms.Label EmpIDLabel;
        private System.Windows.Forms.Label CustNameLabel;
        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Label SaleIDLabel;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.MaskedTextBox SaleIDInput;
        private System.Windows.Forms.Label EmployeeSectionLabel;
        private System.Windows.Forms.Label TransactionSectionLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox prodIDinput1;
        private System.Windows.Forms.Label ProdIDLabel;
        private System.Windows.Forms.Label QtyLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ProdNameLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox PriceInput5;
        private System.Windows.Forms.TextBox QtyInput5;
        private System.Windows.Forms.TextBox ProdNameInput5;
        private System.Windows.Forms.TextBox prodIDinput5;
        private System.Windows.Forms.TextBox PriceInput4;
        private System.Windows.Forms.TextBox QtyInput4;
        private System.Windows.Forms.TextBox ProdNameInput4;
        private System.Windows.Forms.TextBox prodIDinput4;
        private System.Windows.Forms.TextBox PriceInput3;
        private System.Windows.Forms.TextBox QtyInput3;
        private System.Windows.Forms.TextBox ProdNameInput3;
        private System.Windows.Forms.TextBox prodIDinput3;
        private System.Windows.Forms.TextBox PriceInput2;
        private System.Windows.Forms.TextBox QtyInput2;
        private System.Windows.Forms.TextBox ProdNameInput2;
        private System.Windows.Forms.TextBox prodIDinput2;
        private System.Windows.Forms.TextBox PriceInput1;
        private System.Windows.Forms.TextBox QtyInput1;
        private System.Windows.Forms.TextBox ProdNameInput1;
        private System.Windows.Forms.Label TotalOutput;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MaskedTextBox EmpIDInput;
        private System.Windows.Forms.Label DateTimeLabel;
    }
}