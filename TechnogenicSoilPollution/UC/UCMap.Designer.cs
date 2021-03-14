
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ChemicalElementsBox = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SamplingPointBox = new System.Windows.Forms.CheckedListBox();
            this.ExportMapBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CalcPollutionBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Gmap = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.ExportMapBtn.Click += new System.EventHandler(this.ExportMapBtn_Click);
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
            this.CalcPollutionBtn.Click += new System.EventHandler(this.CalcPollutionBtn_Click);
            // 
            // Gmap
            // 
            this.Gmap.Bearing = 0F;
            this.Gmap.CanDragMap = true;
            this.Gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.Gmap.GrayScaleMode = false;
            this.Gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Gmap.LevelsKeepInMemory = 5;
            this.Gmap.Location = new System.Drawing.Point(1, -1);
            this.Gmap.MarkersEnabled = true;
            this.Gmap.MaxZoom = 2;
            this.Gmap.MinZoom = 2;
            this.Gmap.MouseWheelZoomEnabled = true;
            this.Gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Gmap.Name = "Gmap";
            this.Gmap.NegativeMode = false;
            this.Gmap.PolygonsEnabled = true;
            this.Gmap.RetryLoadTile = 0;
            this.Gmap.RoutesEnabled = true;
            this.Gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Gmap.ShowTileGridLines = false;
            this.Gmap.Size = new System.Drawing.Size(540, 540);
            this.Gmap.TabIndex = 7;
            this.Gmap.Zoom = 0D;
            this.Gmap.Load += new System.EventHandler(this.Gmap_Load);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Gmap);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 540);
            this.panel1.TabIndex = 8;
            // 
            // UCMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CalcPollutionBtn);
            this.Controls.Add(this.ExportMapBtn);
            this.Controls.Add(this.SamplingPointBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.ChemicalElementsBox);
            this.Controls.Add(this.materialLabel1);
            this.Name = "UCMap";
            this.Size = new System.Drawing.Size(860, 555);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox ChemicalElementsBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.CheckedListBox SamplingPointBox;
        private MaterialSkin.Controls.MaterialRaisedButton ExportMapBtn;
        private MaterialSkin.Controls.MaterialRaisedButton CalcPollutionBtn;
        private GMap.NET.WindowsForms.GMapControl Gmap;
        private System.Windows.Forms.Panel panel1;
    }
}
