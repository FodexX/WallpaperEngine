using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryEngine.Model
{
    public class WallpapersModel : IWallpaperModel
    {
        private List<Wallpaper> wallpapers_ = new List<Wallpaper>
        {
            new Wallpaper("Football", "Picture\\Sports\\Football\\1.jpg", new List<string> { "Football", "Sports" }),
            new Wallpaper("Mountains", "Picture\\Nature\\Mountains\\1.jpg", new List<string> { "Nature", "Mountains" })
        };

        public event Action<WallpaperSelector> WallpapersLoaded;

        public List<Wallpaper> GetWallpapers()
        {
            return wallpapers_;
        }

        public int CountWallpaper()
        {
            return wallpapers_.Count;
        }

        public void AddWallpaper(Wallpaper wallpaper)
        {
            wallpapers_.Add(wallpaper);
            NotifyWallpapersLoaded();
        }

        public List<Wallpaper> GetWallpapersByTags(List<string> tags)
        {
            return wallpapers_.Where(w => tags.All(tag => w.Tags.Contains(tag))).ToList();
        }

        private void NotifyWallpapersLoaded()
        {
            var selector = new WallpaperSelector();
            foreach (var wallpaper in wallpapers_)
            {
                selector.AddWallpaper(wallpaper);
            }
            WallpapersLoaded?.Invoke(selector);
        }
    }
}
