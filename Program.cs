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
    name: "Vintage",
    pattern: "/vintage",
    defaults: new { controller = "Home", action = "Vintage" }
);
app.MapControllerRoute(
    name: "Product",
    pattern: "/product",
    defaults: new { controller = "Home", action = "Product" }
);
app.MapControllerRoute(
    name: "Information",
    pattern: "/information",
    defaults: new { controller = "Home", action = "Information" }
);
app.MapControllerRoute(
    name: "Sale",
    pattern: "/sale",
    defaults: new { controller = "Home", action = "Sale" }
);
app.MapControllerRoute(
    name: "Cart",
    pattern: "/cart",
    defaults: new { controller = "Home", action = "Cart" }
);
app.MapControllerRoute(
    name: "Jersey",
    pattern: "/jersey",
    defaults: new { controller = "Home", action = "Jersey" }
);
app.MapControllerRoute(
    name: "Footwear",
    pattern: "/footwear",
    defaults: new { controller = "Home", action = "Footwear" }
);
app.MapControllerRoute(
    name: "Login",
    pattern: "/login",
    defaults: new { controller = "Account", action = "Login" }
);
app.MapControllerRoute(
    name: "Register",
    pattern: "/register",
    defaults: new { controller = "Account", action = "Register" }
);
app.MapControllerRoute(
    name: "ForgotPassword",
    pattern: "/forgotpassword",
    defaults: new { controller = "Account", action = "ForgotPassword" }
);
app.MapControllerRoute(
    name: "Products",
    pattern: "/products",
    defaults: new { controller = "Product", action = "Products" }
);
app.Run();  
