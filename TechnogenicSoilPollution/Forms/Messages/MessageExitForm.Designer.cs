
namespace TechnogenicSoilPollution.Forms.Messages
{
    partial class MessageExitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageExitForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CancelExitAppButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ExitAppButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CaptionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.CancelExitAppButton);
            this.panel1.Controls.Add(this.ExitAppButton);
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 137);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(77, 35);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(268, 40);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Вы действительно хотите выйти из приложения?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TechnogenicSoilPollution.Properties.Resources.Question;
            this.pictureBox1.Location = new System.Drawing.Point(15, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // CancelExitAppButton
            // 
            this.CancelExitAppButton.Depth = 0;
            this.CancelExitAppButton.Location = new System.Drawing.Point(267, 96);
            this.CancelExitAppButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelExitAppButton.Name = "CancelExitAppButton";
            this.CancelExitAppButton.Primary = true;
            this.CancelExitAppButton.Size = new System.Drawing.Size(70, 28);
            this.CancelExitAppButton.TabIndex = 4;
            this.CancelExitAppButton.Text = "Нет";
            this.CancelExitAppButton.UseVisualStyleBackColor = true;
            this.CancelExitAppButton.Click += new System.EventHandler(this.CancelExitAppButton_Click);
            // 
            // ExitAppButton
            // 
            this.ExitAppButton.Depth = 0;
            this.ExitAppButton.Location = new System.Drawing.Point(191, 96);
            this.ExitAppButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitAppButton.Name = "ExitAppButton";
            this.ExitAppButton.Primary = true;
            this.ExitAppButton.Size = new System.Drawing.Size(70, 28);
            this.ExitAppButton.TabIndex = 3;
            this.ExitAppButton.Text = "Да";
            this.ExitAppButton.UseVisualStyleBackColor = true;
            this.ExitAppButton.Click += new System.EventHandler(this.ExitAppButton_Click);
            // 
            // CaptionLabel
            // 
            this.CaptionLabel.AutoSize = true;
            this.CaptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.CaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaptionLabel.ForeColor = System.Drawing.Color.White;
            this.CaptionLabel.Location = new System.Drawing.Point(12, 4);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(135, 15);
            this.CaptionLabel.TabIndex = 2;
            this.CaptionLabel.Text = "Выход из приложения";
            // 
            // MessageExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 160);
            this.Controls.Add(this.CaptionLabel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageExitForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton CancelExitAppButton;
        private MaterialSkin.Controls.MaterialRaisedButton ExitAppButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label CaptionLabel;
    }
}