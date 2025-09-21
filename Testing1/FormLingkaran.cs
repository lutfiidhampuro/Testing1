using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing1
{
    public partial class FormLingkaran : Form
    {
        public FormLingkaran()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            float r = Convert.ToSingle(tbRadius.Text);
            float luas = (float) (3.14 * r * r);
            tbResult.Text = luas.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbRadius.Text = "";
            tbResult.Text = "";
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
