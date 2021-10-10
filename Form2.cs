using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KMutil
{
    public partial class FormRequests : Form
    {
        public FormRequests()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val = btnView.Text;
            switch (val)
            {
                case "View":
                    grpBoxPending.Visible = true;
                    break;
                case "Minimize":
                    grpBoxPending.Visible = false;
                    break;
            }
            btnView.Text = "Minimize";
            if (grpBoxPending.Visible == true)
            {
                btnView.Text = "Minimize";
            }
            else if (grpBoxPending.Visible == false)
            {
                btnView.Text = "View";
                this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string val = btnNew.Text;
            switch (val)
            {
                case "New":
                    grpBoxNew.Visible = true;
                    break;
                case "Minimize":
                    grpBoxNew.Visible = false;
                    break;
            }
            btnNew.Text = "Minimize";
            if (grpBoxNew.Visible == true)
            {
                btnNew.Text = "Minimize";
            }
            else if (grpBoxNew.Visible == false)
            {
                btnNew.Text = "New";
                this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            }
        }
    }
}
