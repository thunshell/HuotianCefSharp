using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HuotianCefSharp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Main(string[] args)
        {
            App app = new App();
            app.InitializeComponent();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            CefSharp.CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            var setting = new CefSharp.CefSettings()
            {
                CachePath = System.IO.Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory) + "Cache"
            };
            CefSharp.Cef.Initialize(setting, true, null);
        }
    }
}
