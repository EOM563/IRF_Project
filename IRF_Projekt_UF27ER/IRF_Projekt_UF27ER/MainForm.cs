using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRF_Projekt_UF27ER.Entities;

namespace IRF_Projekt_UF27ER
{
    public partial class MainForm : Form
    {
        bolt_dataEntities context = new bolt_dataEntities();       
        List<Aru> keszlet_lista = new List<Aru>();
        List<string> osszesKat = new List<string>();

        List<KatUserControl> KUC_lista = new List<KatUserControl>();

        public MainForm()
        {
            InitializeComponent();

            data_download();
            KUCgeneralas();
        }

        private void data_download()
        {
            var res = from i in context.Raktars
                      orderby i.Kategoria, i.Marka, i.Termek_nev descending
                      select i;

            foreach (var i in res)
            {
                Aru keszlet_sor = new Aru();
                keszlet_sor.ID = Convert.ToInt32(i.ID);
                keszlet_sor.Termek = i.Termek.ToString();
                keszlet_sor.Keszlet_db = Convert.ToInt32(i.keszlet_db);
                keszlet_sor.Egysegar_ft = Convert.ToInt32(i.Egysegar_ft);
                keszlet_sor.Kategoria = i.Kategoria.ToString();                
                keszlet_sor.Marka = i.Marka.ToString();
                keszlet_sor.Termek_nev = i.Termek_nev.ToString();
                keszlet_sor.Kiirasra = false;
                keszlet_lista.Add(keszlet_sor);

                if (osszesKat.Contains(i.Kategoria.ToString()) == false)
                {
                    osszesKat.Add(i.Kategoria.ToString());
                }
            }
        }

        private void KUCgeneralas()
        {
            int x = 12;
            int y = 8;
            for (int i = 0; i < osszesKat.Count(); i++)
            {                
                KatUserControl ujKUC = new KatUserControl(keszlet_lista);
                ujKUC.UCK_kat = osszesKat[i];
                ujKUC.Location = new Point(x, y);
                KUC_lista.Add(ujKUC);
                Controls.Add(ujKUC);
                y = y + 125;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
