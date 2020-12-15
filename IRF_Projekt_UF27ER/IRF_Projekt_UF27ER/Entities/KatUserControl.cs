using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Projekt_UF27ER.Entities
{
    public partial class KatUserControl : UserControl
    {
        public string UCKKat { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public KatUserControl()
        {
            InitializeComponent();
        }

        private void KatUserControl_Load(object sender, EventArgs e)
        {
            Location = new Point(PosX,PosY);
        }
    }
}
