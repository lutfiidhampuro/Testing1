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
    public partial class Form_Login : Form
    {
        private DataIdhamDataContext db = new DataIdhamDataContext();
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user user = db.users.Where(x => x.email.Equals(tbEmail.Text)
            && x.password.Equals(tbPassword.Text)).FirstOrDefault();
            if (user != null) {
            Form1 form = new Form1();
                form.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Email / Password Tidak Ada");
            }
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            new FormRegist().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
