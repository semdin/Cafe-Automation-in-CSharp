using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semdin_Kafe_Otomasyonu
{
    public partial class frmMasa : Form
    {
        public frmMasa()
        {
            InitializeComponent();
        }

        int masaNo;

        private void urunGoster()
        {
            DataTable urun = Veritabani.VeriGetir("select * from Urun where SilinmisMi=False");
            DataTable grup = Veritabani.VeriGetir("select * from UrunGrubu");
            for (int groupIndex = 0; groupIndex < grup.Rows.Count; ++groupIndex)
            {
                
                this.lstUrunler.Groups.Add(grup.Rows[groupIndex]["UrunGrupNo"].ToString(), grup.Rows[groupIndex]["Adi"].ToString());

                for (int urunIndex = 0; urunIndex < urun.Rows.Count; ++urunIndex)
                {
                    if (urun.Rows[urunIndex]["UrunGrupNo"].ToString() == grup.Rows[groupIndex]["UrunGrupNo"].ToString())
                    {


                        if (File.Exists(urun.Rows[urunIndex]["ResimYolu"].ToString()))
                        {
                            Image myImage = Image.FromFile(urun.Rows[urunIndex]["ResimYolu"].ToString());
                            imageList1.Images.Add(urun.Rows[urunIndex]["UrunNo"].ToString(), myImage);
                            ListViewItem item = new ListViewItem(urun.Rows[urunIndex]["Adi"].ToString() + "-" + urun.Rows[urunIndex]["Fiyati"].ToString() + " ₺",
                                urun.Rows[urunIndex]["UrunNo"].ToString(), this.lstUrunler.Groups[groupIndex]);
                            this.lstUrunler.Items.Insert(0, item);
                        }
                        else
                        {
                            ListViewItem item = new ListViewItem(urun.Rows[urunIndex]["Adi"].ToString() + "-" + urun.Rows[urunIndex]["Fiyati"].ToString() + " ₺", urun.Rows[urunIndex]["UrunNo"].ToString(),
                            this.lstUrunler.Groups[groupIndex]);
                            this.lstUrunler.Items.Insert(0, item);
                            
                        }

                    }

                }
            }
        }



        private void sepetUrunGoster()
        {
            try
            {
                int siparisNo = Siparis.siparisNoGetir(masaNo);
                if (kontroller.veriVarmi("select * from SiparisUrun where SiparisNo=" + siparisNo + ""))
                {
                    DataTable siparisUrun = Veritabani.VeriGetir("select Urun.UrunNo as UrunNo,SiparisUrun.UrunAdet as UrunAdet,Urun.Adi as Adi,Urun.Fiyati as Fiyati,Urun.ResimYolu as ResimYolu from SiparisUrun inner join Urun on SiparisUrun.UrunNo=Urun.UrunNo where SiparisUrun.SiparisNo=" + siparisNo + "");
                    for (int urunIndex = 0; urunIndex < siparisUrun.Rows.Count; ++urunIndex)
                    {
                        for (int i = 0; i < Convert.ToInt32(siparisUrun.Rows[urunIndex]["UrunAdet"].ToString()); i++)
                        {
                            if (File.Exists(siparisUrun.Rows[urunIndex]["ResimYolu"].ToString()))
                            {
                                Image myImage = Image.FromFile(siparisUrun.Rows[urunIndex]["ResimYolu"].ToString());
                                imageList1.Images.Add(siparisUrun.Rows[urunIndex]["UrunNo"].ToString(), myImage);
                                ListViewItem item = new ListViewItem(siparisUrun.Rows[urunIndex]["Adi"].ToString() + "-" + siparisUrun.Rows[urunIndex]["Fiyati"].ToString() + " ₺",
                                    siparisUrun.Rows[urunIndex]["UrunNo"].ToString(), this.lstUrunler.Groups[0]);
                                this.lstSepet.Items.Insert(0, item);
                                this.lstSepet.Groups[0].Items.Insert(0, item);
                                double fiyati = Convert.ToDouble(item.Text.Substring(item.Text.IndexOf('-') + 1, item.Text.LastIndexOf(' ') - item.Text.LastIndexOf('-')));
                                txtToplam.Text = (Convert.ToDouble(txtToplam.Text) + fiyati).ToString();

                            }
                            else 
                            {
                                ListViewItem item = new ListViewItem(siparisUrun.Rows[urunIndex]["Adi"].ToString() + "-" + siparisUrun.Rows[urunIndex]["Fiyati"].ToString() + " ₺", siparisUrun.Rows[urunIndex]["UrunNo"].ToString(),
                                this.lstSepet.Groups[0]);
                                this.lstSepet.Items.Insert(0, item);
                                this.lstSepet.Groups[0].Items.Insert(0, item);
                                double fiyati = Convert.ToDouble(item.Text.Substring(item.Text.IndexOf('-') + 1, item.Text.LastIndexOf(' ') - item.Text.LastIndexOf('-')));
                                txtToplam.Text = (Convert.ToDouble(txtToplam.Text) + fiyati).ToString();
                            }
                        }


                    }

                }
            }
            catch
            {
                MessageBox.Show("SepetUrunGoster Metodunda hata");
            }


        }

        private void comboDoldur()
        {
            DataTable dt = Veritabani.VeriGetir("select * from OdemeTuru");
            comboOdemeTuru.DataSource = dt;
            comboOdemeTuru.DisplayMember = "Adi";
            comboOdemeTuru.ValueMember = "OdemeTuruNo";
        }
        private void siparisleriKaydet()
        {
            if (lstSepet.Items.Count > 0)
            {
                if (kontroller.veriVarmi("select * from Siparis where MasaNo=" + masaNo + " AND Hesap=True"))
                {
                    int siparisNo = Siparis.siparisNoGetir(masaNo);
                    if (Siparis.siparisUrunTemizle(siparisNo))
                    {
                            foreach (ListViewItem item in lstSepet.Items)
                            {
                                if (item.Group == lstSepet.Groups[0])
                                {
                                    if (!kontroller.veriVarmi("select UrunNo from SiparisUrun where UrunNo=" + item.ImageKey + " AND SiparisNo=" + siparisNo + ""))
                                    
                                    {

                                        int urunAdeti = 0;
                                        for (int i = 0; i < lstSepet.Groups[0].Items.Count; i++)
                                        {
                                            if (item.ImageKey == lstSepet.Groups[0].Items[i].ImageKey)
                                            {
                                                urunAdeti++;
                                                
                                            }
                                        }
                                        if (Siparis.siparisUrunEkle(siparisNo, item.ImageKey, urunAdeti))
                                        {
                                            
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ürünler eklenirken hata!");
                                        }
                                    }

                                }
                                else
                                {
                                    
                                }

                            }

                        
                    }
                }
                else
                {
                    if (Siparis.siparisEkle(masaNo))
                    {
                        int siparisNo = Siparis.siparisNoGetir(masaNo);
                        foreach (ListViewItem item in lstSepet.Items)
                        {
                            if (item.Group == lstSepet.Groups[0])
                            {
                                if (!kontroller.veriVarmi("select UrunNo from SiparisUrun where UrunNo=" + item.ImageKey + " AND SiparisNo=" + siparisNo + ""))
                                
                                {

                                    int urunAdeti = 0;
                                    for (int i = 0; i < lstSepet.Groups[0].Items.Count; i++)
                                    {
                                        if (item.ImageKey == lstSepet.Groups[0].Items[i].ImageKey)
                                        {
                                            urunAdeti++;
                                            
                                        }
                                    }
                                    if (Siparis.siparisUrunEkle(siparisNo, item.ImageKey, urunAdeti))
                                    {
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ürünler eklenirken hata!");
                                    }
                                }

                            }
                            

                        }
                    }
                    else
                    {
                        MessageBox.Show("Siparisler eklenirken hata meydana geldi.");
                    }

                }
            }
        }

        private void frmMasa_Load(object sender, EventArgs e)
        {
           

            this.Text = "Masa " + frmAna.MasaNumarasi.ToString();
            masaNo = Convert.ToInt32(this.Text.Substring(Convert.ToInt32(this.Text.IndexOf(' '))));
            grpUrun.Visible = true;
            urunGoster();
            comboDoldur();

            
            this.lstSepet.Groups.Add("0", "Ürünler");
            int siparisNo = Siparis.siparisNoGetir(masaNo);
            if (siparisNo != -1)
            {
                sepetUrunGoster();
            }

        }
        private void lstUrunler_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        


        private void lstSepet_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem seciliItem in lstSepet.SelectedItems)
            {
                double fiyati = Convert.ToDouble(seciliItem.Text.Substring(seciliItem.Text.IndexOf('-') + 1, seciliItem.Text.LastIndexOf(' ') - seciliItem.Text.LastIndexOf('-')));
                txtToplam.Text = (Convert.ToDouble(txtToplam.Text) - fiyati).ToString();
                lstSepet.Items[seciliItem.Index].Remove();
            }

        }

        private void frmMasa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lstSepet.Items.Count > 0)
            {
                siparisleriKaydet();
                if (frmAna.anaFrm.lstMasa.Items[masaNo - 1].ImageKey == "bosMasa.png")
                {
                    frmAna.anaFrm.lstMasa.Items[masaNo - 1].ImageKey = "doluMasa.png";

                }

            }
            frmAna.anaFrm.lstMasa_SelectedIndexChanged(null, null);
        }

        int siparisNo;
        private void btnHesapOde_Click(object sender, EventArgs e)
        {
            if (lstSepet.Items.Count > 0)
            {
                if (MessageBox.Show("Hesabı Ödemek İstiyor Musunuz?", "Hesap Öde", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {



                    siparisleriKaydet();
                    siparisNo = Siparis.siparisNoGetir(masaNo);
                    if (Hesap.hesapOde(siparisNo, comboOdemeTuru.SelectedValue, txtToplam.Text))
                    {
                        if (comboOdemeTuru.SelectedIndex == 0)
                        {
                            
                        }
                        


                    }
                    if (frmAna.anaFrm.lstMasa.Items[masaNo - 1].ImageKey == "doluMasa.png")
                    {
                        frmAna.anaFrm.lstMasa.Items[masaNo - 1].ImageKey = "bosMasa.png";


                    }
                    lstSepet.Items.Clear();


                }
            }

        }

        private void txtVerilenMiktar_TextChanged(object sender, EventArgs e)
        {
            if (txtVerilenMiktar.Text != "")
            {
                txtParaUstu.Text = (Convert.ToDouble(txtVerilenMiktar.Text) - Convert.ToDouble(txtToplam.Text)).ToString();
            }
            else
            {
                txtParaUstu.Text = "0";
            }
        }

        private void txtVerilenMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtVerilenMiktar.Text.IndexOf(',') != -1)
            {
                if (e.KeyChar == (char)44)
                {
                    e.Handled = true;
                }
            }
            kontroller.txtParaKontrol(e);
        }



        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItems.Count > 0)
            {
                foreach (ListViewItem seciliItem in lstUrunler.SelectedItems)
                {
                    double fiyati = Convert.ToDouble(seciliItem.Text.Substring(seciliItem.Text.IndexOf('-') + 1, seciliItem.Text.LastIndexOf(' ') - seciliItem.Text.LastIndexOf('-')));
                    txtToplam.Text = (Convert.ToDouble(txtToplam.Text) + fiyati).ToString();

                    ListViewItem item = new ListViewItem(lstUrunler.Items[seciliItem.Index].Text, lstUrunler.Items[seciliItem.Index].ImageKey, this.lstSepet.Groups[0]);//Ürünü,resmi,grubu bağlıyoruz

                    this.lstSepet.Items.Insert(0, item);
                                                        

                    lstUrunler.SelectedItems[0].Selected = false;
                }
            }
        }

        private void txtToplam_TextChanged(object sender, EventArgs e)
        {
            txtVerilenMiktar_TextChanged(null, null);
        }

        private void comboOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

    
        

       

     



       

        


    }

}

