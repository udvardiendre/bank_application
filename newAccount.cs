using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplikáció
{
    public partial class newAccount : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        banking_dbEntities BSE;
        MemoryStream ms;

        public newAccount()
        {
            InitializeComponent();
            loadDate();
            loadAccount();
            loadState();
        }

        private void loadState() 
        {
            string[] line1 = null;
            try
            {
                StreamReader sr = new StreamReader("states.txt");
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (line.Contains(","))
                    {
                        line1 = line.Split(',');
                        statecB.Items.Add(line1[0]);
                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void loadAccount()
        {
            BSE = new banking_dbEntities();
            var item = BSE.userAccounts.ToArray();
            no = item.LastOrDefault().Account_No + 1;
            accNoTb.Text = Convert.ToString(no);
        }

        private void loadDate()
        {
            
            dateLbl.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK) {
                Image img = Image.FromFile(opendlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void newAccount_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (wmnBtn.Checked)
            {
                gender = "Nő";
            }
            else if (maleBtn.Checked) {
                gender = "Férfi";
            } else if (otherBtn.Checked) {
                gender = "Egyéb";
            }

            BSE = new banking_dbEntities();
            userAccount acc = new userAccount();
            acc.Account_No = Convert.ToDecimal(accNoTb.Text);
            acc.Name = nameTb.Text;
            acc.Mother_Name = motherNameTb.Text;
            acc.DOB = birthDateTimePicker.Value.ToString();
            acc.Phone_No = numberTb.Text;
            try
            {
                acc.Zip_Code = Convert.ToDecimal(zipTb.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kérjük töltse ki az összes mezőt!");
                Console.WriteLine(ex.Message);
            }

            acc.State = statecB.SelectedItem.ToString();
            acc.City = cityTb.Text;
            acc.Address = addressTb.Text;
            acc.Gender = gender;
            acc.Balance = Convert.ToDecimal(balanceTb.Text);
            acc.Date = dateLbl.Text;
            if (pictureBox1.Image != null) { // Ezen lehet alakítgatni kell mert az adatbázisban egyenlőre NULL értékű.
                acc.Picture = ms.ToArray();
            }
            
            BSE.userAccounts.Add(acc);
            BSE.SaveChanges();
           
            MessageBox.Show("Ügyfél rögzítve");


        }

        private void accNoTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
