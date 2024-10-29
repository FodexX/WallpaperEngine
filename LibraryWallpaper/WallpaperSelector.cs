using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWallpaper
{
    public class WallpaperSelector
    {
        /// REVIEW. a.boikov. 2024/10/19. поле класса нужно сделать private.
        ///Все управление через методы, чтобы защитить от несанкционированного использования объекта
        private List<Wallpaper> Wallpapers { get; set; }

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
        public List<Wallpaper> GetWallpapersByTags(List<string> tags)
        {
            return Wallpapers.Where(w => w.Tags.Any(t => tags.Contains(t))).ToList();
        }
    }
}
