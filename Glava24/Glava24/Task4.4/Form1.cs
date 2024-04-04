using System.Threading;
namespace Task4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture =
            Thread.CurrentThread.CurrentCulture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
