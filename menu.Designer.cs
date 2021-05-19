
namespace BankApplikáció
{
    partial class menu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fiókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újFiókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiókKeresésefrissítéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzakciókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.befizetésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kifizetésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.átutalásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betétLekötésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nézetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egyenlegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekötöttBetétToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kijelentkezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jelszóMódosításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiókToolStripMenuItem,
            this.tranzakciókToolStripMenuItem,
            this.nézetToolStripMenuItem,
            this.profilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1189, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fiókToolStripMenuItem
            // 
            this.fiókToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újFiókToolStripMenuItem,
            this.fiókKeresésefrissítéseToolStripMenuItem,
            this.felhasználókToolStripMenuItem});
            this.fiókToolStripMenuItem.Name = "fiókToolStripMenuItem";
            this.fiókToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.fiókToolStripMenuItem.Text = "Fiók";
            // 
            // újFiókToolStripMenuItem
            // 
            this.újFiókToolStripMenuItem.Name = "újFiókToolStripMenuItem";
            this.újFiókToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.újFiókToolStripMenuItem.Text = "Új Fiók";
            this.újFiókToolStripMenuItem.Click += new System.EventHandler(this.újFiókToolStripMenuItem_Click);
            // 
            // fiókKeresésefrissítéseToolStripMenuItem
            // 
            this.fiókKeresésefrissítéseToolStripMenuItem.Name = "fiókKeresésefrissítéseToolStripMenuItem";
            this.fiókKeresésefrissítéseToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.fiókKeresésefrissítéseToolStripMenuItem.Text = "Fiók keresése/frissítése";
            this.fiókKeresésefrissítéseToolStripMenuItem.Click += new System.EventHandler(this.fiókKeresésefrissítéseToolStripMenuItem_Click);
            // 
            // felhasználókToolStripMenuItem
            // 
            this.felhasználókToolStripMenuItem.Name = "felhasználókToolStripMenuItem";
            this.felhasználókToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.felhasználókToolStripMenuItem.Text = "Felhasználók";
            this.felhasználókToolStripMenuItem.Click += new System.EventHandler(this.felhasználókToolStripMenuItem_Click);
            // 
            // tranzakciókToolStripMenuItem
            // 
            this.tranzakciókToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.befizetésToolStripMenuItem,
            this.kifizetésToolStripMenuItem,
            this.átutalásToolStripMenuItem,
            this.betétLekötésToolStripMenuItem});
            this.tranzakciókToolStripMenuItem.Name = "tranzakciókToolStripMenuItem";
            this.tranzakciókToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.tranzakciókToolStripMenuItem.Text = "Tranzakciók";
            // 
            // befizetésToolStripMenuItem
            // 
            this.befizetésToolStripMenuItem.Name = "befizetésToolStripMenuItem";
            this.befizetésToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.befizetésToolStripMenuItem.Text = "Befizetés";
            this.befizetésToolStripMenuItem.Click += new System.EventHandler(this.befizetésToolStripMenuItem_Click);
            // 
            // kifizetésToolStripMenuItem
            // 
            this.kifizetésToolStripMenuItem.Name = "kifizetésToolStripMenuItem";
            this.kifizetésToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kifizetésToolStripMenuItem.Text = "Kifizetés";
            this.kifizetésToolStripMenuItem.Click += new System.EventHandler(this.kifizetésToolStripMenuItem_Click);
            // 
            // átutalásToolStripMenuItem
            // 
            this.átutalásToolStripMenuItem.Name = "átutalásToolStripMenuItem";
            this.átutalásToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.átutalásToolStripMenuItem.Text = "Átutalás";
            this.átutalásToolStripMenuItem.Click += new System.EventHandler(this.átutalásToolStripMenuItem_Click);
            // 
            // betétLekötésToolStripMenuItem
            // 
            this.betétLekötésToolStripMenuItem.Name = "betétLekötésToolStripMenuItem";
            this.betétLekötésToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.betétLekötésToolStripMenuItem.Text = "Betét lekötés";
            this.betétLekötésToolStripMenuItem.Click += new System.EventHandler(this.betétLekötésToolStripMenuItem_Click);
            // 
            // nézetToolStripMenuItem
            // 
            this.nézetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.egyenlegToolStripMenuItem,
            this.lekötöttBetétToolStripMenuItem});
            this.nézetToolStripMenuItem.Name = "nézetToolStripMenuItem";
            this.nézetToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.nézetToolStripMenuItem.Text = "Nézet";
            // 
            // egyenlegToolStripMenuItem
            // 
            this.egyenlegToolStripMenuItem.Name = "egyenlegToolStripMenuItem";
            this.egyenlegToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.egyenlegToolStripMenuItem.Text = "Egyenleg";
            this.egyenlegToolStripMenuItem.Click += new System.EventHandler(this.egyenlegToolStripMenuItem_Click);
            // 
            // lekötöttBetétToolStripMenuItem
            // 
            this.lekötöttBetétToolStripMenuItem.Name = "lekötöttBetétToolStripMenuItem";
            this.lekötöttBetétToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lekötöttBetétToolStripMenuItem.Text = "Lekötött betét";
            this.lekötöttBetétToolStripMenuItem.Click += new System.EventHandler(this.lekötöttBetétToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kijelentkezésToolStripMenuItem,
            this.jelszóMódosításaToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // kijelentkezésToolStripMenuItem
            // 
            this.kijelentkezésToolStripMenuItem.Name = "kijelentkezésToolStripMenuItem";
            this.kijelentkezésToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kijelentkezésToolStripMenuItem.Text = "Kijelentkezés";
            this.kijelentkezésToolStripMenuItem.Click += new System.EventHandler(this.kijelentkezésToolStripMenuItem_Click);
            // 
            // jelszóMódosításaToolStripMenuItem
            // 
            this.jelszóMódosításaToolStripMenuItem.Name = "jelszóMódosításaToolStripMenuItem";
            this.jelszóMódosításaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.jelszóMódosításaToolStripMenuItem.Text = "Jelszó módosítása";
            this.jelszóMódosításaToolStripMenuItem.Click += new System.EventHandler(this.jelszóMódosításaToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 520);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fiókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újFiókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiókKeresésefrissítéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranzakciókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem befizetésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kifizetésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem átutalásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betétLekötésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nézetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egyenlegToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lekötöttBetétToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kijelentkezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jelszóMódosításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
    }
}