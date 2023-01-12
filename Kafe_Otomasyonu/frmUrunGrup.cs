using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semdin_Kafe_Otomasyonu
{
    public partial class frmUrunGrup : Form
    {
        public frmUrunGrup()
        {
            InitializeComponent();
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
          
            if (txtAdi.Text == "")
            {
                MessageBox.Show("Ürün Adını Boş Bırakmayınız!");
            }
            else
            {
                if (kontroller.veriVarmi("select Adi from UrunGrubu where Adi='"+txtAdi.Text+"'"))
                {
                    lblBildirim.Text = "Böyle bir grup vardır.";
                }
                else
                {
                    if (Grup.grupEkle(txtAdi.Text))
                    {
                        txtAdi.Clear();
                        lblBildirim.ForeColor = Color.Green;
                        lblBildirim.Text = "Grup Oluşturuldu.";
                    }
                    else
                    {
                        txtAdi.Clear();
                        lblBildirim.ForeColor = Color.Red;
                        lblBildirim.Text = "Grup Oluştururken Hata Meydana Geldi.";
                    }
                }
                
            }

            
        }
        object comboValue;
        private void comboDoldur()
        {
            DataTable dt = Veritabani.VeriGetir("select * from UrunGrubu");
            comboGruplar.DataSource = dt;
            comboGruplar.DisplayMember = "Adi";
            comboGruplar.ValueMember = "UrunGrupNo";
            comboValue = comboGruplar.SelectedValue;
        }
        
        private void frmUrunGrup_Load(object sender, EventArgs e)
        {
            
            comboDoldur();
        }


      
        private void comboGruplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboValue = comboGruplar.SelectedValue;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (comboGruplar.Text==""||txtDuzenlenenAd.Text=="")
            {
                if (txtDuzenlenenAd.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Bırakmayınız!");
                }
                if (comboGruplar.Text=="")
                {
                    MessageBox.Show("Lütfen Grup Seçiniz.");
                }
            }
            else
            {
                if (kontroller.veriVarmi("select Adi from UrunGrubu where Adi='" + txtDuzenlenenAd.Text + "'"))
                {
                    lblBildirim.Text = "Böyle bir grup vardır.";
                }
                else
                {
                    if (Grup.grupDuzenle(comboValue, txtDuzenlenenAd.Text))
                    {
                        txtDuzenlenenAd.Clear();
                        lblBildirim.ForeColor = Color.Green;
                        lblBildirim.Text = "Grup Başarılıyla Düzenlenmiştir.";
                    }
                    else
                    {
                        txtDuzenlenenAd.Clear();
                        lblBildirim.ForeColor = Color.Green;
                        lblBildirim.Text = "Grup Düzenlenirken Hata Meydana Geldi.";
                    }
                }
                
            }
            

            
        }

        private void comboGruplar_Click(object sender, EventArgs e)
        {
            comboDoldur();
        }
    }
}
