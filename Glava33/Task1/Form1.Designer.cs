namespace Task1
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
            this.dataGridViewTourists = new System.Windows.Forms.DataGridView();
            this.dataGridViewTouristInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTours = new System.Windows.Forms.DataGridView();
            this.dataGridViewSeasons = new System.Windows.Forms.DataGridView();
            this.dataGridViewVouchers = new System.Windows.Forms.DataGridView();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTouristInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeasons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVouchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTourists
            // 
            this.dataGridViewTourists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTourists.Location = new System.Drawing.Point(12, 37);
            this.dataGridViewTourists.Name = "dataGridViewTourists";
            this.dataGridViewTourists.RowHeadersWidth = 62;
            this.dataGridViewTourists.RowTemplate.Height = 28;
            this.dataGridViewTourists.Size = new System.Drawing.Size(952, 176);
            this.dataGridViewTourists.TabIndex = 0;
            // 
            // dataGridViewTouristInfo
            // 
            this.dataGridViewTouristInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTouristInfo.Location = new System.Drawing.Point(12, 219);
            this.dataGridViewTouristInfo.Name = "dataGridViewTouristInfo";
            this.dataGridViewTouristInfo.RowHeadersWidth = 62;
            this.dataGridViewTouristInfo.RowTemplate.Height = 28;
            this.dataGridViewTouristInfo.Size = new System.Drawing.Size(952, 179);
            this.dataGridViewTouristInfo.TabIndex = 1;
            // 
            // dataGridViewTours
            // 
            this.dataGridViewTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTours.Location = new System.Drawing.Point(12, 404);
            this.dataGridViewTours.Name = "dataGridViewTours";
            this.dataGridViewTours.RowHeadersWidth = 62;
            this.dataGridViewTours.RowTemplate.Height = 28;
            this.dataGridViewTours.Size = new System.Drawing.Size(952, 175);
            this.dataGridViewTours.TabIndex = 2;
            // 
            // dataGridViewSeasons
            // 
            this.dataGridViewSeasons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeasons.Location = new System.Drawing.Point(12, 585);
            this.dataGridViewSeasons.Name = "dataGridViewSeasons";
            this.dataGridViewSeasons.RowHeadersWidth = 62;
            this.dataGridViewSeasons.RowTemplate.Height = 28;
            this.dataGridViewSeasons.Size = new System.Drawing.Size(952, 181);
            this.dataGridViewSeasons.TabIndex = 3;
            // 
            // dataGridViewVouchers
            // 
            this.dataGridViewVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVouchers.Location = new System.Drawing.Point(12, 772);
            this.dataGridViewVouchers.Name = "dataGridViewVouchers";
            this.dataGridViewVouchers.RowHeadersWidth = 62;
            this.dataGridViewVouchers.RowTemplate.Height = 28;
            this.dataGridViewVouchers.Size = new System.Drawing.Size(952, 180);
            this.dataGridViewVouchers.TabIndex = 4;
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(12, 958);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.RowHeadersWidth = 62;
            this.dataGridViewPayments.RowTemplate.Height = 28;
            this.dataGridViewPayments.Size = new System.Drawing.Size(952, 197);
            this.dataGridViewPayments.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 1253);
            this.Controls.Add(this.dataGridViewPayments);
            this.Controls.Add(this.dataGridViewVouchers);
            this.Controls.Add(this.dataGridViewSeasons);
            this.Controls.Add(this.dataGridViewTours);
            this.Controls.Add(this.dataGridViewTouristInfo);
            this.Controls.Add(this.dataGridViewTourists);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTouristInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeasons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVouchers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTourists;
        private System.Windows.Forms.DataGridView dataGridViewTouristInfo;
        private System.Windows.Forms.DataGridView dataGridViewTours;
        private System.Windows.Forms.DataGridView dataGridViewSeasons;
        private System.Windows.Forms.DataGridView dataGridViewVouchers;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
    }
}

