
namespace TechnogenicSoilPollution.Forms
{
    partial class ReferenceWorkDBForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReferenceWorkDBForm));
            this.CloseFormBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CloseFormBtn
            // 
            this.CloseFormBtn.Depth = 0;
            this.CloseFormBtn.Location = new System.Drawing.Point(488, 448);
            this.CloseFormBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseFormBtn.Name = "CloseFormBtn";
            this.CloseFormBtn.Primary = true;
            this.CloseFormBtn.Size = new System.Drawing.Size(100, 40);
            this.CloseFormBtn.TabIndex = 27;
            this.CloseFormBtn.Text = "ОК";
            this.CloseFormBtn.UseVisualStyleBackColor = true;
            this.CloseFormBtn.Click += new System.EventHandler(this.CloseFormBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(6, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 1);
            this.panel2.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(6, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 1);
            this.panel1.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(582, 40);
            this.label7.TabIndex = 35;
            this.label7.Text = "Для удаления строки, пользователю необходимо выделить строку, затем \r\nудалить её." +
    "\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Удаление данных:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Обновление отображения данных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Обновление данных:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 60);
            this.label1.TabIndex = 31;
            this.label1.Text = "При обновлении данных, пользователю необходимо находиться на той \r\nстроке, где пр" +
    "оисходило обновление данных. Иначе обновленные данные \r\nсохранятся совсем в друг" +
    "ую строку в базе данных.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(589, 40);
            this.label4.TabIndex = 38;
            this.label4.Text = "Для того, чтобы отобразить изменения данных, пользователю нужно снова\r\nнажать на " +
    "кнопку \"Выбрать\".";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(6, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 1);
            this.panel3.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Добавление новых данных:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(5, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(571, 80);
            this.label8.TabIndex = 37;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(5, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(534, 40);
            this.label9.TabIndex = 41;
            this.label9.Text = "Незаполненные ячейки означают, что для выбранного элемента не \r\nпроводились измер" +
    "ения.";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(6, 388);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 1);
            this.panel4.TabIndex = 40;
            // 
            // ReferenceWorkDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseFormBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "ReferenceWorkDBForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подсказка для работы с базой данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton CloseFormBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
    }
}