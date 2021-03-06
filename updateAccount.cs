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
    public partial class updateAccount : Form
    {
        banking_dbEntities dbe;
        MemoryStream ms;
        BindingList<userAccount> bi;

        public updateAccount()
        {
            InitializeComponent();
            loadDate();
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

        private void loadDate()
        {
            
            dateLbl.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                dbe = new banking_dbEntities();
                decimal accountno = Convert.ToDecimal(accNoTb.Text);
                userAccount useraccount = dbe.userAccount.First(s => s.Account_No.Equals(accountno));
                useraccount.Account_No = Convert.ToDecimal(accNoTb.Text);
                useraccount.Name = nameTb.Text;
                useraccount.Mother_Name = motherNameTb.Text;
                useraccount.Date = birthDateTimePicker.Value.ToString();
                useraccount.Phone_No = numberTb.Text;
                useraccount.Zip_Code = Convert.ToDecimal(zipTb.Text);
                useraccount.State = statecB.SelectedItem.ToString();
                useraccount.City = cityTb.Text;
                useraccount.Address = addressTb.Text;
                if (wmnBtn.Checked)
                {
                    useraccount.Gender = "Nő";
                }
                else if (maleBtn.Checked)
                {
                    useraccount.Gender = "Férfi";
                }
                else if (otherBtn.Checked)
                {
                    useraccount.Gender = "Egyéb";
                }

                Image img = pictureBox1.Image;
                if (img.RawFormat != null)
                {
                    if (ms != null)
                    {
                        img.Save(ms, img.RawFormat);
                        useraccount.Picture = ms.ToArray();
                    }
                }
                dbe.SaveChanges();
                MessageBox.Show("Az ügyfél adatai frissültek!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kérjük töltse ki az összes mezőt!");
                Console.WriteLine(ex.Message);
            }
            
           

        }

        private void deatilsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;

                bi = new BindingList<userAccount>();
                dbe = new banking_dbEntities();
                decimal accNo = Convert.ToDecimal(accNoTb.Text);
                var item = dbe.userAccount.Where(a => a.Account_No == accNo);
                foreach (var item1 in item)
                {
                    bi.Add(item1);
                }
                dataGridView1.DataSource = bi;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Kérjük töltse ki az összes mezőt!");
                Console.WriteLine(ex.Message);
            }
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities();
            var item = dbe.userAccount.Where(a => a.Name == nameTb.Text);
            foreach (var item1 in item) {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dbe = new banking_dbEntities();
            decimal accNo = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = dbe.userAccount.Where(a => a.Account_No == accNo).FirstOrDefault();
            accNoTb.Text = item.Account_No.ToString();
            nameTb.Text = item.Name;
            motherNameTb.Text = item.Mother_Name;
            birthDateTimePicker.Value = Convert.ToDateTime(item.DOB);
            numberTb.Text = item.Phone_No;
            zipTb.Text = Convert.ToString(item.Zip_Code);   // itt átkell convertálni -- Kész
            statecB.SelectedItem = item.State;  // megyét kikell választatni.
            cityTb.Text = item.City;
            addressTb.Text = item.Address;
            byte[] img = item.Picture;
            if (img != null)
            {
                // uploadBtn.Visible = true;
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }

            if (item.Gender == "Nő")
            {
                wmnBtn.Checked = true;
            }
            else if (item.Gender == "Férfi")
            {
                maleBtn.Checked = true;
            }
            else if (item.Gender == "Egyéb")
            {
                otherBtn.Checked = true;
            }

        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opendlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try {
                bi.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                dbe = new banking_dbEntities();
                decimal a = Convert.ToDecimal(accNoTb.Text);
                userAccount acc = dbe.userAccount.First(s => s.Account_No.Equals(a));
                dbe.userAccount.Remove(acc);
                dbe.SaveChanges();
            } catch (Exception ex) {
                Console.WriteLine("Kérjük töltse ki az összes mezőt!");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
