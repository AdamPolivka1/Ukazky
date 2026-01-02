using System.Windows.Forms.DataVisualization.Charting;

namespace WinformsChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            CreateBarChart();
        }

        public void InitializeComboBox()
        {
            comboBoxShowChart.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxShowChart.Items.Add("Sloupcový");
            comboBoxShowChart.Items.Add("Čárový");

            comboBoxShowChart.SelectedIndex = 0;
            comboBoxShowChart.SelectedIndexChanged += ComboBoxShowChart_SelectedIndexChanged;
        }

  
        private void ComboBoxShowChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chartActual = panelChart.Controls.OfType<Chart>().First();
            panelChart.Controls.Remove(chartActual);
            string selectedChart = comboBoxShowChart.SelectedItem.ToString();

            switch (selectedChart)
            {
                case "Sloupcový":
                    CreateBarChart();
                    break;
                case "Čárový":
                    CreateLineChart();
                    break;
            }
        }

        public void CreateBarChart()
        {
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;
            ChartArea area = new ChartArea("MainArea");
            chart.ChartAreas.Add(area);
           
            Series series = new Series("Ceny produktů")
            {
                ChartType = SeriesChartType.Column
            };
            series.Points.AddXY("Objednávka A", 100);
            series.Points.AddXY("Objednávka B", 150);
            series.Points.AddXY("Objednávka C", 200);
            series.Points.AddXY("Objednávka D", 180);

            chart.Series.Add(series);
            chart.Titles.Add("Ceny objednávek");
            chart.ChartAreas["MainArea"].AxisX.Interval = 1;

            panelChart.Controls.Add(chart);
        }

        private void CreateLineChart()
        {
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;
            ChartArea area = new ChartArea("MainArea");
            chart.ChartAreas.Add(area);

            Series series = new Series("Ceny objednávek")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };
            series.Points.AddXY("Objednávka A", 100);
            series.Points.AddXY("Objednávka B", 150);
            series.Points.AddXY("Objednávka C", 200);
            series.Points.AddXY("Objednávka D", 180);

            chart.Series.Add(series);
            chart.Titles.Add("Ceny objednávek");
            panelChart.Controls.Add(chart);

            foreach (DataPoint point in series.Points)
            {
                point.Label = $"{point.AxisLabel}: {point.YValues[0]}";
            }
        }

    }
}
