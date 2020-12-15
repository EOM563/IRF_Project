using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace IRF_Projekt_UF27ER.Entities
{
    class KatButton : Button
    {
        private string _betuSzin;
        private bool _katActive = false;
        public string Kat { get; set; }

        public string BetuSzin
        {
            get { return _betuSzin; }
            set
            {
                if (value == "Csokoládé")
                {
                    ForeColor = Color.FromArgb(51,25,0);
                    _betuSzin = "51,25,0";
                }
                else if (value == "Bögre")
                {
                    ForeColor = Color.FromArgb(0,0,102);
                    _betuSzin = "0,0,102";
                }
                else if (value == "Képeslap")
                {
                    ForeColor = Color.FromArgb(102,0,0);
                    _betuSzin = "102,0,0";
                }
                else
                {
                    Random ran = new Random();
                    int r = ran.Next(0, 156);
                    int g = ran.Next(0, 156);
                    int b = ran.Next(0, 156);
                    ForeColor = Color.FromArgb(r,g,b);
                    _betuSzin = r.ToString() + "," + g.ToString() + "," + b.ToString();
                }
            }
        }

        public bool katActive
        {
            get { return _katActive; }
            set
            {
                _katActive = value;
                if (_katActive == true)
                {
                    Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                    FlatStyle = FlatStyle.Flat;
                    FlatAppearance.BorderColor = Color.Black;
                    FlatAppearance.BorderSize = 2;
                    BackColor = SystemColors.ControlDark;
                }
                else
                {
                    Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
                    FlatStyle = FlatStyle.Flat;
                    FlatAppearance.BorderColor = SystemColors.AppWorkspace;
                    FlatAppearance.BorderSize = 2;
                    BackColor = SystemColors.Control;
                }
            }
        }

        public KatButton()
        {
            Height = 100;
            Width = 130;
            //Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            Location = new Point(3, 3);
            MouseDown += KatButton_MouseDown;
        }

        private void KatButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (katActive == true)
            {
                katActive = false;
            }
            else
            {
                katActive = true;
            }
        }
    }

}
