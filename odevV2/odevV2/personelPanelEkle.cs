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
    public partial class personelPanelEkle : Form
    {
        public Banka banka;
        public personelPanelEkle()
        {
            InitializeComponent();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelPanelEkle ekle = new personelPanelEkle();
            ekle.banka = banka;
            this.Hide();
            ekle.Show();
        }

        private void hesapAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelPanelAc ac = new personelPanelAc();
            ac.banka = banka;
            this.Hide();
            ac.Show();
        }

        private void gelirGiderRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelPanelRapor rapor = new personelPanelRapor();
            rapor.banka = banka;
            this.Hide();
            rapor.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.banka = banka;
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.ad = textBox1.Text;
            musteri.soyad = textBox2.Text;
            musteri.tcNo = textBox3.Text;
            if ("Bireysel" == comboBox1.Text)
                musteri.bireyselMusteri = true;
            else
                musteri.bireyselMusteri = false;
            musteri.kayitTarihi = DateTime.Now;

            banka.musteriler.Add(musteri);
            MessageBox.Show("Müsteri Eklendi");
            //Console.WriteLine(banka.musteriler);
            
            listBox1.DataSource = banka.musteriler;
            //listBox1.DisplayMember ="ad";
            listBox1.ValueMember = "musteriNo";

        }
    }
}
