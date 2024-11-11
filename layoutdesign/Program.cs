using layoutdesign.Data;
using layoutdesign.Helper;
using layoutdesign.Interfaces;
using layoutdesign.Models;
using layoutdesign.Repository;
using layoutdesign.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<LoggingService>(); // Register LoggingService
//builder.Services.AddScoped<Icategory, Categoryrepo>(); // Register Categoryrepo
builder.Services.AddScoped<Categoryrepo>(); // Register Productrepo
builder.Services.AddScoped<Brandrepo>(); // Register Brandrepo
builder.Services.AddScoped<Accountrepo>();
builder.Services.AddScoped<UpdatePlaceHolders>();

builder.Services.AddDbContext<ApplicationDBContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddIdentity<Appuser, IdentityRole>(
    option =>
    {
        option.Password.RequiredUniqueChars = 1;
        option.Password.RequireDigit = true;
        option.Password.RequireLowercase = true;
        option.Password.RequireNonAlphanumeric = false;
        option.Password.RequiredLength = 8;
        option.Password.RequireUppercase = true;

        option.SignIn.RequireConfirmedEmail = true;
    }

    )
    .AddEntityFrameworkStores<ApplicationDBContext>().AddDefaultTokenProviders();



// Register HttpClient
builder.Services.AddHttpClient(); // <--- This registers IHttpClientFactory
builder.Services.AddScoped<ApiService>();
builder.Services.AddHttpContextAccessor();


// Add session services
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromDays(1); // Set session timeout to 1 day
    options.Cookie.HttpOnly = true; // Make the cookie accessible only via HTTP
    options.Cookie.IsEssential = true; // Make the session cookie essential
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Enable session before the authorization middleware
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
