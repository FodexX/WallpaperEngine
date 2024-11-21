using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWallpaper.Model
{
    public class WallpapersModel : IWallpaperModel
    {
        private List<Wallpaper> wallpapers_ = new List<Wallpaper>();

        public WallpapersModel() 
        {
            wallpapers_.Add(new Wallpaper
            {
                Name = "Cпортик",
                ImagePath = " ",
                Tags = new List<string> { "Футбол", "Мяч" },
            });
        }


        public List<Wallpaper> GetWallpapers()
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

        public event Action WallpaperLoaded;

    }
}
