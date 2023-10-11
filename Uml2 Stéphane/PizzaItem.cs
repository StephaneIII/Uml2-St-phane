using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml2_Stéphane
{
    internal class PizzaItem
    {
        private string _PizzaName;
        private string _toppings;
        private double _PizzaPrice;
        public string PizzaName
        {
            get { return _PizzaName; }
            set { _PizzaName = value; }
        }
        public string Toppings
        {
            get { return _toppings; }
            set { _toppings = value; }
        }
        public double PizzaPrice
        {
            get { return _PizzaPrice; }
            set { _PizzaPrice = value; }
        }
        public PizzaItem(string pizzaName, string toppings, Double pizzaPrice)
        {
            PizzaName = pizzaName;
            Toppings = toppings;
            PizzaPrice = pizzaPrice;
        }
        public override string ToString()
        {
            return $"{PizzaName}\t{PizzaPrice}kr";
        }
    }
}
