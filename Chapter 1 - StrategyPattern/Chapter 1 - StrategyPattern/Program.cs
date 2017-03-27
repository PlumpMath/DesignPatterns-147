using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1___StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 1 - Strategy Pattern:");

            //A Normal Duck Object
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.Swim();

            //Changing Mallard Duck @ Runtime.
            Console.WriteLine("Changing Mallard Ducks Behvaior @ Runtime!");
            mallardDuck.SetFlyBehavior(new RocketPowered());
            mallardDuck.SetQuackBehavior(new BurpQuack());
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.Swim();


            //Decoy Duck
            Console.WriteLine("Decoy Duck with Decoy Duck Behavior!");
            DecoyDuck decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.PerformFly();
            decoyDuck.PerformQuack();
            decoyDuck.Swim();

            //Astronaut Duck
            Console.WriteLine("Astronaut Duck with Upgraded Behavior!");
            AstronautDuck astronautDuck = new AstronautDuck();
            astronautDuck.Display();
            astronautDuck.PerformFly();
            astronautDuck.PerformQuack();
            astronautDuck.Swim();

            Console.ReadKey();
        }
    }
}
