using Microsoft.Extensions.FileProviders;

namespace ScribeX.BookStore
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "MyFiles")),
                RequestPath = "/MyFiles"
            });
            app.UseRouting();
            app.UseEndpoints(endPoints =>
            {
                endPoints.MapDefaultControllerRoute();
            });

        }
    }
}
