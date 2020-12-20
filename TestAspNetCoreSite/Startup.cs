using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestAspNetCoreSite.Interfaces;
using TestAspNetCoreSite.Mocks;

namespace TestAspNetCoreSite
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Сопоставляем Класс и Интерфейс, вероятно это DI контейнер
            services.AddTransient<IAllMicrowaves, MockMicrowaves>();
            services.AddTransient<IMicrowavesCategory, MockMicrowaveCategory>();
            
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
