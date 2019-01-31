using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevV2
{
   public abstract class HesapAbstract
    {
        public int hesapNo { get; set; }
        public Double bakiye { get; set; }
        public DateTime kayitTarihi { get; set; }
        public double ekBakiye { get; set; }


        public List<Islem> HesapOzeti
        {
            get;
        }

    }

    public class Hesap : HesapAbstract
    {
        public Hesap() {
            bakiye = 0;
            ekBakiye = 300;
            kayitTarihi = DateTime.Now;
            
            //Müşteri No için random sayı aldığım kısım
            Random rastgele = new Random();
            int sayi = rastgele.Next(1,10);
            hesapNo = sayi;
        }

        public override string ToString()
        {
            return hesapNo.ToString();
        }


    }
}
