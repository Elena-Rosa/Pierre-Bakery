using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;

namespace PierreBakery
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
      builder.Services.AddControllersWithViews();
      WebApplication app = builder.Build();
      app.UseHttpsRedirection();
      app.UseStaticFiles();
      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllerRoute(

          name: "Vendors",
          pattern: "vendors",
          defaults: new { controller = "Vendors", action = "Index" }
      );
      });
      app.Run();
    }
  }
}