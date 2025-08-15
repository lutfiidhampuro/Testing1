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
    public partial class FormPersegi : Form
    {
        public FormPersegi()
        {
            InitializeComponent();
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void FormPersegi_Load(object sender, EventArgs e)
        {

        }

        private void tbSide_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            var side = Convert.ToInt32 (tbSide .Text);
            tbResult.Text = (side * side). ToString();
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbSide.Text = "";
            tbResult.Text = "";
        }
    }
}
