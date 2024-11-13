using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SA_Outreach_Website.Clients;
using SA_Outreach_Website.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                       ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//        .AddRoles<IdentityRole>() // Enable roles
//        .AddEntityFrameworkStores<ApplicationDbContext>();


// Register PaypalClient as a dependency so it's available in controllers
// builder.Services.AddSingleton<PaypalClient>();

// Add services to the container.
builder.Services.AddControllersWithViews();
// Register the PaypalClient as a singleton service
// Add services to the container.
builder.Services.AddSingleton(x =>
    new PaypalClient(
        builder.Configuration["PayPalOptions:ClientId"],
        builder.Configuration["PayPalOptions:ClientSecret"],
        builder.Configuration["PayPalOptions:Mode"]
    )
);

var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseMigrationsEndPoint();
//}
//else
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// static async Task CreateAdminRole(IServiceProvider serviceProvider)
//{
//    var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
//    var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

//    // Create "Admin" role if it doesn't exist
//    if (!await roleManager.RoleExistsAsync("Admin"))
//    {
//        await roleManager.CreateAsync(new IdentityRole("Admin"));
//    }

//    // Create an admin user
//    var adminEmail = "admin@example.com";
//    var adminPassword = "Admin@123";

//    var adminUser = await userManager.FindByEmailAsync(adminEmail);
//    if (adminUser == null)
//    {
//        adminUser = new IdentityUser { UserName = adminEmail, Email = adminEmail };
//        await userManager.CreateAsync(adminUser, adminPassword);
//        await userManager.AddToRoleAsync(adminUser, "Admin");
//    }
//}

//using (var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;
//    await CreateAdminRole(services);
//}

//// Add Identity
//builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
//    .AddEntityFrameworkStores<ApplicationDbContext>()
//    .AddDefaultTokenProviders();

// Add authentication cookies
//builder.Services.ConfigureApplicationCookie(options =>
//{
//    options.LoginPath = "/Identity/Account/Login";
//    options.LogoutPath = "/Identity/Account/Logout";
//});

// Add controllers with views
//builder.Services.AddControllersWithViews();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Add a custom route for the "Donate" action (optional if needed)
app.MapControllerRoute(
    name: "donate",
    pattern: "Donate",
    defaults: new { controller = "Paypal", action = "Donate" });

// Default route configuration to handle all other actions like AboutUs
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Enable Razor Pages
app.MapRazorPages();

app.Run();

