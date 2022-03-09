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
                new Pizza("Royal", 11.3f, false),
                new Pizza("Flamme", 13.5f, false),
                new Pizza("siciLienne", 12.7f, false),
                new Pizza("MontaGnarde", 14.3f, false),
                new Pizza("KeBab", 11.5f, false),
                new Pizza("AnchoiE", 10.5f, false),
                new Pizza("FrOmage", 7.5f, true),
                new Pizza("vegie", 12.5f, true)
            };

            foreach(var pizza in listePizzas)
            {
                pizza.Afficher();
            }
            

            
            

        }
    }
}
