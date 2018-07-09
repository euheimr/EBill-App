namespace EBill_App
{
    partial class frmMain
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
            this.lblCustFirstName = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblCustLastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustFirstName
            // 
            this.lblCustFirstName.AutoSize = true;
            this.lblCustFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustFirstName.Location = new System.Drawing.Point(12, 73);
            this.lblCustFirstName.Name = "lblCustFirstName";
            this.lblCustFirstName.Size = new System.Drawing.Size(140, 16);
            this.lblCustFirstName.TabIndex = 0;
            this.lblCustFirstName.Text = "Customer First Name: ";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(384, 538);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(190, 38);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "GENERATE INVOICE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblCustLastName
            // 
            this.lblCustLastName.AutoSize = true;
            this.lblCustLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustLastName.Location = new System.Drawing.Point(12, 103);
            this.lblCustLastName.Name = "lblCustLastName";
            this.lblCustLastName.Size = new System.Drawing.Size(139, 16);
            this.lblCustLastName.TabIndex = 2;
            this.lblCustLastName.Text = "Customer Last Name: ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 588);
            this.Controls.Add(this.lblCustLastName);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblCustFirstName);
            this.Name = "frmMain";
            this.Text = "invoicR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustFirstName;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblCustLastName;
    }
}

