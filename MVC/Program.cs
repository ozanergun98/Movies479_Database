using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

#region IoC (Inversion of Control) Container

builder.Services.AddDbContext<Db>(options => options.UseMySQL("server = 127.0.0.1; database = test; user id = root; password = ;"));

#endregion

builder.Services.AddControllersWithViews();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
