using Microsoft.AspNetCore.Mvc;
using RestauranteSaborCasero.Models;

namespace RestauranteSaborCasero.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult Menu()
        {
            // Datos de ejemplo. El modelo Plato se utiliza en esta acción
            // y se envía a la vista Menu.cshtml mediante View().
            var platos = new List<Plato>
            {
                new Plato { Nombre = "Hamburguesa casera", Categoria = "Hamburguesas", Descripcion = "Carne a la plancha, queso, vegetales y salsa de la casa.", Precio = 180m },
                new Plato { Nombre = "Hamburguesa clásica", Categoria = "Hamburguesas", Descripcion = "Carne, lechuga, tomate y aderezo tradicional.", Precio = 150m },
                new Plato { Nombre = "Pizza de pepperoni", Categoria = "Pizzas", Descripcion = "Salsa de tomate, queso mozzarella y pepperoni.", Precio = 280m },
                new Plato { Nombre = "Pizza vegetariana", Categoria = "Pizzas", Descripcion = "Vegetales frescos y queso mozzarella.", Precio = 260m },
                new Plato { Nombre = "Limonada natural", Categoria = "Bebidas", Descripcion = "Refrescante limonada preparada al momento.", Precio = 55m },
                new Plato { Nombre = "Jugo de naranja", Categoria = "Bebidas", Descripcion = "Jugo de naranja natural.", Precio = 60m },
                new Plato { Nombre = "Pastel de chocolate", Categoria = "Postres", Descripcion = "Porción de pastel suave con cobertura de chocolate.", Precio = 85m },
                new Plato { Nombre = "Flan casero", Categoria = "Postres", Descripcion = "Flan tradicional con caramelo.", Precio = 70m }
            };

            return View(platos);
        }

        public IActionResult Nosotros()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
