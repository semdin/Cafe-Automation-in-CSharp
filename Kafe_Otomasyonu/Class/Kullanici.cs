using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semdin_Kafe_Otomasyonu
{
    class Kullanici
    {
        public static bool KullaniciEkle(object KullaniciAdi, object Sifre, object Adi, object Soyadi)
        {
            Veritabani.baglantiKontrol();
            try
            {
                OleDbCommand cmd = new OleDbCommand("insert into Kullanici (KullaniciAdi,Sifre,Adi,Soyadi) values (@KullaniciAdi,@Sifre,@Adi,@Soyadi)", Veritabani.con);
                cmd.Parameters.Add("@KullaniciAdi", OleDbType.VarWChar).Value = KullaniciAdi;
                cmd.Parameters.Add("@Sifre", OleDbType.VarWChar).Value = Sifre;
                cmd.Parameters.Add("@Adi", OleDbType.VarWChar).Value = Adi;
                cmd.Parameters.Add("@Soyadi", OleDbType.VarWChar).Value = Soyadi;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool KullaniciSifreDegistir(object KullaniciAdi, object Sifre)
        {
            Veritabani.baglantiKontrol();
            try
            {
                OleDbCommand cmd = new OleDbCommand("update Kullanici set Sifre=@Sifre where KullaniciAdi=@KullaniciAdi", Veritabani.con);               
                cmd.Parameters.Add("@Sifre", OleDbType.VarWChar).Value = Sifre;
                cmd.Parameters.Add("@KullaniciAdi", OleDbType.VarWChar).Value = KullaniciAdi;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
