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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewTours = new System.Windows.Forms.DataGridView();
            this.кодТураDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.турыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTur_firmDataSet = new Task1.DBTur_firmDataSet();
            this.турыTableAdapter = new Task1.DBTur_firmDataSetTableAdapters.ТурыTableAdapter();
            this.btnSelectAllTours = new System.Windows.Forms.Button();
            this.btnDeleteTour = new System.Windows.Forms.Button();
            this.dataGridViewTourists = new System.Windows.Forms.DataGridView();
            this.btnAddTourist = new System.Windows.Forms.Button();
            this.btnSelectAllTourists = new System.Windows.Forms.Button();
            this.btnUpdateTourist = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtTourId = new System.Windows.Forms.TextBox();
            this.txtTouristId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.турыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTur_firmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourists)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTours
            // 
            this.dataGridViewTours.AutoGenerateColumns = false;
            this.dataGridViewTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТураDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.информацияDataGridViewTextBoxColumn});
            this.dataGridViewTours.DataSource = this.турыBindingSource;
            this.dataGridViewTours.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTours.Name = "dataGridViewTours";
            this.dataGridViewTours.RowHeadersWidth = 62;
            this.dataGridViewTours.RowTemplate.Height = 28;
            this.dataGridViewTours.Size = new System.Drawing.Size(1063, 260);
            this.dataGridViewTours.TabIndex = 0;
            // 
            // кодТураDataGridViewTextBoxColumn
            // 
            this.кодТураDataGridViewTextBoxColumn.DataPropertyName = "Код тура";
            this.кодТураDataGridViewTextBoxColumn.HeaderText = "Код тура";
            this.кодТураDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодТураDataGridViewTextBoxColumn.Name = "кодТураDataGridViewTextBoxColumn";
            this.кодТураDataGridViewTextBoxColumn.Width = 150;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 150;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 150;
            // 
            // информацияDataGridViewTextBoxColumn
            // 
            this.информацияDataGridViewTextBoxColumn.DataPropertyName = "Информация";
            this.информацияDataGridViewTextBoxColumn.HeaderText = "Информация";
            this.информацияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.информацияDataGridViewTextBoxColumn.Name = "информацияDataGridViewTextBoxColumn";
            this.информацияDataGridViewTextBoxColumn.Width = 150;
            // 
            // турыBindingSource
            // 
            this.турыBindingSource.DataMember = "Туры";
            this.турыBindingSource.DataSource = this.dBTur_firmDataSet;
            // 
            // dBTur_firmDataSet
            // 
            this.dBTur_firmDataSet.DataSetName = "DBTur_firmDataSet";
            this.dBTur_firmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // турыTableAdapter
            // 
            this.турыTableAdapter.ClearBeforeFill = true;
            // 
            // btnSelectAllTours
            // 
            this.btnSelectAllTours.Location = new System.Drawing.Point(12, 278);
            this.btnSelectAllTours.Name = "btnSelectAllTours";
            this.btnSelectAllTours.Size = new System.Drawing.Size(166, 56);
            this.btnSelectAllTours.TabIndex = 1;
            this.btnSelectAllTours.Text = "Все туры";
            this.btnSelectAllTours.UseVisualStyleBackColor = true;
            this.btnSelectAllTours.Click += new System.EventHandler(this.btnSelectAllTours_Click);
            // 
            // btnDeleteTour
            // 
            this.btnDeleteTour.Location = new System.Drawing.Point(184, 278);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Size = new System.Drawing.Size(166, 56);
            this.btnDeleteTour.TabIndex = 2;
            this.btnDeleteTour.Text = "Удалить тур";
            this.btnDeleteTour.UseVisualStyleBackColor = true;
            this.btnDeleteTour.Click += new System.EventHandler(this.btnDeleteTour_Click);
            // 
            // dataGridViewTourists
            // 
            this.dataGridViewTourists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTourists.Location = new System.Drawing.Point(12, 363);
            this.dataGridViewTourists.Name = "dataGridViewTourists";
            this.dataGridViewTourists.RowHeadersWidth = 62;
            this.dataGridViewTourists.RowTemplate.Height = 28;
            this.dataGridViewTourists.Size = new System.Drawing.Size(1063, 225);
            this.dataGridViewTourists.TabIndex = 3;
            // 
            // btnAddTourist
            // 
            this.btnAddTourist.Location = new System.Drawing.Point(184, 594);
            this.btnAddTourist.Name = "btnAddTourist";
            this.btnAddTourist.Size = new System.Drawing.Size(166, 56);
            this.btnAddTourist.TabIndex = 4;
            this.btnAddTourist.Text = "Добавить туриста";
            this.btnAddTourist.UseVisualStyleBackColor = true;
            this.btnAddTourist.Click += new System.EventHandler(this.btnAddTourist_Click);
            // 
            // btnSelectAllTourists
            // 
            this.btnSelectAllTourists.Location = new System.Drawing.Point(12, 594);
            this.btnSelectAllTourists.Name = "btnSelectAllTourists";
            this.btnSelectAllTourists.Size = new System.Drawing.Size(166, 56);
            this.btnSelectAllTourists.TabIndex = 5;
            this.btnSelectAllTourists.Text = "Все туристы";
            this.btnSelectAllTourists.UseVisualStyleBackColor = true;
            this.btnSelectAllTourists.Click += new System.EventHandler(this.btnSelectAllTourists_Click);
            // 
            // btnUpdateTourist
            // 
            this.btnUpdateTourist.Location = new System.Drawing.Point(356, 594);
            this.btnUpdateTourist.Name = "btnUpdateTourist";
            this.btnUpdateTourist.Size = new System.Drawing.Size(166, 56);
            this.btnUpdateTourist.TabIndex = 6;
            this.btnUpdateTourist.Text = "Изменить туриста";
            this.btnUpdateTourist.UseVisualStyleBackColor = true;
            this.btnUpdateTourist.Click += new System.EventHandler(this.btnUpdateTourist_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(184, 656);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(143, 26);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(333, 656);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(143, 26);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(482, 656);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(143, 26);
            this.txtMiddleName.TabIndex = 9;
            // 
            // txtTourId
            // 
            this.txtTourId.Location = new System.Drawing.Point(356, 278);
            this.txtTourId.Name = "txtTourId";
            this.txtTourId.Size = new System.Drawing.Size(143, 26);
            this.txtTourId.TabIndex = 10;
            // 
            // txtTouristId
            // 
            this.txtTouristId.Location = new System.Drawing.Point(528, 594);
            this.txtTouristId.Name = "txtTouristId";
            this.txtTouristId.Size = new System.Drawing.Size(143, 26);
            this.txtTouristId.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 708);
            this.Controls.Add(this.txtTouristId);
            this.Controls.Add(this.txtTourId);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnUpdateTourist);
            this.Controls.Add(this.btnSelectAllTourists);
            this.Controls.Add(this.btnAddTourist);
            this.Controls.Add(this.dataGridViewTourists);
            this.Controls.Add(this.btnDeleteTour);
            this.Controls.Add(this.btnSelectAllTours);
            this.Controls.Add(this.dataGridViewTours);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.турыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTur_firmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTours;
        private DBTur_firmDataSet dBTur_firmDataSet;
        private System.Windows.Forms.BindingSource турыBindingSource;
        private DBTur_firmDataSetTableAdapters.ТурыTableAdapter турыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТураDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn информацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSelectAllTours;
        private System.Windows.Forms.Button btnDeleteTour;
        private System.Windows.Forms.DataGridView dataGridViewTourists;
        private System.Windows.Forms.Button btnAddTourist;
        private System.Windows.Forms.Button btnSelectAllTourists;
        private System.Windows.Forms.Button btnUpdateTourist;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtTourId;
        private System.Windows.Forms.TextBox txtTouristId;
    }
}

