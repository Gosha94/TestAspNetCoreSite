using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestAspNetCoreSite.Interfaces;
using TestAspNetCoreSite.Mocks;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;
using TestAspNetCoreSite.Data.EfCoreContext;
using TestAspNetCoreSite.Data.Repository;

namespace TestAspNetCoreSite
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        [Obsolete]
        public Startup(IHostingEnvironment hostEnv)
        {
            this._confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbSettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbaseContext>(options => options.UseSqlServer(_confString.GetConnectionString("SqlServerConnection")));
            // Сопоставляем Класс и Интерфейс, вероятно это DI контейнер            
            //services.AddTransient<IAllMicrowaves, MockMicrowaves>();
            //services.AddTransient<IMicrowavesCategory, MockMicrowaveCategory>();            
            services.AddTransient<IAllMicrowaves, MicrowaveRepository>();
            services.AddTransient<IMicrowavesCategory, MicrowaveCategoryRepository>();
            // Подключаем MVC к проекту
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {          

            // Подключаем вывод исключений в режиме разработки
            app.UseDeveloperExceptionPage();
            // Подключаем вывод кодов ошибок на страницах
            app.UseStatusCodePages();
            // Включаем поддержку стат.файлов в проекте (картинки и т.д.)
            app.UseStaticFiles();
            // Включаем отслеживание URL адреса, по которому переходят
            // Если не указывается конкретный адрес ресурса, будет передаваться осн контролер по умолчанию index.html
            app.UseMvcWithDefaultRoute();
        }
    }
}
