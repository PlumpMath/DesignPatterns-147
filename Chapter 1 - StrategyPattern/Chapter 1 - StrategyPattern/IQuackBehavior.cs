using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1___StrategyPattern
{
    public interface IQuackBehavior
    {
        void Quack();
    }

    public class LoudQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Loud Quack Envoked.");
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Mute Quack Envoked.");
        }
    }

    public class BurpQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Burp Quack Envoked.");
        }
    }
}
