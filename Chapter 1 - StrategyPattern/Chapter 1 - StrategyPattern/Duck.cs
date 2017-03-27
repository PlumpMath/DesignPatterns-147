using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1___StrategyPattern
{
    public abstract class Duck
    {
        //Behaviors
        protected IFlyBehavior FlyBehavior;
        protected IQuackBehavior QuackBehavior;

        //Set Behavior Methods - Allows behavior to be Changed at Runtime +5 Flexibility.
        public void SetFlyBehavior(IFlyBehavior fb)
        {
            FlyBehavior = fb;
        }
        public void SetQuackBehavior(IQuackBehavior qb)
        {
            QuackBehavior = qb;
        }
        //Perform Behavior Methods
        public void PerformFly()
        {
            FlyBehavior.Fly();
        }
        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }
        //Duck's can Display Themselves
        public abstract void Display();

        //Normal Duck Methods
        public void Swim()
        {
            Console.WriteLine("All Ducks Swim. \n");
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            //Setting Behavior @ instantiation
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new LoudQuack();
        }
        //Only have to Implement the Display Method.
        public override void Display()
        {
            Console.WriteLine("I am Mallard Duck.");
        }
    }

    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I am Decoy Duck.");
        }
    }
    public class AstronautDuck : Duck
    {
        public AstronautDuck()
        {
            FlyBehavior = new RocketPowered();
            QuackBehavior = new BurpQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I am Astronaut Duck.");
        }
    }

}
