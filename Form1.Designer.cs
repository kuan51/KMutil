
namespace KMutil
{
    partial class FormKmutil
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblRequests = new System.Windows.Forms.Label();
            this.lblCertificates = new System.Windows.Forms.Label();
            this.btnCertificates = new System.Windows.Forms.Button();
            this.lblKeys = new System.Windows.Forms.Label();
            this.btnKeys = new System.Windows.Forms.Button();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Requests";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRequests
            // 
            this.lblRequests.AutoSize = true;
            this.lblRequests.Location = new System.Drawing.Point(42, 9);
            this.lblRequests.Name = "lblRequests";
            this.lblRequests.Size = new System.Drawing.Size(100, 15);
            this.lblRequests.TabIndex = 1;
            this.lblRequests.Text = "Manage Requests";
            // 
            // lblCertificates
            // 
            this.lblCertificates.AutoSize = true;
            this.lblCertificates.Location = new System.Drawing.Point(42, 53);
            this.lblCertificates.Name = "lblCertificates";
            this.lblCertificates.Size = new System.Drawing.Size(112, 15);
            this.lblCertificates.TabIndex = 3;
            this.lblCertificates.Text = "Manage Certificates";
            // 
            // btnCertificates
            // 
            this.btnCertificates.Location = new System.Drawing.Point(42, 71);
            this.btnCertificates.Name = "btnCertificates";
            this.btnCertificates.Size = new System.Drawing.Size(75, 23);
            this.btnCertificates.TabIndex = 2;
            this.btnCertificates.Text = "Certificates";
            this.btnCertificates.UseVisualStyleBackColor = true;
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Location = new System.Drawing.Point(42, 97);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(116, 15);
            this.lblKeys.TabIndex = 5;
            this.lblKeys.Text = "Manage Private Keys";
            // 
            // btnKeys
            // 
            this.btnKeys.Location = new System.Drawing.Point(42, 115);
            this.btnKeys.Name = "btnKeys";
            this.btnKeys.Size = new System.Drawing.Size(75, 23);
            this.btnKeys.TabIndex = 4;
            this.btnKeys.Text = "Private Keys";
            this.btnKeys.UseVisualStyleBackColor = true;
            // 
            // btnTutorial
            // 
            this.btnTutorial.Location = new System.Drawing.Point(124, 156);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(75, 23);
            this.btnTutorial.TabIndex = 6;
            this.btnTutorial.Text = "Tutorial";
            this.btnTutorial.UseVisualStyleBackColor = true;
            // 
            // FormKmutil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 191);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.btnKeys);
            this.Controls.Add(this.lblCertificates);
            this.Controls.Add(this.btnCertificates);
            this.Controls.Add(this.lblRequests);
            this.Controls.Add(this.button1);
            this.Name = "FormKmutil";
            this.Text = "KMutil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRequests;
        private System.Windows.Forms.Label lblCertificates;
        private System.Windows.Forms.Button btnCertificates;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.Button btnKeys;
        private System.Windows.Forms.Button btnTutorial;
    }
}