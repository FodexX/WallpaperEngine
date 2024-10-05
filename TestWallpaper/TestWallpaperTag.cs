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
            var selector = new WallpaperSelector();

            /// REVIEW. a.boikov. 05/10/2024. Пути нужно указывать относительные (от собранного exe с тестами)
            var natureWallpaper = new Wallpaper("Лес", "\"C:\\Users\\fodex\\source\\repos\\WallpaperEngine\\Picture\\Nature\\1.jpg\"", new List<string> { "Природа", "Зелень" });
            var sportsWallpaper = new Wallpaper("Футбол", "\"C:\\Users\\fodex\\source\\repos\\WallpaperEngine\\Picture\\Footbool\\1.jpg\"", new List<string> { "Спорт", "Действие" });

            selector.AddWallpaper(natureWallpaper);
            selector.AddWallpaper(sportsWallpaper);

            var result = selector.GetWallpapersByTag("Природа");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Лес", result[0].Name);
            Assert.AreEqual("\"C:\\Users\\fodex\\source\\repos\\WallpaperEngine\\Picture\\Nature\\1.jpg\"", result[0].ImagePath);
        }

        [TestMethod]
        public void Test_GetWallpapersByTag_NoResults_WithImagePaths()
        {
            var selector = new WallpaperSelector();
            var natureWallpaper = new Wallpaper("Горы", "\"C:\\Users\\fodex\\source\\repos\\WallpaperEngine\\Picture\\Nature\\1.jpg\"", new List<string> { "Природа" });
            selector.AddWallpaper(natureWallpaper);

            var result = selector.GetWallpapersByTag("Спорт");

            Assert.AreEqual(0, result.Count);
        }

    }
}