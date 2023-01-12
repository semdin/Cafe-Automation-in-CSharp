namespace Semdin_Kafe_Otomasyonu
{
    partial class frmAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAna));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKullanıcıOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lstMasa = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.masayiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.raporlarToolStripMenuItem,
            this.kullanıcıToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1085, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünSilToolStripMenuItem,
            this.ürünEkleToolStripMenuItem,
            this.ürünDüzenleToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 50);
            this.toolStripMenuItem1.Text = "Ürünler";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ürünSilToolStripMenuItem
            // 
            this.ürünSilToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ürünSilToolStripMenuItem.Name = "ürünSilToolStripMenuItem";
            this.ürünSilToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ürünSilToolStripMenuItem.Text = "Ürünleri Göster";
            this.ürünSilToolStripMenuItem.Click += new System.EventHandler(this.ürünSilToolStripMenuItem_Click);
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // ürünDüzenleToolStripMenuItem
            // 
            this.ürünDüzenleToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ürünDüzenleToolStripMenuItem.Name = "ürünDüzenleToolStripMenuItem";
            this.ürünDüzenleToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ürünDüzenleToolStripMenuItem.Text = "Ürün Düzenle";
            this.ürünDüzenleToolStripMenuItem.Click += new System.EventHandler(this.ürünDüzenleToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışlarToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(61, 50);
            this.raporlarToolStripMenuItem.Text = "Geçmiş";
            // 
            // satışlarToolStripMenuItem
            // 
            this.satışlarToolStripMenuItem.Name = "satışlarToolStripMenuItem";
            this.satışlarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.satışlarToolStripMenuItem.Text = "Satış Geçmişi";
            this.satışlarToolStripMenuItem.Click += new System.EventHandler(this.satışlarToolStripMenuItem_Click);
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKullanıcıOluşturToolStripMenuItem});
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(66, 50);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            // 
            // yeniKullanıcıOluşturToolStripMenuItem
            // 
            this.yeniKullanıcıOluşturToolStripMenuItem.Name = "yeniKullanıcıOluşturToolStripMenuItem";
            this.yeniKullanıcıOluşturToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.yeniKullanıcıOluşturToolStripMenuItem.Text = "Kullanıcı Oluştur";
            this.yeniKullanıcıOluşturToolStripMenuItem.Click += new System.EventHandler(this.yeniKullanıcıOluşturToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(12, 50);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bosMasa.png");
            this.imageList1.Images.SetKeyName(1, "doluMasa.png");
            this.imageList1.Images.SetKeyName(2, "bosMasa.png");
            this.imageList1.Images.SetKeyName(3, "doluMasa.png");
            // 
            // lstMasa
            // 
            this.lstMasa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstMasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMasa.LargeImageList = this.imageList1;
            this.lstMasa.Location = new System.Drawing.Point(227, 7);
            this.lstMasa.MultiSelect = false;
            this.lstMasa.Name = "lstMasa";
            this.lstMasa.Size = new System.Drawing.Size(858, 448);
            this.lstMasa.TabIndex = 1;
            this.lstMasa.UseCompatibleStateImageBehavior = false;
            this.lstMasa.SelectedIndexChanged += new System.EventHandler(this.lstMasa_SelectedIndexChanged);
            this.lstMasa.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.lstMasa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstMasa_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lstMasa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1085, 455);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masalar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = global::Semdin_Kafe_Otomasyonu.Properties.Resources.solfoto;
            this.pictureBox1.Location = new System.Drawing.Point(0, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 436);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masayiKapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 26);
            // 
            // masayiKapatToolStripMenuItem
            // 
            this.masayiKapatToolStripMenuItem.Name = "masayiKapatToolStripMenuItem";
            this.masayiKapatToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.masayiKapatToolStripMenuItem.Text = "Masayi Kapat";
            this.masayiKapatToolStripMenuItem.Click += new System.EventHandler(this.masayiKapatToolStripMenuItem_Click);
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1085, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kafe Otomasyonu - Mehmet Şemdin Aktay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAna_FormClosing);
            this.Load += new System.EventHandler(this.frmAna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünSilToolStripMenuItem;
        public System.Windows.Forms.ListView lstMasa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masayiKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKullanıcıOluşturToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

