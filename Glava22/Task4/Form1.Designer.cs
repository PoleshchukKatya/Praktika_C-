namespace Task4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtMiddleName = new TextBox();
            groupBox1 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            groupBox2 = new GroupBox();
            dtpBirthDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtMobilePhone = new TextBox();
            groupBox3 = new GroupBox();
            rbMoreThan10Years = new RadioButton();
            rb5To10Years = new RadioButton();
            rb1To5Years = new RadioButton();
            rbLessThan1Year = new RadioButton();
            rbNoExperience = new RadioButton();
            groupBox4 = new GroupBox();
            label7 = new Label();
            rbCategoryD = new CheckBox();
            rbCategoryC = new CheckBox();
            rbCategoryB = new CheckBox();
            rbCategoryA = new CheckBox();
            cbHasDriversLicense = new CheckBox();
            cbHasCar = new CheckBox();
            groupBox5 = new GroupBox();
            nudSalaryTo = new NumericUpDown();
            nudSalaryFrom = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            groupBox6 = new GroupBox();
            rbShiftWork = new RadioButton();
            rbPartTime = new RadioButton();
            rbRemoteWork = new RadioButton();
            rbFullTime = new RadioButton();
            txtResume = new TextBox();
            label10 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            btnCancel = new Button();
            comboBoxCity = new ComboBox();
            comboBoxMobileOperator = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSalaryTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSalaryFrom).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(128, 39);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(242, 31);
            txtLastName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(29, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 1;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(29, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 3;
            label2.Text = "Имя";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(128, 80);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(242, 31);
            txtFirstName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(29, 121);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 5;
            label3.Text = "Отчество";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(128, 121);
            txtMiddleName.Margin = new Padding(4);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(242, 31);
            txtMiddleName.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(515, 39);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(315, 116);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пол";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.ForeColor = SystemColors.Desktop;
            rbFemale.Location = new Point(72, 66);
            rbFemale.Margin = new Padding(4);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(109, 29);
            rbFemale.TabIndex = 1;
            rbFemale.TabStop = true;
            rbFemale.Text = "Женский";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.ForeColor = SystemColors.Desktop;
            rbMale.Location = new Point(72, 29);
            rbMale.Margin = new Padding(4);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(113, 29);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Мужской";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpBirthDate);
            groupBox2.ForeColor = SystemColors.Highlight;
            groupBox2.Location = new Point(32, 163);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(798, 99);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Дата рождения";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(8, 46);
            dtpBirthDate.Margin = new Padding(4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(290, 31);
            dtpBirthDate.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 286);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 8;
            label4.Text = "Место проживания";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 329);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(228, 25);
            label5.TabIndex = 9;
            label5.Text = "Адрес электронной почты";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 375);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(182, 25);
            label6.TabIndex = 10;
            label6.Text = "Мобильный телефон";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(282, 329);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 31);
            txtEmail.TabIndex = 12;
            // 
            // txtMobilePhone
            // 
            txtMobilePhone.Location = new Point(418, 375);
            txtMobilePhone.Margin = new Padding(4);
            txtMobilePhone.Name = "txtMobilePhone";
            txtMobilePhone.Size = new Size(182, 31);
            txtMobilePhone.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbMoreThan10Years);
            groupBox3.Controls.Add(rb5To10Years);
            groupBox3.Controls.Add(rb1To5Years);
            groupBox3.Controls.Add(rbLessThan1Year);
            groupBox3.Controls.Add(rbNoExperience);
            groupBox3.ForeColor = SystemColors.Highlight;
            groupBox3.Location = new Point(40, 431);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(798, 137);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Опыт работы";
            // 
            // rbMoreThan10Years
            // 
            rbMoreThan10Years.AutoSize = true;
            rbMoreThan10Years.ForeColor = SystemColors.Desktop;
            rbMoreThan10Years.Location = new Point(460, 42);
            rbMoreThan10Years.Margin = new Padding(4);
            rbMoreThan10Years.Name = "rbMoreThan10Years";
            rbMoreThan10Years.Size = new Size(155, 29);
            rbMoreThan10Years.TabIndex = 6;
            rbMoreThan10Years.TabStop = true;
            rbMoreThan10Years.Text = "10 лет и более";
            rbMoreThan10Years.UseVisualStyleBackColor = true;
            // 
            // rb5To10Years
            // 
            rb5To10Years.AutoSize = true;
            rb5To10Years.ForeColor = SystemColors.Desktop;
            rb5To10Years.Location = new Point(243, 79);
            rb5To10Years.Margin = new Padding(4);
            rb5To10Years.Name = "rb5To10Years";
            rb5To10Years.Size = new Size(174, 29);
            rb5To10Years.TabIndex = 5;
            rb5To10Years.TabStop = true;
            rb5To10Years.Text = "От 5 лет до 9 лет";
            rb5To10Years.UseVisualStyleBackColor = true;
            // 
            // rb1To5Years
            // 
            rb1To5Years.AutoSize = true;
            rb1To5Years.ForeColor = SystemColors.Desktop;
            rb1To5Years.Location = new Point(243, 42);
            rb1To5Years.Margin = new Padding(4);
            rb1To5Years.Name = "rb1To5Years";
            rb1To5Years.Size = new Size(186, 29);
            rb1To5Years.TabIndex = 4;
            rb1To5Years.TabStop = true;
            rb1To5Years.Text = "От 1 года до 5 лет";
            rb1To5Years.UseVisualStyleBackColor = true;
            // 
            // rbLessThan1Year
            // 
            rbLessThan1Year.AutoSize = true;
            rbLessThan1Year.ForeColor = SystemColors.Desktop;
            rbLessThan1Year.Location = new Point(17, 79);
            rbLessThan1Year.Margin = new Padding(4);
            rbLessThan1Year.Name = "rbLessThan1Year";
            rbLessThan1Year.Size = new Size(161, 29);
            rbLessThan1Year.TabIndex = 3;
            rbLessThan1Year.TabStop = true;
            rbLessThan1Year.Text = "Меньше 1 года";
            rbLessThan1Year.UseVisualStyleBackColor = true;
            // 
            // rbNoExperience
            // 
            rbNoExperience.AutoSize = true;
            rbNoExperience.ForeColor = SystemColors.Desktop;
            rbNoExperience.Location = new Point(17, 42);
            rbNoExperience.Margin = new Padding(4);
            rbNoExperience.Name = "rbNoExperience";
            rbNoExperience.Size = new Size(197, 29);
            rbNoExperience.TabIndex = 2;
            rbNoExperience.TabStop = true;
            rbNoExperience.Text = "Прежде не работал";
            rbNoExperience.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(rbCategoryD);
            groupBox4.Controls.Add(rbCategoryC);
            groupBox4.Controls.Add(rbCategoryB);
            groupBox4.Controls.Add(rbCategoryA);
            groupBox4.Controls.Add(cbHasDriversLicense);
            groupBox4.Controls.Add(cbHasCar);
            groupBox4.ForeColor = SystemColors.Highlight;
            groupBox4.Location = new Point(40, 590);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(299, 218);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Дргуие сведения";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 118);
            label7.Name = "label7";
            label7.Size = new Size(140, 25);
            label7.TabIndex = 21;
            label7.Text = "Категория прав";
            // 
            // rbCategoryD
            // 
            rbCategoryD.AutoSize = true;
            rbCategoryD.Location = new Point(164, 146);
            rbCategoryD.Name = "rbCategoryD";
            rbCategoryD.Size = new Size(51, 29);
            rbCategoryD.TabIndex = 20;
            rbCategoryD.Text = "D";
            rbCategoryD.UseVisualStyleBackColor = true;
            // 
            // rbCategoryC
            // 
            rbCategoryC.AutoSize = true;
            rbCategoryC.Location = new Point(113, 146);
            rbCategoryC.Name = "rbCategoryC";
            rbCategoryC.Size = new Size(49, 29);
            rbCategoryC.TabIndex = 19;
            rbCategoryC.Text = "С";
            rbCategoryC.UseVisualStyleBackColor = true;
            // 
            // rbCategoryB
            // 
            rbCategoryB.AutoSize = true;
            rbCategoryB.Location = new Point(59, 146);
            rbCategoryB.Name = "rbCategoryB";
            rbCategoryB.Size = new Size(48, 29);
            rbCategoryB.TabIndex = 18;
            rbCategoryB.Text = "В";
            rbCategoryB.UseVisualStyleBackColor = true;
            // 
            // rbCategoryA
            // 
            rbCategoryA.AutoSize = true;
            rbCategoryA.Location = new Point(7, 146);
            rbCategoryA.Name = "rbCategoryA";
            rbCategoryA.Size = new Size(50, 29);
            rbCategoryA.TabIndex = 17;
            rbCategoryA.Text = "А";
            rbCategoryA.UseVisualStyleBackColor = true;
            // 
            // cbHasDriversLicense
            // 
            cbHasDriversLicense.AutoSize = true;
            cbHasDriversLicense.Location = new Point(7, 77);
            cbHasDriversLicense.Name = "cbHasDriversLicense";
            cbHasDriversLicense.Size = new Size(279, 29);
            cbHasDriversLicense.TabIndex = 16;
            cbHasDriversLicense.Text = "Водительское удостоверение";
            cbHasDriversLicense.UseVisualStyleBackColor = true;
            // 
            // cbHasCar
            // 
            cbHasCar.AutoSize = true;
            cbHasCar.Location = new Point(7, 42);
            cbHasCar.Name = "cbHasCar";
            cbHasCar.Size = new Size(223, 29);
            cbHasCar.TabIndex = 15;
            cbHasCar.Text = "Наличие личного авто";
            cbHasCar.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(nudSalaryTo);
            groupBox5.Controls.Add(nudSalaryFrom);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label8);
            groupBox5.ForeColor = SystemColors.Highlight;
            groupBox5.Location = new Point(378, 590);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(446, 104);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            groupBox5.Text = "Объем ЗП";
            // 
            // nudSalaryTo
            // 
            nudSalaryTo.Location = new Point(204, 46);
            nudSalaryTo.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            nudSalaryTo.Name = "nudSalaryTo";
            nudSalaryTo.Size = new Size(149, 31);
            nudSalaryTo.TabIndex = 24;
            // 
            // nudSalaryFrom
            // 
            nudSalaryFrom.Location = new Point(41, 46);
            nudSalaryFrom.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudSalaryFrom.Name = "nudSalaryFrom";
            nudSalaryFrom.Size = new Size(103, 31);
            nudSalaryFrom.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(166, 46);
            label9.Name = "label9";
            label9.Size = new Size(35, 25);
            label9.TabIndex = 22;
            label9.Text = "До";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 46);
            label8.Name = "label8";
            label8.Size = new Size(33, 25);
            label8.TabIndex = 21;
            label8.Text = "От";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rbShiftWork);
            groupBox6.Controls.Add(rbPartTime);
            groupBox6.Controls.Add(rbRemoteWork);
            groupBox6.Controls.Add(rbFullTime);
            groupBox6.ForeColor = SystemColors.Highlight;
            groupBox6.Location = new Point(378, 704);
            groupBox6.Margin = new Padding(4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4);
            groupBox6.Size = new Size(446, 104);
            groupBox6.TabIndex = 25;
            groupBox6.TabStop = false;
            groupBox6.Text = "Предпочитаемый график работы";
            // 
            // rbShiftWork
            // 
            rbShiftWork.AutoSize = true;
            rbShiftWork.ForeColor = SystemColors.Desktop;
            rbShiftWork.Location = new Point(189, 68);
            rbShiftWork.Margin = new Padding(4);
            rbShiftWork.Name = "rbShiftWork";
            rbShiftWork.Size = new Size(191, 29);
            rbShiftWork.TabIndex = 10;
            rbShiftWork.TabStop = true;
            rbShiftWork.Text = "Посменная работа";
            rbShiftWork.UseVisualStyleBackColor = true;
            // 
            // rbPartTime
            // 
            rbPartTime.AutoSize = true;
            rbPartTime.ForeColor = SystemColors.Desktop;
            rbPartTime.Location = new Point(189, 32);
            rbPartTime.Margin = new Padding(4);
            rbPartTime.Name = "rbPartTime";
            rbPartTime.Size = new Size(204, 29);
            rbPartTime.TabIndex = 9;
            rbPartTime.TabStop = true;
            rbPartTime.Text = "Частичная занятость";
            rbPartTime.UseVisualStyleBackColor = true;
            // 
            // rbRemoteWork
            // 
            rbRemoteWork.AutoSize = true;
            rbRemoteWork.ForeColor = SystemColors.Desktop;
            rbRemoteWork.Location = new Point(8, 69);
            rbRemoteWork.Margin = new Padding(4);
            rbRemoteWork.Name = "rbRemoteWork";
            rbRemoteWork.Size = new Size(165, 29);
            rbRemoteWork.TabIndex = 8;
            rbRemoteWork.TabStop = true;
            rbRemoteWork.Text = "Работа на дому";
            rbRemoteWork.UseVisualStyleBackColor = true;
            // 
            // rbFullTime
            // 
            rbFullTime.AutoSize = true;
            rbFullTime.ForeColor = SystemColors.Desktop;
            rbFullTime.Location = new Point(8, 31);
            rbFullTime.Margin = new Padding(4);
            rbFullTime.Name = "rbFullTime";
            rbFullTime.Size = new Size(181, 29);
            rbFullTime.TabIndex = 7;
            rbFullTime.TabStop = true;
            rbFullTime.Text = "Полная занятость";
            rbFullTime.UseVisualStyleBackColor = true;
            // 
            // txtResume
            // 
            txtResume.Location = new Point(40, 835);
            txtResume.Multiline = true;
            txtResume.Name = "txtResume";
            txtResume.Size = new Size(784, 138);
            txtResume.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 809);
            label10.Name = "label10";
            label10.Size = new Size(148, 25);
            label10.TabIndex = 22;
            label10.Text = "Краткое резюме";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(843, 835);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(196, 34);
            btnSave.TabIndex = 27;
            btnSave.Text = "Сохранить данные";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(843, 875);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(196, 34);
            btnClear.TabIndex = 28;
            btnClear.Text = "Очистить форму";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(843, 915);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(196, 34);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(282, 286);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(318, 33);
            comboBoxCity.TabIndex = 30;
            // 
            // comboBoxMobileOperator
            // 
            comboBoxMobileOperator.FormattingEnabled = true;
            comboBoxMobileOperator.Location = new Point(282, 373);
            comboBoxMobileOperator.Name = "comboBoxMobileOperator";
            comboBoxMobileOperator.Size = new Size(129, 33);
            comboBoxMobileOperator.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 985);
            Controls.Add(comboBoxMobileOperator);
            Controls.Add(comboBoxCity);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(label10);
            Controls.Add(txtResume);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(txtMobilePhone);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(txtMiddleName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSalaryTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSalaryFrom).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLastName;
        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtMiddleName;
        private GroupBox groupBox1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private GroupBox groupBox2;
        private DateTimePicker dtpBirthDate;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private TextBox txtMobilePhone;
        private GroupBox groupBox3;
        private RadioButton rbMoreThan10Years;
        private RadioButton rb5To10Years;
        private RadioButton rb1To5Years;
        private RadioButton rbLessThan1Year;
        private RadioButton rbNoExperience;
        private GroupBox groupBox4;
        private CheckBox cbHasCar;
        private CheckBox cbHasDriversLicense;
        private CheckBox rbCategoryA;
        private Label label7;
        private CheckBox rbCategoryD;
        private CheckBox rbCategoryC;
        private CheckBox rbCategoryB;
        private GroupBox groupBox5;
        private NumericUpDown nudSalaryTo;
        private NumericUpDown nudSalaryFrom;
        private Label label9;
        private Label label8;
        private GroupBox groupBox6;
        private RadioButton rbShiftWork;
        private RadioButton rbPartTime;
        private RadioButton rbRemoteWork;
        private RadioButton rbFullTime;
        private TextBox txtResume;
        private Label label10;
        private Button btnSave;
        private Button btnClear;
        private Button btnCancel;
        private ComboBox comboBoxCity;
        private ComboBox comboBoxMobileOperator;
    }
}
