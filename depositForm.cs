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
    public partial class depositForm : Form
    {
        public depositForm()
        {
            InitializeComponent();
            loadDate();
        }

        private void loadDate()
        {
            dateLbl.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void depositForm_Load(object sender, EventArgs e)
        {

        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            banking_dbEntities context = new banking_dbEntities();
            decimal b = Convert.ToDecimal(accNoTb.Text);
            var item = (from u in context.userAccount where u.Account_No == b select u).FirstOrDefault();
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            banking_dbEntities context = new banking_dbEntities();
            newAccount acc = new newAccount();
            deposit dp = new deposit();
            dp.Date = dateLbl.Text;
            dp.Account_No = Convert.ToDecimal(accNoTb.Text);
            dp.Name = nameTb.Text;
            dp.Old_Balance = Convert.ToDecimal(oldBalTb.Text);
            dp.Message = messageTb.Text;
            dp.Dip_Amount = Convert.ToDecimal(balanceTb.Text);
            context.deposit.Add(dp);
            context.SaveChanges();
            decimal b = Convert.ToDecimal(accNoTb.Text);
            var item = (from u in context.userAccount where u.Account_No == b select u).FirstOrDefault();

            item.Balance = item.Balance + Convert.ToDecimal(balanceTb.Text);
            context.SaveChanges();
            MessageBox.Show("Sikeres tranzakció!");

        }
    }
}
