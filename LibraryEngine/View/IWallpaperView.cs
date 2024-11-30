using System;
using System.Collections.Generic;

namespace LibraryEngine.View
{
    public delegate void WallpaperHandler(Wallpaper wallpaper);

    public interface IWallpaperView
    {
        void LoadWallpapers(List<Wallpaper> wallpapers);
        void LoadWallpapers(Wallpaper wallpaper);
        event WallpaperHandler WallpaperSelected;
    }
}
