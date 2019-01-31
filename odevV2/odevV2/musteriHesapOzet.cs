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
    public partial class musteriHesapOzet : Form
    {
        public Banka banka;
        public Musteri musteri;
        public musteriHesapOzet()
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          int  hesapNo = Convert.ToInt32(textBox1.Text);
            List<Islem> islemler = banka.islemleriBul(hesapNo);
            listBox1.Items.Add(islemler);
            listBox1.DataSource = banka.islemler;
            //listBox1.DisplayMember ="ad";
            listBox1.ValueMember = "islemYapan";
            listBox2.Items.Add(islemler);
            listBox2.DataSource = banka.islemler;
            listBox2.ValueMember = "islemYapilan";

            listBox3.Items.Add(islemler);
            listBox3.DataSource = banka.islemler;
            listBox3.ValueMember = "islemTipi";

            listBox4.Items.Add(islemler);
            listBox4.DataSource = banka.islemler;
            listBox4.ValueMember = "paraMiktarı";
        }
    }
}
