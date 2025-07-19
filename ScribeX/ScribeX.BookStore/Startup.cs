namespace ScribeX.BookStore
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Request From First Middleware\n");
                await next();
                await context.Response.WriteAsync("Response From First Middleware\n");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Request From Second Middleware\n");
                await next();
                await context.Response.WriteAsync("Response From Second Middleware\n");
            });
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Request From Third Middleware\n");
                await next();
                await context.Response.WriteAsync("Response From Third Middleware\n");
            });

            app.UseEndpoints(endPoints =>
            {
                endPoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello from App\n");
                });
            });

        }
    }
}
