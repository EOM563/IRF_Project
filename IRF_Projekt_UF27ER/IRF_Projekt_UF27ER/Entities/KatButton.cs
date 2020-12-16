using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using IRF_Projekt_UF27ER.Entities;

namespace IRF_Projekt_UF27ER.Entities
{
    public class KatButton : Button
    {
        private bool _katActive = false;
        private string _kat;
        List<AruButton> aruButton_lista;

        //Kategória
        public string Kat 
        { 
            get { return _kat; }
            set 
            {
                _kat = value;
                Text = _kat;

                //szín állítás kat alapján
                if (value == "Csokoládé")
                {
                    ForeColor = Color.FromArgb(51, 25, 0);
                }
                else if (value == "Bögre")
                {
                    ForeColor = Color.FromArgb(0, 0, 102);
                }
                else if (value == "Képeslap")
                {
                    ForeColor = Color.FromArgb(102, 0, 0);
                }
                else
                {
                    Random ran = new Random();
                    int r = ran.Next(0, 156);
                    int g = ran.Next(0, 156);
                    int b = ran.Next(0, 156);
                    ForeColor = Color.FromArgb(r, g, b);
                }
            } 
        }        

        //button aktivitás vizsgálat
        public bool katActive
        {
            get { return _katActive; }
            set
            {
                _katActive = value;
                if (_katActive == true)
                {
                    Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
                    FlatStyle = FlatStyle.Flat;
                    FlatAppearance.BorderColor = Color.Black;
                    FlatAppearance.BorderSize = 2;
                    BackColor = SystemColors.ControlDark;

                    for (int i = 0; i < aruButton_lista.Count; i++)
                    {
                        aruButton_lista[i].AruActive = true;
                        aruButton_lista[i].Enabled = false;
                    }
                }
                else
                {
                    NormalFormazas();
                    for (int i = 0; i < aruButton_lista.Count; i++)
                    {
                        aruButton_lista[i].AruActive = false;
                        aruButton_lista[i].Enabled = true;
                    }
                }
            }
        }

        public KatButton(List<AruButton> aruButton_lista)
        {
            this.aruButton_lista = aruButton_lista;

            Height = 120;
            Width = 130;
            Text = Kat;
            Location = new Point(3, 3);
            NormalFormazas();

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

        private void NormalFormazas()
        {
            Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            FlatAppearance.BorderSize = 1;
            BackColor = SystemColors.ControlLight;
        }
    }

}
