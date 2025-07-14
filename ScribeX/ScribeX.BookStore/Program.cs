namespace ScribeX.BookStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //add services to DI container

            var app = builder.Build();

            //add http pipelines
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("request from first middleware");
                await next();
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("request from second middleware");
                await next();
            });

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
