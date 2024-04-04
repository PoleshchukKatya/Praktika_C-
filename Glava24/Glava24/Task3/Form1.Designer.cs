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
            ColorChangingButton = new Button();
            SuspendLayout();
            // 
            // ColorChangingButton
            // 
            ColorChangingButton.Location = new Point(333, 192);
            ColorChangingButton.Name = "ColorChangingButton";
            ColorChangingButton.Size = new Size(112, 34);
            ColorChangingButton.TabIndex = 0;
            ColorChangingButton.Text = "Клик";
            ColorChangingButton.UseVisualStyleBackColor = true;
            ColorChangingButton.Click += ColorChangingButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ColorChangingButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ColorChangingButton;
    }
}
