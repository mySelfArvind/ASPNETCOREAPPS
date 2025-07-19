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
            app.UseRouting();

            app.UseEndpoints(endPoints =>
            {
                endPoints.MapDefaultControllerRoute();
            });

        }
    }
}
