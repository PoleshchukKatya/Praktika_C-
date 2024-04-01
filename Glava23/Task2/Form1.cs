using System.Windows.Forms.DataVisualization.Charting;
namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxXmin.Text, out double xmin) ||
                !double.TryParse(textBoxXmax.Text, out double xmax) ||
                !double.TryParse(textBoxStep.Text, out double step))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
                return;
            }

            chart.Series.Clear();

            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            series.Color = System.Drawing.Color.Blue;

            double x, y;
            for (x = xmin; x <= xmax; x += step)
            {
                y = Math.Cos(x);
                series.Points.AddXY(x, y);
            }

            chart.Series.Add(series);
        }
    }
}
