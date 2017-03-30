using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_6___CommandPattern
{
    public class Remote
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        private ICommand _undoCommand;

        public Remote()
        {
            //Defining Amount of Commands.
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            //Filling Array with Null Commands(Incase they're pressed before assignment)
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
        }
        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public void PressOnButton(int slot)
        {
            onCommands[slot].Execute();
            _undoCommand = onCommands[slot];
        }
        public void PressOffButton(int slot)
        {
            offCommands[slot].Execute();
            _undoCommand = offCommands[slot];
        }

        public void PressUndo()
        {
            _undoCommand.Undo();
        }

        public void DisplayButtons()
        {
            for (int i = 0; i < onCommands.Length; i++)
            {
                Console.WriteLine("Command:{0} - OnButton:{1} - OffButton:{2}" , i, onCommands[i].GetType().Name, offCommands[i].GetType().Name);
            }
        }
    }
}
