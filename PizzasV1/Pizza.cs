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
        #endregion

        #region Constructor field
        public Pizza() { }
        public Pizza(string name, float price, bool vegan)
        {
            this.name = name;
            this.price = price;
            this.vegan = vegan;
        }
        #endregion

        #region Function field
        public void Afficher()
        {
            string badgeVege = vegan ? " (V)" : "";
           
            string nameDisplay = NameDisplay(name);

            Console.WriteLine(nameDisplay + badgeVege + " - " + price + "€");
        }
        #endregion

        private static string NameDisplay(string s)
        {
            string charMin = s.ToLower();
            string charMaj = s.ToUpper();

            string result = charMaj[0] + charMin[1..];
            return result;
        }
    }
}
