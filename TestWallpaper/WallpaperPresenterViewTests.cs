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
            mockModel.Verify(m => m.GetWallpapers(), Times.Once());
        }
    }
}
