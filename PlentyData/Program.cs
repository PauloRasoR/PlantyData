using PlentyData.Data;
using Microsoft.EntityFrameworkCore;
using PlentyData.Services;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PlentyDataContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("PlentyDataContext"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql"), builder =>
        builder.MigrationsAssembly("PlentyData")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ProdutoService>();

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
    
    app.UseAuthorization();
    
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    
    app.Run();
