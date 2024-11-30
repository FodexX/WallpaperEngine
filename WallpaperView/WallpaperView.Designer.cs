namespace WallpaperView
{
    partial class WallpaperView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            wallpapersListBox = new ListBox();
            wallpaperPictureBox = new PictureBox();
            selectButton = new Button();
            ((System.ComponentModel.ISupportInitialize)wallpaperPictureBox).BeginInit();
            SuspendLayout();
            // 
            // wallpapersListBox
            // 
            wallpapersListBox.FormattingEnabled = true;
            wallpapersListBox.ItemHeight = 15;
            wallpapersListBox.Location = new Point(12, 12);
            wallpapersListBox.Name = "wallpapersListBox";
            wallpapersListBox.Size = new Size(206, 229);
            wallpapersListBox.TabIndex = 0;
            // 
            // wallpaperPictureBox
            // 
            wallpaperPictureBox.Location = new Point(260, 12);
            wallpaperPictureBox.Name = "wallpaperPictureBox";
            wallpaperPictureBox.Size = new Size(494, 318);
            wallpaperPictureBox.TabIndex = 1;
            wallpaperPictureBox.TabStop = false;
            // 
            // selectButton
            // 
            selectButton.Location = new Point(143, 256);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(75, 23);
            selectButton.TabIndex = 2;
            selectButton.Text = "button1";
            selectButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(selectButton);
            Controls.Add(wallpaperPictureBox);
            Controls.Add(wallpapersListBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)wallpaperPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox wallpapersListBox;
        private PictureBox wallpaperPictureBox;
        private Button selectButton;
    }
}
