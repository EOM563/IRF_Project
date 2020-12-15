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
        List<aruk> keszlet_lista = new List<aruk>();
        public MainForm()
        {
            InitializeComponent();

            data_download();
        }

        private void data_download()
        {
            var res = from i in context.Raktars
                      orderby i.Kategoria, i.Marka, i.Termek_nev descending
                      select i;

            foreach (var i in res)
            {
                aruk keszlet_sor = new aruk();
                keszlet_sor.ID = Convert.ToInt32(i.ID);
                keszlet_sor.Termek = i.Termek.ToString();
                keszlet_sor.Keszlet_db = Convert.ToInt32(i.keszlet_db);
                keszlet_sor.Egysegar_ft = Convert.ToInt32(i.Egysegar_ft);
                keszlet_sor.Kategoria = i.Kategoria.ToString();
                keszlet_sor.Marka = i.Marka.ToString();
                keszlet_sor.Termek_nev = i.Termek_nev.ToString();
                keszlet_lista.Add(keszlet_sor);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
