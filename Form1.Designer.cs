namespace PanoramaViewer
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
            this.PanoramaPictureBox = new System.Windows.Forms.PictureBox();
            this.ToolsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPanoramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanoramaOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PanoramaNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PanoramaPictureBox)).BeginInit();
            this.ToolsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanoramaPictureBox
            // 
            this.PanoramaPictureBox.BackColor = System.Drawing.Color.White;
            this.PanoramaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanoramaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanoramaPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PanoramaPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanoramaPictureBox.ImageLocation = "";
            this.PanoramaPictureBox.Location = new System.Drawing.Point(0, 23);
            this.PanoramaPictureBox.Name = "PanoramaPictureBox";
            this.PanoramaPictureBox.Size = new System.Drawing.Size(1061, 539);
            this.PanoramaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PanoramaPictureBox.TabIndex = 0;
            this.PanoramaPictureBox.TabStop = false;
            this.PanoramaPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PanoramaPictureBox_Paint);
            this.PanoramaPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanoramaPictureBox_MouseDown);
            this.PanoramaPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanoramaPictureBox_MouseMove);
            // 
            // ToolsMenuStrip
            // 
            this.ToolsMenuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ToolsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.ToolsMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ToolsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolsMenuStrip.Name = "ToolsMenuStrip";
            this.ToolsMenuStrip.Size = new System.Drawing.Size(1061, 23);
            this.ToolsMenuStrip.TabIndex = 1;
            this.ToolsMenuStrip.Text = "ToolsMenuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenPanoramaToolStripMenuItem,
            this.ClearToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(112, 19);
            this.FileToolStripMenuItem.Text = "Рабочая область";
            // 
            // OpenPanoramaToolStripMenuItem
            // 
            this.OpenPanoramaToolStripMenuItem.Name = "OpenPanoramaToolStripMenuItem";
            this.OpenPanoramaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.OpenPanoramaToolStripMenuItem.Text = "Открыть панораму";
            this.OpenPanoramaToolStripMenuItem.Click += new System.EventHandler(this.OpenPanoramaToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ClearToolStripMenuItem.Text = "Очистить";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 19);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(94, 19);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // PanoramaOpenFileDialog
            // 
            this.PanoramaOpenFileDialog.Title = "Открытие файла панорамы";
            // 
            // PanoramaNameLabel
            // 
            this.PanoramaNameLabel.AutoSize = true;
            this.PanoramaNameLabel.Location = new System.Drawing.Point(3, 546);
            this.PanoramaNameLabel.Name = "PanoramaNameLabel";
            this.PanoramaNameLabel.Size = new System.Drawing.Size(119, 13);
            this.PanoramaNameLabel.TabIndex = 2;
            this.PanoramaNameLabel.Text = "Панорама не открыта";
            this.PanoramaNameLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 562);
            this.Controls.Add(this.PanoramaNameLabel);
            this.Controls.Add(this.PanoramaPictureBox);
            this.Controls.Add(this.ToolsMenuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ToolsMenuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1077, 601);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр панорамы";
            ((System.ComponentModel.ISupportInitialize)(this.PanoramaPictureBox)).EndInit();
            this.ToolsMenuStrip.ResumeLayout(false);
            this.ToolsMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PanoramaPictureBox;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenPanoramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip ToolsMenuStrip;
        private System.Windows.Forms.OpenFileDialog PanoramaOpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.Label PanoramaNameLabel;
    }
}

