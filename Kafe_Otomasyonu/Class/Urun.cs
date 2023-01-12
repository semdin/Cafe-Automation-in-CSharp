using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semdin_Kafe_Otomasyonu
{
    class Urun
    {
        public static bool urunEkle(object adi, object fiyati, object grupNo, object resimYolu)
        {
            Veritabani.baglantiKontrol();

            try
            {
                OleDbCommand cmd = new OleDbCommand("insert into Urun (Adi,Fiyati,UrunGrupNo,ResimYolu) values (@adi,@fiyati,@urungrupno,@resimyolu)", Veritabani.con);
                cmd.Parameters.Add("@adi", OleDbType.VarWChar).Value = adi;
                cmd.Parameters.Add("@fiyati", OleDbType.Currency).Value = fiyati;
                cmd.Parameters.Add("@urungrupno", OleDbType.Integer).Value = grupNo;
                cmd.Parameters.Add("@resimyolu", OleDbType.VarWChar).Value = resimYolu;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool urunDuzenle(object urunNo, object resimYolu, object fiyat, object grupNo, object urunAdi)
        {
            Veritabani.baglantiKontrol();

            try
            {
                OleDbCommand cmd = new OleDbCommand("update Urun set ResimYolu=@resimyolu, Fiyati=@fiyati, UrunGrupNo=@urungrupno, Adi=@adi  where UrunNo=@urunno", Veritabani.con);
                cmd.Parameters.Add("@resimyolu", OleDbType.VarWChar).Value = resimYolu;
                cmd.Parameters.Add("@fiyati", OleDbType.Currency).Value = fiyat;
                cmd.Parameters.Add("@urungrupno", OleDbType.Integer).Value = grupNo;
                cmd.Parameters.Add("@adi", OleDbType.VarWChar).Value = urunAdi;
                cmd.Parameters.Add("@urunno", OleDbType.Integer).Value = urunNo;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool urunDuzenle(object UrunNo, bool SilinmisMi)
        {
            Veritabani.baglantiKontrol();

            try
            {
                OleDbCommand cmd = new OleDbCommand("update Urun set SilinmisMi=@SilinmisMi where UrunNo=@UrunNo", Veritabani.con);
                cmd.Parameters.Add("@SilinmisMi", OleDbType.Boolean).Value = SilinmisMi;
                cmd.Parameters.Add("@UrunNo", OleDbType.Integer).Value = UrunNo;
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
