using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6___CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 6 - Command Pattern:");

            //Appliances
            Console.WriteLine("Launcher - Creating Appliances:");
            Light light = new Light(){Location = "Bathroom"};
            CeilingFan fan = new CeilingFan(){Location = "Living Room"};
            Stereo stereo = new Stereo(){Album = "Barry Whites Greatest Hits"};
            HotTub tub = new HotTub(){Temperature=50};

            //Commands
            Console.WriteLine("Launcher - Creating Commands for Appliances:");
            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);

            CeilingFanHigh ceilingFanHigh = new CeilingFanHigh(fan);
            CeilingFanOff ceilingFanOff = new CeilingFanOff(fan);

            StereoOn stereoOn = new StereoOn(stereo);
            StereoOff stereoOff = new StereoOff(stereo);

            HottubOnCommand tubOn = new HottubOnCommand(tub);
            HottubOffCommand tubOff = new HottubOffCommand(tub);

            //Party Button
            Console.WriteLine("Launcher - Creating Custom Macro Party Button:");
            ICommand[] OnCommands = { lightOn , ceilingFanHigh , stereoOn, tubOn};
            ICommand[] OffCommands = { lightOff, ceilingFanOff, stereoOff, tubOff};

            MacroPartyCommand macroPartyOn = new MacroPartyCommand(OnCommands);
            MacroPartyCommand macroPartyOff = new MacroPartyCommand(OffCommands);

            //Remote Programming
            Console.WriteLine("Launcher - Adding Commands to Remote:");
            Remote remote = new Remote();
            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(1, ceilingFanHigh, ceilingFanOff);
            remote.SetCommand(2, stereoOn, stereoOff);
            remote.SetCommand(3, tubOn, tubOff);
            remote.SetCommand(4, macroPartyOn, macroPartyOff);

            //Displaying Commands
            Console.WriteLine("\nLauncher - Displaying Stored Remote Commands:");
            remote.DisplayButtons();

            //Pressing Buttons
            Console.WriteLine("\nLauncher - Remote Pressing Buttons to Trigger Commands:");
            Console.WriteLine("Launcher - Remote Pressing Party ON Button:");
            remote.PressOnButton(4);
            Console.WriteLine("\nLauncher - Remote Pressing Party OFF Button:");
            remote.PressOffButton(4);

            Console.WriteLine("\nLauncher - Remote Pressing Undo:");
            remote.PressUndo();

            Console.ReadKey();
        }
    }
}
