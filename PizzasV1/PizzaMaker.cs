using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasV1
{
    internal class PizzaMaker : Pizza
    {
        //Static variable
        static int nbOwnPizza = 0;

        #region Constructor field
        public PizzaMaker() : base("Your own Pizza", 10, false, null)
        {
            nbOwnPizza++;
            ingredients = new List<string>();
            name = "Own Pizza : " + nbOwnPizza;

            #region Main logic
            while (true)
            {
                //Main Logic string
                Console.Write("Please Enter Ingredients to make your Own Pizza : " + nbOwnPizza + " (PRESS ENTER to finish) : ");
                var ingredient = Console.ReadLine();

                #region Condition field
                //Encoder checker
                if (string.IsNullOrWhiteSpace(ingredient))
                {
                    break;
                }

                //Ingredient checker
                if (ingredients.Contains(ingredient))
                {
                    Console.WriteLine("ERROR : This ingredient is ready on your pizza");
                }
                else
                {
                    ingredients.Add(ingredient);
                    Console.WriteLine(String.Join(", ", ingredients));
                }
                #endregion

                #region Price setter
                //Set price by ingredients
                price = 7 + ingredients.Count * 1.5f;
                #endregion

                Console.WriteLine();
            }
            #endregion
        }
        #endregion
    }
}
