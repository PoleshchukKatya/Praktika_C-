namespace Task3
{
    public partial class Form1 : Form
    {
        private Color[] colors = { Color.Red, Color.Green, Color.Blue };
        private int currentColorIndex = 0;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = colors[currentColorIndex];
            this.Click += ColorChangingButton_Click;
        }

        private void ColorChangingButton_Click(object sender, EventArgs e)
        {
            currentColorIndex = (currentColorIndex + 1) % colors.Length;
            this.BackColor = colors[currentColorIndex];
        }
    }
}
