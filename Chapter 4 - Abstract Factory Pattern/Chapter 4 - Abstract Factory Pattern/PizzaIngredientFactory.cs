using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4___Abstract_Factory_Pattern
{
    //Factory Interface
    public interface PizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Pepperoni CreatePepperoni();
        Veggies[] CreateVeggies();
        Clam CreateClam();
    }

    //Implementing Region Specific Receipes.
    public class NewYorkIngredientFactory : PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }
        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }
        public Cheese CreateCheese()
        {
            return new MozerallaCheese();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] vegtables = {new Onion(), new Sweetcorn()};
            return vegtables;
        }

        public Clam CreateClam()
        {
            return new FreshClams();
        }
    }

    public class CaliforniaIngredientFactory : PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }
        public Sauce CreateSauce()
        {
            return new PlumTomato();
        }
        public Cheese CreateCheese()
        {
            return new CheddarCheese();
        }

        public Pepperoni CreatePepperoni()
        {
            return new GroundPepperoni();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] vegtables = { new Pineapple(), new Sweetcorn() };
            return vegtables;
        }

        public Clam CreateClam()
        {
            return new FrozenClam();
        }
    }

    public class ChicagoPizzaFactory : PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }
        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }
        public Cheese CreateCheese()
        {
            return new CheddarCheese();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] vegtables = { new Pineapple(), new Sweetcorn(), new Onion()};
            return vegtables;
        }

        public Clam CreateClam()
        {
            return new FrozenClam();
        }
    }
}
