# Restaurante Sabor Casero

Proyecto académico de ejemplo creado con **ASP.NET Core MVC y C#**, pensado para Visual Studio 2022. Es una maqueta informativa: no utiliza base de datos, autenticación ni pedidos.

## Requisitos
- Visual Studio 2022 actualizado (17.8 o superior).
- Carga de trabajo **ASP.NET y desarrollo web**.
- SDK de .NET 8.

## Abrir y ejecutar
1. Descarga el ZIP y extrae la carpeta `RestauranteSaborCasero` en una ubicación fácil de encontrar.
2. Abre Visual Studio 2022.
3. Selecciona **Archivo > Abrir > Proyecto o solución**.
4. Busca la carpeta extraída y abre `RestauranteSaborCasero.csproj`.
5. Espera a que Visual Studio restaure las dependencias.
6. En la barra superior selecciona el perfil `https` o `http`.
7. Presiona el botón verde de ejecutar o la tecla **F5**. Para ejecutar sin depuración, usa **Ctrl + F5**.

## Organización del proyecto
- `Models/Plato.cs`: clase que representa cada producto del menú.
- `Views/`: archivos `.cshtml` que forman las páginas que ve el visitante.
  - `Views/Home/Inicio.cshtml`: bienvenida.
  - `Views/Home/Menu.cshtml`: productos y precios.
  - `Views/Home/Nosotros.cshtml`: descripción del restaurante.
  - `Views/Home/Contacto.cshtml`: dirección, teléfono y horario.
  - `Views/Shared/_Layout.cshtml`: encabezado, navegación y pie compartidos.
- `Controllers/HomeController.cs`: recibe las rutas y selecciona qué vista mostrar. También crea la lista de objetos `Plato` y la envía a la vista del menú.
- `wwwroot/css/site.css`: colores, tarjetas y adaptación a pantallas pequeñas.
- `Program.cs`: registra MVC y configura las rutas y archivos estáticos.

## Comprobar la navegación
Desde la página de inicio, pulsa **Conocer nuestro menú**. Después prueba los enlaces Inicio, Menú, Nosotros y Contacto del encabezado. Cada enlace debe abrir su vista correspondiente.

## Personalizar
- Cambia nombres, descripciones y precios en la lista de `new Plato(...)` dentro de `HomeController.cs`.
- Cambia dirección, teléfono y horario en `Views/Home/Contacto.cshtml`.
- Modifica colores y estilos en `wwwroot/css/site.css`.

## Si aparece un error
- **No se reconoce .NET 8:** instala el SDK de .NET 8 y actualiza Visual Studio 2022.
- **No aparece ASP.NET Core:** abre Visual Studio Installer > Modificar y marca la carga de trabajo **ASP.NET y desarrollo web**.
- **No encuentra una vista:** comprueba que el archivo esté exactamente en `Views/Home/` y que el nombre coincida con la acción (`Menu.cshtml`, `Inicio.cshtml`, etc.).
- **No carga el CSS:** verifica que exista `wwwroot/css/site.css` y que `app.UseStaticFiles();` esté en `Program.cs`.
- **Errores después de copiar archivos:** en Visual Studio selecciona **Compilar > Limpiar solución** y luego **Compilar > Recompilar solución**.

Los datos de contacto y precios son ejemplos; reemplázalos por los que indique tu profesor si es necesario.
