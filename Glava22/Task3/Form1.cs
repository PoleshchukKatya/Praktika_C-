namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxX0.Text, out double x0) ||
                !double.TryParse(textBoxXk.Text, out double xk) ||
                !double.TryParse(textBoxDx.Text, out double dx) ||
                !double.TryParse(textBoxA.Text, out double a) ||
                !double.TryParse(textBoxB.Text, out double b))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
                return;
            }
            listBoxResults.Items.Clear();

            for (double x = x0; x <= xk; x += dx)
            {
                double y = 1e-1 * a * Math.Pow(x, 3) * Math.Tan(a - b * x);
                listBoxResults.Items.Add($"x = {x}, y = {y}");
            }
        }
    }
}
