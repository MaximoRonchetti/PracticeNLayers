using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Models.Data;
using Services;
using Services.Interfaces;
using Services.Repository;

namespace UI
{
    internal static class Program
    {
        public static IServiceProvider _serviceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();
            var services = host.Services;
            //ApplicationConfiguration.Initialize();
            Application.Run(services.GetRequiredService<Menu>());
        }
        
        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) => 
            {
                services.AddDbContext<PracticeNLayersContext>(opt => opt.UseSqlServer("Server=localhost;Database=PracticeNLayers;Trusted_Connection=True;"));
                //services.AddTransient<EmployeeView>();
                services.AddTransient<Menu>();
                services.AddTransient<IEmployeeRepository, EmployeeRepository>();
                services.AddTransient<IDepartamentRepository, DepartamentRepository>();
                services.AddTransient<IProjectRepository, ProjectRepository>();
                services.AddTransient<IEmployeeProjectRepository, EmployeeProjectRepository>();
                services.AddTransient<ISprintRepository, SprintRepository>();
                services.AddTransient<IUnitOfWork, UnitOfWork>();
            });
        }
    }
}