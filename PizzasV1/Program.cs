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

            #region Menu GetPizzaByConstructor()
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

            #region GenerateJson()
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
            #endregion

            #region GetPizzaByFileName()
            static void GetPizzaByFileName(string fileName)
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
            }
            #endregion

            #region GetPizzaFromUrl()
            static void GetPizzaFromUrl(string url) { 
            Console.WriteLine("Connexion...");
                try
                {
                    var webClient = new WebClient();
                    webClient.DownloadFile(url,"url.json");
                    Console.WriteLine("SUCCESS...DOWNLOAD 100%");
                }
                catch (WebException ex)
                {
                    if (ex.Response != null)
                    {
                        var statusCode = ((HttpWebResponse)ex.Response).StatusCode;

                        if (statusCode == HttpStatusCode.NotFound)
                        {
                            Console.WriteLine("NETWORK ERROR : Non trouvé");
                        }
                        else
                        {
                            Console.WriteLine("NETWORK ERROR : " + statusCode);
                        }
                    }
                    else
                    {
                        Console.WriteLine("NETWORK ERROR : " + ex.Message);
                    }
                }
            }
            #endregion

            #region Deserialisation
            static List<Pizza> Deserialisation(string file)
            {
                List<Pizza> pizzas = null;

                try
                {
                    pizzas = JsonConvert.DeserializeObject<List<Pizza>>(file);
                    Console.WriteLine("SUCCESS...Deserialisation complete");
                    Console.WriteLine();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("JSON ERROR...Deserialisation Fail " + ex.Message);
                    Console.WriteLine();
                    return null;
                }

                return pizzas;
            }
            #endregion

            #region Main Call function
            string url = "https://codeavecjonathan.com/res/pizzas2.json";

            //string file = File.ReadAllText("urlv2.json");
            string file = File.ReadAllText("pizzaJson.json");

            //GetPizzaFromUrl(url);
            // pizzas = GetPizzaByConstructor();
            //var pizzas = GetPizzaByFileName(fileName);
            var pizzas = Deserialisation(file);
            //GenerateJson(pizzas, fileName);
            #endregion

            #region Query Linq OrderBy()
            //Pizza pizzaPriceMax = null;
            //Pizza pizzaPriceMin = null;

            //pizzaPriceMin = pizzas[0];
            //pizzaPriceMax = pizzas[0];

            //foreach (var pizza in pizzas)
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

            ////Display vegan only
            ////listPizzas = listPizzas.Where(p => p.vegan).ToList();

            ////Sort by price && return ingredient "tomato"
            //pizzas = pizzas.OrderByDescending(e => e.price).ToList();
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
