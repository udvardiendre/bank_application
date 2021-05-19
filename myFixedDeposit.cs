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
    public partial class myFixedDeposit : Form
    {
        BindingList<FD> bl;
        banking_dbEntities dbe;

        public myFixedDeposit()
        {
            InitializeComponent();
            loadDate();
            
        }

        private void loadDate()
        {
            dateLbl.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            bl = new BindingList<FD>();
            dbe = new banking_dbEntities();
            string date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            MessageBox.Show("Választott dátum: " + date);
            var item = dbe.FDs.Where(a => a.Start_Date.Equals(date));
            dataGridView1.DataSource = item.ToList();

        }
    }
}
