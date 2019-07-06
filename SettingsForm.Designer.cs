namespace PanoramaViewer
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.NamePanoramaShowButton = new System.Windows.Forms.Button();
            this.ShowPanoramaNameLabel = new System.Windows.Forms.Label();
            this.SmoothCameraButton = new System.Windows.Forms.Button();
            this.SmoothCameraLabel = new System.Windows.Forms.Label();
            this.AdvancedOptionsLabel = new System.Windows.Forms.Label();
            this.ImageOptionsLabel = new System.Windows.Forms.Label();
            this.ResizeImageLabel = new System.Windows.Forms.Label();
            this.BigImageButton = new System.Windows.Forms.Button();
            this.LangLabel = new System.Windows.Forms.Label();
            this.LangComboBox = new System.Windows.Forms.ComboBox();
            this.GitButton = new System.Windows.Forms.Button();
            this.GHButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // NamePanoramaShowButton
            // 
            this.NamePanoramaShowButton.BackColor = System.Drawing.Color.OrangeRed;
            this.NamePanoramaShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NamePanoramaShowButton.Location = new System.Drawing.Point(279, 63);
            this.NamePanoramaShowButton.Name = "NamePanoramaShowButton";
            this.NamePanoramaShowButton.Size = new System.Drawing.Size(75, 23);
            this.NamePanoramaShowButton.TabIndex = 0;
            this.NamePanoramaShowButton.UseVisualStyleBackColor = false;
            this.NamePanoramaShowButton.Click += new System.EventHandler(this.NamePanoramaShowButton_Click);
            // 
            // ShowPanoramaNameLabel
            // 
            this.ShowPanoramaNameLabel.AutoSize = true;
            this.ShowPanoramaNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPanoramaNameLabel.Location = new System.Drawing.Point(19, 62);
            this.ShowPanoramaNameLabel.Name = "ShowPanoramaNameLabel";
            this.ShowPanoramaNameLabel.Size = new System.Drawing.Size(254, 21);
            this.ShowPanoramaNameLabel.TabIndex = 1;
            this.ShowPanoramaNameLabel.Text = "Показывать название панорамы";
            // 
            // SmoothCameraButton
            // 
            this.SmoothCameraButton.BackColor = System.Drawing.Color.OrangeRed;
            this.SmoothCameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SmoothCameraButton.Location = new System.Drawing.Point(279, 101);
            this.SmoothCameraButton.Name = "SmoothCameraButton";
            this.SmoothCameraButton.Size = new System.Drawing.Size(75, 23);
            this.SmoothCameraButton.TabIndex = 2;
            this.SmoothCameraButton.UseVisualStyleBackColor = false;
            this.SmoothCameraButton.Click += new System.EventHandler(this.SmoothCameraButton_Click);
            // 
            // SmoothCameraLabel
            // 
            this.SmoothCameraLabel.AutoSize = true;
            this.SmoothCameraLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SmoothCameraLabel.Location = new System.Drawing.Point(19, 100);
            this.SmoothCameraLabel.Name = "SmoothCameraLabel";
            this.SmoothCameraLabel.Size = new System.Drawing.Size(224, 21);
            this.SmoothCameraLabel.TabIndex = 3;
            this.SmoothCameraLabel.Text = "Инерция движения камеры";
            // 
            // AdvancedOptionsLabel
            // 
            this.AdvancedOptionsLabel.AutoSize = true;
            this.AdvancedOptionsLabel.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdvancedOptionsLabel.Location = new System.Drawing.Point(17, 9);
            this.AdvancedOptionsLabel.Name = "AdvancedOptionsLabel";
            this.AdvancedOptionsLabel.Size = new System.Drawing.Size(315, 32);
            this.AdvancedOptionsLabel.TabIndex = 4;
            this.AdvancedOptionsLabel.Text = "Дополнительные опции\r\n";
            // 
            // ImageOptionsLabel
            // 
            this.ImageOptionsLabel.AutoSize = true;
            this.ImageOptionsLabel.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImageOptionsLabel.Location = new System.Drawing.Point(17, 140);
            this.ImageOptionsLabel.Name = "ImageOptionsLabel";
            this.ImageOptionsLabel.Size = new System.Drawing.Size(268, 64);
            this.ImageOptionsLabel.TabIndex = 5;
            this.ImageOptionsLabel.Text = "Опции изображения\r\n\r\n";
            // 
            // ResizeImageLabel
            // 
            this.ResizeImageLabel.AutoSize = true;
            this.ResizeImageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResizeImageLabel.Location = new System.Drawing.Point(19, 189);
            this.ResizeImageLabel.Name = "ResizeImageLabel";
            this.ResizeImageLabel.Size = new System.Drawing.Size(207, 21);
            this.ResizeImageLabel.TabIndex = 6;
            this.ResizeImageLabel.Text = "Растягивать изображение";
            // 
            // BigImageButton
            // 
            this.BigImageButton.BackColor = System.Drawing.Color.OrangeRed;
            this.BigImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BigImageButton.Location = new System.Drawing.Point(279, 190);
            this.BigImageButton.Name = "BigImageButton";
            this.BigImageButton.Size = new System.Drawing.Size(75, 23);
            this.BigImageButton.TabIndex = 7;
            this.BigImageButton.UseVisualStyleBackColor = false;
            this.BigImageButton.Click += new System.EventHandler(this.BigImageButton_Click);
            // 
            // LangLabel
            // 
            this.LangLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LangLabel.Location = new System.Drawing.Point(105, 425);
            this.LangLabel.Name = "LangLabel";
            this.LangLabel.Size = new System.Drawing.Size(690, 21);
            this.LangLabel.TabIndex = 8;
            this.LangLabel.Text = "Язык локализации";
            // 
            // LangComboBox
            // 
            this.LangComboBox.FormattingEnabled = true;
            this.LangComboBox.Location = new System.Drawing.Point(3, 426);
            this.LangComboBox.Name = "LangComboBox";
            this.LangComboBox.Size = new System.Drawing.Size(98, 21);
            this.LangComboBox.TabIndex = 9;
            this.LangComboBox.SelectedIndexChanged += new System.EventHandler(this.LangComboBox_SelectedIndexChanged);
            // 
            // GitButton
            // 
            this.GitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GitButton.BackgroundImage")));
            this.GitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.GitButton.Location = new System.Drawing.Point(758, 410);
            this.GitButton.Name = "GitButton";
            this.GitButton.Size = new System.Drawing.Size(37, 37);
            this.GitButton.TabIndex = 10;
            this.GHButtonToolTip.SetToolTip(this.GitButton, "Наш GitHub");
            this.GitButton.UseVisualStyleBackColor = true;
            this.GitButton.Click += new System.EventHandler(this.GitButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GitButton);
            this.Controls.Add(this.LangComboBox);
            this.Controls.Add(this.LangLabel);
            this.Controls.Add(this.BigImageButton);
            this.Controls.Add(this.ResizeImageLabel);
            this.Controls.Add(this.ImageOptionsLabel);
            this.Controls.Add(this.AdvancedOptionsLabel);
            this.Controls.Add(this.SmoothCameraLabel);
            this.Controls.Add(this.SmoothCameraButton);
            this.Controls.Add(this.ShowPanoramaNameLabel);
            this.Controls.Add(this.NamePanoramaShowButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Настройки программы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NamePanoramaShowButton;
        private System.Windows.Forms.Label ShowPanoramaNameLabel;
        private System.Windows.Forms.Button SmoothCameraButton;
        private System.Windows.Forms.Label SmoothCameraLabel;
        private System.Windows.Forms.Label AdvancedOptionsLabel;
        private System.Windows.Forms.Label ImageOptionsLabel;
        private System.Windows.Forms.Label ResizeImageLabel;
        private System.Windows.Forms.Button BigImageButton;
        private System.Windows.Forms.Label LangLabel;
        private System.Windows.Forms.ComboBox LangComboBox;
        private System.Windows.Forms.Button GitButton;
        private System.Windows.Forms.ToolTip GHButtonToolTip;
    }
}