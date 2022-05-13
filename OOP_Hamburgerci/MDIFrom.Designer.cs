namespace OOP_Hamburgerci
{
    partial class MDIFrom
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisOlurtur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisListele = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEkstraMalzemeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişYonetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişYonetimiToolStripMenuItem
            // 
            this.siparişYonetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisOlurtur,
            this.tsmSiparisListele});
            this.siparişYonetimiToolStripMenuItem.Name = "siparişYonetimiToolStripMenuItem";
            this.siparişYonetimiToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.siparişYonetimiToolStripMenuItem.Text = "SiparişYonetimi";
            // 
            // tsmSiparisOlurtur
            // 
            this.tsmSiparisOlurtur.Name = "tsmSiparisOlurtur";
            this.tsmSiparisOlurtur.Size = new System.Drawing.Size(180, 22);
            this.tsmSiparisOlurtur.Text = "Sipariş Oluştur";
            this.tsmSiparisOlurtur.Click += new System.EventHandler(this.SiparisOlustur_Click);
            // 
            // tsmSiparisListele
            // 
            this.tsmSiparisListele.Name = "tsmSiparisListele";
            this.tsmSiparisListele.Size = new System.Drawing.Size(180, 22);
            this.tsmSiparisListele.Text = "Sipariş Listele";
            this.tsmSiparisListele.Click += new System.EventHandler(this.TumSiparisler_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEkstraMalzemeEkle,
            this.tsmMenuEkle});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // tsmEkstraMalzemeEkle
            // 
            this.tsmEkstraMalzemeEkle.Name = "tsmEkstraMalzemeEkle";
            this.tsmEkstraMalzemeEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmEkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            // 
            // tsmMenuEkle
            // 
            this.tsmMenuEkle.Name = "tsmMenuEkle";
            this.tsmMenuEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmMenuEkle.Text = "Menü Ekle";
            // 
            // MDIFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(899, 727);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIFrom";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MDIFrom";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSiparisOlurtur;
        private System.Windows.Forms.ToolStripMenuItem tsmSiparisListele;
        private System.Windows.Forms.ToolStripMenuItem tsmEkstraMalzemeEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmMenuEkle;
    }
}