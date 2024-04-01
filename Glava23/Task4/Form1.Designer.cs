namespace Task4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.controlTypeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.yCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.createControlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "БУКВА";
            // 
            // controlTypeTextBox
            // 
            this.controlTypeTextBox.Location = new System.Drawing.Point(73, 52);
            this.controlTypeTextBox.Name = "controlTypeTextBox";
            this.controlTypeTextBox.Size = new System.Drawing.Size(138, 26);
            this.controlTypeTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Координаты элементы";
            // 
            // xCoordinateTextBox
            // 
            this.xCoordinateTextBox.Location = new System.Drawing.Point(73, 163);
            this.xCoordinateTextBox.Name = "xCoordinateTextBox";
            this.xCoordinateTextBox.Size = new System.Drawing.Size(138, 26);
            this.xCoordinateTextBox.TabIndex = 3;
            // 
            // yCoordinateTextBox
            // 
            this.yCoordinateTextBox.Location = new System.Drawing.Point(73, 195);
            this.yCoordinateTextBox.Name = "yCoordinateTextBox";
            this.yCoordinateTextBox.Size = new System.Drawing.Size(138, 26);
            this.yCoordinateTextBox.TabIndex = 4;
            // 
            // createControlButton
            // 
            this.createControlButton.Location = new System.Drawing.Point(344, 48);
            this.createControlButton.Name = "createControlButton";
            this.createControlButton.Size = new System.Drawing.Size(90, 30);
            this.createControlButton.TabIndex = 7;
            this.createControlButton.Text = "Создать";
            this.createControlButton.UseVisualStyleBackColor = true;
            this.createControlButton.Click += new System.EventHandler(this.createControlButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 477);
            this.Controls.Add(this.createControlButton);
            this.Controls.Add(this.yCoordinateTextBox);
            this.Controls.Add(this.xCoordinateTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.controlTypeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox controlTypeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xCoordinateTextBox;
        private System.Windows.Forms.TextBox yCoordinateTextBox;
        private System.Windows.Forms.Button createControlButton;
    }
}

