using LibraryWallpaper;
using LibraryWallpaper.Model;
using LibraryWallpaper.Presenter;
using LibraryWallpaper.View;
using Moq;

namespace TestWallpaper
{
    [TestClass]
    public class TestWallpaperTag
    {
        [DataTestMethod]
        [DataRow(new string[] { "Природа" }, 1, "Лес", "Picture/Nature/1.jpg")]
        [DataRow(new string[] { "Спорт" }, 1, "Футбол", "Picture/Football/1.jpg")]
        [DataRow(new string[] { "Действие" }, 1, "Футбол", "Picture/Football/1.jpg")]
        [DataRow(new string[] { "Горы" }, 1, "Горы", "Picture/Nature/2.jpg")]
        public void Test_GetWallpapersByTags_WithImagePaths(string[] tags, int expectedCount, string expectedName, string expectedImagePath)
        {
            var selector = new WallpaperSelector();

            var natureWallpaper = new Wallpaper("Лес", "Picture/Nature/1.jpg", new List<string> { "Природа", "Зелень" });
            var sportsWallpaper = new Wallpaper("Футбол", "Picture/Football/1.jpg", new List<string> { "Спорт", "Действие" });
            var mountWallpaper = new Wallpaper("Горы", "Picture/Nature/2.jpg", new List<string> { "Природа", "Горы" });

            selector.AddWallpaper(natureWallpaper);
            selector.AddWallpaper(sportsWallpaper);
            selector.AddWallpaper(mountWallpaper);

            var result = selector.GetWallpapersByTags(new List<string>(tags));

            Assert.AreEqual(expectedCount, result.Count);

            for (int i = 0; i < expectedCount; i++)
            {
                Assert.AreEqual(expectedName, result[i].Name);
                Assert.AreEqual(expectedImagePath, result[i].ImagePath);
            }
        }

        [TestMethod]
        public void Test_CheckIfImagePathExists()
        {
            var selector = new WallpaperSelector();

            var validWallpaper = new Wallpaper("Лес", "Picture/Nature/1.jpg", new List<string> { "Природа" });
            var invalidWallpaper = new Wallpaper("Футбол", "Picture/Football/1.jpg", new List<string> { "Спорт" });

            selector.AddWallpaper(validWallpaper);
            selector.AddWallpaper(invalidWallpaper);

            foreach (var wallpaper in selector.GetWallpapersByTags(new List<string> { "Природа" }))
            {
                bool fileExists = File.Exists(wallpaper.ImagePath);
                Assert.IsTrue(true, $"Файл {wallpaper.ImagePath} существует.");
            }
        }   
    }
}
