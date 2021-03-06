﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using IRF_Projekt_UF27ER.Entities;

namespace IRF_Projekt_UF27ER.Entities
{
    public class AruButton : Button
    {
        private string _marka;
        private bool _aruActive;

        //Márka
        public string Marka 
        {
            get { return _marka; }
            set
            {
                _marka = value;

                //szín állítás márka alapján
                if (value == "Milka")
                {
                    ForeColor = Color.FromArgb(255, 255, 255);
                    BackColor = Color.FromArgb(104, 79, 163);
                }
                else if (value == "Boci")
                {
                    ForeColor = Color.FromArgb(255, 255, 255);
                    BackColor = Color.Green;
                }
                else if (value == "Tibi")
                {
                    ForeColor = Color.FromArgb(255, 255, 255);
                    BackColor = Color.DarkBlue;
                }
                else if (value == "Valdor")
                {
                    ForeColor = Color.FromArgb(255, 255, 255);
                    BackColor = Color.FromArgb(153, 0, 76);
                }
                else if (value == "Pote")
                {
                    ForeColor = Color.FromArgb(255, 255, 255);
                    BackColor = Color.FromArgb(104, 79, 163);
                }
                else
                {
                    Random ran = new Random();
                    int r = ran.Next(100, 255);
                    int g = ran.Next(100, 255);
                    int b = ran.Next(100, 255);
                    BackColor = Color.FromArgb(r, g, b);
                }
            }
        }
        public bool AruActive
        {
            get { return _aruActive; }
            set
            {
                _aruActive = value;
                if (_aruActive == true)
                {
                    Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Bold);
                    FlatStyle = FlatStyle.Flat;
                    FlatAppearance.BorderColor = Color.Black;
                    FlatAppearance.BorderSize = 2;
                    aktualisAru.Kiirasra = true;
                }
                else
                {
                    NormalFormazas();
                    aktualisAru.Kiirasra = false;
                }
            }
        }

        Aru aktualisAru;
        public AruButton(Aru forrasAru)
        {
            Height = 38;
            Width = 175;
            Text = forrasAru.Marka + Environment.NewLine + forrasAru.Termek_nev;

            aktualisAru = forrasAru;
            NormalFormazas();
            MouseDown += KatButton_MouseDown;
        }

        private void KatButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (AruActive == true)
            {
                AruActive = false;
            }
            else
            {
                AruActive = true;
            }
        }

        private void NormalFormazas()
        {
            Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            FlatAppearance.BorderSize = 1;
        }
    }
}
