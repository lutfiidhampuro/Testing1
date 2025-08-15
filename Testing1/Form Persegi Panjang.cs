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
    public partial class Form_Persegi_Panjang : Form
    {
        public Form_Persegi_Panjang()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            var Panjang = Convert.ToInt32(tbLong.Text);
            var widht = Convert.ToInt32(tbWidht.Text);
            tbResult.Text = (Panjang * widht).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbLong.Text = "";
            tbWidht.Text = "";
            tbResult.Text = "";
        }
    }
}
