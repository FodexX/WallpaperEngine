using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEngine.Model
{
    public interface IWallpaperModel
    {
        List<Wallpaper> GetWallpapers();

        List<Wallpaper> GetWallpaper();

        int CountWallpaper();

        event Action<WallpaperSelector> WallpapersLoaded;
    }
}
