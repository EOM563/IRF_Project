using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace IRF_Projekt_UF27ER.Entities
{
    class AlKatButton : Button
    {
        private string _hatterSzin;
        private bool _alKatActive;
        public string AlKat { get; set; }

        public string HatterSzin
        {
            get { return _hatterSzin; }
            set
            {
                if (value == "Milka")
                {
                    ForeColor = Color.FromArgb(255,255,255);
                    BackColor = Color.FromArgb(104,79,163);
                    _hatterSzin = "104,79,163";
                }
                else if (value == "Boci")
                {
                    ForeColor = Color.FromArgb(255, 255, 255);
                    BackColor = Color.FromArgb(0, 204, 0);
                    _hatterSzin = "0, 204, 0";
                }
                else if (value == "Tibi")
                {
                    ForeColor = Color.FromArgb(255, 255, 255);
                    BackColor = Color.FromArgb(51, 51, 255);
                    _hatterSzin = "51,51,255";
                }
                else if (value == "Valdor")
                {
                    ForeColor = Color.FromArgb(255, 255, 255);
                    BackColor = Color.FromArgb(153, 0, 76);
                    _hatterSzin = "153, 0, 76";
                }
                else if (value == "Pote")
                {
                    ForeColor = Color.FromArgb(255, 255, 255);
                    BackColor = Color.FromArgb(104, 79, 163);
                    _hatterSzin = "104,79,163";
                }
                else
                {
                    Random ran = new Random();
                    int r = ran.Next(100, 255);
                    int g = ran.Next(100, 255);
                    int b = ran.Next(100, 255);
                    BackColor = Color.FromArgb(r, g, b);
                    _hatterSzin = r.ToString() + "," + g.ToString() + "," + b.ToString();
                }
            }
        }

        public bool AlKatActive
        {
            get { return _alKatActive; }
            set
            {
                _alKatActive = value;
                if (_alKatActive == true)
                {
                    Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Bold);
                    FlatStyle = FlatStyle.Flat;
                    FlatAppearance.BorderColor = Color.Black;
                    FlatAppearance.BorderSize = 2;
                }
                else
                {
                    Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular);
                    FlatStyle = FlatStyle.Flat;
                    FlatAppearance.BorderColor = SystemColors.AppWorkspace;
                    FlatAppearance.BorderSize = 2;
                }
            }
        }

        public AlKatButton()
        {
            Height = 35;
            Width = 175;
            Location = new Point(3, 3);
            MouseDown += KatButton_MouseDown;
        }

        private void KatButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (AlKatActive == true)
            {
                AlKatActive = false;
            }
            else
            {
                AlKatActive = true;
            }
        }
    }
}
