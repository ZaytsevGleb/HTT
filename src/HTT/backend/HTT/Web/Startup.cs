using BusinessLogic;
using DataAccess;
using Microsoft.OpenApi.Models;

namespace WebApi
{
    public sealed class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Register application dependencies
            services
                .AddDataAccessDependencies(_configuration)
                .AddBusinessLogicDependencies();

            // Api configuration
            services
                .AddCors(opt => opt.AddDefaultPolicy(b => b.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()))
                .AddControllers();

            // Swagger configuration
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(
                    name: "v1.0",
                    info: new OpenApiInfo { Title = "HTT API", Version = "v1.0" }
                );
            });
        }

        public void Configure(IApplicationBuilder builder)
        {
            builder
                .UseSwagger()
                .UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("../swagger/v1.0/swagger.json", "API v1.0");
                    options.RoutePrefix = "docs";
                })
                .UseCors()
                .UseRouting()
                .UseAuthentication()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapGet(
                        pattern: "/",
                        requestDelegate: async context => await context.Response.WriteAsync("Ok"));

                    endpoints.MapControllers();
                });
        }
    }
}
