using System.Drawing;

namespace Task3
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen pen;
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            pen = new Pen(Color.Blue, 2);
        }

        private void drawFlowerButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            int stemWidth = 5;
            int stemHeight = 100;
            int stemX = (ClientSize.Width - stemWidth) / 2;
            int stemY = ClientSize.Height - stemHeight;
            graphics.DrawLine(pen, stemX + stemWidth / 2, ClientSize.Height, stemX + stemWidth / 2, stemY);

            int centerX = stemX + stemWidth / 2;
            int centerY = stemY;
            int petalRadius = 30;
            int numPetals = 8;
            double angleIncrement = 2 * Math.PI / numPetals;

            for (int i = 0; i < numPetals; i++)
            {
                double angle = i * angleIncrement;
                int x = (int)(centerX + petalRadius * Math.Cos(angle));
                int y = (int)(centerY - petalRadius * Math.Sin(angle));
                graphics.DrawEllipse(pen, x - petalRadius / 2, y - petalRadius / 2, petalRadius, petalRadius);
            }
        }
        
    }
}
