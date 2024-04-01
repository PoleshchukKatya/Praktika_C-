namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedString = listBoxStrings.SelectedItem?.ToString();


            if (selectedString != null)
            {
                int punctuationCount = selectedString.Count(char.IsPunctuation);

                labelResult.Text = $"Количество знаков препинания: {punctuationCount}";
            }
            else
            {
                MessageBox.Show("Выберите строку из списка.");
            }
        }
    }
}
