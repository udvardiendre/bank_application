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
    public partial class trasferForm : Form
    {
        public trasferForm()
        {
            InitializeComponent();
            loadDate();
        }

        private void loadDate()
        {
            dateLbl.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            banking_dbEntities context = new banking_dbEntities();
            decimal b = Convert.ToDecimal(accNoTb.Text);
            var item = (from u in context.userAccounts where u.Account_No == b select u).FirstOrDefault();
            if (item != null)
            {
                nameTb.Text = item.Name;
                oldBalTb.Text = Convert.ToString(item.Balance);
            }
            else
            {
                MessageBox.Show("Nem létező számlaszám!");
            }
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            banking_dbEntities context = new banking_dbEntities();
            decimal b = Convert.ToDecimal(accNoTb.Text);
            var item = (from u in context.userAccounts where u.Account_No == b select u).FirstOrDefault();
            decimal b1 = Convert.ToDecimal(item.Balance);
            decimal totalbalance = Convert.ToDecimal(balanceTb.Text);
            decimal transferacc = Convert.ToDecimal(destAccNoTb.Text);
            if (b1 > totalbalance) {
                userAccount item2 = (from u in context.userAccounts where u.Account_No == transferacc select u).FirstOrDefault();

                item2.Balance = item2.Balance + totalbalance;
                item.Balance = item.Balance - totalbalance;
                transfer trans = new transfer();
                trans.Account_No = Convert.ToDecimal(accNoTb.Text);
                trans.To_Transfer = Convert.ToDecimal(destAccNoTb.Text);
                trans.Date = DateTime.Now.ToString("yyyy/MM/dd");
                trans.Name = nameTb.Text;
                trans.Balance = Convert.ToDecimal(balanceTb.Text);

                context.transfers.Add(trans);
                context.SaveChanges();
                MessageBox.Show("Sikeres tranzakció!");

            }
        }
    }
}
