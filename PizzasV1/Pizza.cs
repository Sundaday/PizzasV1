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
        string name;
        float price;
        bool vegan;
        List<string> ingredients;
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
        public void Afficher()
        {
            string badgeVege = vegan ? " (V)" : "";
           
            string nameDisplay = NameDisplay(name);

            Console.WriteLine(nameDisplay + badgeVege + " - " + price + "€");
            Console.WriteLine(string.Join(", ", ingredients));
            Console.WriteLine();
        }
        #endregion

        private static string NameDisplay(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            string charMin = s.ToLower();
            string charMaj = s.ToUpper();

            string result = charMaj[0] + charMin[1..];
            return result;
        }
    }
}
