using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestAspNetCoreSite.Interfaces;
using TestAspNetCoreSite.Mocks;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;
using TestAspNetCoreSite.Data.EfCoreContext;

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
            // ������������ ����� � ���������, �������� ��� DI ���������
            
            //services.AddTransient<IAllMicrowaves, MockMicrowaves>();
            //services.AddTransient<IMicrowavesCategory, MockMicrowaveCategory>();            
            // ���������� MVC � �������
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {          

            // ���������� ����� ���������� � ������ ����������
            app.UseDeveloperExceptionPage();
            // ���������� ����� ����� ������ �� ���������
            app.UseStatusCodePages();
            // �������� ��������� ����.������ � ������� (�������� � �.�.)
            app.UseStaticFiles();
            // �������� ������������ URL ������, �� �������� ���������
            // ���� �� ����������� ���������� ����� �������, ����� ������������ ��� ��������� �� ��������� index.html
            app.UseMvcWithDefaultRoute();
        }
    }
}
