using Microsoft.EntityFrameworkCore;
using Assign1PROG30000.Models;
using Assign1PROG30000.Models.Enum;
using Assign1PROG30000.Models.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add Entity Framework
builder.Services.AddDbContext<FastEquipmentContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("FastEquipmentDb")));

// Register repositories
builder.Services.AddScoped<IEquipmentRepository, EquipmentRepository>();
builder.Services.AddScoped<IRequestRepository, RequestRepository>();

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