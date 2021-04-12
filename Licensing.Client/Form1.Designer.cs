
namespace Licensing.Client
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
            this.lblHardwareId = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.tbxLicense = new System.Windows.Forms.TextBox();
            this.trvHardware = new System.Windows.Forms.TreeView();
            this.lblHardwareOutput = new System.Windows.Forms.Label();
            this.lblLicenseOutput = new System.Windows.Forms.Label();
            this.btnVerifyLicense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHardwareId
            // 
            this.lblHardwareId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardwareId.Location = new System.Drawing.Point(12, 9);
            this.lblHardwareId.Name = "lblHardwareId";
            this.lblHardwareId.Size = new System.Drawing.Size(190, 23);
            this.lblHardwareId.TabIndex = 0;
            this.lblHardwareId.Text = "Hardware Id";
            this.lblHardwareId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLicense
            // 
            this.lblLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.Location = new System.Drawing.Point(221, 9);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(190, 23);
            this.lblLicense.TabIndex = 1;
            this.lblLicense.Text = "License";
            this.lblLicense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxLicense
            // 
            this.tbxLicense.Location = new System.Drawing.Point(221, 35);
            this.tbxLicense.Multiline = true;
            this.tbxLicense.Name = "tbxLicense";
            this.tbxLicense.Size = new System.Drawing.Size(190, 136);
            this.tbxLicense.TabIndex = 2;
            // 
            // trvHardware
            // 
            this.trvHardware.Location = new System.Drawing.Point(12, 35);
            this.trvHardware.Name = "trvHardware";
            this.trvHardware.Size = new System.Drawing.Size(190, 165);
            this.trvHardware.TabIndex = 3;
            // 
            // lblHardwareOutput
            // 
            this.lblHardwareOutput.Location = new System.Drawing.Point(12, 214);
            this.lblHardwareOutput.Name = "lblHardwareOutput";
            this.lblHardwareOutput.Size = new System.Drawing.Size(189, 227);
            this.lblHardwareOutput.TabIndex = 4;
            this.lblHardwareOutput.Text = "label1";
            // 
            // lblLicenseOutput
            // 
            this.lblLicenseOutput.Location = new System.Drawing.Point(222, 214);
            this.lblLicenseOutput.Name = "lblLicenseOutput";
            this.lblLicenseOutput.Size = new System.Drawing.Size(189, 227);
            this.lblLicenseOutput.TabIndex = 5;
            // 
            // btnVerifyLicense
            // 
            this.btnVerifyLicense.Location = new System.Drawing.Point(221, 177);
            this.btnVerifyLicense.Name = "btnVerifyLicense";
            this.btnVerifyLicense.Size = new System.Drawing.Size(190, 23);
            this.btnVerifyLicense.TabIndex = 6;
            this.btnVerifyLicense.Text = "VerifyLicense";
            this.btnVerifyLicense.UseVisualStyleBackColor = true;
            this.btnVerifyLicense.Click += new System.EventHandler(this.btnVerifyLicense_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.btnVerifyLicense);
            this.Controls.Add(this.lblLicenseOutput);
            this.Controls.Add(this.lblHardwareOutput);
            this.Controls.Add(this.trvHardware);
            this.Controls.Add(this.tbxLicense);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblHardwareId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHardwareId;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.TextBox tbxLicense;
        private System.Windows.Forms.TreeView trvHardware;
        private System.Windows.Forms.Label lblHardwareOutput;
        private System.Windows.Forms.Label lblLicenseOutput;
        private System.Windows.Forms.Button btnVerifyLicense;
    }
}

