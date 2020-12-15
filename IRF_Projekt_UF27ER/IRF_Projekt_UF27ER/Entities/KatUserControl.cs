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
        public string UCKKat { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public KatUserControl(List<aruk> keszlet_lista)
        {
            InitializeComponent();
        }

        private void KatUserControl_Load(object sender, EventArgs e)
        {
            Location = new Point(PosX,PosY);

            /*KatButton katButton = new KatButton();
            katButton.Kat = UCKKat;
            Controls.Add(katButton);*/

            katButton.Kat = UCKKat;
        }
    }
}
