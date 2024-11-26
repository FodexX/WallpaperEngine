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

        public List<Wallpaper> GetWallpapersByTags(List<string> tags)
        {
            return Wallpapers.Where(w => tags.All(tag => w.Tags.Contains(tag))).ToList();
        }

    }
}
