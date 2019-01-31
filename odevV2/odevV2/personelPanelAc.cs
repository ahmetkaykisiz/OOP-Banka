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
    public partial class personelPanelAc : Form
    {
        public Banka banka;
        public personelPanelAc()
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
            int musteriNo = Convert.ToInt32(textBox1.Text);
            Musteri musteri = banka.musteriBul(musteriNo);

            if (musteri!= null)
            {
                Hesap hesap = new Hesap();
                musteri.hesaplar.Add(hesap);

                MessageBox.Show(hesap.hesapNo.ToString());
            }
            
        }
    }
}
