using System;
using System.Windows.Forms;
using LibraryEngine.Model;
using LibraryEngine.View;
using LibraryEngine.Presenter;

namespace WallpaperView
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IWallpaperModel model = new WallpapersModel();
            IWallpaperView view = new WallpaperView();
            WallpaperPresenter presenter = new WallpaperPresenter(model, view);

            Application.Run((Form)view);
        }
    }
}
