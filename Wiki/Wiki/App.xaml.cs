using GalaSoft.MvvmLight.Messaging;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Wiki.Services.Classes;
using Wiki.Services.Interfaces;
using Wiki.ViewModel;

namespace Wiki
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; } = new();

        protected override void OnStartup(StartupEventArgs e)
        {
            Register();
            MainStartup();
        }

        private void Register()
        {
            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<INavigateService, NavigateService>();
            Container.RegisterSingleton<ICheckService, CheckService>();

            Container.RegisterSingleton<MainVM>();
            Container.RegisterSingleton<AddVM>();
            Container.RegisterSingleton<ListVM>();
        }

        private void MainStartup()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = Container.GetInstance<MainVM>();
            mainWindow.ShowDialog();
        }
    }
}
