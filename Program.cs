// Author: Zachary Jordan
// Course: COMP-003B: ASP.NET Core
// Instructor: Jonathan Cruz
// Purpose: Final project synthesizing MVC, Web API, EF Core, and middleware
using COMP003B.SP26.FinalProject.ZachJ.Middleware;
using COMP003B.SP26.FinalProject.ZachJ.Data;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.SP26.FinalProject.ZachJ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
                });
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<FinalsContext>(options =>
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FinalsDb;Trusted_Connection=True;MultipleActiveResultSets=true"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            
            }
            else
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            //custom middleware
            app.UseMiddleware<RequestTimingMiddleware>();
            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
