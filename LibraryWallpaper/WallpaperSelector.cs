namespace LibraryWallpaper
{
    public class WallpaperSelector
    {
        private List<Wallpaper> Wallpapers { get; }

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
            /// REVIEW. a.boikov. 2024/10/29. 0. Разобраться с тем, как это работает
            /// 1. убрать частный метод поиска по одному тегу
            /// 2. Использовать в тесте поиск по нескольким тегам, соответственно и расширить тестовые данные до нескольких тегов поиска
            return Wallpapers.Where(w => w.Tags.Any(t => tags.Contains(t))).ToList();
        }
    }
}
