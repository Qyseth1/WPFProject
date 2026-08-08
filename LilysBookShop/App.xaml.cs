using LilysBookShop.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace LilysBookShop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; }

        public App()
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();
        }


        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainViewModel>();
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();

            mainWindow.Show();
        }
    }
}
