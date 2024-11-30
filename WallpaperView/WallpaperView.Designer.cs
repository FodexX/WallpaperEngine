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
            wallpapersListBox.ItemHeight = 15;
            wallpapersListBox.Location = new Point(12, 12);
            wallpapersListBox.Name = "wallpapersListBox";
            wallpapersListBox.Size = new Size(200, 394);
            wallpapersListBox.TabIndex = 0;
            wallpapersListBox.SelectedIndexChanged += WallpapersListBox_SelectedIndexChanged;
            // 
            // wallpaperPictureBox
            // 
            wallpaperPictureBox.Location = new Point(220, 12);
            wallpaperPictureBox.Name = "wallpaperPictureBox";
            wallpaperPictureBox.Size = new Size(300, 300);
            wallpaperPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            wallpaperPictureBox.TabIndex = 1;
            wallpaperPictureBox.TabStop = false;
            // 
            // selectButton
            // 
            selectButton.Location = new Point(220, 320);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(100, 30);
            selectButton.TabIndex = 2;
            selectButton.Text = "Выбрать";
            selectButton.Click += this.selectButton_Click;
            // 
            // WallpaperView
            // 
            ClientSize = new Size(550, 450);
            Controls.Add(wallpapersListBox);
            Controls.Add(wallpaperPictureBox);
            Controls.Add(selectButton);
            Name = "WallpaperView";
            Text = "Wallpaper View";
            ((System.ComponentModel.ISupportInitialize)wallpaperPictureBox).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private ListBox wallpapersListBox;
        private PictureBox wallpaperPictureBox;
        private Button selectButton;
    }
}
