
namespace Licensing.Licenser
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
            this.tbxHardwareId = new System.Windows.Forms.TextBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxHardwareId
            // 
            this.tbxHardwareId.Location = new System.Drawing.Point(13, 13);
            this.tbxHardwareId.Multiline = true;
            this.tbxHardwareId.Name = "tbxHardwareId";
            this.tbxHardwareId.Size = new System.Drawing.Size(210, 392);
            this.tbxHardwareId.TabIndex = 0;
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(239, 151);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(75, 88);
            this.btnSign.TabIndex = 1;
            this.btnSign.Text = "Sign Hardware ID";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(331, 13);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(211, 389);
            this.lblOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 417);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.tbxHardwareId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxHardwareId;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Label lblOutput;
    }
}

