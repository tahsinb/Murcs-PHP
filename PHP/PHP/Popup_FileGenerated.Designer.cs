namespace PHP
{
    partial class Popup_FileGenerated
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.popupConfirmText = new System.Windows.Forms.Label();
            this.FileLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(120, 66);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // popupConfirmText
            // 
            this.popupConfirmText.AutoSize = true;
            this.popupConfirmText.BackColor = System.Drawing.Color.Transparent;
            this.popupConfirmText.Location = new System.Drawing.Point(112, 12);
            this.popupConfirmText.Name = "popupConfirmText";
            this.popupConfirmText.Size = new System.Drawing.Size(100, 13);
            this.popupConfirmText.TabIndex = 25;
            this.popupConfirmText.Text = "CSV File Generated";
            // 
            // FileLocation
            // 
            this.FileLocation.AutoSize = true;
            this.FileLocation.BackColor = System.Drawing.Color.Transparent;
            this.FileLocation.Location = new System.Drawing.Point(47, 38);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.Size = new System.Drawing.Size(66, 13);
            this.FileLocation.TabIndex = 26;
            this.FileLocation.Text = "File location:";
            this.FileLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Popup_FileGenerated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Sales;
            this.ClientSize = new System.Drawing.Size(324, 101);
            this.Controls.Add(this.FileLocation);
            this.Controls.Add(this.popupConfirmText);
            this.Controls.Add(this.btn_OK);
            this.Name = "Popup_FileGenerated";
            this.Text = "File Generated";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label popupConfirmText;
        private System.Windows.Forms.Label FileLocation;
    }
}