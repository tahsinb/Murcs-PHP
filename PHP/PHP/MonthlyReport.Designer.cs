namespace PHP
{
    partial class MonthlyReport
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
            this.btn_ExportCSV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentToggle = new System.Windows.Forms.CheckBox();
            this.btn_SelectFilepath = new System.Windows.Forms.Button();
            this.ReportTable = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalsTable = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_ExportCSV
            // 
            this.btn_ExportCSV.Location = new System.Drawing.Point(688, 371);
            this.btn_ExportCSV.Name = "btn_ExportCSV";
            this.btn_ExportCSV.Size = new System.Drawing.Size(100, 39);
            this.btn_ExportCSV.TabIndex = 18;
            this.btn_ExportCSV.Text = "Export CSV";
            this.btn_ExportCSV.UseVisualStyleBackColor = true;
            this.btn_ExportCSV.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Monthly Sales Report";
            // 
            // CurrentToggle
            // 
            this.CurrentToggle.AutoSize = true;
            this.CurrentToggle.BackColor = System.Drawing.Color.Transparent;
            this.CurrentToggle.Checked = global::PHP.Properties.Settings.Default.True;
            this.CurrentToggle.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PHP.Properties.Settings.Default, "True", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CurrentToggle.Location = new System.Drawing.Point(688, 348);
            this.CurrentToggle.Name = "CurrentToggle";
            this.CurrentToggle.Size = new System.Drawing.Size(92, 17);
            this.CurrentToggle.TabIndex = 26;
            this.CurrentToggle.Text = "Current month";
            this.CurrentToggle.UseVisualStyleBackColor = false;
            this.CurrentToggle.CheckedChanged += new System.EventHandler(this.CurrentToggle_CheckedChanged);
            // 
            // btn_SelectFilepath
            // 
            this.btn_SelectFilepath.Location = new System.Drawing.Point(688, 416);
            this.btn_SelectFilepath.Name = "btn_SelectFilepath";
            this.btn_SelectFilepath.Size = new System.Drawing.Size(100, 23);
            this.btn_SelectFilepath.TabIndex = 27;
            this.btn_SelectFilepath.Text = "Select Filepath";
            this.btn_SelectFilepath.UseVisualStyleBackColor = true;
            this.btn_SelectFilepath.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReportTable
            // 
            this.ReportTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ReportTable.GridLines = true;
            this.ReportTable.HideSelection = false;
            this.ReportTable.Location = new System.Drawing.Point(30, 105);
            this.ReportTable.Name = "ReportTable";
            this.ReportTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReportTable.Size = new System.Drawing.Size(652, 260);
            this.ReportTable.TabIndex = 31;
            this.ReportTable.UseCompatibleStateImageBehavior = false;
            this.ReportTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product";
            this.columnHeader2.Width = 401;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 56;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sale Price";
            this.columnHeader4.Width = 94;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total Price";
            this.columnHeader5.Width = 96;
            // 
            // TotalsTable
            // 
            this.TotalsTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.TotalsTable.GridLines = true;
            this.TotalsTable.HideSelection = false;
            this.TotalsTable.Location = new System.Drawing.Point(434, 372);
            this.TotalsTable.Name = "TotalsTable";
            this.TotalsTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotalsTable.Size = new System.Drawing.Size(249, 66);
            this.TotalsTable.TabIndex = 34;
            this.TotalsTable.UseCompatibleStateImageBehavior = false;
            this.TotalsTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Product Sales Total";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Month Revenue Total";
            this.columnHeader8.Width = 138;
            // 
            // MonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Sales1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalsTable);
            this.Controls.Add(this.ReportTable);
            this.Controls.Add(this.btn_SelectFilepath);
            this.Controls.Add(this.CurrentToggle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ExportCSV);
            this.Name = "MonthlyReport";
            this.Text = "MonthlyReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ExportCSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CurrentToggle;
        private System.Windows.Forms.Button btn_SelectFilepath;
        private System.Windows.Forms.ListView ReportTable;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView TotalsTable;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}