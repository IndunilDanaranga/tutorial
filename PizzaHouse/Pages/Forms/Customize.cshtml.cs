using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaHouse.Pages.Forms
{
    public class CustomizeModel : PageModel
    {
        [BindProperty]
        public Model.PizzaModel Pizzas { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            PizzaPrice = Pizzas.BasePrice;
            if (Pizzas.Tomato_Sauce) PizzaPrice = PizzaPrice + 2;
            if (Pizzas.Cheese) PizzaPrice = PizzaPrice + 2;
            if (Pizzas.Peperoni) PizzaPrice = PizzaPrice + 2;
            if (Pizzas.Mushroom) PizzaPrice = PizzaPrice + 2;
            if (Pizzas.Tuna) PizzaPrice = PizzaPrice + 2;
            if (Pizzas.Pineapple) PizzaPrice = PizzaPrice + 2;
            if (Pizzas.Ham) PizzaPrice = PizzaPrice + 2;
            if (Pizzas.Beef) PizzaPrice = PizzaPrice + 2;
            return RedirectToPage("/Checkout/Thankyou", new { Pizzas.PizzaName, PizzaPrice });
        }
    }
}
