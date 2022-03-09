using System;
using System.Collections.Generic;
using System.Text;

namespace PizzasV1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region UTF8
            //Display "€" char
            Console.OutputEncoding = Encoding.UTF8;
            #endregion

            var listePizzas = new List<Pizza>()
            {
                new Pizza("Royal", 11.3f, false, new List<string>{"Tomato","mushroom","cream","meat","cheese"}),
                new Pizza("Flamme", 13.5f, false, new List<string>{"cream","porc","oignon" }),
                new Pizza("MontaGnarde", 14.3f, false, new List<string>{"Potato","redMeat","cream","cheddar","cheese"}),
                new Pizza("KeBab", 11.5f, false, new List<string>{"Tomato","mushroom","cream","meat","cheese"}),
                new Pizza("AnchoiE", 10.5f, false, new List<string>{"Tomato","mushroom","cream","meat","cheese"}),
                new Pizza("FrOmage", 7.5f, true, new List<string>{"Tomato","cheddar","cream","cheese"}),
                new Pizza("vegie", 12.5f, true, new List<string>{"Tomato","mushroom","banana"})
            };

            foreach(var pizza in listePizzas)
            {
                pizza.Afficher();
            }
            

            
            

        }
    }
}
