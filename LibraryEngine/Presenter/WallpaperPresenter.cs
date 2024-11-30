using LibraryEngine.Model;
using LibraryEngine.View;

namespace LibraryEngine.Presenter
{
    public class WallpaperPresenter
    {
        private IWallpaperModel model_;
        private IWallpaperView view_;

        public WallpaperPresenter(IWallpaperModel model,IWallpaperView view)
        {
            model_ = model;
            view_ = view;
            model_.WallpapersLoaded += Model__WallpapersLoaded;
            view_.WallpaperSelected += View__WallpaperSelected;
        }


        private void View__WallpaperSelected(Wallpaper wallpaper)
        {
            var wallpapers = model_.GetWallpaper();
        }

        private void Model__WallpapersLoaded(WallpaperSelector obj)
        {
            var wallpapers = obj.GetWallpapersByTags(new List<string>()); // или передавайте актуальные теги
            foreach (var wallpaper in wallpapers)
            {
                view_.LoadWallpapers(wallpaper);
            }
        }

    }
}
