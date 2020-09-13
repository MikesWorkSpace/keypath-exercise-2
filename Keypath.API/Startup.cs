using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Keypath.API.Models;
using Keypath.API.DAL;

namespace Keypath.API
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

            string connectionString = Configuration.GetConnectionString("KeypathRepo");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                services.AddDbContext<KeypathContext>(opt =>
                    opt.UseInMemoryDatabase("KeypathInMemoryRepo"));
            }
            else
            {
                services.AddDbContext<KeypathContext>(opt =>
                    opt.UseSqlServer(connectionString));
            }

            services.AddCors(options =>
            {
                options.AddPolicy("Policy01",
                    builder =>
                    {
                        builder.WithOrigins("https://localhost:44327")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                    });
            });
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
