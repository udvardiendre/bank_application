
namespace BankApplikáció
{
    partial class myFixedDeposit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Account_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maturity_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maturity_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lekötött betétek listája\r\n";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // listBtn
            // 
            this.listBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBtn.Location = new System.Drawing.Point(512, 76);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(141, 39);
            this.listBtn.TabIndex = 2;
            this.listBtn.Text = "Listáz";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account_No,
            this.Message,
            this.Amount,
            this.Period,
            this.Interest,
            this.Maturity_Date,
            this.Maturity_Amount,
            this.Start_Date});
            this.dataGridView1.Location = new System.Drawing.Point(5, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1073, 391);
            this.dataGridView1.TabIndex = 3;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(937, 38);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(57, 17);
            this.dateLbl.TabIndex = 5;
            this.dateLbl.Text = "DÁTUM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(832, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mai dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(45, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lekötés kezdete:";
            // 
            // Account_No
            // 
            this.Account_No.DataPropertyName = "Account_No";
            this.Account_No.HeaderText = "Számlaszám";
            this.Account_No.MinimumWidth = 6;
            this.Account_No.Name = "Account_No";
            this.Account_No.Width = 125;
            // 
            // Message
            // 
            this.Message.DataPropertyName = "Message";
            this.Message.HeaderText = "Közlemény";
            this.Message.MinimumWidth = 6;
            this.Message.Name = "Message";
            this.Message.Width = 125;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Összeg";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // Period
            // 
            this.Period.DataPropertyName = "Period";
            this.Period.HeaderText = "Periódus (nap)";
            this.Period.MinimumWidth = 6;
            this.Period.Name = "Period";
            this.Period.Width = 125;
            // 
            // Interest
            // 
            this.Interest.DataPropertyName = "Interest_Rate";
            this.Interest.HeaderText = "Kamat (%)";
            this.Interest.MinimumWidth = 6;
            this.Interest.Name = "Interest";
            this.Interest.Width = 125;
            // 
            // Maturity_Date
            // 
            this.Maturity_Date.DataPropertyName = "Maturity_Date";
            this.Maturity_Date.HeaderText = "Lejárat";
            this.Maturity_Date.MinimumWidth = 6;
            this.Maturity_Date.Name = "Maturity_Date";
            this.Maturity_Date.Width = 125;
            // 
            // Maturity_Amount
            // 
            this.Maturity_Amount.DataPropertyName = "Maturity_Amount";
            this.Maturity_Amount.HeaderText = "Nyereséggel növelt összeg";
            this.Maturity_Amount.MinimumWidth = 6;
            this.Maturity_Amount.Name = "Maturity_Amount";
            this.Maturity_Amount.Width = 125;
            // 
            // Start_Date
            // 
            this.Start_Date.DataPropertyName = "Start_Date";
            this.Start_Date.HeaderText = "Lekötés kezdete";
            this.Start_Date.MinimumWidth = 6;
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.Width = 125;
            // 
            // myFixedDeposit
            // 
            this.AccessibleName = "Lekötött betétek";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 532);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "myFixedDeposit";
            this.Text = "Lekötött betétek listája";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maturity_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maturity_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Date;
    }
}