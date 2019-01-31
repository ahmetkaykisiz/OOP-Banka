﻿using System;
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
    public partial class musteriParaCekme : Form
    {
        public Banka banka;
        public musteriParaCekme()
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
            int musteriNo = Convert.ToInt32(textBox1.Text);
            int hesapNo = Convert.ToInt32(textBox2.Text);
            int miktar = Convert.ToInt32(textBox3.Text);

            Musteri musteri = banka.musteriBul(musteriNo);
            if (musteri != null)
            {
                Hesap hesap = musteri.hesapBul(hesapNo);
                if (hesap != null)
                {
                    if (hesap.bakiye < miktar)
                    { 
                        double totalHak = hesap.bakiye + hesap.ekBakiye;
                        double fark = totalHak - miktar;
                        if (fark >= 0) { // todo max tutar girişi 
                            hesap.ekBakiye -= (miktar - hesap.bakiye);
                            hesap.bakiye = 0;
                            MessageBox.Show("Para Başarıyla Çekildi");
                            Islem islem = new Islem();
                            islem.islemYapan = hesap;
                            islem.islemYapilan = hesap;
                            islem.paraMiktarı = miktar;
                            islem.islemTipi = Islem.IslemTipi.paraCekme;
                            banka.islemler.Add(islem);
                        }
                       else { MessageBox.Show("Krediniz Yetmiyor");}
                    }
                    else
                    {
                        hesap.bakiye -= miktar;
                        MessageBox.Show("Para Başarıyla Çekildi");
                    }
                    
                    
                }
                else
                {
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
