
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
            this.SelectElementsCB = new System.Windows.Forms.ComboBox();
            this.AddNewRowBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddDataBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ReferenceDataBaseBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelPhases = new System.Windows.Forms.Panel();
            this.materialLabelPhase = new MaterialSkin.Controls.MaterialLabel();
            this.SelectPhasesCB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.panelPhases.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 3);
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
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.UpdateDataBtn.Location = new System.Drawing.Point(388, 596);
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
            this.DeleteDataBtn.Location = new System.Drawing.Point(660, 596);
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
            this.ExportDataBtn.Location = new System.Drawing.Point(796, 596);
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
            this.materialLabel2.Location = new System.Drawing.Point(3, 3);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Год:";
            // 
            // SelectYearCB
            // 
            this.SelectYearCB.FormattingEnabled = true;
            this.SelectYearCB.Location = new System.Drawing.Point(48, 3);
            this.SelectYearCB.Name = "SelectYearCB";
            this.SelectYearCB.Size = new System.Drawing.Size(99, 21);
            this.SelectYearCB.TabIndex = 7;
            // 
            // SelectDataFiltersBtn
            // 
            this.SelectDataFiltersBtn.Depth = 0;
            this.SelectDataFiltersBtn.Location = new System.Drawing.Point(581, 14);
            this.SelectDataFiltersBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectDataFiltersBtn.Name = "SelectDataFiltersBtn";
            this.SelectDataFiltersBtn.Primary = true;
            this.SelectDataFiltersBtn.Size = new System.Drawing.Size(100, 30);
            this.SelectDataFiltersBtn.TabIndex = 8;
            this.SelectDataFiltersBtn.Text = "Выбрать";
            this.SelectDataFiltersBtn.UseVisualStyleBackColor = true;
            this.SelectDataFiltersBtn.Click += new System.EventHandler(this.SelectDataFiltersBtn_Click);
            // 
            // SelectElementsCB
            // 
            this.SelectElementsCB.FormattingEnabled = true;
            this.SelectElementsCB.Location = new System.Drawing.Point(84, 3);
            this.SelectElementsCB.Name = "SelectElementsCB";
            this.SelectElementsCB.Size = new System.Drawing.Size(121, 21);
            this.SelectElementsCB.TabIndex = 11;
            // 
            // AddNewRowBtn
            // 
            this.AddNewRowBtn.Depth = 0;
            this.AddNewRowBtn.Location = new System.Drawing.Point(252, 596);
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
            this.AddDataBtn.Location = new System.Drawing.Point(524, 596);
            this.AddDataBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddDataBtn.Name = "AddDataBtn";
            this.AddDataBtn.Primary = true;
            this.AddDataBtn.Size = new System.Drawing.Size(130, 44);
            this.AddDataBtn.TabIndex = 13;
            this.AddDataBtn.Text = "Добавить данные";
            this.AddDataBtn.UseVisualStyleBackColor = true;
            this.AddDataBtn.Click += new System.EventHandler(this.AddDataBtn_Click);
            // 
            // ReferenceDataBaseBtn
            // 
            this.ReferenceDataBaseBtn.Depth = 0;
            this.ReferenceDataBaseBtn.Location = new System.Drawing.Point(116, 596);
            this.ReferenceDataBaseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ReferenceDataBaseBtn.Name = "ReferenceDataBaseBtn";
            this.ReferenceDataBaseBtn.Primary = true;
            this.ReferenceDataBaseBtn.Size = new System.Drawing.Size(130, 44);
            this.ReferenceDataBaseBtn.TabIndex = 14;
            this.ReferenceDataBaseBtn.Text = "Справка";
            this.ReferenceDataBaseBtn.UseVisualStyleBackColor = true;
            this.ReferenceDataBaseBtn.Click += new System.EventHandler(this.ReferenceDataBaseBtn_Click);
            // 
            // panelPhases
            // 
            this.panelPhases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPhases.Controls.Add(this.materialLabelPhase);
            this.panelPhases.Controls.Add(this.SelectPhasesCB);
            this.panelPhases.Location = new System.Drawing.Point(388, 14);
            this.panelPhases.Name = "panelPhases";
            this.panelPhases.Size = new System.Drawing.Size(187, 30);
            this.panelPhases.TabIndex = 18;
            // 
            // materialLabelPhase
            // 
            this.materialLabelPhase.AutoSize = true;
            this.materialLabelPhase.Depth = 0;
            this.materialLabelPhase.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelPhase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelPhase.Location = new System.Drawing.Point(3, 3);
            this.materialLabelPhase.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelPhase.Name = "materialLabelPhase";
            this.materialLabelPhase.Size = new System.Drawing.Size(49, 19);
            this.materialLabelPhase.TabIndex = 16;
            this.materialLabelPhase.Text = "Фаза:";
            // 
            // SelectPhasesCB
            // 
            this.SelectPhasesCB.FormattingEnabled = true;
            this.SelectPhasesCB.Location = new System.Drawing.Point(58, 2);
            this.SelectPhasesCB.Name = "SelectPhasesCB";
            this.SelectPhasesCB.Size = new System.Drawing.Size(119, 21);
            this.SelectPhasesCB.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.SelectElementsCB);
            this.panel1.Location = new System.Drawing.Point(5, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 30);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.SelectYearCB);
            this.panel2.Location = new System.Drawing.Point(225, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 30);
            this.panel2.TabIndex = 19;
            // 
            // UCData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPhases);
            this.Controls.Add(this.ReferenceDataBaseBtn);
            this.Controls.Add(this.AddDataBtn);
            this.Controls.Add(this.AddNewRowBtn);
            this.Controls.Add(this.SelectDataFiltersBtn);
            this.Controls.Add(this.ExportDataBtn);
            this.Controls.Add(this.DeleteDataBtn);
            this.Controls.Add(this.UpdateDataBtn);
            this.Controls.Add(this.MainDataGridView);
            this.Name = "UCData";
            this.Size = new System.Drawing.Size(1031, 657);
            this.Load += new System.EventHandler(this.UCData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.panelPhases.ResumeLayout(false);
            this.panelPhases.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox SelectElementsCB;
        private MaterialSkin.Controls.MaterialRaisedButton AddNewRowBtn;
        private MaterialSkin.Controls.MaterialRaisedButton AddDataBtn;
        private MaterialSkin.Controls.MaterialRaisedButton ReferenceDataBaseBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel panelPhases;
        private MaterialSkin.Controls.MaterialLabel materialLabelPhase;
        private System.Windows.Forms.ComboBox SelectPhasesCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
