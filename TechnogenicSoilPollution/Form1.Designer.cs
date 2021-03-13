
namespace TechnogenicSoilPollution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnOpenHome = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnOpenMap = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnOpenData = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnOpenHelp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOpenHome
            // 
            this.BtnOpenHome.Depth = 0;
            this.BtnOpenHome.Location = new System.Drawing.Point(3, 3);
            this.BtnOpenHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnOpenHome.Name = "BtnOpenHome";
            this.BtnOpenHome.Primary = true;
            this.BtnOpenHome.Size = new System.Drawing.Size(81, 40);
            this.BtnOpenHome.TabIndex = 0;
            this.BtnOpenHome.Text = "Главная";
            this.BtnOpenHome.UseVisualStyleBackColor = true;
            // 
            // BtnOpenMap
            // 
            this.BtnOpenMap.Depth = 0;
            this.BtnOpenMap.Location = new System.Drawing.Point(3, 95);
            this.BtnOpenMap.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnOpenMap.Name = "BtnOpenMap";
            this.BtnOpenMap.Primary = true;
            this.BtnOpenMap.Size = new System.Drawing.Size(81, 40);
            this.BtnOpenMap.TabIndex = 1;
            this.BtnOpenMap.Text = "Карта";
            this.BtnOpenMap.UseVisualStyleBackColor = true;
            // 
            // BtnOpenData
            // 
            this.BtnOpenData.Depth = 0;
            this.BtnOpenData.Location = new System.Drawing.Point(3, 49);
            this.BtnOpenData.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnOpenData.Name = "BtnOpenData";
            this.BtnOpenData.Primary = true;
            this.BtnOpenData.Size = new System.Drawing.Size(81, 40);
            this.BtnOpenData.TabIndex = 2;
            this.BtnOpenData.Text = "Данные";
            this.BtnOpenData.UseVisualStyleBackColor = true;
            // 
            // BtnOpenHelp
            // 
            this.BtnOpenHelp.Depth = 0;
            this.BtnOpenHelp.Location = new System.Drawing.Point(3, 141);
            this.BtnOpenHelp.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnOpenHelp.Name = "BtnOpenHelp";
            this.BtnOpenHelp.Primary = true;
            this.BtnOpenHelp.Size = new System.Drawing.Size(81, 40);
            this.BtnOpenHelp.TabIndex = 3;
            this.BtnOpenHelp.Text = "Справка";
            this.BtnOpenHelp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnOpenHome);
            this.panel1.Controls.Add(this.BtnOpenHelp);
            this.panel1.Controls.Add(this.BtnOpenData);
            this.panel1.Controls.Add(this.BtnOpenMap);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 560);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 620);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(950, 620);
            this.MinimumSize = new System.Drawing.Size(950, 620);
            this.Name = "Form1";
            this.Text = "Расчёт и визуализация техногенного загрязнения почвенного покрова";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnOpenHome;
        private MaterialSkin.Controls.MaterialRaisedButton BtnOpenMap;
        private MaterialSkin.Controls.MaterialRaisedButton BtnOpenData;
        private MaterialSkin.Controls.MaterialRaisedButton BtnOpenHelp;
        private System.Windows.Forms.Panel panel1;
    }
}

