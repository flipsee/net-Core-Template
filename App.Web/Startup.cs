using App.Core.Helper;
using App.Core.Interfaces;
using App.Core.Interfaces.Models;
using App.Core.Interfaces.Repositories;
using App.Core.Interfaces.Services;
using App.Core.Models;
using App.Core.Services;
using App.Core.Sessions;
using App.Infrastructure.Contexts;
using App.Infrastructure.Repositories;
using App.Web.Middlewares;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace App.Web
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
            services.AddMemoryCache();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Identity
            services.AddDbContext<IdentityDbContext>(options =>
                //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), x => x.MigrationsAssembly("App.Infrastructure"))
                options.UseInMemoryDatabase("InMemoryDB")
            );
            services.AddIdentity<AccountUser, AccountRole>()
                .AddEntityFrameworkStores<IdentityDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();

            //AppDbContext
            services.AddDbContext<ApplicationDbContext>(options =>
                //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                options.UseInMemoryDatabase("InMemoryDB")
            );

            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            //Repo
            ConfigureRepositoryDI(services);

            //Services
            ConfigureServiceDI(services);
            
            services.AddMvc().AddRazorPagesOptions(options =>
            {
                //options.Conventions.AuthorizeFolder("/Menus");
                options.Conventions.AllowAnonymousToPage("/Account/Register");
                options.Conventions.AllowAnonymousToPage("/Account/Login");
                options.Conventions.AllowAnonymousToPage("/Index");
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseMiddleware<SessionMiddleware>();
            app.UseMvcWithDefaultRoute();
        }

        private void ConfigureRepositoryDI(IServiceCollection services)
        {
            services.AddTransient(typeof(IModelMapper<,>), typeof(ModelMapper<,>));
            services.AddTransient<IAccountClaimRepository, AccountClaimRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>(); 
        }

        private void ConfigureServiceDI(IServiceCollection services)
        {
            services.AddSingleton<SessionProvider>();
            services.AddTransient<IAccountClaimService, AccountClaimService>();
            services.AddTransient<IMenuService, MenuService>();
        }
    }
}
