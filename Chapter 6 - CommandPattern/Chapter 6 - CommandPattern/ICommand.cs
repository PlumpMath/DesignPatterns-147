namespace Chapter_6___CommandPattern
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class NoCommand : ICommand
    {
        public void Execute()
        {
            
        }

        public void Undo()
        {
            
        }
    }

    public class LightOnCommand : ICommand
    {
        private Light Light;
        public LightOnCommand(Light light)
        {
            Light = light;
        }
        public void Execute()
        {
            Light.TurnOn();
        }

        public void Undo()
        {
            Light.TurnOff();
        }
    }

    public class LightOffCommand : ICommand
    {
        private Light Light;
        public LightOffCommand(Light light)
        {
            Light = light;
        }
        public void Execute()
        {
            Light.TurnOff();
        }

        public void Undo()
        {
            Light.TurnOn();
        }
    }

    public class CeilingFanHigh : ICommand
    {
        protected int PrevSpeed;
        private CeilingFan Fan;

        public CeilingFanHigh(CeilingFan fan)
        {
            Fan = fan;
        }

        public void Execute()
        {
            PrevSpeed = Fan.Speed;
            Fan.High();
        }

        public void Undo()
        {
            if (PrevSpeed == 3)
            {
                PrevSpeed = Fan.Speed;
                Fan.High();
            }
            else if (PrevSpeed == 2)
            {
                PrevSpeed = Fan.Speed;
                Fan.Medium();
            }
            else if (PrevSpeed == 1)
            {
                PrevSpeed = Fan.Speed;
                Fan.Low();
            }
            else if (PrevSpeed == 0)
            {
                PrevSpeed = Fan.Speed;
                Fan.Off();
            }
        }
    }

    public class CeilingFanOff : ICommand
    {
        protected int PrevSpeed;
        private CeilingFan Fan;

        public CeilingFanOff(CeilingFan fan)
        {
            Fan = fan;
        }

        public void Execute()
        {
            PrevSpeed = Fan.Speed;
            Fan.Off();
        }

        public void Undo()
        {
            if (PrevSpeed == 3)
            {
                PrevSpeed = Fan.Speed;
                Fan.High();
            }
            else if (PrevSpeed == 2)
            {
                PrevSpeed = Fan.Speed;
                Fan.Medium();
            }
            else if (PrevSpeed == 1)
            {
                PrevSpeed = Fan.Speed;
                Fan.Low();
            }
            else if (PrevSpeed == 0)
            {
                PrevSpeed = Fan.Speed;
                Fan.Off();
            }
        }
    }

    public class StereoOn : ICommand
    {
        private Stereo Stereo;

        public StereoOn(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Execute()
        {
            Stereo.TurnOn();
        }

        public void Undo()
        {
            Stereo.TurnOff();
        }
    }
    public class StereoOff : ICommand
    {
        private Stereo Stereo;

        public StereoOff(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Execute()
        {
            Stereo.TurnOff();
        }

        public void Undo()
        {
            Stereo.TurnOn();
        }
    }
}
