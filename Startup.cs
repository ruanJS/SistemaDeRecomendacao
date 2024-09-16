using EducationAndCareerRecommendationsAPI.Data;
using EducationAndCareerRecommendationsAPI.Repositories;
using EducationAndCareerRecommendationsAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers()
                .AddNewtonsoftJson(); // Suporte ao Newtonsoft.Json

        // Swagger/OpenAPI configuration
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Education and Career Recommendations API",
                Version = "v1",
                Description = "API para fornecer recomendações personalizadas de educação e carreira"
            });
        });

        // Configura o Entity Framework para usar Oracle
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseOracle(Configuration.GetConnectionString("DefaultConnection")));

        // Registro dos repositórios e serviços
        services.AddScoped<IRecommendationsRepository, RecommendationsRepository>();
        services.AddScoped<IRecommendationsService, RecommendationsService>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();

            // Configura o Swagger para ser acessível em https://localhost:7111/swagger/index.html
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Education and Career Recommendations API V1");
                c.RoutePrefix = "swagger"; // Define o Swagger para estar em /swagger/index.html
            });
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
