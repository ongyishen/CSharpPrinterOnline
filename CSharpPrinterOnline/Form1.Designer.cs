namespace CSharpPrinterOnline
{
    partial class Form1
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
            this.PrinterName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblOnline = new System.Windows.Forms.Label();
            this.lblOffline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrinterName
            // 
            this.PrinterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrinterName.FormattingEnabled = true;
            this.PrinterName.Location = new System.Drawing.Point(108, 14);
            this.PrinterName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrinterName.Name = "PrinterName";
            this.PrinterName.Size = new System.Drawing.Size(433, 21);
            this.PrinterName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Printer";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(108, 43);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(122, 36);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check Is Online";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblOnline
            // 
            this.lblOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOnline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOnline.Location = new System.Drawing.Point(247, 43);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(145, 36);
            this.lblOnline.TabIndex = 8;
            this.lblOnline.Text = "ONLINE";
            this.lblOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOnline.Visible = false;
            // 
            // lblOffline
            // 
            this.lblOffline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblOffline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOffline.Location = new System.Drawing.Point(398, 43);
            this.lblOffline.Name = "lblOffline";
            this.lblOffline.Size = new System.Drawing.Size(145, 36);
            this.lblOffline.TabIndex = 9;
            this.lblOffline.Text = "OFFLINE";
            this.lblOffline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOffline.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 255);
            this.Controls.Add(this.lblOffline);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.PrinterName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSharp Check Printer Is Online";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PrinterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label lblOffline;
    }
}

