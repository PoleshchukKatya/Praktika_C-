namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            double z = double.Parse(txtZ.Text);

            double w = Math.Pow(Math.Abs(Math.Cos(x) - Math.Cos(y)), 1 + 2 * Math.Pow(Math.Sin(y), 2)) *
                        (1 + z + Math.Pow(z, 2) / 2 + Math.Pow(z, 3) / 3 + Math.Pow(z, 4) / 4);

            lblResult.Text = "Результат W = " + w.ToString();
        }
    }
}
