
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(5, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Элемент:";
            // 
            // SelectElementsBox
            // 
            this.SelectElementsBox.FormattingEnabled = true;
            this.SelectElementsBox.Location = new System.Drawing.Point(86, 15);
            this.SelectElementsBox.Name = "SelectElementsBox";
            this.SelectElementsBox.Size = new System.Drawing.Size(121, 21);
            this.SelectElementsBox.TabIndex = 1;
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(5, 45);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(850, 440);
            this.DataGrid.TabIndex = 2;
            // 
            // UpdateDataBtn
            // 
            this.UpdateDataBtn.Depth = 0;
            this.UpdateDataBtn.Location = new System.Drawing.Point(284, 500);
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
            this.DeleteDataBtn.Location = new System.Drawing.Point(390, 500);
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
            this.ExportDataBtn.Location = new System.Drawing.Point(496, 500);
            this.ExportDataBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportDataBtn.Name = "ExportDataBtn";
            this.ExportDataBtn.Primary = true;
            this.ExportDataBtn.Size = new System.Drawing.Size(140, 40);
            this.ExportDataBtn.TabIndex = 5;
            this.ExportDataBtn.Text = "Экпортировать";
            this.ExportDataBtn.UseVisualStyleBackColor = true;
            // 
            // UCData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExportDataBtn);
            this.Controls.Add(this.DeleteDataBtn);
            this.Controls.Add(this.UpdateDataBtn);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.SelectElementsBox);
            this.Controls.Add(this.materialLabel1);
            this.Name = "UCData";
            this.Size = new System.Drawing.Size(860, 555);
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
    }
}
