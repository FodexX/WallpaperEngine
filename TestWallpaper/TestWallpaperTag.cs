using LibraryWallpaper;

namespace TestWallpaper
{ggf
    [TestClass]
    public class TestWallpaperTag
    {
        [TestMethod]
        public void Test_GetWallpapersByTag()
        {
            var selector = new WallpaperSelector();

            var natureWallpaper = new Wallpaper("Ëåñ", new List<string> { "Ïðèðîäà", "Çåëåíü" });
            var sportsWallpaper = new Wallpaper("Ôóòáîë", new List<string> { "Ñïîðò", "Äåéñòâèå" });
            selector.AddWallpaper(natureWallpaper);
            selector.AddWallpaper(sportsWallpaper);

            var result = selector.GetWallpapersByTag("Ïðèðîäà");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Ëåñ", result[0].Name);
        }

        [TestMethod]
        public void Test_GetWallpapersByTag_NoResults()
        {
            var selector = new WallpaperSelector();
            var natureWallpaper = new Wallpaper("Ãîðû", new List<string> { "Ïðèðîäà" });
            selector.AddWallpaper(natureWallpaper);

            var result = selector.GetWallpapersByTag("Ñïîðò");

            Assert.AreEqual(0, result.Count);
        }
    }
}