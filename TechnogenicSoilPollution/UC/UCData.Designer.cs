
namespace TechnogenicSoilPollution.UC
{
    partial class UCData
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateDataBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DeleteDataBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ExportDataBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SelectYearCB = new System.Windows.Forms.ComboBox();
            this.SelectDataFiltersBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectElementsCB = new System.Windows.Forms.ComboBox();
            this.AddNewRowBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddDataBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(5, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Элемент:";
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AllowUserToAddRows = false;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.MainDataGridView.Location = new System.Drawing.Point(5, 50);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.Size = new System.Drawing.Size(1021, 526);
            this.MainDataGridView.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Direction";
            this.Column1.HeaderText = "Направление";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Number_point";
            this.Column2.HeaderText = "№ точки";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Distance";
            this.Column3.HeaderText = "Расстояние";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Latitude";
            this.Column4.HeaderText = "Широта";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Longitude";
            this.Column5.HeaderText = "Долгота";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Name_phase";
            this.Column6.HeaderText = "Фаза";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Content_elements";
            this.Column7.HeaderText = "Содержание";
            this.Column7.Name = "Column7";
            this.Column7.Width = 130;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Stocks_elements";
            this.Column8.HeaderText = "Запасы";
            this.Column8.Name = "Column8";
            this.Column8.Width = 120;
            // 
            // UpdateDataBtn
            // 
            this.UpdateDataBtn.Depth = 0;
            this.UpdateDataBtn.Location = new System.Drawing.Point(465, 596);
            this.UpdateDataBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateDataBtn.Name = "UpdateDataBtn";
            this.UpdateDataBtn.Primary = true;
            this.UpdateDataBtn.Size = new System.Drawing.Size(130, 44);
            this.UpdateDataBtn.TabIndex = 3;
            this.UpdateDataBtn.Text = "Обновить данные";
            this.UpdateDataBtn.UseVisualStyleBackColor = true;
            this.UpdateDataBtn.Click += new System.EventHandler(this.UpdateDataBtn_Click);
            // 
            // DeleteDataBtn
            // 
            this.DeleteDataBtn.Depth = 0;
            this.DeleteDataBtn.Location = new System.Drawing.Point(737, 596);
            this.DeleteDataBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteDataBtn.Name = "DeleteDataBtn";
            this.DeleteDataBtn.Primary = true;
            this.DeleteDataBtn.Size = new System.Drawing.Size(130, 44);
            this.DeleteDataBtn.TabIndex = 4;
            this.DeleteDataBtn.Text = "Удалить данные";
            this.DeleteDataBtn.UseVisualStyleBackColor = true;
            this.DeleteDataBtn.Click += new System.EventHandler(this.DeleteDataBtn_Click);
            // 
            // ExportDataBtn
            // 
            this.ExportDataBtn.Depth = 0;
            this.ExportDataBtn.Location = new System.Drawing.Point(873, 596);
            this.ExportDataBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportDataBtn.Name = "ExportDataBtn";
            this.ExportDataBtn.Primary = true;
            this.ExportDataBtn.Size = new System.Drawing.Size(130, 44);
            this.ExportDataBtn.TabIndex = 5;
            this.ExportDataBtn.Text = "Экспорт данных";
            this.ExportDataBtn.UseVisualStyleBackColor = true;
            this.ExportDataBtn.Click += new System.EventHandler(this.ExportDataBtn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(225, 20);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Год:";
            // 
            // SelectYearCB
            // 
            this.SelectYearCB.FormattingEnabled = true;
            this.SelectYearCB.Location = new System.Drawing.Point(270, 20);
            this.SelectYearCB.Name = "SelectYearCB";
            this.SelectYearCB.Size = new System.Drawing.Size(99, 21);
            this.SelectYearCB.TabIndex = 7;
            // 
            // SelectDataFiltersBtn
            // 
            this.SelectDataFiltersBtn.Depth = 0;
            this.SelectDataFiltersBtn.Location = new System.Drawing.Point(390, 14);
            this.SelectDataFiltersBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectDataFiltersBtn.Name = "SelectDataFiltersBtn";
            this.SelectDataFiltersBtn.Primary = true;
            this.SelectDataFiltersBtn.Size = new System.Drawing.Size(100, 30);
            this.SelectDataFiltersBtn.TabIndex = 8;
            this.SelectDataFiltersBtn.Text = "Выбрать";
            this.SelectDataFiltersBtn.UseVisualStyleBackColor = true;
            this.SelectDataFiltersBtn.Click += new System.EventHandler(this.SelectDataFiltersBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "\"-\" - означает, что для выбранного элемента\r\nне проводидись измеренеия.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Подсказка:";
            // 
            // SelectElementsCB
            // 
            this.SelectElementsCB.FormattingEnabled = true;
            this.SelectElementsCB.Location = new System.Drawing.Point(86, 20);
            this.SelectElementsCB.Name = "SelectElementsCB";
            this.SelectElementsCB.Size = new System.Drawing.Size(121, 21);
            this.SelectElementsCB.TabIndex = 11;
            // 
            // AddNewRowBtn
            // 
            this.AddNewRowBtn.Depth = 0;
            this.AddNewRowBtn.Location = new System.Drawing.Point(329, 596);
            this.AddNewRowBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddNewRowBtn.Name = "AddNewRowBtn";
            this.AddNewRowBtn.Primary = true;
            this.AddNewRowBtn.Size = new System.Drawing.Size(130, 44);
            this.AddNewRowBtn.TabIndex = 12;
            this.AddNewRowBtn.Text = "Добавить строку";
            this.AddNewRowBtn.UseVisualStyleBackColor = true;
            this.AddNewRowBtn.Click += new System.EventHandler(this.AddNewRowBtn_Click);
            // 
            // AddDataBtn
            // 
            this.AddDataBtn.Depth = 0;
            this.AddDataBtn.Location = new System.Drawing.Point(601, 596);
            this.AddDataBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddDataBtn.Name = "AddDataBtn";
            this.AddDataBtn.Primary = true;
            this.AddDataBtn.Size = new System.Drawing.Size(130, 44);
            this.AddDataBtn.TabIndex = 13;
            this.AddDataBtn.Text = "Добавить данные";
            this.AddDataBtn.UseVisualStyleBackColor = true;
            this.AddDataBtn.Click += new System.EventHandler(this.AddDataBtn_Click);
            // 
            // UCData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddDataBtn);
            this.Controls.Add(this.AddNewRowBtn);
            this.Controls.Add(this.SelectElementsCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectDataFiltersBtn);
            this.Controls.Add(this.SelectYearCB);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.ExportDataBtn);
            this.Controls.Add(this.DeleteDataBtn);
            this.Controls.Add(this.UpdateDataBtn);
            this.Controls.Add(this.MainDataGridView);
            this.Controls.Add(this.materialLabel1);
            this.Name = "UCData";
            this.Size = new System.Drawing.Size(1031, 657);
            this.Load += new System.EventHandler(this.UCData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView MainDataGridView;
        private MaterialSkin.Controls.MaterialRaisedButton UpdateDataBtn;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteDataBtn;
        private MaterialSkin.Controls.MaterialRaisedButton ExportDataBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox SelectYearCB;
        private MaterialSkin.Controls.MaterialRaisedButton SelectDataFiltersBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectElementsCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private MaterialSkin.Controls.MaterialRaisedButton AddNewRowBtn;
        private MaterialSkin.Controls.MaterialRaisedButton AddDataBtn;
    }
}
