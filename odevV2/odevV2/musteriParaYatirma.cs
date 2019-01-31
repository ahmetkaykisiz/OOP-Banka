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
    public partial class musteriParaYatirma : Form
    {
        public Banka banka;
        public musteriParaYatirma()
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
            int musteriNo = Convert.ToInt32(textBox3.Text);
            int hesapNo = Convert.ToInt32(textBox1.Text);
            double miktar = Convert.ToInt32(textBox2.Text);

            Musteri musteri = banka.musteriBul(musteriNo);
            if (musteri != null)
            {
                Hesap hesap = musteri.hesapBul(hesapNo);
                if (hesap != null)
                {

                    if (hesap.ekBakiye < 300)
                    {
                        if (miktar > 300)
                        {
                            miktar -= hesap.ekBakiye;
                            hesap.ekBakiye = 0;
                            }
                        else
                        { hesap.ekBakiye -= miktar; }
                        miktar -= hesap.ekBakiye;
                        hesap.bakiye += miktar;

                    }
                    else
                    { hesap.bakiye += miktar; }
                    
                    Islem islem = new Islem();
                    islem.islemYapan = hesap;
                    islem.islemYapilan = hesap;
                    islem.paraMiktarı = miktar;
                    islem.islemTipi = Islem.IslemTipi.paraYatirma;
                    banka.islemler.Add(islem);
                    MessageBox.Show("Para Başarıyla Yatırıldı");
                   label5.Text= hesap.bakiye.ToString();

                }
                else {
                    MessageBox.Show("Hesap Bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Müşteri Bulunamadı");
            }
        }
    }
}
