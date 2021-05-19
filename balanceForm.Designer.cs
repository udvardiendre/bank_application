
namespace BankApplikáció
{
    partial class balanceForm
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
            this.accNoTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dateLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.depositDgv = new System.Windows.Forms.DataGridView();
            this.withdrawDgv = new System.Windows.Forms.DataGridView();
            this.transferDgv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dip_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_w = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName_w = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deb_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message_w = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationacc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.depositDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mérleg";
            // 
            // accNoTb
            // 
            this.accNoTb.Location = new System.Drawing.Point(144, 87);
            this.accNoTb.Name = "accNoTb";
            this.accNoTb.Size = new System.Drawing.Size(290, 22);
            this.accNoTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Számlaszám:";
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchBtn.Location = new System.Drawing.Point(453, 81);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(152, 32);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Keresés";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(1147, 38);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(57, 17);
            this.dateLbl.TabIndex = 32;
            this.dateLbl.Text = "DÁTUM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1032, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mai dátum:";
            // 
            // depositDgv
            // 
            this.depositDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depositDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.CustomerName,
            this.Dip_Amount,
            this.Message});
            this.depositDgv.Location = new System.Drawing.Point(12, 171);
            this.depositDgv.Name = "depositDgv";
            this.depositDgv.RowHeadersWidth = 51;
            this.depositDgv.RowTemplate.Height = 24;
            this.depositDgv.Size = new System.Drawing.Size(400, 377);
            this.depositDgv.TabIndex = 33;
            // 
            // withdrawDgv
            // 
            this.withdrawDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.withdrawDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_w,
            this.CustomerName_w,
            this.deb_amount,
            this.message_w});
            this.withdrawDgv.Location = new System.Drawing.Point(427, 171);
            this.withdrawDgv.Name = "withdrawDgv";
            this.withdrawDgv.RowHeadersWidth = 51;
            this.withdrawDgv.RowTemplate.Height = 24;
            this.withdrawDgv.Size = new System.Drawing.Size(402, 377);
            this.withdrawDgv.TabIndex = 34;
            // 
            // transferDgv
            // 
            this.transferDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transferDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date_t,
            this.CustomerName_t,
            this.balance_t,
            this.destinationacc});
            this.transferDgv.Location = new System.Drawing.Point(845, 171);
            this.transferDgv.Name = "transferDgv";
            this.transferDgv.RowHeadersWidth = 51;
            this.transferDgv.RowTemplate.Height = 24;
            this.transferDgv.Size = new System.Drawing.Size(400, 377);
            this.transferDgv.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Befizetések";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(841, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Utalások";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(423, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Kifizetések";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Dátum";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "Name";
            this.CustomerName.HeaderText = "Név";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 125;
            // 
            // Dip_Amount
            // 
            this.Dip_Amount.DataPropertyName = "Dip_Amount";
            this.Dip_Amount.HeaderText = "Összeg";
            this.Dip_Amount.MinimumWidth = 6;
            this.Dip_Amount.Name = "Dip_Amount";
            this.Dip_Amount.Width = 125;
            // 
            // Message
            // 
            this.Message.DataPropertyName = "Message";
            this.Message.HeaderText = "Közlemény";
            this.Message.MinimumWidth = 6;
            this.Message.Name = "Message";
            this.Message.Width = 125;
            // 
            // Date_w
            // 
            this.Date_w.DataPropertyName = "Date";
            this.Date_w.HeaderText = "Dátum";
            this.Date_w.MinimumWidth = 6;
            this.Date_w.Name = "Date_w";
            this.Date_w.Width = 125;
            // 
            // CustomerName_w
            // 
            this.CustomerName_w.DataPropertyName = "Name";
            this.CustomerName_w.HeaderText = "Név";
            this.CustomerName_w.MinimumWidth = 6;
            this.CustomerName_w.Name = "CustomerName_w";
            this.CustomerName_w.Width = 125;
            // 
            // deb_amount
            // 
            this.deb_amount.DataPropertyName = "Deb_Amount";
            this.deb_amount.HeaderText = "Összeg";
            this.deb_amount.MinimumWidth = 6;
            this.deb_amount.Name = "deb_amount";
            this.deb_amount.Width = 125;
            // 
            // message_w
            // 
            this.message_w.DataPropertyName = "Message";
            this.message_w.HeaderText = "Közlemény";
            this.message_w.MinimumWidth = 6;
            this.message_w.Name = "message_w";
            this.message_w.Width = 125;
            // 
            // date_t
            // 
            this.date_t.DataPropertyName = "Date";
            this.date_t.HeaderText = "Dátum";
            this.date_t.MinimumWidth = 6;
            this.date_t.Name = "date_t";
            this.date_t.Width = 125;
            // 
            // CustomerName_t
            // 
            this.CustomerName_t.DataPropertyName = "Name";
            this.CustomerName_t.HeaderText = "Név";
            this.CustomerName_t.MinimumWidth = 6;
            this.CustomerName_t.Name = "CustomerName_t";
            this.CustomerName_t.Width = 125;
            // 
            // balance_t
            // 
            this.balance_t.DataPropertyName = "Balance";
            this.balance_t.HeaderText = "Összeg";
            this.balance_t.MinimumWidth = 6;
            this.balance_t.Name = "balance_t";
            this.balance_t.Width = 125;
            // 
            // destinationacc
            // 
            this.destinationacc.DataPropertyName = "To_Transfer";
            this.destinationacc.HeaderText = "Cél";
            this.destinationacc.MinimumWidth = 6;
            this.destinationacc.Name = "destinationacc";
            this.destinationacc.Width = 125;
            // 
            // balanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 560);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transferDgv);
            this.Controls.Add(this.withdrawDgv);
            this.Controls.Add(this.depositDgv);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accNoTb);
            this.Controls.Add(this.label1);
            this.Name = "balanceForm";
            this.Text = "Mérleg";
            ((System.ComponentModel.ISupportInitialize)(this.depositDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accNoTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView depositDgv;
        private System.Windows.Forms.DataGridView withdrawDgv;
        private System.Windows.Forms.DataGridView transferDgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dip_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_w;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName_w;
        private System.Windows.Forms.DataGridViewTextBoxColumn deb_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn message_w;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationacc;
    }
}