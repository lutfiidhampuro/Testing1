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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPersegiPanjang_Click(object sender, EventArgs e)
        {
            new Form_Persegi_Panjang().Show();
            this.Hide();
        }

        private void btnSegitiga_Click(object sender, EventArgs e)
        {
            new FormSegitiga().Show();
            this.Hide();
        }

        private void btnPersegi_Click(object sender, EventArgs e)
        {
            new FormPersegi().Show();
            this.Hide();
        }
    }
}
