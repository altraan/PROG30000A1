using Microsoft.EntityFrameworkCore;
using Assign1PROG30000.Models;
using Assign1PROG30000.Models.Enum;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FastEquipmentContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("FastEquipmentDb")));


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();