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
            labelResult = new Label();
            button1 = new Button();
            listBoxStrings = new ListBox();
            SuspendLayout();
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(37, 295);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 25);
            labelResult.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(26, 335);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Пуск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxStrings
            // 
            listBoxStrings.FormattingEnabled = true;
            listBoxStrings.ItemHeight = 25;
            listBoxStrings.Items.AddRange(new object[] { "Человек культурен настолько, насколько он способен понять кошку.", "Когда все люди будут такими, как коты в два часа дня, мир достигнет совершенства.", "Мой кот знает, что делать." });
            listBoxStrings.Location = new Point(26, 24);
            listBoxStrings.Name = "listBoxStrings";
            listBoxStrings.Size = new Size(411, 254);
            listBoxStrings.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxStrings);
            Controls.Add(button1);
            Controls.Add(labelResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResult;
        private Button button1;
        private ListBox listBoxStrings;
    }
}
