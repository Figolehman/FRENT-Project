using Frent_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using FRENT_Project.Models;
using Frent_Project.DataAccess.Repository.Irepository;
using Frent_Project.DataAccess.Repository;

var builder = WebApplication.CreateBuilder(args);
//var connectionString = builder.Configuration.GetConnectionString("FrentDbContextConnection") ?? throw new InvalidOperationException("Connection string 'FrentDbContextConnection' not found.");

//builder.Services.AddDbContext<FrentDbContext>(options =>
//    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>().AddDefaultTokenProviders()
    .AddEntityFrameworkStores<FrentDbContext>();

// Add services to the container.
builder.Services.AddIdentityCore<User>().AddEntityFrameworkStores<FrentDbContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<FrentDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));
//builder.Services.
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
