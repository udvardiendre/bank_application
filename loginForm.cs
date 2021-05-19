using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplikáció
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            banking_dbEntities dbe = new banking_dbEntities();
            if (usernameTb.Text != string.Empty || passwordTb.Text != string.Empty)
            {
                var user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(usernameTb.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(passwordTb.Text))
                    {
                        menu m1 = new menu();
                        m1.ShowDialog();
                    }
                    else {
                        MessageBox.Show("Helytelen jelszó!");
                    }
                }
                else {
                    MessageBox.Show("Hibás felhasználónév!");
                }
            }
            else {
                MessageBox.Show("Kérem azonosítsa magát!");
            }
        }
    }
}
