using lagosdotnetusertalk.Client.ViewEngines;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

//configure route 
builder.Services.Configure<RazorViewEngineOptions>(options => {
    options.ViewLocationExpanders.Add(new CustomViewLocationExpander());
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "Client/wwwroot")),
    RequestPath= ""
});

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Welcome}/{action=Index}/{id?}");

app.Run();
