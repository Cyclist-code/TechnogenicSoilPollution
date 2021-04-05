
namespace TechnogenicSoilPollution.Forms
{
    partial class PromptMapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CloseFormBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(4, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 1);
            this.panel1.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(584, 40);
            this.label7.TabIndex = 40;
            this.label7.Text = "Для правильного расчёта примесей, необходимо выбирать опорные точки \r\nтолько с од" +
    "ного направления.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Работа с расчётом примесей:";
            // 
            // CloseFormBtn
            // 
            this.CloseFormBtn.Depth = 0;
            this.CloseFormBtn.Location = new System.Drawing.Point(488, 398);
            this.CloseFormBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseFormBtn.Name = "CloseFormBtn";
            this.CloseFormBtn.Primary = true;
            this.CloseFormBtn.Size = new System.Drawing.Size(100, 40);
            this.CloseFormBtn.TabIndex = 38;
            this.CloseFormBtn.Text = "ОК";
            this.CloseFormBtn.UseVisualStyleBackColor = true;
            this.CloseFormBtn.Click += new System.EventHandler(this.CloseFormBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Работа с картой:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 80);
            this.label1.TabIndex = 31;
            this.label1.Text = "Чтобы поствить свой маркер на карту, необходимо правой кнопкой мыши\r\nнажать на лю" +
    "бое место.\r\nЧтобы убрать маркер, необходимо навести на маркер и нажать правой \r\n" +
    "кнопкой мыши.";
            // 
            // PromptMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CloseFormBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "PromptMapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подсказка для работы с картой и расчётами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRaisedButton CloseFormBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}