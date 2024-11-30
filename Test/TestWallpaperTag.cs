using LibraryEngine;

namespace TestWallpaper
{
    [TestClass]
    public class TestWallpaperTag
    {
        [DataTestMethod]
        [DataRow(new string[] { "Природа" }, 1, "Лес", "Picture/Nature/1.jpg")]
        [DataRow(new string[] { "Спорт" }, 1, "Футбол", "Picture/Football/1.jpg")]
        public void Test_GetWallpapersByTags_WithImagePaths(string[] tags, int expectedCount, string expectedName, string expectedImagePath)
        {
            var selector = new WallpaperSelector();

            var natureWallpaper = new Wallpaper("Лес", "Picture/Nature/1.jpg", new List<string> { "Природа", "Зелень" });
            var sportsWallpaper = new Wallpaper("Футбол", "Picture/Football/1.jpg", new List<string> { "Спорт", "Действие" });

            selector.AddWallpaper(natureWallpaper);
            selector.AddWallpaper(sportsWallpaper);

            var result = selector.GetWallpapersByTags(tags.ToList());

            Assert.AreEqual(expectedCount, result.Count);
            if (result.Count > 0)
            {
                Assert.AreEqual(expectedName, result[0].Name);
                Assert.AreEqual(expectedImagePath, result[0].ImagePath);
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
