using LibraryWallpaper;

namespace TestWallpaper
{
    [TestClass]
    public class TestWallpaperTag
    {
        [TestMethod]
        /// REVIEW. a.boikov. 05/10/2024. Объединить два тест-кейса Test_GetWallpapersByTag_WithImagePaths и Test_GetWallpapersByTag_NoResults_WithImagePaths
        /// в один, управляемый данными.
        /// В тест добавить проверку существующих - несуществующих файлов. (лучше отдельным тестом)
        public void Test_GetWallpapersByTag_WithImagePaths()
        {
            var selector1 = new WallpaperSelector();
            var selector2 = new WallpaperSelector();

            /// REVIEW. a.boikov. 05/10/2024. Пути нужно указывать относительные (от собранного exe с тестами)
            var natureWallpaper = new Wallpaper("Лес", "Picture/Nature/1.jpg", new List<string> { "Природа", "Зелень" });
            var sportsWallpaper = new Wallpaper("Футбол", "Picture/Football/1.jpg", new List<string> { "Спорт", "Действие" });
            var mountWallpaper = new Wallpaper("Горы", "Picture/Nature/1.jpg", new List<string> { "Природа" });

            selector1.AddWallpaper(natureWallpaper);
            selector1.AddWallpaper(sportsWallpaper);
            selector2.AddWallpaper(mountWallpaper);

            var result1 = selector1.GetWallpapersByTag("Природа");

            Assert.AreEqual(1, result1.Count);
            Assert.AreEqual("Лес", result1[0].Name);
            Assert.AreEqual("Picture/Nature/1.jpg", result1[0].ImagePath);

            var result2 = selector2.GetWallpapersByTag("Спорт");

            Assert.AreEqual(0, result2.Count);
        }

        [TestMethod]
        public void Test_GetWallpapersByTag()
        {
            var selector = new WallpaperSelector();

            var natureWallpaper = new Wallpaper("Лес", " ", new List<string> { "Природа", "Зелень" });
            var sportsWallpaper = new Wallpaper("Футбол"," " , new List<string> { "Спорт", "Действие" });
            selector.AddWallpaper(natureWallpaper);
            selector.AddWallpaper(sportsWallpaper);

            var result = selector.GetWallpapersByTag("Природа");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Лес", result[0].Name);
        }

        [TestMethod]
        public void Test_GetWallpapersByTag_NoResults()
        {
            var selector = new WallpaperSelector();
            var natureWallpaper = new Wallpaper("Горы", " ", new List<string> { "Природа" });
            selector.AddWallpaper(natureWallpaper);

            var result = selector.GetWallpapersByTag("Спорт");

            Assert.AreEqual(0, result.Count);
        }
    }
}