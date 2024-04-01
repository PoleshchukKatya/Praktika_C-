using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createControlButton_Click(object sender, EventArgs e)
        {
            string controlType = controlTypeTextBox.Text;

            int x = int.Parse(xCoordinateTextBox.Text);
            int y = int.Parse(yCoordinateTextBox.Text);

            Control newControl = null;
            switch (controlType)
            {
                case "К":
                    newControl = new Button();
                    ((Button)newControl).Text = "Новая кнопка";
                    ((Button)newControl).Click += NewControl_Click;
                    break;
                case "П":
                    newControl = new TextBox();
                    break;
                case "М":
                    newControl = new Label();
                    ((Label)newControl).Text = "Новая метка";
                    break;
                default:
                    MessageBox.Show("Неверный тип элемента управления.");
                    return;
            }

            newControl.Location = new Point(x, y);
            newControl.Size = new Size(100, 30);
            newControl.BackColor = Color.LightGray;

            this.Controls.Add(newControl);


            newControl.MouseHover += NewControl_MouseHover;
        }
        private void NewControl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали на новую кнопку!");
        }

        private void NewControl_MouseHover(object sender, EventArgs e)
        {
            this.Controls.Remove((Control)sender);
        }
    }
}
