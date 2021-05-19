
namespace BankApplikáció
{
    partial class fixedDepositForm
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
            this.fixBtn = new System.Windows.Forms.Button();
            this.messageTb = new System.Windows.Forms.TextBox();
            this.periodTb = new System.Windows.Forms.TextBox();
            this.balanceTb = new System.Windows.Forms.TextBox();
            this.interestTb = new System.Windows.Forms.TextBox();
            this.accNoTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fixBtn
            // 
            this.fixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fixBtn.Location = new System.Drawing.Point(412, 367);
            this.fixBtn.Name = "fixBtn";
            this.fixBtn.Size = new System.Drawing.Size(159, 30);
            this.fixBtn.TabIndex = 45;
            this.fixBtn.Text = "Lekötés";
            this.fixBtn.UseVisualStyleBackColor = true;
            this.fixBtn.Click += new System.EventHandler(this.fixBtn_Click);
            // 
            // messageTb
            // 
            this.messageTb.Location = new System.Drawing.Point(130, 258);
            this.messageTb.Multiline = true;
            this.messageTb.Name = "messageTb";
            this.messageTb.Size = new System.Drawing.Size(266, 86);
            this.messageTb.TabIndex = 43;
            // 
            // periodTb
            // 
            this.periodTb.Location = new System.Drawing.Point(158, 160);
            this.periodTb.Name = "periodTb";
            this.periodTb.Size = new System.Drawing.Size(251, 22);
            this.periodTb.TabIndex = 42;
            // 
            // balanceTb
            // 
            this.balanceTb.Location = new System.Drawing.Point(106, 372);
            this.balanceTb.Name = "balanceTb";
            this.balanceTb.Size = new System.Drawing.Size(251, 22);
            this.balanceTb.TabIndex = 41;
            // 
            // interestTb
            // 
            this.interestTb.Location = new System.Drawing.Point(130, 207);
            this.interestTb.Name = "interestTb";
            this.interestTb.Size = new System.Drawing.Size(251, 22);
            this.interestTb.TabIndex = 40;
            // 
            // accNoTb
            // 
            this.accNoTb.Location = new System.Drawing.Point(145, 115);
            this.accNoTb.Name = "accNoTb";
            this.accNoTb.Size = new System.Drawing.Size(251, 22);
            this.accNoTb.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(28, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Periódus (nap):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(28, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Kamat (%):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(28, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Közlemény:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(28, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Összeg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Számlaszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(309, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Betét lekötés";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(134, 34);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(57, 17);
            this.dateLbl.TabIndex = 32;
            this.dateLbl.Text = "DÁTUM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mai dátum:";
            // 
            // fixedDepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fixBtn);
            this.Controls.Add(this.messageTb);
            this.Controls.Add(this.periodTb);
            this.Controls.Add(this.balanceTb);
            this.Controls.Add(this.interestTb);
            this.Controls.Add(this.accNoTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.label1);
            this.Name = "fixedDepositForm";
            this.Text = "fixedDepositForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fixBtn;
        private System.Windows.Forms.TextBox messageTb;
        private System.Windows.Forms.TextBox periodTb;
        private System.Windows.Forms.TextBox balanceTb;
        private System.Windows.Forms.TextBox interestTb;
        private System.Windows.Forms.TextBox accNoTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label label1;
    }
}