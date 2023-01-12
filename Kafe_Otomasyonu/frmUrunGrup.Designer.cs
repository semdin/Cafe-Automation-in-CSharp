namespace Semdin_Kafe_Otomasyonu
{
    partial class frmUrunGrup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunGrup));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.comboGruplar = new System.Windows.Forms.ComboBox();
            this.txtDuzenlenenAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBildirim = new System.Windows.Forms.Label();
            this.hata = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // txtAdi
            // 
            this.txtAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtAdi.Location = new System.Drawing.Point(60, 33);
            this.txtAdi.MaxLength = 50;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(60, 59);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 40);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Ekle.png");
            this.imageList1.Images.SetKeyName(1, "edit.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grup Ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuzenle);
            this.groupBox2.Controls.Add(this.comboGruplar);
            this.groupBox2.Controls.Add(this.txtDuzenlenenAd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 128);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grup Düzenle";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuzenle.Location = new System.Drawing.Point(60, 77);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(121, 40);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // comboGruplar
            // 
            this.comboGruplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGruplar.FormattingEnabled = true;
            this.comboGruplar.Location = new System.Drawing.Point(60, 24);
            this.comboGruplar.Name = "comboGruplar";
            this.comboGruplar.Size = new System.Drawing.Size(121, 21);
            this.comboGruplar.TabIndex = 2;
            this.comboGruplar.SelectedIndexChanged += new System.EventHandler(this.comboGruplar_SelectedIndexChanged);
            this.comboGruplar.Click += new System.EventHandler(this.comboGruplar_Click);
            // 
            // txtDuzenlenenAd
            // 
            this.txtDuzenlenenAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtDuzenlenenAd.Location = new System.Drawing.Point(60, 51);
            this.txtDuzenlenenAd.MaxLength = 50;
            this.txtDuzenlenenAd.Name = "txtDuzenlenenAd";
            this.txtDuzenlenenAd.Size = new System.Drawing.Size(121, 20);
            this.txtDuzenlenenAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gruplar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı:";
            // 
            // lblBildirim
            // 
            this.lblBildirim.AutoSize = true;
            this.lblBildirim.Location = new System.Drawing.Point(19, 151);
            this.lblBildirim.Name = "lblBildirim";
            this.lblBildirim.Size = new System.Drawing.Size(0, 13);
            this.lblBildirim.TabIndex = 5;
            // 
            // hata
            // 
            this.hata.ContainerControl = this;
            // 
            // frmUrunGrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(254, 332);
            this.Controls.Add(this.lblBildirim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUrunGrup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Grupları";
            this.Load += new System.EventHandler(this.frmUrunGrup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.TextBox txtDuzenlenenAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboGruplar;
        private System.Windows.Forms.Label lblBildirim;
        private System.Windows.Forms.ErrorProvider hata;
        private System.Windows.Forms.ImageList imageList1;
    }
}