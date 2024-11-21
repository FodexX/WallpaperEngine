using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWallpaper.View
{
    public delegate void WallpaperHandler(Wallpaper wallpaper);

    public interface IWallpaperView
    {
        void LoadWallpaper(Wallpaper wallpaper);

        event WallpaperHandler WallpaperSelected;
    }
}
