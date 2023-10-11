using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml2_Stéphane
{
    internal class PizzaRepository
    {
        private Dictionary<string, PizzaItem> _pizza;

        public PizzaRepository()
        {
            _pizza = new Dictionary<string, PizzaItem>();
        }



        public void AddPizzaToMenu(PizzaItem aPizza)
        {
            if (!_pizza.ContainsKey(aPizza.PizzaName))
            {
                _pizza.Add(aPizza.PizzaName, aPizza);
            }
        }



        public void DelPizzaFromMenu(string PizzaToRemove)
        {
            _pizza.Remove(PizzaToRemove);
        }



        public void ShowMenu()
        {
            foreach (var p in _pizza)
            {
                Console.WriteLine(p);
            }
        }



        /*
        public void UpdatePizzaInMenu(string PizzaToUpdate)
        {
            if (_pizza.ContainsKey(PizzaToUpdate)) {
                DelPizzaFromMenu(PizzaToUpdate);
                PizzaRepository.AddPizza();
            }
        }
        */

        //The system should be able to search for a Pizza based on relevant and given criteria (Pizza no).

    }
}
