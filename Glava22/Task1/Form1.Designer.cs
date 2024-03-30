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
            btnCalculate = new Button();
            lblResult = new Label();
            txtX = new TextBox();
            txtY = new TextBox();
            txtZ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(57, 207);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Вычислить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(57, 173);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 1;
            // 
            // txtX
            // 
            txtX.Location = new Point(69, 77);
            txtX.Name = "txtX";
            txtX.Size = new Size(125, 27);
            txtX.TabIndex = 2;
            // 
            // txtY
            // 
            txtY.Location = new Point(69, 110);
            txtY.Name = "txtY";
            txtY.Size = new Size(125, 27);
            txtY.TabIndex = 3;
            // 
            // txtZ
            // 
            txtZ.Location = new Point(69, 143);
            txtZ.Name = "txtZ";
            txtZ.Size = new Size(125, 27);
            txtZ.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 81);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 5;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 117);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 6;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 150);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 7;
            label3.Text = "Z";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtZ);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label lblResult;
        private TextBox txtX;
        private TextBox txtY;
        private TextBox txtZ;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
