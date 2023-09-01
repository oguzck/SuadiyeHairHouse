var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddDataAnnotationsLocalization();

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
    name: "AboutUs",
    pattern: "hakkimizda",
    defaults: new { controller = "Home", action = "About" });

app.MapControllerRoute(
    name: "ContactUs",
    pattern: "iletisim",
    defaults: new { controller = "Home", action = "Contact" });

app.MapControllerRoute(
    name: "OurServices",
    pattern: "hizmetlerimiz",
    defaults: new { controller = "Home", action = "Services" });

app.MapControllerRoute(
    name: "FreqAskedQues",
    pattern: "sikca-sorulan-sorular",
    defaults: new { controller = "Home", action = "FrequentlyAskedQuestions" });

app.MapControllerRoute(
    name: "BeforeAfter",
    pattern: "�ncesi-sonrasi",
    defaults: new { controller = "Home", action = "BeforeAndAfter" });


// ... add more custom routes as needed ...

// Keep the default route after all your custom routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
