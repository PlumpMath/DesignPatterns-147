using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12___CompoundPattern
{
    class DuckSimulator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Chapter 12 - Composite Pattern: (Putting Everything Togther)");
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory factory = new CountingDuckFactory();
            simulator.Simulate(factory);

            //Console.WriteLine("Testing Flock Iterator:");
            //Flock flock = new Flock();
            //flock.Add(new MallardDuck());
            //flock.Add(new MallardDuck());
            //flock.Add(new MallardDuck());

            //DuckSimulator duckSimulator = new DuckSimulator();
            //duckSimulator.Simulate(flock);


            Console.ReadKey();
        }

        public void Simulate(AbstractDuckFactory factory)
        {
            //Step 9, using IQuackable Decorator(QuackableCounter)
            //Duck Factories
            IQuackable mallard = factory.CreateMallardDuck();
            IQuackable redhead = factory.CreateRedheadDuck();
            IQuackable duckcall = factory.CreateDuckCall();
            IQuackable adaptedGoose = new QuackableCounter(new GooseAdapter(new Goose()));

            Console.WriteLine("Duck Simulator: W Adapter, Decorator & Composite");

            //Creating Flock(Composite)
            Console.WriteLine("Flock of Ducks & Geese:");
            Flock flock = new Flock();
            flock.Add(mallard);
            flock.Add(redhead);
            flock.Add(duckcall);
            //flock.Add(adaptedGoose);

            //Observers
            Quackologist quackologist = new Quackologist();
            flock.RegisterObserver(quackologist);

            Simulate(flock);
            Console.WriteLine("Quack Counter = {0}" , QuackableCounter.numberOfQuacks);
        }

        public void Simulate(IQuackable duck)
        {
            Console.WriteLine("Inside Simulate");
            duck.Quack();
        }
    }
}
