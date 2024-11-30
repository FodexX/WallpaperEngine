using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEngine.View
{
    public delegate void WallpaperHandler(Wallpaper wallpaper);

    public interface IWallpaperView
    {
        void LoadWallpapers(List<Wallpaper> wallpaper);
        void LoadWallpapers(Wallpaper wallpaper);

        event WallpaperHandler WallpaperSelected;
    }
}
