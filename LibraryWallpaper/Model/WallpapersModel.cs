using System;
using System.Collections.Generic;

namespace LibraryWallpaper.Model
{
    public class WallpapersModel : IWallpaperModel
    {
        private List<Wallpaper> wallpapers_ = new List<Wallpaper>
        {
            new Wallpaper("Cпортик", "example/path/to/image.jpg", new List<string> { "Футбол", "Мяч" })
        };

        event Action<WallpaperSelector> IWallpaperModel.WallpapersLoaded
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public List<Wallpaper> GetWallpaper()
        {
            return wallpapers_;
        }

        public int CountWallpaper()
        {
            return wallpapers_.Count;
        }

        public void NotifyClientsUpdated()
        {
            WallpaperLoaded?.Invoke();
        }

        public List<Wallpaper> GetWallpapers()
        {
            return wallpapers_;
        }

        public event Action WallpaperLoaded;
    }
}
