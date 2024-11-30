using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryEngine;
using LibraryEngine.View;

namespace WallpaperView
{
    public partial class WallpaperView : Form, IWallpaperView
    {
        public event WallpaperHandler WallpaperSelected;

        public WallpaperView()
        {
            InitializeComponent();

            selectButton.Click += selectButton_Click;
            wallpapersListBox.SelectedIndexChanged += WallpapersListBox_SelectedIndexChanged;
        }

        private void selectButton_Click(object? sender, EventArgs e)
        {
            if (wallpapersListBox.SelectedItem is Wallpaper selectedWallpaper)
            {
                WallpaperSelected?.Invoke(selectedWallpaper);
            }
        }

        private void WallpapersListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (wallpapersListBox.SelectedItem is Wallpaper selectedWallpaper)
            {
                wallpaperPictureBox.ImageLocation = selectedWallpaper.ImagePath;
            }
        }


        public void LoadWallpapers(List<Wallpaper> wallpapers)
        {
            wallpapersListBox.Items.Clear();
            wallpapersListBox.DisplayMember = "Name";
            wallpapersListBox.Items.AddRange(wallpapers.ToArray());
        }



        public void LoadWallpapers(Wallpaper wallpaper)
        {
            wallpapersListBox.Items.Add(wallpaper.Name);
        }
    }
}
