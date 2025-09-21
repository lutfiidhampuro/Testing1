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
    public partial class FormRegist : Form
    {
        private DataIdhamDataContext db = new DataIdhamDataContext();
        public FormRegist()
        {
            InitializeComponent();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            var user = new user();
            user.id = Convert.ToInt32(tbId.Text);
            user.email = tbEmail.Text;
            user.password = tbPassword.Text;

            db.users.InsertOnSubmit(user);
            db.SubmitChanges();
            new Form_Login().Show();
            this.Hide();
        }
        private void getId()
        {
            int lastId = db.users.OrderByDescending(x => x.id).FirstOrDefault().id+1;
            tbId.Text = lastId.ToString();
        }

        private void FormRegist_Load(object sender, EventArgs e)
        {
            getId();
        }
    }
}
