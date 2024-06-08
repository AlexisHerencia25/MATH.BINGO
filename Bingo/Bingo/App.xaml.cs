using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;

namespace Bingo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            if (SystemParameters.PrimaryScreenWidth > 1920)
            {
                RenderOptions.ProcessRenderMode = RenderMode.SoftwareOnly;
            }
            else
            {
                RenderOptions.ProcessRenderMode = RenderMode.Default;
            }
        }
    }

}
