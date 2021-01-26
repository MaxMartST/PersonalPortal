using DBRepository;
using DBRepository.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PersonalPortal
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddScoped<IRepositoryContextFactory, RepositoryContextFactory>(); // 1
            services.AddScoped<IBlogRepository>(provider => new BlogRepository(Configuration.GetConnectionString("PersonalPortalConnection"), provider.GetService<IRepositoryContextFactory>())); // 2
            //services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PersonalPortalConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
