using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private string text;
        private int position;
        public Form1()
        {
            InitializeComponent();
            text = "Лабораторная работа 29 бегущая строка.";
            position = 0;

         
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += timer1_Tick; 

            
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            position -= 5;

            if (position + CreateGraphics().MeasureString(text, Font).Width < 0)
            {
                position = ClientSize.Width;
            }

           
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString(text, Font, brush, position, ClientSize.Height / 2);
            }
        }
    }
}
