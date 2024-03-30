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
            if (!double.TryParse(textBoxX.Text, out double x) ||
                !double.TryParse(textBoxY.Text, out double y))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для x и y.");
                return;
            }

            double f_x = x * x;

            double result;
            if (Math.Abs(x - y) == 0)
            {
                result = Math.Pow(f_x, 2) + Math.Pow(y, 2) + Math.Sin(y);
            }
            else if (x - y > 0)
            {
                result = Math.Pow((f_x - y), 2) + Math.Cos(y);
            }
            else
            {
                result = Math.Pow((y - f_x), 2) + Math.Tan(y);
            }

            textBoxResult.Text = result.ToString();
        }
    }
}