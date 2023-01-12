using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semdin_Kafe_Otomasyonu
{
    class kontroller
    {
        public static void txtSayiKontrol(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;

            }
        }

        public static void txtParaKontrol(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
            
        }

        public static bool kullaniciKontrolu(string kulAdi, string sifre)
        {

           Veritabani.baglantiKontrol();
            OleDbCommand cmd = new OleDbCommand("select KullaniciNo from Kullanici where KullaniciAdi=@kuladi and Sifre=@sifre", Veritabani.con);
            cmd.Parameters.Add("@kuladi", OleDbType.VarWChar).Value = kulAdi;
            cmd.Parameters.Add("@sifre", OleDbType.VarWChar).Value = sifre;
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool veriVarmi(string sql)
        {
            Veritabani.baglantiKontrol();
            OleDbCommand cmd = new OleDbCommand(sql, Veritabani.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
