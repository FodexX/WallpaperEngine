using System;
using System.Collections.Generic;

namespace LibraryEngine.Model
{
    public interface IWallpaperModel
    {
        List<Wallpaper> GetWallpapers();
        int CountWallpaper();
        void AddWallpaper(Wallpaper wallpaper);
        List<Wallpaper> GetWallpapersByTags(List<string> tags);
        event Action<WallpaperSelector> WallpapersLoaded;
    }
}
