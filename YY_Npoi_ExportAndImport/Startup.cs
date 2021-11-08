using Export.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Myblog.Repository;
using Myblog.Service;
using MyBlog.IRepository;
using MyBlog.IService;
using SqlSugar;
using SqlSugar.IOC;
using YY_Dal;
using YY_Model;
using YY_Services;



namespace YY_NpoiExportAndImport
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //注入Ef数据库上下文对象服务
            services.AddDbContext<SchoolUserInfoContext>(options =>
      //options.UseMySQL(Configuration.GetConnectionString("MySqlConnection")));
      options.UseSqlServer(Configuration.GetConnectionString("MySqlConnection")));

         
            AppConfig.Appsetting = Configuration.GetConnectionString("MySqlConnection");
            //创建数据库对象
            /*
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = AppConfig.Appsetting,
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true
            });

            */
            // 10秒入门
            SugarIocServices.AddSqlSugar(new IocConfig()
            {
                //ConfigId="db01"  多租户用到
                ConnectionString = AppConfig.Appsetting,
                DbType = IocDbType.SqlServer,
                IsAutoCloseConnection = true//自动释放
            });
            services.AddCustomIOC(
                
                );
            /*
            //注入后就能所有地方使用
            DbScoped.SugarScope.Queryable<UserOrgMapping>().Where(it => it.Id > 0).ToList() //1.7版本支持
            DbScoped.Sugar.Queryable<UserOrgMapping>().Where(it => it.Id > 0).ToList()
            */

            //依赖注入
            services.AddScoped<NpoiWordExportService>();
            services.AddScoped<NpoiExcelOperationService>();


            //升级.NET Core 3.1
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddControllersWithViews();
            services.AddRazorPages();

            //Razor试图运行时编译配置
            services.AddRazorPages().AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
            //TODO:升级 .NET Core 3.1
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }

    public static class IOCExtend
    {
        public static IServiceCollection AddCustomIOC(this IServiceCollection services)
        {
            services.AddScoped<INewsRepository, NewsRepository>();
            services.AddScoped<INewsService, NewsService>();

            services.AddScoped<ICodeFirstTableRepository, CodeFirstTableRepository>();
            services.AddScoped<ICodeFirstService, CodeFirstService>();

            services.AddScoped<IUserInfoRepository, UserInfoRepository>();
            services.AddScoped<IUserInfoService, UserInfoService>();
            return services;
        }
        /*
        public static IServiceCollection AddCustomJWT(this IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                  .AddJwtBearer(options =>
                  {
                      options.TokenValidationParameters = new TokenValidationParameters
                      {
                          ValidateIssuerSigningKey = true,
                          IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SDMC-CJAS1-SAD-DFSFA-SADHJVF-VF")),
                          ValidateIssuer = true,
                          ValidIssuer = "http://localhost:6060",
                          ValidateAudience = true,
                          ValidAudience = "http://localhost:5000",
                          ValidateLifetime = true,
                          ClockSkew = TimeSpan.FromMinutes(60)
                      };
                  });
            return services;
        }
        */
    }
}
