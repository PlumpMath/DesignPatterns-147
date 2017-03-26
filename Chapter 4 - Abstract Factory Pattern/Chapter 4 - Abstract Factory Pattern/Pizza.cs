using System;

namespace Chapter_4___Abstract_Factory_Pattern
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected Dough Dough;
        protected Sauce Sauce;
        protected Cheese Cheese;
        protected Pepperoni Pepperoni;
        protected Veggies[] Veggies;
        protected Clam Clam;

        //To be implemented by Child Clasess (Each Pizza Type)
        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Baking Pizza @ 250c for 25 Minutes.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting Pizza into diagonal slices.");
        }

        public void Box()
        {
            Console.WriteLine("Placing Pizza in Official Pizza Store Box. \n");
        }
    }

    public class CheesePizza : Pizza
    {
        private PizzaIngredientFactory pizzaIngredientFactory;

        public CheesePizza(PizzaIngredientFactory factory)
        {
            pizzaIngredientFactory = factory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSauce();
            Cheese = pizzaIngredientFactory.CreateCheese();
            Console.WriteLine("Ingredients: Dough: {0} - Sauce: {1} - Cheese: {2}", Dough.ToString(), Sauce.ToString(), Cheese.ToString());
        }
    }

    public class PepperoniPizza : Pizza
    {
        private PizzaIngredientFactory pizzaIngredientFactory;

        public PepperoniPizza(PizzaIngredientFactory factory)
        {
            pizzaIngredientFactory = factory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSauce();
            Cheese = pizzaIngredientFactory.CreateCheese();
            Pepperoni = pizzaIngredientFactory.CreatePepperoni();
            Console.WriteLine("Ingredients: Dough: {0} - Sauce: {1} - Cheese: {2} - Pepperoni: {3}", Dough.ToString(), Sauce.ToString(), Cheese.ToString(), Pepperoni.ToString());
        }
    }

    public class VeggiePizza : Pizza
    {
        private PizzaIngredientFactory pizzaIngredientFactory;

        public VeggiePizza(PizzaIngredientFactory factory)
        {
            pizzaIngredientFactory = factory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSauce();
            Cheese = pizzaIngredientFactory.CreateCheese();
            Veggies = pizzaIngredientFactory.CreateVeggies();
            Console.WriteLine("Ingredients: Dough: {0} - Sauce: {1} - Cheese: {2}", Dough.ToString(), Sauce.ToString(),
                Cheese.ToString());
            Console.WriteLine("Additional Vegtables: ");
            foreach (Veggies vegtable in Veggies)
            {
                Console.WriteLine(vegtable.ToString());
            }
        }

        public class ClamPizza : Pizza
        {
            private PizzaIngredientFactory pizzaIngredientFactory;

            public ClamPizza(PizzaIngredientFactory factory)
            {
                pizzaIngredientFactory = factory;
            }

            public override void Prepare()
            {
                Console.WriteLine("Preparing {0}", Name);
                Dough = pizzaIngredientFactory.CreateDough();
                Sauce = pizzaIngredientFactory.CreateSauce();
                Cheese = pizzaIngredientFactory.CreateCheese();
                Veggies = pizzaIngredientFactory.CreateVeggies();
                Clam = pizzaIngredientFactory.CreateClam();
                Console.WriteLine("Ingredients: Dough: {0} - Sauce: {1} - Cheese: {2} - Clam: {3}", Dough.ToString(),Sauce.ToString(), Cheese.ToString(), Clam.ToString());

            }
        }
    }
}