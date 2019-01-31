using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevV2
{
    public abstract class IslemAbstract
    {
       public enum IslemTipi
        {
            paraYatirma = 1,
            paraCekme = 2,
            havale = 3,
        }
        public IslemTipi islemTipi { get; set; }
        
        public Hesap islemYapan { get; set; }
        public Hesap islemYapilan { get; set; }
        public Double paraMiktarı { get; set; }
        public Double bankaKomisyon { get; set; }
        public DateTime islemTarihi { get; set; }

       
    }
    public class Islem:IslemAbstract
    {
            Double  bankaKomisyon=0.0;
    }
}
