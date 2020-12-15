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

        List<AruButton> AlKatButton_lista = new List<AruButton>();
        List<Aru> keszlet_lista;
      
        public KatUserControl(List<Aru> keszlet_lista)
        {
            InitializeComponent();

            this.keszlet_lista = keszlet_lista;
        }

        private void KatUserControl_Load(object sender, EventArgs e)
        {                      
            //Kategróia button
            KatButton katButton = new KatButton(keszlet_lista);
            katButton.Kat = UCK_kat;
            Controls.Add(katButton);

            //Termék button generálás
            int x = 139;
            int y = 3;

            foreach (Aru sor in keszlet_lista)
            {
                if (sor.Kategoria == UCK_kat)
                {
                    AruButton aruButton = new AruButton(sor);
                    aruButton.Marka = sor.Marka;       
                    aruButton.Location = new Point(x, y);
                    Controls.Add(aruButton);
                    x = x + 181;
                }
            }       



        }
    }
}
