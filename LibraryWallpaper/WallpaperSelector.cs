using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWallpaper
{
    public class WallpaperSelector
    {
        public List<Wallpaper> Wallpapers { get; set; }

        public WallpaperSelector()
        {
            Wallpapers = new List<Wallpaper>();
        }

        public void AddWallpaper(Wallpaper wallpaper)
        {
            Wallpapers.Add(wallpaper);
        }

        public List<Wallpaper> GetWallpapersByTag(string tag)
        {
            return Wallpapers.FindAll(w => w.Tags.Contains(tag));
        }
    }
}
