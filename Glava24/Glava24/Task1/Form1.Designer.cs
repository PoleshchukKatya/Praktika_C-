namespace Task1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBoxMobileOperator = new ComboBox();
            comboBoxCity = new ComboBox();
            label10 = new Label();
            txtResume = new TextBox();
            groupBox6 = new GroupBox();
            rbShiftWork = new RadioButton();
            rbPartTime = new RadioButton();
            rbRemoteWork = new RadioButton();
            rbFullTime = new RadioButton();
            groupBox5 = new GroupBox();
            nudSalaryTo = new NumericUpDown();
            nudSalaryFrom = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            groupBox4 = new GroupBox();
            label7 = new Label();
            rbCategoryD = new CheckBox();
            rbCategoryC = new CheckBox();
            rbCategoryB = new CheckBox();
            rbCategoryA = new CheckBox();
            cbHasDriversLicense = new CheckBox();
            cbHasCar = new CheckBox();
            groupBox3 = new GroupBox();
            rbMoreThan10Years = new RadioButton();
            rb5To10Years = new RadioButton();
            rb1To5Years = new RadioButton();
            rbLessThan1Year = new RadioButton();
            rbNoExperience = new RadioButton();
            txtMobilePhone = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            dtpBirthDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label3 = new Label();
            txtMiddleName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            txtLastName = new TextBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            spWin = new ToolStripStatusLabel();
            statusStrip2 = new StatusStrip();
            spData = new ToolStripStatusLabel();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSalaryTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSalaryFrom).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            statusStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxMobileOperator
            // 
            comboBoxMobileOperator.FormattingEnabled = true;
            comboBoxMobileOperator.Location = new Point(332, 444);
            comboBoxMobileOperator.Name = "comboBoxMobileOperator";
            comboBoxMobileOperator.Size = new Size(129, 33);
            comboBoxMobileOperator.TabIndex = 79;
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(332, 357);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(318, 33);
            comboBoxCity.TabIndex = 78;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(89, 880);
            label10.Name = "label10";
            label10.Size = new Size(148, 25);
            label10.TabIndex = 71;
            label10.Text = "Краткое резюме";
            // 
            // txtResume
            // 
            txtResume.Location = new Point(90, 906);
            txtResume.Multiline = true;
            txtResume.Name = "txtResume";
            txtResume.Size = new Size(784, 138);
            txtResume.TabIndex = 74;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rbShiftWork);
            groupBox6.Controls.Add(rbPartTime);
            groupBox6.Controls.Add(rbRemoteWork);
            groupBox6.Controls.Add(rbFullTime);
            groupBox6.ForeColor = SystemColors.Highlight;
            groupBox6.Location = new Point(428, 775);
            groupBox6.Margin = new Padding(4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4);
            groupBox6.Size = new Size(446, 104);
            groupBox6.TabIndex = 73;
            groupBox6.TabStop = false;
            groupBox6.Text = "Предпочитаемый график работы";
            // 
            // rbShiftWork
            // 
            rbShiftWork.AutoSize = true;
            rbShiftWork.ForeColor = SystemColors.ActiveCaptionText;
            rbShiftWork.Location = new Point(191, 70);
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
            rbPartTime.ForeColor = SystemColors.ActiveCaptionText;
            rbPartTime.Location = new Point(191, 34);
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
            rbRemoteWork.ForeColor = SystemColors.ActiveCaptionText;
            rbRemoteWork.Location = new Point(10, 71);
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
            rbFullTime.ForeColor = SystemColors.ActiveCaptionText;
            rbFullTime.Location = new Point(10, 33);
            rbFullTime.Margin = new Padding(4);
            rbFullTime.Name = "rbFullTime";
            rbFullTime.Size = new Size(181, 29);
            rbFullTime.TabIndex = 7;
            rbFullTime.TabStop = true;
            rbFullTime.Text = "Полная занятость";
            rbFullTime.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(nudSalaryTo);
            groupBox5.Controls.Add(nudSalaryFrom);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label8);
            groupBox5.ForeColor = SystemColors.Highlight;
            groupBox5.Location = new Point(428, 661);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(446, 104);
            groupBox5.TabIndex = 72;
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
            label9.Location = new Point(168, 48);
            label9.Name = "label9";
            label9.Size = new Size(35, 25);
            label9.TabIndex = 22;
            label9.Text = "До";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 48);
            label8.Name = "label8";
            label8.Size = new Size(33, 25);
            label8.TabIndex = 21;
            label8.Text = "От";
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
            groupBox4.Location = new Point(90, 661);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(299, 218);
            groupBox4.TabIndex = 67;
            groupBox4.TabStop = false;
            groupBox4.Text = "Дргуие сведения";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 120);
            label7.Name = "label7";
            label7.Size = new Size(140, 25);
            label7.TabIndex = 21;
            label7.Text = "Категория прав";
            // 
            // rbCategoryD
            // 
            rbCategoryD.AutoSize = true;
            rbCategoryD.Location = new Point(166, 148);
            rbCategoryD.Name = "rbCategoryD";
            rbCategoryD.Size = new Size(51, 29);
            rbCategoryD.TabIndex = 20;
            rbCategoryD.Text = "D";
            rbCategoryD.UseVisualStyleBackColor = true;
            // 
            // rbCategoryC
            // 
            rbCategoryC.AutoSize = true;
            rbCategoryC.Location = new Point(115, 148);
            rbCategoryC.Name = "rbCategoryC";
            rbCategoryC.Size = new Size(49, 29);
            rbCategoryC.TabIndex = 19;
            rbCategoryC.Text = "С";
            rbCategoryC.UseVisualStyleBackColor = true;
            // 
            // rbCategoryB
            // 
            rbCategoryB.AutoSize = true;
            rbCategoryB.Location = new Point(61, 148);
            rbCategoryB.Name = "rbCategoryB";
            rbCategoryB.Size = new Size(48, 29);
            rbCategoryB.TabIndex = 18;
            rbCategoryB.Text = "В";
            rbCategoryB.UseVisualStyleBackColor = true;
            // 
            // rbCategoryA
            // 
            rbCategoryA.AutoSize = true;
            rbCategoryA.Location = new Point(9, 148);
            rbCategoryA.Name = "rbCategoryA";
            rbCategoryA.Size = new Size(50, 29);
            rbCategoryA.TabIndex = 17;
            rbCategoryA.Text = "А";
            rbCategoryA.UseVisualStyleBackColor = true;
            // 
            // cbHasDriversLicense
            // 
            cbHasDriversLicense.AutoSize = true;
            cbHasDriversLicense.Location = new Point(9, 79);
            cbHasDriversLicense.Name = "cbHasDriversLicense";
            cbHasDriversLicense.Size = new Size(279, 29);
            cbHasDriversLicense.TabIndex = 16;
            cbHasDriversLicense.Text = "Водительское удостоверение";
            cbHasDriversLicense.UseVisualStyleBackColor = true;
            // 
            // cbHasCar
            // 
            cbHasCar.AutoSize = true;
            cbHasCar.Location = new Point(9, 44);
            cbHasCar.Name = "cbHasCar";
            cbHasCar.Size = new Size(223, 29);
            cbHasCar.TabIndex = 15;
            cbHasCar.Text = "Наличие личного авто";
            cbHasCar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbMoreThan10Years);
            groupBox3.Controls.Add(rb5To10Years);
            groupBox3.Controls.Add(rb1To5Years);
            groupBox3.Controls.Add(rbLessThan1Year);
            groupBox3.Controls.Add(rbNoExperience);
            groupBox3.ForeColor = SystemColors.Highlight;
            groupBox3.Location = new Point(90, 502);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(798, 137);
            groupBox3.TabIndex = 65;
            groupBox3.TabStop = false;
            groupBox3.Text = "Опыт работы";
            // 
            // rbMoreThan10Years
            // 
            rbMoreThan10Years.AutoSize = true;
            rbMoreThan10Years.ForeColor = SystemColors.ActiveCaptionText;
            rbMoreThan10Years.Location = new Point(462, 44);
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
            rb5To10Years.ForeColor = SystemColors.ActiveCaptionText;
            rb5To10Years.Location = new Point(245, 81);
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
            rb1To5Years.ForeColor = SystemColors.ActiveCaptionText;
            rb1To5Years.Location = new Point(245, 44);
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
            rbLessThan1Year.ForeColor = SystemColors.ActiveCaptionText;
            rbLessThan1Year.Location = new Point(19, 81);
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
            rbNoExperience.ForeColor = SystemColors.ActiveCaptionText;
            rbNoExperience.Location = new Point(19, 44);
            rbNoExperience.Margin = new Padding(4);
            rbNoExperience.Name = "rbNoExperience";
            rbNoExperience.Size = new Size(197, 29);
            rbNoExperience.TabIndex = 2;
            rbNoExperience.TabStop = true;
            rbNoExperience.Text = "Прежде не работал";
            rbNoExperience.UseVisualStyleBackColor = true;
            // 
            // txtMobilePhone
            // 
            txtMobilePhone.Location = new Point(468, 446);
            txtMobilePhone.Margin = new Padding(4);
            txtMobilePhone.Name = "txtMobilePhone";
            txtMobilePhone.Size = new Size(182, 31);
            txtMobilePhone.TabIndex = 70;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(332, 400);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 31);
            txtEmail.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 446);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(182, 25);
            label6.TabIndex = 68;
            label6.Text = "Мобильный телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 400);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(228, 25);
            label5.TabIndex = 66;
            label5.Text = "Адрес электронной почты";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 357);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 64;
            label4.Text = "Место проживания";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpBirthDate);
            groupBox2.ForeColor = SystemColors.Highlight;
            groupBox2.Location = new Point(82, 234);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(798, 99);
            groupBox2.TabIndex = 63;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(565, 110);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(315, 116);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пол";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.ForeColor = SystemColors.ActiveCaptionText;
            rbFemale.Location = new Point(74, 68);
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
            rbMale.ForeColor = SystemColors.ActiveCaptionText;
            rbMale.Location = new Point(74, 31);
            rbMale.Margin = new Padding(4);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(113, 29);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Мужской";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(79, 192);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 61;
            label3.Text = "Отчество";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(178, 192);
            txtMiddleName.Margin = new Padding(4);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(242, 31);
            txtMiddleName.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(79, 151);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 59;
            label2.Text = "Имя";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(178, 151);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(242, 31);
            txtFirstName.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(79, 110);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 57;
            label1.Text = "Фамилия";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(178, 110);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(242, 31);
            txtLastName.TabIndex = 56;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1169, 33);
            toolStrip1.TabIndex = 80;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "Сохранить ";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "Очистить";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 28);
            toolStripButton3.Text = "Отмена";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { spWin });
            statusStrip1.Location = new Point(0, 1122);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1169, 32);
            statusStrip1.TabIndex = 81;
            // 
            // spWin
            // 
            spWin.Name = "spWin";
            spWin.Size = new Size(60, 25);
            spWin.Text = "Status";
            // 
            // statusStrip2
            // 
            statusStrip2.ImageScalingSize = new Size(24, 24);
            statusStrip2.Items.AddRange(new ToolStripItem[] { spData });
            statusStrip2.Location = new Point(0, 1090);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(1169, 32);
            statusStrip2.TabIndex = 82;
            statusStrip2.Text = "statusStrip2";
            // 
            // spData
            // 
            spData.Name = "spData";
            spData.Size = new Size(49, 25);
            spData.Text = "Data";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 1154);
            Controls.Add(statusStrip2);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(comboBoxMobileOperator);
            Controls.Add(comboBoxCity);
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
            Name = "Form1";
            Text = "Form1";
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSalaryTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSalaryFrom).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMobileOperator;
        private ComboBox comboBoxCity;
        private Label label10;
        private TextBox txtResume;
        private GroupBox groupBox6;
        private RadioButton rbShiftWork;
        private RadioButton rbPartTime;
        private RadioButton rbRemoteWork;
        private RadioButton rbFullTime;
        private GroupBox groupBox5;
        private NumericUpDown nudSalaryTo;
        private NumericUpDown nudSalaryFrom;
        private Label label9;
        private Label label8;
        private GroupBox groupBox4;
        private Label label7;
        private CheckBox rbCategoryD;
        private CheckBox rbCategoryC;
        private CheckBox rbCategoryB;
        private CheckBox rbCategoryA;
        private CheckBox cbHasDriversLicense;
        private CheckBox cbHasCar;
        private GroupBox groupBox3;
        private RadioButton rbMoreThan10Years;
        private RadioButton rb5To10Years;
        private RadioButton rb1To5Years;
        private RadioButton rbLessThan1Year;
        private RadioButton rbNoExperience;
        private TextBox txtMobilePhone;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private DateTimePicker dtpBirthDate;
        private GroupBox groupBox1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label label3;
        private TextBox txtMiddleName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
        private TextBox txtLastName;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel spWin;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel spData;
    }
}
