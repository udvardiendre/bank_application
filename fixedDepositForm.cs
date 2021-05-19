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
    public partial class fixedDepositForm : Form
    {
        public fixedDepositForm()
        {
            InitializeComponent();
            loadDate();
        }

        private void loadDate()
        {
            dateLbl.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fixBtn_Click(object sender, EventArgs e)
        {
            banking_dbEntities context = new banking_dbEntities();
            decimal accno = Convert.ToDecimal(accNoTb.Text);
            var accounts = context.userAccounts.Where(x => x.Account_No == accno).SingleOrDefault();
            FD fdform = new FD();
            fdform.Account_No = Convert.ToDecimal(accNoTb.Text);
            fdform.Message = messageTb.Text;
            fdform.Amount = balanceTb.Text;
            fdform.Period = Convert.ToInt32(periodTb.Text);
            fdform.Interest_Rate = Convert.ToDecimal(interestTb.Text);
            fdform.Start_Date = DateTime.Now.ToString("yyyy/MM/dd");
            fdform.Maturity_Date = (DateTime.Now.AddDays(Convert.ToInt32(periodTb.Text))).ToString("yyyy/MM/dd");
            fdform.Maturity_Amount = ((Convert.ToDecimal(balanceTb.Text) * Convert.ToInt32(periodTb.Text) * Convert.ToDecimal(interestTb.Text))/(100*12*30)) + (Convert.ToDecimal(balanceTb.Text));
            context.FDs.Add(fdform);
            decimal amount = Convert.ToDecimal(balanceTb.Text);
            decimal totalamount = Convert.ToDecimal(accounts.Balance);
            decimal fixedamount = totalamount - amount;
                
            accounts.Balance = fixedamount;
            context.SaveChanges();
                         
            MessageBox.Show("Sikeres lekötés!");
            // Hibákat lekell kezelni csak 180 napos lehet lekötni eddig
        }  
    }
}
