
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
            this.SelectElementsBox = new System.Windows.Forms.ComboBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.UpdateDataBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DeleteDataBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ExportDataBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SelectYearBox = new System.Windows.Forms.ComboBox();
            this.SelectDataFiltersBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
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
            // SelectElementsBox
            // 
            this.SelectElementsBox.FormattingEnabled = true;
            this.SelectElementsBox.Location = new System.Drawing.Point(86, 20);
            this.SelectElementsBox.Name = "SelectElementsBox";
            this.SelectElementsBox.Size = new System.Drawing.Size(121, 21);
            this.SelectElementsBox.TabIndex = 1;
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DataGrid.Location = new System.Drawing.Point(5, 50);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(920, 510);
            this.DataGrid.TabIndex = 2;
            // 
            // UpdateDataBtn
            // 
            this.UpdateDataBtn.Depth = 0;
            this.UpdateDataBtn.Location = new System.Drawing.Point(340, 574);
            this.UpdateDataBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateDataBtn.Name = "UpdateDataBtn";
            this.UpdateDataBtn.Primary = true;
            this.UpdateDataBtn.Size = new System.Drawing.Size(100, 40);
            this.UpdateDataBtn.TabIndex = 3;
            this.UpdateDataBtn.Text = "Обновить";
            this.UpdateDataBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteDataBtn
            // 
            this.DeleteDataBtn.Depth = 0;
            this.DeleteDataBtn.Location = new System.Drawing.Point(446, 574);
            this.DeleteDataBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteDataBtn.Name = "DeleteDataBtn";
            this.DeleteDataBtn.Primary = true;
            this.DeleteDataBtn.Size = new System.Drawing.Size(100, 40);
            this.DeleteDataBtn.TabIndex = 4;
            this.DeleteDataBtn.Text = "Удалить";
            this.DeleteDataBtn.UseVisualStyleBackColor = true;
            // 
            // ExportDataBtn
            // 
            this.ExportDataBtn.Depth = 0;
            this.ExportDataBtn.Location = new System.Drawing.Point(552, 574);
            this.ExportDataBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportDataBtn.Name = "ExportDataBtn";
            this.ExportDataBtn.Primary = true;
            this.ExportDataBtn.Size = new System.Drawing.Size(140, 40);
            this.ExportDataBtn.TabIndex = 5;
            this.ExportDataBtn.Text = "Экпортировать";
            this.ExportDataBtn.UseVisualStyleBackColor = true;
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
            // SelectYearBox
            // 
            this.SelectYearBox.FormattingEnabled = true;
            this.SelectYearBox.Location = new System.Drawing.Point(270, 20);
            this.SelectYearBox.Name = "SelectYearBox";
            this.SelectYearBox.Size = new System.Drawing.Size(99, 21);
            this.SelectYearBox.TabIndex = 7;
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
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Направление";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "№ точки";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Расстояние";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Широта";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Долгота";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Фаза";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Содержание (мг/л)";
            this.Column7.Name = "Column7";
            this.Column7.Width = 130;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Запасы (кг/м3)";
            this.Column8.Name = "Column8";
            this.Column8.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "\"-\" - означает, что для выбранного элемента\r\nне проводидись измеренеия.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Подсказка:";
            // 
            // UCData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectDataFiltersBtn);
            this.Controls.Add(this.SelectYearBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.ExportDataBtn);
            this.Controls.Add(this.DeleteDataBtn);
            this.Controls.Add(this.UpdateDataBtn);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.SelectElementsBox);
            this.Controls.Add(this.materialLabel1);
            this.Name = "UCData";
            this.Size = new System.Drawing.Size(930, 636);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox SelectElementsBox;
        private System.Windows.Forms.DataGridView DataGrid;
        private MaterialSkin.Controls.MaterialRaisedButton UpdateDataBtn;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteDataBtn;
        private MaterialSkin.Controls.MaterialRaisedButton ExportDataBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox SelectYearBox;
        private MaterialSkin.Controls.MaterialRaisedButton SelectDataFiltersBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
