namespace Chapter_4___FactoryPattern
{
    public class PizzaStore
    {
        PizzaFactory Factory;

        public PizzaStore(PizzaFactory factory)
        {
            Factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = Factory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
