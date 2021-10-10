using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KMutil
{
    public partial class FormKmutil : Form
    {
        public FormKmutil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRequests form = new FormRequests();
            form.Show();
        }
    }
}
