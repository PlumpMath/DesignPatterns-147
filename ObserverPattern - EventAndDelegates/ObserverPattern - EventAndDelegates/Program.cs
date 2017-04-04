using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern___EventAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer Pattern - Events & Delegates Version:");
            Video video = new Video(){Title = "LOTR Battle for Middle Earth"};

            Console.WriteLine("Launcher - Creating Publisher/Subject:");
            VideoEncoder encoder = new VideoEncoder();

            Console.WriteLine("Launcher - Creating Observers:");
            MailService mailService = new MailService();
            MessageService messageService = new MessageService();

            Console.WriteLine("Launcher - Registering Observers to Publisher:");
            encoder.VideoEncoded += mailService.OnVideoEncoded;
            encoder.VideoEncoded += messageService.OnVideoEncoded;

            Console.WriteLine("Launcher - Encoding Video:");
            encoder.Encode(video);


            Console.ReadKey();
        }
    }
}
