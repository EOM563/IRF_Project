using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRF_Projekt_UF27ER.Entities;

namespace IRF_Projekt_UF27ER.Entities
{
    public partial class KatUserControl : UserControl
    {
        public string UCK_kat { get; set; }

        List<AruButton> aruButton_lista = new List<AruButton>();
        List<Aru> aru_lista;

        //button alap koordináták
        private int b_x = 139;
        private int b_y = 3;

        //label alap koordináták
        private int l_x = 141;
        private int l_y = 46;

        public KatUserControl(List<Aru> keszlet_lista)
        {
            InitializeComponent();

            this.aru_lista = keszlet_lista;
        }

        private void KatUserControl_Load(object sender, EventArgs e)
        {                      
            //Kategróia button
            KatButton katButton = new KatButton(aruButton_lista);
            katButton.Kat = UCK_kat;
            Controls.Add(katButton);

            //Termék button és data label generálás

            foreach (Aru sor in aru_lista)
            {
                if (sor.Kategoria == UCK_kat)
                {
                    //Button
                    AruButton aruButton = new AruButton(sor);
                    aruButton.Marka = sor.Marka;
                    aruButton.Location = new Point(b_x, b_y);
                    b_x = b_x + 181;

                    aruButton_lista.Add(aruButton);
                    Controls.Add(aruButton);

                    //Label-ek
                    Label keszletErtekLb = new Label();
                    Label keszletDbLb = new Label();
                    Label egysegArLb = new Label();
                    Label rendelesLb = new Label();
                    LabelGeneralas(sor, keszletErtekLb, keszletDbLb, egysegArLb, rendelesLb);

                    if (l_y > 106) l_y = 46;
                    l_x = l_x + 181;
                }
            }       
        }

        private void LabelGeneralas(Aru sor, Label keszletErtek, Label keszletDb, Label egysegAr, Label rendeles)
        {
            //keszlet labelek
            if (sor.Keszlet_db == 0)
            {
                keszletErtek.Text = "Készlet érték: 0 Ft";
                pozAdd(l_x, l_y, keszletErtek);
                keszletDb.Text = "Készlet: 0 db";
                pozAdd(l_x, l_y, keszletDb);
            }
            else
            {
                keszletErtek.Text = "Készlet érték: " + (sor.KeszletErtek).ToString() + " Ft";
                pozAdd(l_x, l_y, keszletErtek);
                keszletDb.Text = "Készlet: " + (sor.Keszlet_db).ToString() + " db";
                pozAdd(l_x, l_y, keszletDb);
            }

            //egységár label
            egysegAr.Text = "Egységár: " + (sor.Egysegar_ft).ToString() + " Ft";
            pozAdd(l_x, l_y, egysegAr);

            //rendelés label
            if (sor.Keszlet_db <= 20)
            {
                rendeles.Text = "Alacsony készlet, rendelni kell";
                rendeles.BackColor = Color.Red;
                pozAdd(l_x, l_y, rendeles);
            }
            else if (sor.Keszlet_db > 20 && sor.Keszlet_db < 60)
            {
                rendeles.Text = "Alacsony készlet";
                rendeles.BackColor = Color.Yellow;
                pozAdd(l_x, l_y, rendeles);
            }
            else if (sor.Keszlet_db > 60)
            {
                rendeles.Text = "Készleten";
                rendeles.BackColor = Color.Green;
                pozAdd(l_x, l_y, rendeles);
            }
            else
            {
                rendeles.Text = "Nincs készleten, rendelni kell";
                rendeles.BackColor = Color.Red;
                pozAdd(l_x, l_y, rendeles);
            }
        }


        //label pozíció állítás és felhelyezés
        private void pozAdd(int x, int y, Label dataLabel)
        {
            dataLabel.Location = new Point(x, y);
            dataLabel.Height = 15;
            dataLabel.Width = 174;
            Controls.Add(dataLabel);
            l_y = l_y + 20;
        }
    }
}
