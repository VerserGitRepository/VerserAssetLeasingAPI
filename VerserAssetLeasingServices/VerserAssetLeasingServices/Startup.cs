using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using VerserAssetLeasingServices.DBEntities.EntityModels;
using AutoMapper;

using VerserAssetLeasingServices.BusinessLogic.Interfaces;
using VerserAssetLeasingServices.BusinessLogic.Implementations;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using VerserAssetLeasingServices.Common.Implementation;
using VerserAssetLeasingServices.Common.Interfaces;
namespace VerserAssetLeasingServices
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
            services.AddScoped<IDBAccess, DBAccess>();
            services.AddScoped<ICreateCompany, CreateCompanyService>();
            services.AddScoped<ICreateEndUsers, CreateEndUsersService>();
            services.AddScoped<IListItems, ListItemsService>();
            services.AddScoped<IMasterData, MasterDataService>();
            services.AddScoped<INewContract, NewContractService>();
            services.AddScoped<IAssets, AssetsService>();
            services.AddScoped<ICompany, CompanyService>();
            services.AddScoped<IEndUsers, EndUsersService>();
            services.AddScoped<IContracts, ContractService>();
           // services.AddScoped<ILogs, Logs>();
            services.AddDbContext<AssetLeaseDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BrightstarDev")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddAutoMapper();
            services.AddCors(options => {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()        
                        .AllowCredentials()
                        .AllowAnyHeader();                        
                    });                
            });

            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("AllowAll"));
            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            if (env.IsProduction() || env.IsStaging())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseCors("AllowAll");
            //else
            //{
            //    app.UseHsts();
            //}
          //  app.UseHttpsRedirection();
            app.UseMvc();            
        }
    }
}
