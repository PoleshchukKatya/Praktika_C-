namespace Task2
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
            calculateButton = new Button();
            textBoxX = new TextBox();
            X = new Label();
            textBoxY = new TextBox();
            textBoxResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(215, 195);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(108, 29);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Решить";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(215, 86);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(122, 27);
            textBoxX.TabIndex = 1;
            // 
            // X
            // 
            X.AutoSize = true;
            X.Location = new Point(191, 93);
            X.Name = "X";
            X.Size = new Size(18, 20);
            X.TabIndex = 2;
            X.Text = "X";
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(215, 130);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(122, 27);
            textBoxY.TabIndex = 3;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(215, 240);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(122, 27);
            textBoxResult.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 137);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 5;
            label1.Text = "Y";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 247);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 6;
            label2.Text = "W";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxY);
            Controls.Add(X);
            Controls.Add(textBoxX);
            Controls.Add(calculateButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private TextBox textBoxX;
        private Label X;
        private TextBox textBoxY;
        private TextBox textBoxResult;
        private Label label1;
        private Label label2;
    }
}
