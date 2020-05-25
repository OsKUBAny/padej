using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Schema;

namespace Kolokwium_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //funkcje matematyczne
        private static double Funkcja1(double x, int n)
        {
            double wynik = 0;
            int n1 = n - 1;
            if (n1 < 0) return 0;
            double[] wsp = new double[n1 + 1];
            for (int i = 0; i <= n1; i++)
            {
                wsp[i] = 1.0 / (1.5 + i * i * i);
                wynik = (x - n) * wsp[n1];
                for (int j = n1 - 1; j >= 0; j--)
                {
                    wynik = wynik * x + wsp[j];
                }
            }
            return wynik;
        }

        private static double Funkcja2(double x, int n)
        {
            double wynik = 1;
            for (int i = 0; i < n; i++)
            {
                wynik = x * wynik;
            }
            return wynik;
        }

        private static double Funkcja3(double x, int n)
        {
            double wynik = Math.Sin(x + n);
            return wynik;

        }

        //funkcje "wykreślające" punkty dla wykresu
        private void rysujF1(int n, int min, int max)
        {
            Series series = chart1.Series.Add("Funckja 1");
            series.ChartType = SeriesChartType.Spline;
            for (int i = min; i <= max; i++)
            {
                series.Points.AddXY(i, Funkcja1(i, n));
            }
            double xmax = series.Points.FindMaxByValue().XValue;
            double xmin = series.Points.FindMinByValue().XValue;
            double ymax = series.Points.FindMaxByValue().YValues[0];
            double ymin = series.Points.FindMinByValue().YValues[0];

            label_max.Text = "Wartość max dla (" + xmax.ToString() + "; " + ymax.ToString() + ")";
            label_min.Text = "Wartość min dla (" + xmin.ToString() + "; " + ymin.ToString() + ")";
        }

        private void rysujF2(int n, int min, int max)
        {
            Series series = chart1.Series.Add("Funckja 2");
            series.ChartType = SeriesChartType.Spline;
            for (int i = min; i <= max; i++)
            {
                series.Points.AddXY(i, Funkcja2(i, n));
            }
            double xmax = series.Points.FindMaxByValue().XValue;
            double xmin = series.Points.FindMinByValue().XValue;
            double ymax = series.Points.FindMaxByValue().YValues[0];
            double ymin = series.Points.FindMinByValue().YValues[0];

            label_max.Text = "Wartość max dla (" + xmax.ToString() + "; " + ymax.ToString() + ")";
            label_min.Text = "Wartość min dla (" + xmin.ToString() + "; " + ymin.ToString() + ")";
        }

        private void rysujF3(int n, int min, int max)
        {
            Series series = chart1.Series.Add("Funckja 3");
            series.ChartType = SeriesChartType.Spline;
            for (int i = min; i <= max; i++)
            {
                series.Points.AddXY(i, Funkcja3(i, n));
            }
            double xmax = series.Points.FindMaxByValue().XValue;
            double xmin = series.Points.FindMinByValue().XValue;
            double ymax = series.Points.FindMaxByValue().YValues[0];
            double ymin = series.Points.FindMinByValue().YValues[0];

            label_max.Text = "Wartość max dla (" + xmax.ToString() + "; " + ymax.ToString() + ")";
            label_min.Text = "Wartość min dla (" + xmin.ToString() + "; " + ymin.ToString() + ")";
            
        }

        //wybór funkcji po naciśnięciu przycisku
        private void button_rysuj_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = trackBar_xmax.Value;
            chart1.ChartAreas[0].AxisX.Minimum = trackBar_xmin.Value;
            int n = int.Parse(textBox_n.Text);

            if (radioButton1.Checked == true) rysujF1(n, trackBar_xmin.Value, trackBar_xmax.Value);

            if (radioButton2.Checked == true) rysujF2(n, trackBar_xmin.Value, trackBar_xmax.Value);

            if (radioButton3.Checked == true) rysujF3(n, trackBar_xmin.Value, trackBar_xmax.Value);
        }


        //automatyczna zmiana wartości tekstu dla granic wykresu
        private void trackBar_xmin_Scroll(object sender, EventArgs e)
        {
            label_graniceXmin.Text = trackBar_xmin.Value.ToString();
        }

        private void trackBar_xmax_Scroll(object sender, EventArgs e)
        {
            label_graniceXmax.Text = trackBar_xmax.Value.ToString();
        }
    }
}
