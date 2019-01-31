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
    public partial class musteriHesapKapama : Form
    {
        public Banka banka;
        public Musteri musteri;
        public musteriHesapKapama()
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

        private void musteriHesapKapama_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int musteriNo = Convert.ToInt32(textBox1.Text);
            musteri = banka.musteriBul(musteriNo);
            if (musteri != null)
            {
                listBox1.DataSource = musteri.hesaplar;
                listBox1.ValueMember = "hesapNo";
                listBox1.DisplayMember = "hesapNo";
            }
            else
                MessageBox.Show("musteri bulunamadı!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String hesap_no = listBox1.SelectedItem.ToString();
            
            MessageBox.Show(musteri.HesapSil(hesap_no));
            listBox1.DataSource = musteri.hesaplar;
            listBox1.ValueMember = "hesapNo";
            listBox1.DisplayMember = "hesapNo";
        }
    }
}
