using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7___Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 7 - Adapter Pattern:");

            //Normal Turkey
            FarmTurkey farmTurkey = new FarmTurkey();
            farmTurkey.Display();
            farmTurkey.Gobble();
            farmTurkey.Glide();

            Console.WriteLine("");
            //Normal Duck
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.Quack();
            mallardDuck.Fly();

            Console.WriteLine("");

            //Turkey with Access to Duck Methods
            WildTurkey wildTurkey = new WildTurkey();
            wildTurkey.Display();
            wildTurkey.Quack();
            wildTurkey.Fly();



            Console.ReadKey();
        }
    }
}
