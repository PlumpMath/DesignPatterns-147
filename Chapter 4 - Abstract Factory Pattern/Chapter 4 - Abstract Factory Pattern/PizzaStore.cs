using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4___Abstract_Factory_Pattern
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = null;
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        protected abstract Pizza CreatePizza(string type);
    }

    public class NewYorkPizzaStore : PizzaStore
    {

        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory factory = new NewYorkIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(factory) {Name = "New York Style Cheese Pizza"};
            }
            else if(type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(factory) { Name = "New York Style Pepperoni Pizza" };
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza(factory) { Name = "New York Style Veggie Pizza" };
            }
            return pizza;
        }
    }

    public class CaliforniaPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory factory = new CaliforniaIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(factory) { Name = "Cali Style Cheese Pizza" };
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(factory) { Name = "Cali Style Pepperoni Pizza" };
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza(factory) { Name = "Cali Style Veggie Pizza" };
            }
            return pizza;
        }
    }

    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory factory = new ChicagoPizzaFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(factory) { Name = "Chicago Style Cheese Pizza" };
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(factory) { Name = "Chicago Style Pepperoni Pizza" };
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza(factory) { Name = "Chicago Style Veggie Pizza" };
            }
            return pizza;
        }
    }
}
