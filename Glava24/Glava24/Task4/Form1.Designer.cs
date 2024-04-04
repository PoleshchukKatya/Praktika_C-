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
            components = new System.ComponentModel.Container();
            helpProvider1 = new HelpProvider();
            txbA = new TextBox();
            txbB = new TextBox();
            btnRun = new Button();
            btnWork = new Button();
            button1 = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "\"D:\\Практика С#\\Glava24\\Glava24\\Документ Microsoft Word.docx\"";
            // 
            // txbA
            // 
            helpProvider1.SetHelpString(txbA, "Для входного целого числа A");
            txbA.Location = new Point(46, 51);
            txbA.Margin = new Padding(2, 2, 2, 2);
            txbA.Name = "txbA";
            helpProvider1.SetShowHelp(txbA, true);
            txbA.Size = new Size(121, 27);
            txbA.TabIndex = 0;
            toolTip1.SetToolTip(txbA, "Для входного целого числа A");
            // 
            // txbB
            // 
            helpProvider1.SetHelpString(txbB, "Для входного целого числа B");
            txbB.Location = new Point(46, 90);
            txbB.Margin = new Padding(2, 2, 2, 2);
            txbB.Name = "txbB";
            helpProvider1.SetShowHelp(txbB, true);
            txbB.Size = new Size(121, 27);
            txbB.TabIndex = 1;
            toolTip1.SetToolTip(txbB, "Для входного целого числа B");
            // 
            // btnRun
            // 
            helpProvider1.SetHelpString(btnRun, "Сумма");
            btnRun.Location = new Point(46, 133);
            btnRun.Margin = new Padding(2, 2, 2, 2);
            btnRun.Name = "btnRun";
            helpProvider1.SetShowHelp(btnRun, true);
            btnRun.Size = new Size(90, 27);
            btnRun.TabIndex = 2;
            btnRun.Text = "Сумма";
            toolTip1.SetToolTip(btnRun, "Сумма");
            btnRun.UseVisualStyleBackColor = true;
            // 
            // btnWork
            // 
            helpProvider1.SetHelpString(btnWork, "Начать");
            btnWork.Location = new Point(46, 174);
            btnWork.Margin = new Padding(2, 2, 2, 2);
            btnWork.Name = "btnWork";
            helpProvider1.SetShowHelp(btnWork, true);
            btnWork.Size = new Size(90, 27);
            btnWork.TabIndex = 3;
            btnWork.Text = "Старт";
            toolTip1.SetToolTip(btnWork, "Начать");
            btnWork.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(46, 316);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 4;
            button1.Text = "Помощь";
            toolTip1.SetToolTip(button1, "Помощь");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(button1);
            Controls.Add(btnWork);
            Controls.Add(btnRun);
            Controls.Add(txbB);
            Controls.Add(txbA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HelpProvider helpProvider1;
        private TextBox txbA;
        private TextBox txbB;
        private Button btnRun;
        private Button btnWork;
        private Button button1;
        private ToolTip toolTip1;
    }
}
