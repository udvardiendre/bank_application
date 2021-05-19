
namespace BankApplikáció
{
    partial class trasferForm
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
            this.transferBtn = new System.Windows.Forms.Button();
            this.detailsBtn = new System.Windows.Forms.Button();
            this.destAccNoTb = new System.Windows.Forms.TextBox();
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
            // transferBtn
            // 
            this.transferBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.transferBtn.Location = new System.Drawing.Point(407, 362);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(159, 30);
            this.transferBtn.TabIndex = 45;
            this.transferBtn.Text = "Utalás";
            this.transferBtn.UseVisualStyleBackColor = true;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // detailsBtn
            // 
            this.detailsBtn.Location = new System.Drawing.Point(407, 109);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(159, 28);
            this.detailsBtn.TabIndex = 44;
            this.detailsBtn.Text = "Részletek";
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // destAccNoTb
            // 
            this.destAccNoTb.Location = new System.Drawing.Point(168, 253);
            this.destAccNoTb.Name = "destAccNoTb";
            this.destAccNoTb.Size = new System.Drawing.Size(266, 22);
            this.destAccNoTb.TabIndex = 43;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(72, 155);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(251, 22);
            this.nameTb.TabIndex = 42;
            // 
            // balanceTb
            // 
            this.balanceTb.Location = new System.Drawing.Point(101, 367);
            this.balanceTb.Name = "balanceTb";
            this.balanceTb.Size = new System.Drawing.Size(251, 22);
            this.balanceTb.TabIndex = 41;
            // 
            // oldBalTb
            // 
            this.oldBalTb.Location = new System.Drawing.Point(148, 202);
            this.oldBalTb.Name = "oldBalTb";
            this.oldBalTb.Size = new System.Drawing.Size(251, 22);
            this.oldBalTb.TabIndex = 40;
            // 
            // accNoTb
            // 
            this.accNoTb.Location = new System.Drawing.Point(140, 110);
            this.accNoTb.Name = "accNoTb";
            this.accNoTb.Size = new System.Drawing.Size(251, 22);
            this.accNoTb.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(23, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Név:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(23, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Egyenleg: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(23, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Cél számlaszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(23, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Összeg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Számlaszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(319, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Utalás";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(129, 29);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(57, 17);
            this.dateLbl.TabIndex = 32;
            this.dateLbl.Text = "DÁTUM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mai dátum:";
            // 
            // trasferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.detailsBtn);
            this.Controls.Add(this.destAccNoTb);
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
            this.Name = "trasferForm";
            this.Text = "trasferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Button detailsBtn;
        private System.Windows.Forms.TextBox destAccNoTb;
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