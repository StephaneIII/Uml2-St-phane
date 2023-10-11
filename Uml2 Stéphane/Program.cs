using Uml2_Stéphane;




void TestSetup()
{
    PizzaItem p1 = new PizzaItem("margarita", "tomat og ost",  75);
    PizzaItem p2 = new PizzaItem("peperoni", "peperoni tomat og ost",  95);
    PizzaItem p3 = new PizzaItem("pizza3", "toppings3",  105);
    PizzaItem p4 = new PizzaItem("pizza4", "toppings4", 105);

    PizzaRepository._pizza = new PizzaRepository._pizza();
    PizzaRepository._pizza.AddPizzaItem(p1);
    PizzaRepository._pizza.AddPizzaItem(p2);
    PizzaRepository._pizza.AddPizzaItem(p3);
    PizzaRepository._pizza.AddPizzaItem(p4);
}






































/*
string PizzaName = null;
string PizzaToppings = null;
double PizzaPrice = 0;


 void AddPizza()
{
    Console.WriteLine("indtast navnet på pizzaen");
    PizzaName = Console.ReadLine();
    if (!_pizza.ContainsKey(PizzaName))
    {
        Console.WriteLine($"hvilke ingredienser er der på {PizzaName}");
        PizzaToppings = Console.ReadLine();
        Console.WriteLine($"hvad er prisen på {PizzaName}");
        PizzaPrice = double.Parse(Console.ReadLine());
        menu.AddPizzaToMenu(new PizzaItem(PizzaName, PizzaToppings, PizzaPrice));
    }
}


string PizzaToRemove = null;
void DelPizza()
{
    Console.WriteLine("hvad er navnet på pizzaen du vil fjerne");
    PizzaToRemove = Console.ReadLine();
    if (_pizza.ContainsKey(PizzaToRemove))
    {
        menu.DelPizzaFromMenu(PizzaToRemove);
    }
    else Console.WriteLine("elementet du referrer til findes desværre ikke");
}
*/