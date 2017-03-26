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

            //Applicances
            Light light = new Light(){Location = "Bathroom"};
            CeilingFan fan = new CeilingFan(){Location = "Living Room"};
            Stereo stereo = new Stereo(){Album = "Barry Whites Greatest Hits"};

            //Commands
            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);

            CeilingFanHigh ceilingFanHigh = new CeilingFanHigh(fan);
            CeilingFanOff ceilingFanOff = new CeilingFanOff(fan);

            StereoOn stereoOn = new StereoOn(stereo);
            StereoOff stereoOff = new StereoOff(stereo);

            //Party Button
            ICommand[] OnCommands = { lightOn , ceilingFanHigh , stereoOn};
            ICommand[] OffCommands = { lightOff, ceilingFanOff, stereoOff };
            MacroPartyCommand macroPartyOn = new MacroPartyCommand(OnCommands);
            MacroPartyCommand macroPartyOff = new MacroPartyCommand(OffCommands);

            //Remote Programming
            Remote remote = new Remote();
            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(1, ceilingFanHigh, ceilingFanOff);
            remote.SetCommand(2, stereoOn, stereoOff);
            remote.SetCommand(3, macroPartyOn, macroPartyOff);

            remote.DisplayButtons();
            remote.PressOnButton(3);
            remote.PressOffButton(3);
            remote.PressUndo();

            Console.ReadKey();
        }
    }
}
