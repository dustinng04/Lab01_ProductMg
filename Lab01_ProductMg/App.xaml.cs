using System.Configuration;
using System.Data;
//using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;
using System.Windows;
using DataAccessLayer;
using WPFApp;
using Repositories;
using Services;
using Microsoft.Extensions.DependencyInjection;

namespace Lab01_ProductMg
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IHost _host;
        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Register services and repositories
                    services.AddSingleton<IProductRepository, ProductRepository>();
                    services.AddSingleton<IProductService, ProductService>();
                    services.AddSingleton<ICategoryService, CategoryService>();
                    services.AddSingleton<MainWindow>();
                })
                .Build();
        }

        //public App()
        //{
        //    _host = Host.CreateDefaultBuilder()
        //        .ConfigureServices((context, services) =>
        //        {
        //            // Register DbContext with connection string
        //            services.AddDbContext<MyStoreContext>(options =>
        //                options.UseSqlServer(@"Server=Riversy\SQLEXPRESS;Database=MyStore;Integrated Security=true;Trusted_Connection=True;"));

        //            // Register repositories and services
        //            services.AddScoped<IProductRepository, ProductRepository>();
        //            services.AddScoped<IProductService, ProductService>();

        //            // Register windows to get them via DI
        //            services.AddSingleton<LoginWindow>();
        //            services.AddSingleton<MainWindow>();
        //        })
        //        .ConfigureLogging(logging =>
        //        {
        //            logging.ClearProviders();
        //            logging.AddConsole();
        //        })
        //        .Build();
        //}

        //protected override async void OnStartup(StartupEventArgs e)
        //{
        //    await _host.StartAsync();

        //    var loginWindow = _host.Services.GetRequiredService<MainWindow>();
        //    loginWindow.Show();

        //    base.OnStartup(e);
        //}
        //private ServiceProvider serviceProvider;
        //public App()
        //{
        //    ServiceCollection services = new ServiceCollection();
        //    ConfigureServices(services);
        //    serviceProvider = services.BuildServiceProvider();
        //}

        //private void ConfigureServices(ServiceCollection services)
        //{
        //    services.AddDbContext<MyStoreContext>();
        //    services.AddScoped<LoginWindow>();
        //}
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //   var loginWindow = serviceProvider.GetService<LoginWindow>();
        //    loginWindow.Show();
        //}
    }

}
