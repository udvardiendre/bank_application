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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        
        private void újFiókToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newAccount nAccount = new newAccount();
            nAccount.MdiParent = this;
            nAccount.Show();
        }

        private void fiókKeresésefrissítéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateAccount uAccount = new updateAccount();
            uAccount.MdiParent = this;
            uAccount.Show();
        }

        private void felhasználókToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allUsers aUsers = new allUsers();
            aUsers.MdiParent = this;
            aUsers.Show();
        }

        private void befizetésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            depositForm dForm = new depositForm();
            dForm.MdiParent = this;
            dForm.Show();
        }

        private void kifizetésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            withdrawForm wForm = new withdrawForm();
            wForm.MdiParent = this;
            wForm.Show();
        }

        private void átutalásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trasferForm tForm = new trasferForm();
            tForm.MdiParent = this;
            tForm.Show();
        }

        private void betétLekötésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fixedDepositForm fDForm = new fixedDepositForm();
            fDForm.MdiParent = this;
            fDForm.Show();
        }

        private void egyenlegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balanceForm bForm = new balanceForm();
            bForm.MdiParent = this;
            bForm.Show();
        }

        private void lekötöttBetétToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myFixedDeposit mFDForm = new myFixedDeposit();
            mFDForm.MdiParent = this;
            mFDForm.Show();
        }

        private void kijelentkezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jelszóMódosításaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePassword cPForm = new changePassword();
            cPForm.MdiParent = this;
            cPForm.Show();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
