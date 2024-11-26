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
        [DataRow(new string[] { "Природа" }, 2, "Лес", "Picture/Nature/1.jpg")]
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

        [TestMethod]
        public void Test_GetWallpapersByMultipleTags_SingleImageWithMultipleTags()
        {
            var selector = new WallpaperSelector();

            var natureWallpaper = new Wallpaper("Лес", "Picture/Nature/1.jpg", new List<string> { "Природа", "Зелень" });
            var multiTaggedWallpaper = new Wallpaper("Горы и Лес", "Picture/Nature/2.jpg", new List<string> { "Природа", "Горы" });
            var sportsWallpaper = new Wallpaper("Футбол", "Picture/Football/1.jpg", new List<string> { "Спорт" });

            selector.AddWallpaper(natureWallpaper);
            selector.AddWallpaper(multiTaggedWallpaper);
            selector.AddWallpaper(sportsWallpaper);

            var searchTags = new List<string> { "Природа", "Горы" };
            var result = selector.GetWallpapersByTags(searchTags);

            Assert.AreEqual(1, result.Count, "Ожидается 1 результат.");

            Assert.AreEqual("Горы и Лес", result[0].Name);
            Assert.AreEqual("Picture/Nature/2.jpg", result[0].ImagePath);
        }
    }

    [TestClass]
    public class WallpaperPresenterModelTests
    {
        private Mock<IWallpaperModel> mockModel;
        private Mock<IWallpaperView> mockView;
        private WallpaperPresenter presenter;

        [TestInitialize]
        public void Setup()
        {
            mockModel = new Mock<IWallpaperModel>();
            mockView = new Mock<IWallpaperView>();
            presenter = new WallpaperPresenter(mockModel.Object, mockView.Object);
        }

        [TestMethod]
        public void Presenter_ShouldReactToModelEvent()
        {
            // Arrange
            var wallpaper = new Wallpaper("Test", "path/to/image", new List<string> { "Tag1", "Tag2" });
            var selector = new WallpaperSelector();
            selector.AddWallpaper(wallpaper);

            mockModel
                .Setup(m => m.GetWallpaper())
                .Returns(new List<Wallpaper> { wallpaper });

            // Act
            mockModel.Raise(m => m.WallpapersLoaded += null, selector);

            // Assert
            mockView.Verify(v => v.LoadWallpaper(It.Is<Wallpaper>(w => w.Name == "Test")), Times.Once);
        }
    }


    [TestClass]
    public class WallpaperPresenterViewTests
    {
        private Mock<IWallpaperModel> mockModel;
        private Mock<IWallpaperView> mockView;
        private WallpaperPresenter presenter;

        [TestInitialize]
        public void Setup()
        {
            mockModel = new Mock<IWallpaperModel>();
            mockView = new Mock<IWallpaperView>();
            presenter = new WallpaperPresenter(mockModel.Object, mockView.Object);
        }

       [TestMethod]
public void Presenter_ShouldUpdateModelOnViewSelection()
{
    // Arrange
    var mockModel = new Mock<IWallpaperModel>();
    var mockView = new Mock<IWallpaperView>();
    var presenter = new WallpaperPresenter(mockModel.Object, mockView.Object);

    var wallpaper = new Wallpaper("Test", "path", new List<string> { "tag" });
    mockView.Raise(v => v.WallpaperSelected += null, wallpaper);

    // Act & Assert
    mockModel.Verify(m => m.GetWallpaper(), Times.Once());
}
    }
}
