using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11___ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 11 - Proxy Pattern:");

            GumballMachine realMachine = new GumballMachine("Rodeo Drive", 25);
            GumballMonitor monitor = new GumballMonitor(realMachine);
            monitor.Report();


            Console.ReadKey();
        }
    }
}
