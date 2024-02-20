using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Diagnostics.CodeAnalysis;
[ExcludeFromCodeCoverage]
internal class Program
{
    private static async Task Main(string[] args)
    {        
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api", Version = "v1" });
        });

        builder.Services.AddDbContext<ApiDbContext>(options =>
        {
            string connectionString = builder.Configuration.GetConnectionString("ConexMysql") ?? throw new Exception("Unable connected database");
            options.UseMySQL(connectionString);
        });
        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        {
            var service = scope.ServiceProvider;
            var loggerfactory = service.GetRequiredService<ILoggerFactory>();
            try
            {
                var context = service.GetRequiredService<ApiDbContext>();
                await context.Database.MigrateAsync();
            }
            catch
            {
                var logger = loggerfactory.CreateLogger<ApiDbContext>();
                logger.LogCritical("unable created the migrations");


            }
        }

        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "api v1"));
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}