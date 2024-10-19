using LibraryWallpaper;

namespace TestWallpaper
{
    [TestClass]
    public class TestWallpaperTag
    {
        [DataTestMethod]
        [DataRow("Природа", 2, "Лес", "Picture/Nature/1.jpg")]
        [DataRow("Спорт", 1, "Футбол", "Picture/Football/1.jpg")]
        [DataRow("Действие", 1, "Футбол", "Picture/Football/1.jpg")]
        [DataRow("Горы", 0, null, null)] // No matching wallpapers
        public void Test_GetWallpapersByTag_WithImagePaths(string tag, int expectedCount, string expectedName, string expectedImagePath)
        {
            /// REVIEW. a.boikov. 2024/10/19. Заполнять WallpaperSelector разными объектами Wallpaper.
            /// Пока он тестируется на фиксированном наборе данных
            var selector = new WallpaperSelector();

            var natureWallpaper = new Wallpaper("Лес", "Picture/Nature/1.jpg", new List<string> { "Природа", "Зелень" });
            var sportsWallpaper = new Wallpaper("Футбол", "Picture/Football/1.jpg", new List<string> { "Спорт", "Действие" });
            var mountWallpaper = new Wallpaper("Горы", "Picture/Nature/2.jpg", new List<string> { "Природа" });

            selector.AddWallpaper(natureWallpaper);
            selector.AddWallpaper(sportsWallpaper);
            selector.AddWallpaper(mountWallpaper);

            /// REVIEW. a.boikov. 2024/10/19. Реализовать поиск по нескольким тегам одновременно
            var result = selector.GetWallpapersByTag(tag);

            Assert.AreEqual(expectedCount, result.Count);

            /// REVIEW. a.boikov. 2024/10/19. Проверять нужно весь массив, а не только первый элемент
            if (expectedCount > 0)
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
            var invalidWallpaper = new Wallpaper("Футбол", "Picture/InvalidPath/1.jpg", new List<string> { "Спорт" });

            selector.AddWallpaper(validWallpaper);
            selector.AddWallpaper(invalidWallpaper);

            foreach (var wallpaper in selector.Wallpapers)
            {
                bool fileExists = File.Exists(wallpaper.ImagePath);
                /// REVIEW. a.boikov. 2024/10/19. Вывода не должно быть в тестах
                /// Все проверки осуществлять через Assert.IsTrue
                if (fileExists)
                {
                    Console.WriteLine($"Файл существует: {wallpaper.ImagePath}");
                }
                else
                {
                    Console.WriteLine($"Файл не найден: {wallpaper.ImagePath}");
                }

                // Для тестов можно сделать ассерт на существование файла:
                // Assert.IsTrue(fileExists, $"Файл {wallpaper.ImagePath} не существует.");
            }
        }
    }
}
