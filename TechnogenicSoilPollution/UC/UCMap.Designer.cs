
namespace TechnogenicSoilPollution.UC
{
    partial class UCMap
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
            this.button1 = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ChemicalElementsBox = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SamplingPointBox = new System.Windows.Forms.CheckedListBox();
            this.ExportMapBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CalcPollutionBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(540, 540);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(549, 3);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Элемент:";
            // 
            // ChemicalElementsBox
            // 
            this.ChemicalElementsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChemicalElementsBox.FormattingEnabled = true;
            this.ChemicalElementsBox.Location = new System.Drawing.Point(553, 25);
            this.ChemicalElementsBox.Name = "ChemicalElementsBox";
            this.ChemicalElementsBox.Size = new System.Drawing.Size(113, 26);
            this.ChemicalElementsBox.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(549, 63);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Опорные точки:";
            // 
            // SamplingPointBox
            // 
            this.SamplingPointBox.FormattingEnabled = true;
            this.SamplingPointBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.SamplingPointBox.Location = new System.Drawing.Point(553, 85);
            this.SamplingPointBox.Name = "SamplingPointBox";
            this.SamplingPointBox.Size = new System.Drawing.Size(114, 124);
            this.SamplingPointBox.TabIndex = 4;
            // 
            // ExportMapBtn
            // 
            this.ExportMapBtn.Depth = 0;
            this.ExportMapBtn.Location = new System.Drawing.Point(585, 503);
            this.ExportMapBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportMapBtn.Name = "ExportMapBtn";
            this.ExportMapBtn.Primary = true;
            this.ExportMapBtn.Size = new System.Drawing.Size(140, 40);
            this.ExportMapBtn.TabIndex = 5;
            this.ExportMapBtn.Text = "Экпортировать";
            this.ExportMapBtn.UseVisualStyleBackColor = true;
            // 
            // CalcPollutionBtn
            // 
            this.CalcPollutionBtn.Depth = 0;
            this.CalcPollutionBtn.Location = new System.Drawing.Point(731, 503);
            this.CalcPollutionBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CalcPollutionBtn.Name = "CalcPollutionBtn";
            this.CalcPollutionBtn.Primary = true;
            this.CalcPollutionBtn.Size = new System.Drawing.Size(114, 40);
            this.CalcPollutionBtn.TabIndex = 6;
            this.CalcPollutionBtn.Text = "Рассчитать";
            this.CalcPollutionBtn.UseVisualStyleBackColor = true;
            // 
            // UCMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CalcPollutionBtn);
            this.Controls.Add(this.ExportMapBtn);
            this.Controls.Add(this.SamplingPointBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.ChemicalElementsBox);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.button1);
            this.Name = "UCMap";
            this.Size = new System.Drawing.Size(860, 555);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox ChemicalElementsBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.CheckedListBox SamplingPointBox;
        private MaterialSkin.Controls.MaterialRaisedButton ExportMapBtn;
        private MaterialSkin.Controls.MaterialRaisedButton CalcPollutionBtn;
    }
}
