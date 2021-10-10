
namespace KMutil
{
    partial class FormRequests
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
            this.btnNew = new System.Windows.Forms.Button();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.grpBoxPending = new System.Windows.Forms.GroupBox();
            this.listViewRequests = new System.Windows.Forms.ListView();
            this.grpBoxNew = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpBoxPending.SuspendLayout();
            this.grpBoxNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(40, 27);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(68, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(12, 9);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(133, 15);
            this.lblNew.TabIndex = 1;
            this.lblNew.Text = "Request New Certificate";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Location = new System.Drawing.Point(166, 9);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(129, 15);
            this.lblPending.TabIndex = 3;
            this.lblPending.Text = "View Pending Requests";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(193, 27);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(68, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpBoxPending
            // 
            this.grpBoxPending.AutoSize = true;
            this.grpBoxPending.Controls.Add(this.listViewRequests);
            this.grpBoxPending.Location = new System.Drawing.Point(2, 56);
            this.grpBoxPending.Name = "grpBoxPending";
            this.grpBoxPending.Size = new System.Drawing.Size(428, 504);
            this.grpBoxPending.TabIndex = 5;
            this.grpBoxPending.TabStop = false;
            this.grpBoxPending.Text = "Pending Requests";
            this.grpBoxPending.Visible = false;
            // 
            // listViewRequests
            // 
            this.listViewRequests.HideSelection = false;
            this.listViewRequests.Location = new System.Drawing.Point(10, 18);
            this.listViewRequests.Name = "listViewRequests";
            this.listViewRequests.Size = new System.Drawing.Size(407, 464);
            this.listViewRequests.TabIndex = 0;
            this.listViewRequests.UseCompatibleStateImageBehavior = false;
            // 
            // grpBoxNew
            // 
            this.grpBoxNew.AutoSize = true;
            this.grpBoxNew.Controls.Add(this.label1);
            this.grpBoxNew.Controls.Add(this.button1);
            this.grpBoxNew.Location = new System.Drawing.Point(2, 56);
            this.grpBoxNew.Name = "grpBoxNew";
            this.grpBoxNew.Size = new System.Drawing.Size(428, 504);
            this.grpBoxNew.TabIndex = 6;
            this.grpBoxNew.TabStop = false;
            this.grpBoxNew.Text = "New Request";
            this.grpBoxNew.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(436, 567);
            this.Controls.Add(this.grpBoxNew);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grpBoxPending);
            this.Name = "FormRequests";
            this.Text = "Manage Requests";
            this.grpBoxPending.ResumeLayout(false);
            this.grpBoxNew.ResumeLayout(false);
            this.grpBoxNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox grpBoxPending;
        private System.Windows.Forms.ListView listViewRequests;
        private System.Windows.Forms.GroupBox grpBoxNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}