using System;

namespace Chapter_7___Adapter_Pattern
{
    public interface ITurkey
    {
        void Glide();
        void Gobble();
    }

    public class FarmTurkey : ITurkey
    {
        public void Display()
        {
            Console.WriteLine("I am a Farm Turkey.");
        }

        public void Glide()
        {
            Console.WriteLine("Turkey Glide!");
        }

        public void Gobble()
        {
            Console.WriteLine("Turkey Gobble!");
        }
    }
}
