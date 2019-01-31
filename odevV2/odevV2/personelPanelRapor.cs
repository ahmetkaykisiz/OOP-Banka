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
    public partial class personelPanelRapor : Form
    {
        public Banka banka;
        public Musteri musteri;
        public personelPanelRapor()
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

        private void personelPanelRapor_Load(object sender, EventArgs e)
        {
           
           
        }
    }
}
