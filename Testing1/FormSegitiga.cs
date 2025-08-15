using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing1
{
    public partial class FormSegitiga : Form
    {
        public FormSegitiga()
        {
            InitializeComponent();
        }

        private void btnBackSegitiga_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void FormSegitiga_Load(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            var Alas = Convert.ToInt32(tbBase.Text);
            var Tinggi = Convert.ToInt32(tbHeight.Text);
            tbResult.Text = (Alas * Tinggi / 2).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbBase.Text = "";
            tbHeight.Text = "";
            tbResult.Text = "";
        }
    }
}
