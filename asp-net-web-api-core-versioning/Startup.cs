using asp_net_web_api_core_versioning.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace asp_net_web_api_core_versioning
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
            services.AddMvc();

            services.AddApiVersioning(v =>
            {
                v.DefaultApiVersion = new ApiVersion(1, 1);
                v.AssumeDefaultVersionWhenUnspecified = true;
                v.ReportApiVersions = true;
                v.ApiVersionReader = new HeaderApiVersionReader("version", "X-MySample-Version");
                v.Conventions.Controller<ValuesV3Controller>()
                .HasApiVersion(new ApiVersion(3, 0));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}