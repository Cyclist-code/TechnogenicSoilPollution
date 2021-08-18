
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.GitHubProfileButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CopyEmailButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DocumentationButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 227);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(410, 134);
            this.materialLabel1.TabIndex = 35;
            this.materialLabel1.Text = resources.GetString("materialLabel1.Text");
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GitHubProfileButton
            // 
            this.GitHubProfileButton.Depth = 0;
            this.GitHubProfileButton.Location = new System.Drawing.Point(45, 374);
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
            this.CopyEmailButton.Location = new System.Drawing.Point(151, 374);
            this.CopyEmailButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CopyEmailButton.Name = "CopyEmailButton";
            this.CopyEmailButton.Primary = true;
            this.CopyEmailButton.Size = new System.Drawing.Size(100, 36);
            this.CopyEmailButton.TabIndex = 39;
            this.CopyEmailButton.Text = "Email";
            this.CopyEmailButton.UseVisualStyleBackColor = true;
            this.CopyEmailButton.Click += new System.EventHandler(this.CopyEmailButton_Click);
            // 
            // DocumentationButton
            // 
            this.DocumentationButton.Depth = 0;
            this.DocumentationButton.Location = new System.Drawing.Point(257, 374);
            this.DocumentationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DocumentationButton.Name = "DocumentationButton";
            this.DocumentationButton.Primary = true;
            this.DocumentationButton.Size = new System.Drawing.Size(140, 36);
            this.DocumentationButton.TabIndex = 42;
            this.DocumentationButton.Text = "Документация";
            this.DocumentationButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TechnogenicSoilPollution.Properties.Resources.factory;
            this.pictureBox1.Location = new System.Drawing.Point(145, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // ReferenceProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 440);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DocumentationButton);
            this.Controls.Add(this.CopyEmailButton);
            this.Controls.Add(this.GitHubProfileButton);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReferenceProgramForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о приложении";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton GitHubProfileButton;
        private MaterialSkin.Controls.MaterialRaisedButton CopyEmailButton;
        private MaterialSkin.Controls.MaterialRaisedButton DocumentationButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}