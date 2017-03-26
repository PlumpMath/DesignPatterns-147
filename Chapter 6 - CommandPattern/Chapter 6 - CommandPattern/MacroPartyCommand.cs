namespace Chapter_6___CommandPattern
{
    public class MacroPartyCommand : ICommand
    {
        private ICommand[] Commands;
        //Take in Array of Commands
        public MacroPartyCommand(ICommand[] commands)
        {
            Commands = commands;
        }
        //Execute All
        public void Execute()
        {
            foreach (ICommand command in Commands)
            {
                command.Execute();   
            }
        }
        //Undo All
        public void Undo()
        {
            foreach (ICommand command in Commands)
            {
                command.Undo();
            }
        }
    }
}