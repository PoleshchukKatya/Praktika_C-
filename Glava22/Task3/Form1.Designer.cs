namespace Task3
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
            CalculateButton = new Button();
            textBoxX0 = new TextBox();
            textBoxXk = new TextBox();
            textBoxDx = new TextBox();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            listBoxResults = new ListBox();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(344, 85);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(114, 29);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "Решить";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // textBoxX0
            // 
            textBoxX0.Location = new Point(37, 31);
            textBoxX0.Name = "textBoxX0";
            textBoxX0.Size = new Size(120, 27);
            textBoxX0.TabIndex = 1;
            // 
            // textBoxXk
            // 
            textBoxXk.Location = new Point(189, 31);
            textBoxXk.Name = "textBoxXk";
            textBoxXk.Size = new Size(120, 27);
            textBoxXk.TabIndex = 2;
            // 
            // textBoxDx
            // 
            textBoxDx.Location = new Point(344, 31);
            textBoxDx.Name = "textBoxDx";
            textBoxDx.Size = new Size(120, 27);
            textBoxDx.TabIndex = 3;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(491, 31);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(120, 27);
            textBoxA.TabIndex = 4;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(638, 31);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(120, 27);
            textBoxB.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 7;
            label1.Text = "X0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 34);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 8;
            label2.Text = "Xk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 34);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 9;
            label3.Text = "Dx";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 34);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 10;
            label4.Text = "A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(624, 34);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 11;
            label5.Text = "B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(243, 145);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 12;
            label6.Text = "Результат";
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(243, 168);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(327, 204);
            listBoxResults.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResults);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(textBoxDx);
            Controls.Add(textBoxXk);
            Controls.Add(textBoxX0);
            Controls.Add(CalculateButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateButton;
        private TextBox textBoxX0;
        private TextBox textBoxXk;
        private TextBox textBoxDx;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox listBoxResults;
    }
}
