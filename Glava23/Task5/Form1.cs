namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxCity.Items.AddRange(new string[] { "���������", "������", "�����", "�����" });
            comboBoxMobileOperator.Items.AddRange(new string[] { "���", "����", "������" });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "�������";
            }
            else if (rbFemale.Checked)
            {
                gender = "�������";
            }
            DateTime birthDate = dtpBirthDate.Value;
            string city = comboBoxCity.SelectedItem.ToString();
            string email = txtEmail.Text;
            string mobilePhone = txtMobilePhone.Text;
            string mobileOperator = comboBoxMobileOperator.SelectedItem?.ToString();
            string workExperience = "";
            if (rbNoExperience.Checked)
            {
                workExperience = "��� �����";
            }
            else if (rbLessThan1Year.Checked)
            {
                workExperience = "����� 1 ����";
            }
            else if (rb1To5Years.Checked)
            {
                workExperience = "�� 1 ���� �� 5 ���";
            }
            else if (rb5To10Years.Checked)
            {
                workExperience = "�� 5 �� 10 ���";
            }
            else if (rbMoreThan10Years.Checked)
            {
                workExperience = "10 ��� � �����";
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
                preferredWorkSchedule = "������ ���������";
            }
            else if (rbPartTime.Checked)
            {
                preferredWorkSchedule = "��������� ���������";
            }
            else if (rbRemoteWork.Checked)
            {
                preferredWorkSchedule = "������ �� ����";
            }
            else if (rbShiftWork.Checked)
            {
                preferredWorkSchedule = "��������� ������";
            }
            string resume = txtResume.Text;

            MessageBox.Show(
                "�������: " + lastName + "\n" +
                "���: " + firstName + "\n" +
                "��������: " + middleName + "\n" +
                "���: " + gender + "\n" +
                "���� ��������: " + birthDate.ToShortDateString() + "\n" +
                "�����: " + city + "\n" +
                "����������� �����: " + email + "\n" +
                "�������� ��������� �����: " + mobileOperator + "\n" +
                "��������� �������: " + mobilePhone + "\n" +
                "���� ������: " + workExperience + "\n" +
                "������� ������� ����: " + hasCar + "\n" +
                "������� ������������� �������������: " + hasDriversLicense + "\n" +
                "��������� ������������� �������������: " + driversLicenseCategory + "\n" +
                "����� ���������� ����� ��: " + salaryFrom + "\n" +
                "����� ���������� ����� ��: " + salaryTo + "\n" +
                "�������������� ������ ������: " + preferredWorkSchedule + "\n" +
                "������� ������: " + resume
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
