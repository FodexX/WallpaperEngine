namespace WallapaperView
{
    partial class WallpaperView
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
            this.wallpapersListBox = new System.Windows.Forms.ListBox();
            this.wallpaperPictureBox = new System.Windows.Forms.PictureBox();
            this.selectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wallpaperPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // wallpapersListBox
            // 
            this.wallpapersListBox.FormattingEnabled = true;
            this.wallpapersListBox.Location = new System.Drawing.Point(12, 12);
            this.wallpapersListBox.Name = "wallpapersListBox";
            this.wallpapersListBox.Size = new System.Drawing.Size(157, 212);
            this.wallpapersListBox.TabIndex = 0;
            // 
            // wallpaperPictureBox
            // 
            this.wallpaperPictureBox.Location = new System.Drawing.Point(203, 12);
            this.wallpaperPictureBox.Name = "wallpaperPictureBox";
            this.wallpaperPictureBox.Size = new System.Drawing.Size(535, 288);
            this.wallpaperPictureBox.TabIndex = 1;
            this.wallpaperPictureBox.TabStop = false;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(94, 251);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "button1";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // WallpaperView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.wallpaperPictureBox);
            this.Controls.Add(this.wallpapersListBox);
            this.Name = "WallpaperView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wallpaperPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox wallpapersListBox;
        private System.Windows.Forms.PictureBox wallpaperPictureBox;
        private System.Windows.Forms.Button selectButton;
    }
}

