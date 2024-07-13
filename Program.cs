var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
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
app.MapControllerRoute(
    name: "Vintageteeshop",
    pattern: "/vintageteeshop",
    defaults: new { controller = "Home", action = "Vintageteeshop" }
);
app.MapControllerRoute(
    name: "Reword",
    pattern: "/reword",
    defaults: new { controller = "Home", action = "Reword" }
);
app.MapControllerRoute(
    name: "Information",
    pattern: "/information",
    defaults: new { controller = "Home", action = "Information" }
);
app.MapControllerRoute(
    name: "Contact",
    pattern: "/contact",
    defaults: new { controller = "Home", action = "Contact" }
);
app.MapControllerRoute(
    name: "Cart",
    pattern: "/cart",
    defaults: new { controller = "Home", action = "Cart" }
);
app.Run();
