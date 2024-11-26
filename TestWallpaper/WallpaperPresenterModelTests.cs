using LibraryWallpaper.Model;
using LibraryWallpaper.Presenter;
using LibraryWallpaper.View;
using LibraryWallpaper;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWallpaper
{
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
}
