
namespace TechnogenicSoilPollution
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BtnOpenHome = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnOpenMap = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnOpenData = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnOpenHelp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.PanelLoadUserControl = new System.Windows.Forms.Panel();
            this.SideMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOpenHome
            // 
            this.BtnOpenHome.Depth = 0;
            this.BtnOpenHome.Location = new System.Drawing.Point(3, 3);
            this.BtnOpenHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnOpenHome.Name = "BtnOpenHome";
            this.BtnOpenHome.Primary = true;
            this.BtnOpenHome.Size = new System.Drawing.Size(110, 40);
            this.BtnOpenHome.TabIndex = 0;
            this.BtnOpenHome.Text = "Главная";
            this.BtnOpenHome.UseVisualStyleBackColor = true;
            this.BtnOpenHome.Click += new System.EventHandler(this.OpenPageBtn);
            // 
            // BtnOpenMap
            // 
            this.BtnOpenMap.Depth = 0;
            this.BtnOpenMap.Location = new System.Drawing.Point(3, 95);
            this.BtnOpenMap.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnOpenMap.Name = "BtnOpenMap";
            this.BtnOpenMap.Primary = true;
            this.BtnOpenMap.Size = new System.Drawing.Size(110, 40);
            this.BtnOpenMap.TabIndex = 1;
            this.BtnOpenMap.Text = "Расчёт";
            this.BtnOpenMap.UseVisualStyleBackColor = true;
            this.BtnOpenMap.Click += new System.EventHandler(this.OpenPageBtn);
            // 
            // BtnOpenData
            // 
            this.BtnOpenData.Depth = 0;
            this.BtnOpenData.Location = new System.Drawing.Point(3, 49);
            this.BtnOpenData.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnOpenData.Name = "BtnOpenData";
            this.BtnOpenData.Primary = true;
            this.BtnOpenData.Size = new System.Drawing.Size(110, 40);
            this.BtnOpenData.TabIndex = 2;
            this.BtnOpenData.Text = "База Данных";
            this.BtnOpenData.UseVisualStyleBackColor = true;
            this.BtnOpenData.Click += new System.EventHandler(this.OpenPageBtn);
            // 
            // BtnOpenHelp
            // 
            this.BtnOpenHelp.Depth = 0;
            this.BtnOpenHelp.Location = new System.Drawing.Point(3, 141);
            this.BtnOpenHelp.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnOpenHelp.Name = "BtnOpenHelp";
            this.BtnOpenHelp.Primary = true;
            this.BtnOpenHelp.Size = new System.Drawing.Size(110, 40);
            this.BtnOpenHelp.TabIndex = 3;
            this.BtnOpenHelp.Text = "Справка";
            this.BtnOpenHelp.UseVisualStyleBackColor = true;
            this.BtnOpenHelp.Click += new System.EventHandler(this.BtnOpenHelp_Click);
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SideMenuPanel.Controls.Add(this.BtnOpenHome);
            this.SideMenuPanel.Controls.Add(this.BtnOpenHelp);
            this.SideMenuPanel.Controls.Add(this.BtnOpenData);
            this.SideMenuPanel.Controls.Add(this.BtnOpenMap);
            this.SideMenuPanel.Location = new System.Drawing.Point(-1, 63);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(120, 658);
            this.SideMenuPanel.TabIndex = 4;
            // 
            // PanelLoadUserControl
            // 
            this.PanelLoadUserControl.Location = new System.Drawing.Point(119, 64);
            this.PanelLoadUserControl.Name = "PanelLoadUserControl";
            this.PanelLoadUserControl.Size = new System.Drawing.Size(1031, 657);
            this.PanelLoadUserControl.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 720);
            this.Controls.Add(this.PanelLoadUserControl);
            this.Controls.Add(this.SideMenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 720);
            this.MinimumSize = new System.Drawing.Size(1150, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчёт и визуализация техногенного загрязнения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SideMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnOpenHome;
        private MaterialSkin.Controls.MaterialRaisedButton BtnOpenMap;
        private MaterialSkin.Controls.MaterialRaisedButton BtnOpenData;
        private MaterialSkin.Controls.MaterialRaisedButton BtnOpenHelp;
        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Panel PanelLoadUserControl;
    }
}

