using IndustrialSafety.Data;
using IndustrialSafetyDataSeed;
using IndustrialSafetyDataSeed.DTO.Commons;
using IndustrialSafetyLib.Commons;
using IndustrialSafetyLib.CoreEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);
var connectionString = "";
if (builder.Environment.IsDevelopment())
    connectionString = builder.Configuration.GetConnectionString("DevelopmentConnection") ?? throw new InvalidOperationException("Connection string 'DevelopmentConnection' not found.");
else
    connectionString =  builder.Configuration.GetConnectionString("ProductionConnection") ?? throw new InvalidOperationException("Connection string 'ProductionConnection' not found.");


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<User>(
    options =>
    {
        options.SignIn.RequireConfirmedAccount = true;
    }
    )
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages(options => options.Conventions.AuthorizeFolder("/"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
#if !DESKTOP
    app.Services.GetService<ApplicationDbContext>()!.Database.Migrate();
#endif
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
