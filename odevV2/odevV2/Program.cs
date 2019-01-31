using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevV2
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Banka banka = new Banka();
            banka.name = "Ziraat Bank";
            Form1 form = new Form1();

            form.banka = banka;
            Application.Run(form);
        }
    }
}
