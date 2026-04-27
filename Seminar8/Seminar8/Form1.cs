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

namespace Seminar8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IncarcaCompanii();
        }

        private void IncarcaCompanii()
        {
            companiiComboBox.DataSource = FakeDatabase.Companii;
            companiiComboBox.DisplayMember = "Nume";
            companiiComboBox.ValueMember = "Simbol";
        }

        private void IncarcaChartPret(Companie companie)
        {
            List<ZiBursiera> zile = FakeDatabase.Zile
                .Where(z => z.Simbol == companie.Simbol)
                .OrderBy(z => z.Data)
                .ToList();

            chartPret.Titles.Clear();
            chartPret.Titles.Add(companie.Nume);

            chartPret.Legends.Clear();

            Legend legenda = new Legend("legenda");
            legenda.Docking = Docking.Bottom;
            chartPret.Legends.Add(legenda);

            chartPret.ChartAreas.Clear();

            var area = new ChartArea("Preturi");
            area.AxisX.Title = "Data";
            area.AxisX.LabelStyle.Format = "dd.MM";
            area.AxisX.MajorGrid.LineColor = Color.LightGray;

            area.AxisY.Title = "Pret (RON)";
            area.AxisY.LabelStyle.Format = "0.00";
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            area.AxisX.Interval = 1;

            var min = zile.Min(z => z.Close);
            var max = zile.Max(z => z.Close);
            var padding = (max - min) * 0.05m;

            area.AxisY.Minimum = (double)(min - padding);
            area.AxisY.Maximum = (double)(max + padding);

            chartPret.ChartAreas.Add(area);

            chartPret.Series.Clear();

            var series = new Series("Pret inchidere");
            series.ChartType = SeriesChartType.Line;
            series.ChartArea = "Preturi";
            series.Color = Color.SteelBlue;
            series.BorderWidth = 2;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 5;

            chartPret.Series.Add(series);

            foreach (ZiBursiera zi in zile)
                series.Points.AddXY(zi.Data.ToString("dd.MM"), zi.Close);
        }

        private void IncarcaVolumChart(Companie companie)
        {
            List<ZiBursiera> zile = FakeDatabase.Zile
                .Where(z => z.Simbol == companie.Simbol)
                .OrderBy(z => z.Data)
                .ToList();

            volumChart.Titles.Clear();
            volumChart.Titles.Add(companie.Nume);

            volumChart.Legends.Clear();

            Legend legenda = new Legend("legenda");
            legenda.Docking = Docking.Bottom;
            volumChart.Legends.Add(legenda);

            volumChart.ChartAreas.Clear();

            var area = new ChartArea("Volum");
            area.AxisX.Title = "Data";
            area.AxisX.LabelStyle.Format = "dd.MM";
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisX.Interval = 1;

            area.AxisY.Title = "Volum tranzactionat";
            area.AxisY.LabelStyle.Format = "0";
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            volumChart.ChartAreas.Add(area);

            volumChart.Series.Clear();

            var series = new Series("Volum");
            series.ChartType = SeriesChartType.Column;
            series.ChartArea = "Volum";
            series.Color = Color.Orange;

            volumChart.Series.Add(series);

            foreach (ZiBursiera zi in zile)
                series.Points.AddXY(zi.Data.ToString("dd.MM"), zi.Volum);
        }

        private void IncarcaEvolutieChart(Companie companie)
        {
            List<ZiBursiera> zile = FakeDatabase.Zile
                .Where(z => z.Simbol == companie.Simbol)
                .OrderBy(z => z.Data)
                .ToList();

            evolutieChart.Legends.Clear();

            evolutieChart.Titles.Clear();
            evolutieChart.Titles.Add(companie.Nume);

            evolutieChart.ChartAreas.Clear();

            ChartArea area = new ChartArea("candlestick");
            area.AxisX.Title = "Data";
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisX.Interval = 1;

            area.AxisY.Title = "Preț (RON)";
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.LabelStyle.Format = "0.00";

            var min = zile.Min(z => z.Low);
            var max = zile.Max(z => z.High);
            var padding = (max - min) * 0.05m;

            area.AxisY.Minimum = (double)(min - padding);
            area.AxisY.Maximum = (double)(max + padding);

            evolutieChart.ChartAreas.Add(area);

            evolutieChart.Series.Clear();

            Series series = new Series("Evolutie");
            series.ChartType = SeriesChartType.Candlestick;
            series.ChartArea = "candlestick";
            series.Color = Color.Black;  
            series["PriceUpColor"] = "SeaGreen";    
            series["PriceDownColor"] = "Tomato";   
            series["PointWidth"] = "0.7";           
            evolutieChart.Series.Add(series);
                        
            foreach (ZiBursiera zi in zile)
            {
                series.Points.AddXY(
                    zi.Data.ToString("dd.MM"),
                    zi.High,    
                    zi.Low,     
                    zi.Open,    
                    zi.Close   
                );
            }
        }



        private void companiiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var companie = companiiComboBox.SelectedItem as Companie;
            if (companie != null)
            {
                IncarcaChartPret(companie);
                IncarcaVolumChart(companie);
                IncarcaEvolutieChart(companie);
            }
        }
    }
}
