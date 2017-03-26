using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12___CompoundPattern
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable CreateMallardDuck();
        public abstract IQuackable CreateRedheadDuck();
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateRubberDuck();
    }

    //Undecorated Factory
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuackable CreateDuckCall()
        {
            return  new DuckCall();
        }

        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }

    //Decorator Factory
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck()
        {
            return new QuackableCounter(new MallardDuck());
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new QuackableCounter(new RedheadDuck());
        }

        public override IQuackable CreateDuckCall()
        {
            return new QuackableCounter(new DuckCall());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new QuackableCounter(new RubberDuck());
        }
    }
}