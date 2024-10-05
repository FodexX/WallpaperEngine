namespace LibraryWallpaper
{
    public class Wallpaper
    {
        public string Name { get; set; }
        public List<string> Tags { get; set; }

        public Wallpaper(string name, List<string> tags)
        {
            Name = name;
            Tags = tags;
        }
    }
}
