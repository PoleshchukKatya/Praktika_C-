namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxCity.Items.AddRange(new string[] { "Волковыск", "Гродно", "Брест", "Минск" });
            comboBoxMobileOperator.Items.AddRange(new string[] { "МТС", "Лайф", "Велком" });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "Мужской";
            }
            else if (rbFemale.Checked)
            {
                gender = "Женский";
            }
            DateTime birthDate = dtpBirthDate.Value;
            string city = comboBoxCity.SelectedItem.ToString();
            string email = txtEmail.Text;
            string mobilePhone = txtMobilePhone.Text;
            string mobileOperator = comboBoxMobileOperator.SelectedItem?.ToString();
            string workExperience = "";
            if (rbNoExperience.Checked)
            {
                workExperience = "Нет опыта";
            }
            else if (rbLessThan1Year.Checked)
            {
                workExperience = "Менее 1 года";
            }
            else if (rb1To5Years.Checked)
            {
                workExperience = "От 1 года до 5 лет";
            }
            else if (rb5To10Years.Checked)
            {
                workExperience = "От 5 до 10 лет";
            }
            else if (rbMoreThan10Years.Checked)
            {
                workExperience = "10 лет и более";
            }
            bool hasCar = cbHasCar.Checked;
            bool hasDriversLicense = cbHasDriversLicense.Checked;
            string driversLicenseCategory = "";
            if (rbCategoryA.Checked)
            {
                driversLicenseCategory = "A";
            }
            else if (rbCategoryB.Checked)
            {
                driversLicenseCategory = "B";
            }
            else if (rbCategoryC.Checked)
            {
                driversLicenseCategory = "C";
            }
            else if (rbCategoryD.Checked)
            {
                driversLicenseCategory = "D";
            }
            int salaryFrom = (int)nudSalaryFrom.Value;
            int salaryTo = (int)nudSalaryTo.Value;
            string preferredWorkSchedule = "";
            if (rbFullTime.Checked)
            {
                preferredWorkSchedule = "Полная занятость";
            }
            else if (rbPartTime.Checked)
            {
                preferredWorkSchedule = "Частичная занятость";
            }
            else if (rbRemoteWork.Checked)
            {
                preferredWorkSchedule = "Работа на дому";
            }
            else if (rbShiftWork.Checked)
            {
                preferredWorkSchedule = "Посменная работа";
            }
            string resume = txtResume.Text;

            MessageBox.Show(
                "Фамилия: " + lastName + "\n" +
                "Имя: " + firstName + "\n" +
                "Отчество: " + middleName + "\n" +
                "Пол: " + gender + "\n" +
                "Дата рождения: " + birthDate.ToShortDateString() + "\n" +
                "Город: " + city + "\n" +
                "Электронная почта: " + email + "\n" +
                "Оператор мобильной связи: " + mobileOperator + "\n" +
                "Мобильный телефон: " + mobilePhone + "\n" +
                "Опыт работы: " + workExperience + "\n" +
                "Наличие личного авто: " + hasCar + "\n" +
                "Наличие водительского удостоверения: " + hasDriversLicense + "\n" +
                "Категория водительского удостоверения: " + driversLicenseCategory + "\n" +
                "Объем заработной платы от: " + salaryFrom + "\n" +
                "Объем заработной платы до: " + salaryTo + "\n" +
                "Предпочитаемый график работы: " + preferredWorkSchedule + "\n" +
                "Краткое резюме: " + resume
            );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            dtpBirthDate.Value = DateTime.Now;
            comboBoxCity.SelectedIndex = -1;
            txtEmail.Text = "";
            comboBoxMobileOperator.SelectedIndex = -1;
            txtMobilePhone.Text = "";
            rbNoExperience.Checked = false;
            rbLessThan1Year.Checked = false;
            rb1To5Years.Checked = false;
            rb5To10Years.Checked = false;
            rbMoreThan10Years.Checked = false;
            cbHasCar.Checked = false;
            cbHasDriversLicense.Checked = false;
            rbCategoryA.Checked = false;
            rbCategoryB.Checked = false;
            rbCategoryC.Checked = false;
            rbCategoryD.Checked = false;
            nudSalaryFrom.Value = 0;
            nudSalaryTo.Value = 0;
            rbFullTime.Checked = false;
            rbPartTime.Checked = false;
            rbRemoteWork.Checked = false;
            rbShiftWork.Checked = false;
            txtResume.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
