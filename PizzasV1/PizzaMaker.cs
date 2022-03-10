using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasV1
{
    internal class PizzaMaker : Pizza
    {
        #region Constructor field
        public PizzaMaker() : base("Your own Pizza", 5, false, null)
        {
            ingredients = new List<string>();

            while (true)
            {
                Console.WriteLine("Please Enter Ingredients to make your own Pizza (PRESS ENTER to finish) : ");
                var ingredient = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ingredient))
                {
                    break;
                }
                ingredients.Add(ingredient);
            }
        }
        #endregion
    }
}
