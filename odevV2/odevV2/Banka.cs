using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevV2
{
    public abstract class BankaAbstract
    {
        public List<Musteri> musteriler { get; set; }
        public List<Islem> islemler { get; set; }
        public String Rapor { get; set; }
        public Double ToplamBakiye { get; set; }
        public Double Havale { get; set; }
        public Double Yatırılan { get; set; }
        public Double Cekilen { get; set; }

        public String name { get; set; }
        public abstract Musteri musteriBul(int musteriNo);
        public abstract List<Islem> islemleriBul(int hesap);
        // olmassa burdan devam
        
    }
    public class Banka:BankaAbstract
    {
        public List<Musteri> musteriler = new List<Musteri>();
        public List<Islem> islemler = new List<Islem>();
        public override Musteri musteriBul(int musteriNo)
        {
            foreach (Musteri item in musteriler)
            {
                if(item.musteriNo == musteriNo){
                    return item;
                }
            }
            return null;
        }

        public override List<Islem> islemleriBul(int hesap)
        {
            List<Islem> return_islemler = new List<Islem>();
            foreach (Islem item in islemler)
            {
                if (item.islemYapan.hesapNo == hesap || item.islemYapilan.hesapNo == hesap )
                {
                    return_islemler.Add(item);
                }
            }
            return return_islemler;
        }

        
        }
    }

