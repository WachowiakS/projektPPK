using Microsoft.AspNetCore.Identity;
<<<<<<< HEAD
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore; 
using ProjektSklep.Data; 

// Tworzenie aplikacji z u¿yciem WebApplicationBuilder.
var builder = WebApplication.CreateBuilder(args);

// Pobranie ci¹gu po³¹czenia z konfiguracji aplikacji.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// Dodanie kontekstu bazy danych ApplicationDbContext z u¿yciem SQLite.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));

// Dodanie filtra wyj¹tków strony b³êdów dla stron deweloperskich.
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Konfiguracja domyœlnego uwierzytelniania z u¿yciem IdentityUser.
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Dodanie us³ug kontroli i widoków.
builder.Services.AddControllersWithViews();

// Budowanie aplikacji.
var app = builder.Build();

// Konfiguracja aplikacji w zale¿noœci od œrodowiska.

if (app.Environment.IsDevelopment())
{
    // U¿ycie punktu koñcowego migracji w trybie deweloperskim.
=======
=======
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
using Microsoft.EntityFrameworkCore;
using ProjektSklep.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
<<<<<<< HEAD
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
=======
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
    app.UseMigrationsEndPoint();
}
else
{
<<<<<<< HEAD
<<<<<<< HEAD
    // U¿ycie obs³ugi b³êdów dla b³êdu na stronie g³ównej.
    app.UseExceptionHandler("/Home/Error");

    // W³¹czenie zabezpieczeñ transportu (HSTS).
    app.UseHsts();
}

// Przekierowanie ¿¹dañ HTTP na HTTPS.
app.UseHttpsRedirection();

// Udostêpnianie plików statycznych.
app.UseStaticFiles();

// Konfiguracja trasowania ¿¹dañ.
app.UseRouting();

// Konfiguracja autoryzacji.
app.UseAuthorization();

// Mapowanie domyœlnej trasy dla kontrolera.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Mapowanie stron Razor.
app.MapRazorPages();


=======
=======
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
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
app.MapRazorPages();

<<<<<<< HEAD
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
=======
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
app.Run();