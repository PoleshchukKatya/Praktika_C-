
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxXmin = new TextBox();
            textBoxXmax = new TextBox();
            textBoxStep = new TextBox();
            calculateButton = new Button();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 341);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "X min";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 341);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "X max";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 341);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 2;
            label3.Text = "Шаг";
            // 
            // textBoxXmin
            // 
            textBoxXmin.Location = new Point(37, 369);
            textBoxXmin.Name = "textBoxXmin";
            textBoxXmin.Size = new Size(118, 31);
            textBoxXmin.TabIndex = 3;
            // 
            // textBoxXmax
            // 
            textBoxXmax.Location = new Point(182, 369);
            textBoxXmax.Name = "textBoxXmax";
            textBoxXmax.Size = new Size(118, 31);
            textBoxXmax.TabIndex = 4;
            // 
            // textBoxStep
            // 
            textBoxStep.Location = new Point(332, 369);
            textBoxStep.Name = "textBoxStep";
            textBoxStep.Size = new Size(118, 31);
            textBoxStep.TabIndex = 5;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(465, 369);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(112, 31);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "Расчет";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(37, 26);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(720, 286);
            chart.TabIndex = 7;
            chart.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 515);
            Controls.Add(chart);
            Controls.Add(calculateButton);
            Controls.Add(textBoxStep);
            Controls.Add(textBoxXmax);
            Controls.Add(textBoxXmin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxXmin;
        private TextBox textBoxXmax;
        private TextBox textBoxStep;
        private Button calculateButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}
