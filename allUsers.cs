﻿using System;
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
    public partial class allUsers : Form
    {
        public allUsers()
        {
            InitializeComponent();
            bindgrid();
        }

        private void bindgrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            banking_dbEntities bs = new banking_dbEntities();
            var item = bs.userAccount.ToList();
            dataGridView1.DataSource = item;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
