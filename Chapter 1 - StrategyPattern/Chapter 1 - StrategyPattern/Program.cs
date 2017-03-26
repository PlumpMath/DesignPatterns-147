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

            //Changing Behavior @ Runtime
            mallardDuck.SetFlyBehavior(new RocketPowered());
            mallardDuck.SetQuackBehavior(new BurpQuack());
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.Swim();


            //Decoy Duck
            DecoyDuck decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.PerformFly();
            decoyDuck.PerformQuack();
            decoyDuck.Swim();

            //Astronaut Duck
            AstronautDuck astronautDuck = new AstronautDuck();
            astronautDuck.Display();
            astronautDuck.PerformFly();
            astronautDuck.PerformQuack();
            astronautDuck.Swim();

            Console.ReadKey();
        }
    }
}
