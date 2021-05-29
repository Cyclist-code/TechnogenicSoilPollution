
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
            this.ChemicalElementsCB = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.PivotPointsCLB = new System.Windows.Forms.CheckedListBox();
            this.ExportMapBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CalcPollutionBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Gmap = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.PhasesCB = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.YearsCB = new System.Windows.Forms.ComboBox();
            this.PromptFormBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RoseWindLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RoseWindImagePanel = new System.Windows.Forms.Panel();
            this.RoseWindPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLightGreen = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxYellow = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxOrange = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.RoseWindImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoseWindPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLightGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(681, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Элемент:";
            // 
            // ChemicalElementsCB
            // 
            this.ChemicalElementsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChemicalElementsCB.FormattingEnabled = true;
            this.ChemicalElementsCB.Location = new System.Drawing.Point(685, 38);
            this.ChemicalElementsCB.Name = "ChemicalElementsCB";
            this.ChemicalElementsCB.Size = new System.Drawing.Size(130, 26);
            this.ChemicalElementsCB.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(862, 16);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Опорные точки:";
            // 
            // PivotPointsCLB
            // 
            this.PivotPointsCLB.CheckOnClick = true;
            this.PivotPointsCLB.FormattingEnabled = true;
            this.PivotPointsCLB.Location = new System.Drawing.Point(866, 38);
            this.PivotPointsCLB.Name = "PivotPointsCLB";
            this.PivotPointsCLB.Size = new System.Drawing.Size(119, 154);
            this.PivotPointsCLB.TabIndex = 4;
            this.PivotPointsCLB.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PivotPointsCLB_ItemCheck);
            // 
            // ExportMapBtn
            // 
            this.ExportMapBtn.Depth = 0;
            this.ExportMapBtn.Location = new System.Drawing.Point(875, 600);
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
            this.CalcPollutionBtn.Location = new System.Drawing.Point(657, 600);
            this.CalcPollutionBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CalcPollutionBtn.Name = "CalcPollutionBtn";
            this.CalcPollutionBtn.Primary = true;
            this.CalcPollutionBtn.Size = new System.Drawing.Size(140, 40);
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
            this.Gmap.Location = new System.Drawing.Point(0, 0);
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
            this.Gmap.Size = new System.Drawing.Size(630, 625);
            this.Gmap.TabIndex = 7;
            this.Gmap.Zoom = 0D;
            this.Gmap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.Gmap_OnMarkerClick);
            this.Gmap.Load += new System.EventHandler(this.Gmap_Load);
            this.Gmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Gmap_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Gmap);
            this.panel1.Location = new System.Drawing.Point(5, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 625);
            this.panel1.TabIndex = 8;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(681, 78);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(49, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Фаза:";
            // 
            // PhasesCB
            // 
            this.PhasesCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhasesCB.FormattingEnabled = true;
            this.PhasesCB.Location = new System.Drawing.Point(685, 100);
            this.PhasesCB.Name = "PhasesCB";
            this.PhasesCB.Size = new System.Drawing.Size(130, 26);
            this.PhasesCB.TabIndex = 10;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(681, 144);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(39, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Год:";
            // 
            // YearsCB
            // 
            this.YearsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearsCB.FormattingEnabled = true;
            this.YearsCB.Location = new System.Drawing.Point(685, 166);
            this.YearsCB.Name = "YearsCB";
            this.YearsCB.Size = new System.Drawing.Size(130, 26);
            this.YearsCB.TabIndex = 12;
            this.YearsCB.SelectedIndexChanged += new System.EventHandler(this.YearsCB_SelectedIndexChanged);
            // 
            // PromptFormBtn
            // 
            this.PromptFormBtn.Depth = 0;
            this.PromptFormBtn.Location = new System.Drawing.Point(741, 203);
            this.PromptFormBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.PromptFormBtn.Name = "PromptFormBtn";
            this.PromptFormBtn.Primary = true;
            this.PromptFormBtn.Size = new System.Drawing.Size(190, 40);
            this.PromptFormBtn.TabIndex = 13;
            this.PromptFormBtn.Text = "Помощь при расчётах";
            this.PromptFormBtn.UseVisualStyleBackColor = true;
            this.PromptFormBtn.Click += new System.EventHandler(this.PromptFormBtn_Click);
            // 
            // RoseWindLabel
            // 
            this.RoseWindLabel.AutoSize = true;
            this.RoseWindLabel.Depth = 0;
            this.RoseWindLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RoseWindLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RoseWindLabel.Location = new System.Drawing.Point(743, 503);
            this.RoseWindLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RoseWindLabel.Name = "RoseWindLabel";
            this.RoseWindLabel.Size = new System.Drawing.Size(0, 19);
            this.RoseWindLabel.TabIndex = 15;
            // 
            // RoseWindImagePanel
            // 
            this.RoseWindImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoseWindImagePanel.Controls.Add(this.RoseWindPictureBox);
            this.RoseWindImagePanel.Location = new System.Drawing.Point(685, 253);
            this.RoseWindImagePanel.Name = "RoseWindImagePanel";
            this.RoseWindImagePanel.Size = new System.Drawing.Size(300, 240);
            this.RoseWindImagePanel.TabIndex = 14;
            // 
            // RoseWindPictureBox
            // 
            this.RoseWindPictureBox.Location = new System.Drawing.Point(-1, -1);
            this.RoseWindPictureBox.Name = "RoseWindPictureBox";
            this.RoseWindPictureBox.Size = new System.Drawing.Size(300, 240);
            this.RoseWindPictureBox.TabIndex = 0;
            this.RoseWindPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(679, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "< 2";
            // 
            // pictureBoxLightGreen
            // 
            this.pictureBoxLightGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLightGreen.Location = new System.Drawing.Point(657, 547);
            this.pictureBoxLightGreen.Name = "pictureBoxLightGreen";
            this.pictureBoxLightGreen.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxLightGreen.TabIndex = 16;
            this.pictureBoxLightGreen.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(747, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "3 - 5";
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGreen.Location = new System.Drawing.Point(725, 547);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxGreen.TabIndex = 18;
            this.pictureBoxGreen.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(822, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "6 - 9";
            // 
            // pictureBoxYellow
            // 
            this.pictureBoxYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxYellow.Location = new System.Drawing.Point(800, 547);
            this.pictureBoxYellow.Name = "pictureBoxYellow";
            this.pictureBoxYellow.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxYellow.TabIndex = 20;
            this.pictureBoxYellow.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(892, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "10 - 13";
            // 
            // pictureBoxOrange
            // 
            this.pictureBoxOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOrange.Location = new System.Drawing.Point(870, 547);
            this.pictureBoxOrange.Name = "pictureBoxOrange";
            this.pictureBoxOrange.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxOrange.TabIndex = 22;
            this.pictureBoxOrange.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(978, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "> 14";
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRed.Location = new System.Drawing.Point(956, 547);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxRed.TabIndex = 24;
            this.pictureBoxRed.TabStop = false;
            // 
            // UCMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxRed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxOrange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxYellow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxGreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxLightGreen);
            this.Controls.Add(this.RoseWindLabel);
            this.Controls.Add(this.RoseWindImagePanel);
            this.Controls.Add(this.PromptFormBtn);
            this.Controls.Add(this.YearsCB);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.PhasesCB);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CalcPollutionBtn);
            this.Controls.Add(this.ExportMapBtn);
            this.Controls.Add(this.PivotPointsCLB);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.ChemicalElementsCB);
            this.Controls.Add(this.materialLabel1);
            this.Name = "UCMap";
            this.Size = new System.Drawing.Size(1031, 657);
            this.Load += new System.EventHandler(this.UCMap_Load);
            this.panel1.ResumeLayout(false);
            this.RoseWindImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoseWindPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLightGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox ChemicalElementsCB;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.CheckedListBox PivotPointsCLB;
        private MaterialSkin.Controls.MaterialRaisedButton ExportMapBtn;
        private MaterialSkin.Controls.MaterialRaisedButton CalcPollutionBtn;
        private GMap.NET.WindowsForms.GMapControl Gmap;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox PhasesCB;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox YearsCB;
        private MaterialSkin.Controls.MaterialRaisedButton PromptFormBtn;
        private MaterialSkin.Controls.MaterialLabel RoseWindLabel;
        private System.Windows.Forms.PictureBox RoseWindPictureBox;
        private System.Windows.Forms.Panel RoseWindImagePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLightGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxYellow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxOrange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxRed;
    }
}
