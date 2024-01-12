using App.Middlewares;
using Microsoft.EntityFrameworkCore;
using AppContext = App.Context.AppContext;

var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
/*if (string.IsNullOrWhiteSpace(connectionString))
    throw new ApplicationException("Connection string was not supplied");*/

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppContext>(optionsBuilder =>
    optionsBuilder.UseNpgsql(connectionString));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseMiddleware<RequestMiddleware>();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();