using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevV2
{
    public partial class musteriHavale : Form
    {
        public Banka banka;
        public Musteri musteri;
        public musteriHavale()
        {
            InitializeComponent();
        }

        private void paraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriParaCekme cek = new musteriParaCekme();
            cek.banka = banka;
            this.Hide();
            cek.Show();
        }

        private void paraYatırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriParaYatirma yatir = new musteriParaYatirma();
            yatir.banka = banka;
            this.Hide();
            yatir.Show();
        }

        private void havaleYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriHavale havale = new musteriHavale();
            havale.banka = banka;
            this.Hide();
            havale.Show();
        }

        private void hesapÖzetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriHesapOzet ozet = new musteriHesapOzet();
            ozet.banka = banka;
            this.Hide();
            ozet.Show();
        }

        private void hesapKapamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriHesapKapama kapa = new musteriHesapKapama();
            kapa.banka = banka;
            this.Hide();
            kapa.Show();
        }

        private void hesapAçmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriHesapAc ac = new musteriHesapAc();
            ac.banka = banka;
            this.Hide();
            ac.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.banka = banka;
            this.Hide();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  anaHesap = Convert.ToInt32(textBox1.Text);
            int hedefHesapNo = Convert.ToInt32(textBox2.Text);

            int tutar = Convert.ToInt32(textBox3.Text);
            int anaMusteriNo= Convert.ToInt32(textBox4.Text);

            int hedefMusteriNo= Convert.ToInt32(textBox5.Text);

            // Gönderici Hesabı bulma Step 1
            musteri = banka.musteriBul(anaMusteriNo);
            if (musteri != null)
            {
                Hesap hesap = musteri.hesapBul(anaHesap);
                //double anaHesapPara = hesap.bakiye;
                if (hesap != null){
                    double total_musteri_tutar = tutar;
                    if (musteri.bireyselMusteri == true)
                    {
                        total_musteri_tutar = tutar * 1.02;
                    }
                    if (hesap.bakiye >= total_musteri_tutar)
                    {
                        Musteri hedefMusteri = banka.musteriBul(hedefMusteriNo);
                        if (hedefMusteri != null)
                        {
                            if (hesap != null)
                            {
                                Hesap hedefHesap = musteri.hesapBul(hedefHesapNo);
                                hedefHesap.bakiye += tutar;
                                hesap.bakiye -= total_musteri_tutar;
                                Islem islem = new Islem();
                                islem.islemYapan = hesap;
                                islem.islemYapilan = hedefHesap;
                                islem.paraMiktarı = tutar;
                                islem.bankaKomisyon = total_musteri_tutar - tutar;
                                islem.islemTipi = Islem.IslemTipi.havale;
                                banka.islemler.Add(islem);
                                MessageBox.Show("Havale Yapıldı");
                            }
                            else
                                MessageBox.Show("Alıcı Hesabı Bulunamadı");
                        }
                        else
                            MessageBox.Show("Alıcı Bulunamadı");
                    }
                    else
                        MessageBox.Show("Para yetersiz");
                }
                else
                    MessageBox.Show("Hesap Bulunamadı");

            }
            else
                MessageBox.Show("Gönderici Bulunamadı");

            //Hedef Hesabı bulma Step 2


        }
    }
}
