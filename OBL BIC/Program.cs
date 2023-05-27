using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using OBL.BIC.Data;
using System.Configuration;
using Microsoft.AspNetCore.Mvc;
using OBL.BIC.Models;
using Microsoft.AspNetCore.Authentication;
using OBL.BIC.Model;
using OBL.CSRM.IRepository;
using OBL.CSRM.Repository;
using OBL.BIC.SignalR;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("TestCon");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

//var connectionString = builder.Configuration.GetConnectionString("TestCon");
builder.Services.AddDbContext<TestContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddSignalR();

builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".AdventureWorks.Session";
    //options.IdleTimeout = TimeSpan.FromMinutes(5);
    options.IdleTimeout = TimeSpan.FromMinutes(5);
    options.Cookie.IsEssential = true;
    

});
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IRepositoryDependency, RepositoryDependency>();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).
    AddCookie(options =>
    { 
        options.LoginPath = "/login";
        options.Events = new CookieAuthenticationEvents()
        {
            OnSigningIn = async context =>
            {
                await Task.CompletedTask;
            },
            OnSignedIn = async context =>
            {
                await Task.CompletedTask;
            },
            OnValidatePrincipal = async context =>
            {
                await Task.CompletedTask;
            }
        };
        options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
    });

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
app.UseSession();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<NotificationHub>("/notificationHub"); // Change "NotificationHub" to your desired hub class name
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
