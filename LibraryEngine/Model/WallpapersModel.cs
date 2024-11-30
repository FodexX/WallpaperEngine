using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryEngine.Model
{
    public class WallpapersModel : IWallpaperModel
    {
        // Поле для хранения списка обоев
        private List<Wallpaper> wallpapers_ = new List<Wallpaper>
        {
            new Wallpaper("Спортик", "Picture\\Footbool\\1.jpg", new List<string> { "Футбол", "Мяч" }),
            new Wallpaper("Горы", "Picture\\Nature\\1.jpg", new List<string> { "Горы", "Природа" })
        };

        public event Action<WallpaperSelector> WallpapersLoaded;

        public List<Wallpaper> GetWallpapers()
        {
            return wallpapers_;
        }

        public List<Wallpaper> GetWallpaper()
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
            NotifyClientsUpdated(); 
        }

        public List<Wallpaper> GetWallpapersByTags(List<string> tags)
        {
            return wallpapers_.Where(w => tags.All(tag => w.Tags.Contains(tag))).ToList();
        }

        private void NotifyClientsUpdated()
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
