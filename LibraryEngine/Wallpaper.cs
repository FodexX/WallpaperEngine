namespace LibraryEngine
{
    public class Wallpaper
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public List<string> Tags { get; set; }

        public Wallpaper(string name, string imagePath, List<string> tags)
        {
            Name = name;
            ImagePath = imagePath;
            Tags = tags;
        }
    }
}
