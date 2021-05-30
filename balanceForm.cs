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
    public partial class balanceForm : Form
    {
        public balanceForm()
        {
            InitializeComponent();
            loadDate();
        }

        private void loadDate()
        {
            dateLbl.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            banking_dbEntities dbe = new banking_dbEntities();
            decimal b = Convert.ToDecimal(accNoTb.Text);

            depositDgv.AutoGenerateColumns = false;
            var item = (from u in dbe.deposit where u.Account_No == b select u);
            depositDgv.DataSource = item.ToList();

            withdrawDgv.AutoGenerateColumns = false;
            var item1 = (from u in dbe.debit where u.Account_No == b select u);
            withdrawDgv.DataSource = item1.ToList();

            transferDgv.AutoGenerateColumns = false;
            var item2 = (from u in dbe.transfer where u.Account_No == b select u);
            transferDgv.DataSource = item2.ToList();

        }
    }
}
