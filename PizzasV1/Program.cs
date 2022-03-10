using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzasV1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region UTF8
            //Encode "€" char
            Console.OutputEncoding = Encoding.UTF8;
            #endregion

            #region Menu
            var listPizzas = new List<Pizza>()
            {
                new Pizza("Royal", 11.3f, false, new List<string>{"Tomato","mushroom","cream","meat","cheese"}),
                new Pizza("Flamme", 13.5f, false, new List<string>{"cream","porc","oignon" }),
                new Pizza("MontaGnarde", 14.3f, false, new List<string>{"Potato","redMeat","cream","cheddar","cheese"}),
                new Pizza("KeBab", 11.5f, false, new List<string>{"Tomato","mushroom","cream","porc","cheese"}),
                new Pizza("AnchoiE", 10.5f, false, new List<string>{"Tomato","mushroom","cream","Fish","cheese"}),
                new Pizza("FrOmage", 7.5f, true, new List<string>{"Tomato","cheddar","cream","cheese"}),
                new Pizza("veggie", 12.5f, true, new List<string>{"tomato","mushroom","banana"}),
                new PizzaMaker(),
                new PizzaMaker()
            };
            #endregion

            //Display vegan only
            //listPizzas = listPizzas.Where(p => p.vegan).ToList();

            //Sort by price && return ingredient "tomato"
            listPizzas = listPizzas.OrderByDescending(e => e.price).ToList();

            #region Display
            //Display all pizzas
            foreach (var pizzas in listPizzas)
            {
                pizzas.Display();
            }
            #endregion

            #region Show Max & Min price
            //Pizza pizzaPriceMax = null;
            //Pizza pizzaPriceMin = null;

            //pizzaPriceMin = listPizzas[0];
            //pizzaPriceMax = listPizzas[0];

            //foreach (var pizza in listPizzas)
            //{
            //    if (pizza.price < pizzaPriceMin.price)
            //    {
            //        pizzaPriceMin = pizza;
            //    }
            //    if (pizza.price > pizzaPriceMax.price)
            //    {
            //        pizzaPriceMax = pizza;
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("la pizza la plus chere est : ");
            //pizzaPriceMax.Display();
            //Console.WriteLine();
            //Console.WriteLine("la pizza la moins chere est : ");
            //pizzaPriceMin.Display();
            #endregion
        }
    }
}
