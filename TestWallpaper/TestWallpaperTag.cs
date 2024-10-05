using LibraryWallpaper;

namespace TestWallpaper
{
    [TestClass]
    public class TestWallpaperTag
    {
        [TestMethod]
        public void Test_GetWallpapersByTag_WithImagePaths()
        {
            var selector = new WallpaperSelector();

            var natureWallpaper = new Wallpaper("Лес", "\"D:\\Picture\\Nature\\1.jpg\"", new List<string> { "Природа", "Зелень" });
            var sportsWallpaper = new Wallpaper("Футбол", "\"D:\\Picture\\Footbool\\1.jpg\"", new List<string> { "Спорт", "Действие" });

            selector.AddWallpaper(natureWallpaper);
            selector.AddWallpaper(sportsWallpaper);

            var result = selector.GetWallpapersByTag("Природа");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Лес", result[0].Name);
            Assert.AreEqual("\"D:\\Picture\\Nature\\1.jpg\"", result[0].ImagePath);
        }

        [TestMethod]
        public void Test_GetWallpapersByTag_NoResults_WithImagePaths()
        {
            var selector = new WallpaperSelector();
            var natureWallpaper = new Wallpaper("Горы", "\"D:\\Picture\\Nature\\1.jpg\"", new List<string> { "Природа" });
            selector.AddWallpaper(natureWallpaper);

            var result = selector.GetWallpapersByTag("Лес");

            Assert.AreEqual(0, result.Count);
        }

    }
}