using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevV2
{
  public abstract  class MusteriAbstract
    {
        public int musteriNo { get; set; }
        public Boolean bireyselMusteri { get; set; }
        public String ad { get; set; }
        public String soyad { get; set; }
        public String tcNo { get; set; }
        public DateTime kayitTarihi { get; set; }
        public List<Hesap> hesaplar { get; set; }

        abstract public String ParaCekme();

        abstract public String ParaYatırma();  

        abstract public String Havale();

        abstract public String HesapAc();

        abstract public String HesapSil(String hesap_no);

        public abstract Hesap hesapBul(int HesapNo);

    }
    public class Musteri : MusteriAbstract
    {
        public List<Hesap> hesaplar = new List<Hesap>();
        public Musteri()
        {
            kayitTarihi = DateTime.Now;
            hesaplar = new List<Hesap>();
            //Müşteri No için random sayı aldığım kısım
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 10);

            musteriNo = sayi;

        }
        public override string ParaCekme()
        {
            throw new NotImplementedException();
        }
        public override string ParaYatırma()
        {
            throw new NotImplementedException();
        }
        public override string Havale()
        {
            throw new NotImplementedException();
        }
        public override string HesapAc()
        {
            throw new NotImplementedException();
        }
        public override String HesapSil(string hesap_no)
        {
            int hesap_No = Convert.ToInt32(hesap_no);
            Hesap hesap = hesapBul(hesap_No);
            if (hesap.bakiye == 0 && hesap.ekBakiye == 300)
            {
                hesaplar.Remove(hesap);
                return "HEsap Silindi!";
            }
            else
                return "Hesap Bakiyesi Uygun Değil!";  
            }

        public override Hesap hesapBul(int HesapNo)
        {
            foreach (Hesap item in hesaplar)
            {
                if (item.hesapNo == HesapNo)
                { return item; }
            }
            return null;

        }






    }

}
