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
    public partial class changePassword : Form
    {
        public changePassword()
        {
            InitializeComponent();
            loadDate();
        }

        private void loadDate()
        {
            dateLbl.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            banking_dbEntities dbe = new banking_dbEntities();
            if (oldPassTb.Text != string.Empty || newPassTb.Text != string.Empty || newPassReTb.Text != string.Empty) {
                Admin_Table user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(userNameTb.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(oldPassTb.Text))
                    {
                        user1.Password = newPassTb.Text;
                        dbe.SaveChanges();
                        MessageBox.Show("A jelszóváltoztatás megtörtént!");
                    }
                    else
                    {
                        MessageBox.Show("Helytelen jelszó!");
                    }

                }
            }
        }
    }
}
