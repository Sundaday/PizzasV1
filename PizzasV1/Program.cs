using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
            static List<Pizza> GetPizzaByConstructor()
            {

                var pizzas = new List<Pizza>()
                {
                    new Pizza("Royal", 11.3f, false, new List<string>{"Tomato","mushroom","cream","meat","cheese"}),
                    new Pizza("Flamme", 13.5f, false, new List<string>{"cream","porc","oignon" }),
                    new Pizza("MontaGnarde", 14.3f, false, new List<string>{"Potato","redMeat","cream","cheddar","cheese"}),
                    new Pizza("KeBab", 11.5f, false, new List<string>{"Tomato","mushroom","cream","porc","cheese"}),
                    new Pizza("AnchoiE", 10.5f, false, new List<string>{"Tomato","mushroom","cream","Fish","cheese"}),
                    new Pizza("FrOmage", 7.5f, true, new List<string>{"Tomato","cheddar","cream","cheese"}),
                    new Pizza("veggie", 12.5f, true, new List<string>{"tomato","mushroom","banana"}),
                    //new PizzaMaker(),
                    //new PizzaMaker()
                };
                return pizzas;
            }  
            #endregion

            var fileName = "pizzaJson.json";

            static void GenerateJson(List<Pizza> pizzas, string filename)
            {
                var json = JsonConvert.SerializeObject(pizzas);
                try
                {
                    File.WriteAllText("pizzaJson.json", json);
                    Console.WriteLine("SUCCESS ... DATA CREATED");
                }
                catch
                {
                    Console.WriteLine("ERROR DURING JSON CREATION");
                }
            }


            List<Pizza>GetPizzaByFileName(string fileName)
            {
                string json = null;

                try
                {
                    json = File.ReadAllText(fileName);
                    Console.WriteLine("SUCCESS : " + fileName + " Found");
                    Console.WriteLine();
                }
                catch 
                {
                    Console.WriteLine("ERROR ... File : " + fileName + " NOT FOUND");
                }

                List<Pizza> pizzas = null;

                try
                {
                    pizzas = JsonConvert.DeserializeObject<List<Pizza>>(json);
                }
                catch
                {
                    Console.WriteLine("JSON ERROR : ");
                    return null;
                }
                return pizzas;
            }

            //var pizzas = GetPizzaByConstructor();
            //var pizzas = GetPizzaByFileName(fileName);
            //GenerateJson(pizzas, fileName);

            #region Query Linq
            #region Display Max/Min price
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

            //Display vegan only
            //listPizzas = listPizzas.Where(p => p.vegan).ToList();

            //Sort by price && return ingredient "tomato"
            pizzas = pizzas.OrderByDescending(e => e.price).ToList();
            #endregion
            
            #region Display
            //Display all pizzas
            foreach (Pizza pizza in pizzas)
            {
                pizza.Display();
                //Console.WriteLine(pizza);
            }
            #endregion
        }
    }
}
