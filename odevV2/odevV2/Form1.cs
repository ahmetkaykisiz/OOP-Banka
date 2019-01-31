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
    public partial class Form1 : Form
    {
        public Banka banka;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriPanel frm2 = new musteriPanel();
            frm2.banka = banka;
            this.Hide();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personelPanel frm3 = new personelPanel();
            frm3.banka = banka;
            this.Hide();
            frm3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
