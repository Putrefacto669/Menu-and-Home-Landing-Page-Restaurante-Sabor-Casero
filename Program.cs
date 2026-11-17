var builder = WebApplication.CreateBuilder(args);

// Registrar los servicios de MVC (controladores y vistas).
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurar el manejo de errores y los archivos estáticos.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Página inicial: HomeController, acción Inicio.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Inicio}/{id?}");

app.Run();
