using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokwium_MU_148946
{
    public partial class Form1 : Form
    {
        List<klasabmi> klasabmi;
        public string plec2 = "";
        public double pal = 0;
        public double ppm = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zapisz_oblicz_Click(object sender, EventArgs e)
        {
            if (radioKobieta.Checked)
            {
                ppm = (double.Parse(numeric_waga.Text) * 10) + (6.25 * double.Parse(numeric_wzrost.Text) / 100) - (5 * double.Parse(numeric_wiek.Text)) - 161;
                plec2 = "k";
                if (poziom_aktywnosci.SelectedIndex == 0)
                {
                    pal = 1.2;
                }
                else if (poziom_aktywnosci.SelectedIndex == 1)
                {
                    pal = 1.3;
                }
                else if (poziom_aktywnosci.SelectedIndex == 2)
                {
                    pal = 1.5;
                }
                else if (poziom_aktywnosci.SelectedIndex == 3)
                {
                    pal = 1.6;
                }
                else if (poziom_aktywnosci.SelectedIndex == 4)
                {
                    pal = 1.9;
                }
                else if (poziom_aktywnosci.SelectedIndex == 5)
                {
                    pal = 2.2;
                }

            }
            else
            {
                ppm = (double.Parse(numeric_waga.Text) * 10) + (6.25 * double.Parse(numeric_wzrost.Text) / 100) - (5 * double.Parse(numeric_wiek.Text)) + 5;
                plec2 = "m";
                if (poziom_aktywnosci.SelectedIndex == 0)
                {
                    pal = 1.2;
                }
                else if (poziom_aktywnosci.SelectedIndex == 1)
                {
                    pal = 1.3;
                }
                else if (poziom_aktywnosci.SelectedIndex == 2)
                {
                    pal = 1.6;
                }
                else if (poziom_aktywnosci.SelectedIndex == 3)
                {
                    pal = 1.7;
                }
                else if (poziom_aktywnosci.SelectedIndex == 4)
                {
                    pal = 2.1;
                }
                else if (poziom_aktywnosci.SelectedIndex == 5)
                {
                    pal = 2.4;
                }
            }
            klasabmi bmi = new klasabmi()
            {
                Wiek = double.Parse(numeric_wiek.Text),
                Waga = double.Parse(numeric_waga.Text),
                Wzrost = double.Parse(numeric_wzrost.Text),
                Plec = plec2,
                Bmi = double.Parse(numeric_waga.Text) / Math.Pow(double.Parse(numeric_wzrost.Text) / 100, 2),
                Ppm = ppm,
                Cpm = pal * ppm,
                Aktywnosc = poziom_aktywnosci.SelectedItem.ToString(),
            };
            MessageBox.Show(bmi.bmi_wyswietl());
        }

        private void numeric_wiek_ValueChanged(object sender, EventArgs e)
        {
            numeric_wiek.Minimum = 18;
            numeric_wiek.Maximum = 99;
        }

        private void numeric_waga_ValueChanged(object sender, EventArgs e)
        {
            numeric_waga.Maximum = 1000;

        }

        private void numeric_wzrost_ValueChanged(object sender, EventArgs e)
        {
            numeric_wzrost.Maximum = 1000;
        }
    }
}
