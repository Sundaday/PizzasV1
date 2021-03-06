using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasV1
{
    internal class Pizza
    {
        #region Variable field
        public string name { get; init; }
        public float price { get; init; }
        public bool vegan { get; init; }
        public List<string> ingredients { get; init; }
        #endregion

        #region Constructor field
        public Pizza() { }
        public Pizza(string name, float price, bool vegan, List<string> ingredients)
        {
            this.name = name;
            this.price = price;
            this.vegan = vegan;
            this.ingredients = ingredients;
        }
        #endregion

        #region Function field
        public void Display()
        {
            //if smart syntax
            string badgeVege = vegan ? " (V)" : ""; 
           
            string nameDisplay = VarDisplay(name);

            //Display ingredients
            //var ingredientDisplay = new List<string>();
            //foreach(string ingredient in ingredients)
            //{
            //    ingredientDisplay.Add(VarDisplay(ingredient));
            //}

            //Display ingredients
            var ingredientDisplay = ingredients.Select(i => VarDisplay(i)).ToList();

            Console.WriteLine(nameDisplay + badgeVege + " - " + price + "€");
            Console.WriteLine(string.Join(", ", ingredientDisplay));
            Console.WriteLine();
        }

        //Search ingredients by occurences
        public bool ReturnIngredient(string ingredient)
        {
            return ingredients.Where(i => i.ToLower().Contains(ingredient)).ToList().Count > 0;
        }
        #endregion

        #region Static Function field
        private static string VarDisplay(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            string charMin = s.ToLower();
            string charMaj = s.ToUpper();

            string result = charMaj[0] + charMin[1..];//[1..] => alternative to SubString(1) !!

            return result;
        }
        #endregion
    }
}
