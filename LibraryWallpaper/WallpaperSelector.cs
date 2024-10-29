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
            return Wallpapers.Where(w => w.Tags.Any(t => tags.Contains(t))).ToList();
        }
    }
}
