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
            Console.WriteLine("Creating Generic Turkey:");
            FarmTurkey farmTurkey = new FarmTurkey();
            farmTurkey.Display();
            farmTurkey.Gobble();
            farmTurkey.Glide();


            //Normal Duck
            Console.WriteLine("\nCreating Generic Duck:");
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.Quack();
            mallardDuck.Fly();

            //Turkey with Access to Duck Methods
            Console.WriteLine("\nCreating Wild Turkey - Turkey Methods Point to Duck Behaviors:");
            WildTurkey wildTurkey = new WildTurkey();
            wildTurkey.Display();
            wildTurkey.Gobble();
            wildTurkey.Glide();


            Console.ReadKey();
        }
    }
}
