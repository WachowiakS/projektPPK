using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore; 
using ProjektSklep.Data; 

// Tworzenie aplikacji z u�yciem WebApplicationBuilder.
var builder = WebApplication.CreateBuilder(args);

// Pobranie ci�gu po��czenia z konfiguracji aplikacji.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// Dodanie kontekstu bazy danych ApplicationDbContext z u�yciem SQLite.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));

// Dodanie filtra wyj�tk�w strony b��d�w dla stron deweloperskich.
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Konfiguracja domy�lnego uwierzytelniania z u�yciem IdentityUser.
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Dodanie us�ug kontroli i widok�w.
builder.Services.AddControllersWithViews();

// Budowanie aplikacji.
var app = builder.Build();

// Konfiguracja aplikacji w zale�no�ci od �rodowiska.

if (app.Environment.IsDevelopment())
{
    // U�ycie punktu ko�cowego migracji w trybie deweloperskim.
    app.UseMigrationsEndPoint();
}
else
{
    // U�ycie obs�ugi b��d�w dla b��du na stronie g��wnej.
    app.UseExceptionHandler("/Home/Error");

    // W��czenie zabezpiecze� transportu (HSTS).
    app.UseHsts();
}

// Przekierowanie ��da� HTTP na HTTPS.
app.UseHttpsRedirection();

// Udost�pnianie plik�w statycznych.
app.UseStaticFiles();

// Konfiguracja trasowania ��da�.
app.UseRouting();

// Konfiguracja autoryzacji.
app.UseAuthorization();

// Mapowanie domy�lnej trasy dla kontrolera.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Mapowanie stron Razor.
app.MapRazorPages();


app.Run();