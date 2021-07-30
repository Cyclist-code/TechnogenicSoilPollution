
namespace TechnogenicSoilPollution.Forms
{
    partial class ReferenceProgramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReferenceProgramForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.GitHubProfileButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CopyEmailButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CloseFormButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(7, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 1);
            this.panel2.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(7, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 1);
            this.panel1.TabIndex = 29;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(5, 69);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(533, 95);
            this.materialLabel1.TabIndex = 35;
            this.materialLabel1.Text = resources.GetString("materialLabel1.Text");
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(5, 170);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(528, 152);
            this.materialLabel2.TabIndex = 36;
            this.materialLabel2.Text = resources.GetString("materialLabel2.Text");
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(5, 329);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(124, 19);
            this.materialLabel3.TabIndex = 37;
            this.materialLabel3.Text = "Обратная связь:";
            // 
            // GitHubProfileButton
            // 
            this.GitHubProfileButton.Depth = 0;
            this.GitHubProfileButton.Location = new System.Drawing.Point(7, 355);
            this.GitHubProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GitHubProfileButton.Name = "GitHubProfileButton";
            this.GitHubProfileButton.Primary = true;
            this.GitHubProfileButton.Size = new System.Drawing.Size(100, 36);
            this.GitHubProfileButton.TabIndex = 38;
            this.GitHubProfileButton.Text = "GitHub";
            this.GitHubProfileButton.UseVisualStyleBackColor = true;
            this.GitHubProfileButton.Click += new System.EventHandler(this.GitHubProfileButton_Click);
            // 
            // CopyEmailButton
            // 
            this.CopyEmailButton.Depth = 0;
            this.CopyEmailButton.Location = new System.Drawing.Point(113, 355);
            this.CopyEmailButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CopyEmailButton.Name = "CopyEmailButton";
            this.CopyEmailButton.Primary = true;
            this.CopyEmailButton.Size = new System.Drawing.Size(100, 36);
            this.CopyEmailButton.TabIndex = 39;
            this.CopyEmailButton.Text = "Email";
            this.CopyEmailButton.UseVisualStyleBackColor = true;
            this.CopyEmailButton.Click += new System.EventHandler(this.CopyEmailButton_Click);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Depth = 0;
            this.CloseFormButton.Location = new System.Drawing.Point(428, 398);
            this.CloseFormButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Primary = true;
            this.CloseFormButton.Size = new System.Drawing.Size(100, 40);
            this.CloseFormButton.TabIndex = 40;
            this.CloseFormButton.Text = "OK";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // ReferenceProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.CopyEmailButton);
            this.Controls.Add(this.GitHubProfileButton);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReferenceProgramForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о приложении";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton GitHubProfileButton;
        private MaterialSkin.Controls.MaterialRaisedButton CopyEmailButton;
        private MaterialSkin.Controls.MaterialRaisedButton CloseFormButton;
    }
}