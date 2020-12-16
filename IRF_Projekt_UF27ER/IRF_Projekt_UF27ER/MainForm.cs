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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace IRF_Projekt_UF27ER
{
    public partial class MainForm : Form
    {
        bolt_dataEntities context = new bolt_dataEntities();       
        List<Aru> keszlet_lista = new List<Aru>();
        List<string> osszesKat = new List<string>();

        List<KatUserControl> KUC_lista = new List<KatUserControl>();

        //Excel
        Excel.Application excelApp; 
        Excel.Workbook excelWorkbooks; 
        Excel.Worksheet excelActiveSheet;

        string[] fejlec_lista;
        object[,] keszlet_sorok;

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
                keszlet_sor.KeszletErtek = keszlet_sor.Egysegar_ft * keszlet_sor.Keszlet_db;
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
                y = y + 150;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateExcel()
        {
            try
            {
                excelApp = new Excel.Application();
                excelWorkbooks = excelApp.Workbooks.Add(Missing.Value);
                excelActiveSheet = excelWorkbooks.ActiveSheet;

                TablaLetrehozas();               
            }
            catch (Exception ex)
            {
                string error = string.Format("Error: " + ex.Message + "\n" + "Line:" + ex.Source);
                MessageBox.Show(error, "Error");

                excelWorkbooks.Close(false, Type.Missing, Type.Missing);
                excelApp.Quit();
                excelWorkbooks = null;
                excelApp = null;
            }
        }        

        private void TablaLetrehozas()
        {
            fejlec_lista = new string[]
            {
                 "ID",
                 "Termék",
                 "Készlet (db)",
                 "Egységár (Ft)",
                 "Kategória",
                 "Márka",
                 "Megnevezés",
                 "Készlet érték (Ft)",
                 "Elérhetőség"
            };

            for (int i = 0; i < fejlec_lista.Length; i++)
            {
                excelActiveSheet.Cells[1, (i + 1)] = fejlec_lista[i];
            }

            //kiírandó sorok száma
            int kiSorDb = 0;
            foreach (Aru v in keszlet_lista)
            {
                if (v.Kiirasra == true)
                {
                    kiSorDb++;
                }
            }

            keszlet_sorok = new object[kiSorDb, fejlec_lista.Length];

            int szamlalo = 0;
            foreach (Aru sor in keszlet_lista)
            {
                if (sor.Kiirasra == true)
                {
                    keszlet_sorok[szamlalo, 0] = sor.ID;
                    keszlet_sorok[szamlalo, 1] = sor.Termek;
                    keszlet_sorok[szamlalo, 2] = sor.Keszlet_db;
                    keszlet_sorok[szamlalo, 3] = sor.Egysegar_ft;
                    keszlet_sorok[szamlalo, 4] = sor.Kategoria;
                    keszlet_sorok[szamlalo, 5] = sor.Marka;
                    keszlet_sorok[szamlalo, 6] = sor.Termek_nev;
                    keszlet_sorok[szamlalo, 7] = sor.KeszletErtek;

                    if (sor.Keszlet_db <= 20)
                    {
                        keszlet_sorok[szamlalo, 8] = "Alacsony készlet, rendelni kell";
                    }
                    else if (sor.Keszlet_db > 20 && sor.Keszlet_db < 60)
                    {
                        keszlet_sorok[szamlalo, 8] = "Alacsony készlet";
                    }
                    else if (sor.Keszlet_db > 60)
                    {
                        keszlet_sorok[szamlalo, 8] = "Készleten";
                    }
                    else
                    {
                        keszlet_sorok[szamlalo, 8] = "Nincs készleten, rendelni kell";
                    }

                    szamlalo++;
                }                               
            }
            excelActiveSheet.get_Range(GetCell(2, 1), GetCell(1 + keszlet_sorok.GetLength(0), keszlet_sorok.GetLength(1))).Value2 = keszlet_sorok;
        }

        private void TablaFormazas()
        {
            Excel.Range fejlec = excelActiveSheet.get_Range(GetCell(1, 1), GetCell(1, fejlec_lista.Length));
            Excel.Range tabla = excelActiveSheet.get_Range(GetCell(1, 1), GetCell(1 + keszlet_sorok.GetLength(0), keszlet_sorok.GetLength(1)));
            Excel.Range idOszlop = excelActiveSheet.get_Range(GetCell(2, 1), GetCell(1 + keszlet_sorok.GetLength(0), 1));
            Excel.Range keszletErt = excelActiveSheet.get_Range(GetCell(2, keszlet_sorok.GetLength(1)-1), GetCell(1 + keszlet_sorok.GetLength(0), keszlet_sorok.GetLength(1)-1));
            Excel.Range termekOszlop = excelActiveSheet.get_Range(GetCell(2, 2), GetCell(1 + keszlet_sorok.GetLength(0), 1));

            //Borderek
            fejlec.Cells.Borders.Weight = Excel.XlBorderWeight.xlThin;
            tabla.Cells.Borders.Weight = Excel.XlBorderWeight.xlThin;
            tabla.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            //Cella formazas
            fejlec.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fejlec.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            
            fejlec.RowHeight = 20;
            fejlec.Font.Size = 14;
            fejlec.Font.Bold = true;
            idOszlop.Font.Bold = true;
            termekOszlop.Font.Italic = true;

            fejlec.Interior.Color = Color.LightGray;
            idOszlop.Interior.Color = Color.LightSlateGray;
            keszletErt.Interior.Color = Color.LightGreen;

            keszletErt.NumberFormat = "#\\ ##0";
            
            fejlec.EntireColumn.AutoFit();
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }

        private void buttonFormNelkul_Click(object sender, EventArgs e)
        {
            CreateExcel();
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void buttonFormazott_Click(object sender, EventArgs e)
        {
            CreateExcel();
            TablaFormazas();
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
