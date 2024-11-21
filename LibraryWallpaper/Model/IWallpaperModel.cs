using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWallpaper.Model
{
    public interface IWallpaperModel
    {
        List<Wallpaper> GetWallpaper();
        
        int CountWallpaper();

        event Action<Wallpaper> WallpaperLoaded;
    }
}
