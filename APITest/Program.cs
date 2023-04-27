using APITest.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddScoped<IBreakfastService, BreakfastService>();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error"); //Adds Try/Catch Middleware, defaults request to /error route on exception

    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();
}
