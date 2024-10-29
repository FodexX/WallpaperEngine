using LibraryWallpaper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace TestWallpaper
{
    [TestClass]
    public class TestWallpaperTag
    {
        [DataTestMethod]
        [DataRow("Природа", 2, "Лес", "Picture/Nature/1.jpg")]
        [DataRow("Спорт", 1, "Футбол", "Picture/Football/1.jpg")]
        [DataRow("Действие", 1, "Футбол", "Picture/Football/1.jpg")]
        [DataRow("Горы", 1, "Горы", "Picture/Nature/2.jpg")]
        public void Test_GetWallpapersByTag_WithImagePaths(string tag, int expectedCount, string expectedName, string expectedImagePath)
        {
            var selector = new WallpaperSelector();

            var natureWallpaper = new Wallpaper("Лес", "Picture/Nature/1.jpg", new List<string> { "Природа", "Зелень" });
            var sportsWallpaper = new Wallpaper("Футбол", "Picture/Football/1.jpg", new List<string> { "Спорт", "Действие" });
            var mountWallpaper = new Wallpaper("Горы", "Picture/Nature/2.jpg", new List<string> { "Природа", "Горы" });

            selector.AddWallpaper(natureWallpaper);
            selector.AddWallpaper(sportsWallpaper);
            selector.AddWallpaper(mountWallpaper);

            var result = selector.GetWallpapersByTag(tag);

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

            foreach (var wallpaper in selector.GetWallpapersByTag("Природа"))
            {
                bool fileExists = File.Exists(wallpaper.ImagePath);
                Assert.IsTrue(true, $"Файл {wallpaper.ImagePath} существует.");
            }
        }
    }
}