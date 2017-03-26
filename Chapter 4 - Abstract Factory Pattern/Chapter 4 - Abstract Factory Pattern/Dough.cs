using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4___Abstract_Factory_Pattern
{
    //Dough
    public interface Dough
    {
        string ToString();
    }

    public class ThickCrustDough : Dough
    {
        public string ToString()
        {
            return "Thick Crust Dough";
        }
    }
    public class ThinCrustDough : Dough
    {
        public string ToString()
        {
            return "Thin Crust Dough";
        }
    }

    //Sauce
    public interface Sauce
    {
        string ToString();
    }
    public class MarinaraSauce : Sauce
    {
        public string ToString()
        {
            return "Marinara Sauce";
        }
    }

    public class PlumTomato : Sauce
    {
        public string ToString()
        {
            return "Plum Tomato Sauce";
        }
    }

    //Cheese
    public interface Cheese
    {
        string ToString();
    }
    public class MozerallaCheese : Cheese
    {
        public string ToString()
        {
            return "Mozeralla Cheese";
        }
    }
    public class CheddarCheese : Cheese
    {
        public string ToString()
        {
            return "Cheddar Cheese";
        }
    }

    //Pepperoni
    public interface Pepperoni
    {
        string ToString();
    }
    public class SlicedPepperoni : Pepperoni
    {
        public string ToString()
        {
            return "Sliced Pepperoni";
        }
    }
    public class GroundPepperoni : Pepperoni
    {
        public string ToString()
        {
            return "Ground Pepperoni";
        }
    }

    //Veggies
    public interface Veggies
    {
        string ToString();
    }
    public class Onion : Veggies
    {
        public string ToString()
        {
            return "Onion";
        }
    }
    public class Sweetcorn : Veggies
    {
        public string ToString()
        {
            return "Sweetcorn";
        }
    }
    public class Pineapple : Veggies
    {
        public string ToString()
        {
            return "Pineapple";
        }
    }

    //Clams
    public interface Clam
    {
        string ToString();
    }

    public class FreshClams : Clam
    {
        public string ToString()
        {
            return "Fresh Clams";
        }
    }

    public class FrozenClam : Clam
    {
        public string ToString()
        {
            return "Frozen Clam";
        }
    }
}
