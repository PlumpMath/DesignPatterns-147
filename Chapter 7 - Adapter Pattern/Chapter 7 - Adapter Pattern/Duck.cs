using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7___Adapter_Pattern
{
    public interface IDuck
    {
        void Fly();
        void Quack();
    }

    public class MallardDuck : IDuck
    {
        public void Display()
        {
            Console.WriteLine("I am a Mallard Duck.");
        }

        public void Fly()
        {
            Console.WriteLine("Duck Flying.");
        }

        public void Quack()
        {
            Console.WriteLine("Duck Quack.");
        }
    }
}
