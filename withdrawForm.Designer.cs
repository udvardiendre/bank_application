
namespace BankApplikáció
{
    partial class withdrawForm
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.detailBtn = new System.Windows.Forms.Button();
            this.messageTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.balanceTb = new System.Windows.Forms.TextBox();
            this.oldBalTb = new System.Windows.Forms.TextBox();
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
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateBtn.Location = new System.Drawing.Point(409, 365);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(159, 30);
            this.updateBtn.TabIndex = 30;
            this.updateBtn.Text = "Teljesítés";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // detailBtn
            // 
            this.detailBtn.Location = new System.Drawing.Point(409, 112);
            this.detailBtn.Name = "detailBtn";
            this.detailBtn.Size = new System.Drawing.Size(159, 28);
            this.detailBtn.TabIndex = 29;
            this.detailBtn.Text = "Részletek";
            this.detailBtn.UseVisualStyleBackColor = true;
            this.detailBtn.Click += new System.EventHandler(this.detailBtn_Click);
            // 
            // messageTb
            // 
            this.messageTb.Location = new System.Drawing.Point(127, 256);
            this.messageTb.Multiline = true;
            this.messageTb.Name = "messageTb";
            this.messageTb.Size = new System.Drawing.Size(266, 86);
            this.messageTb.TabIndex = 28;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(74, 158);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(251, 22);
            this.nameTb.TabIndex = 27;
            // 
            // balanceTb
            // 
            this.balanceTb.Location = new System.Drawing.Point(103, 370);
            this.balanceTb.Name = "balanceTb";
            this.balanceTb.Size = new System.Drawing.Size(251, 22);
            this.balanceTb.TabIndex = 26;
            // 
            // oldBalTb
            // 
            this.oldBalTb.Location = new System.Drawing.Point(150, 205);
            this.oldBalTb.Name = "oldBalTb";
            this.oldBalTb.Size = new System.Drawing.Size(251, 22);
            this.oldBalTb.TabIndex = 25;
            // 
            // accNoTb
            // 
            this.accNoTb.Location = new System.Drawing.Point(142, 113);
            this.accNoTb.Name = "accNoTb";
            this.accNoTb.Size = new System.Drawing.Size(251, 22);
            this.accNoTb.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(25, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Név:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(25, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Régi egyenleg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(25, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Közlemény:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(25, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Összeg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Számlaszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(321, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kifizetés";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(131, 32);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(57, 17);
            this.dateLbl.TabIndex = 17;
            this.dateLbl.Text = "DÁTUM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mai dátum:";
            // 
            // withdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.detailBtn);
            this.Controls.Add(this.messageTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.balanceTb);
            this.Controls.Add(this.oldBalTb);
            this.Controls.Add(this.accNoTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.label1);
            this.Name = "withdrawForm";
            this.Text = "withdrawForm";
            this.Load += new System.EventHandler(this.withdrawForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button detailBtn;
        private System.Windows.Forms.TextBox messageTb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox balanceTb;
        private System.Windows.Forms.TextBox oldBalTb;
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