using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasV1
{
    internal class PizzaMaker : Pizza
    {
        static int nbOwnPizza = 0;
        #region Constructor field
        public PizzaMaker() : base("Your own Pizza", 10, false, null)
        {
            nbOwnPizza++;
            ingredients = new List<string>();
            name = "Own Pizza : " + nbOwnPizza;

            while (true)
            {
                #region Main logic
                Console.Write("Please Enter Ingredients to make your Own Pizza : " + nbOwnPizza + " (PRESS ENTER to finish) : ");
                var ingredient = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ingredient))
                {
                    break;
                }
                #endregion

                #region Condition field
                //Ingredient checker
                if (ingredients.Contains(ingredient))
                {
                    Console.WriteLine("ERROR : This ingredient is allready on your pizza");
                }
                else
                {
                    ingredients.Add(ingredient);
                    Console.WriteLine(String.Join(", ", ingredients));
                }
                #endregion

                price = 10 + ingredients.Count * 1.5f;
                Console.WriteLine();
            }
        }
        #endregion
    }
}
