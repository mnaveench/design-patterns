using csharp;

namespace csharp
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        protected void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }
        protected void QuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public abstract void Display();

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuash()
        {
            _quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new QuackBehavior();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }

    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new QuackBehavior();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Redhead duck");
        }
    }

    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a readl Rubber duck");
        }
    }

    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Decoy duck");
        }
    }

    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new QuackBehavior();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }

    public interface IQuackBehavior
    {
        void Quack();
    }

    public sealed class QuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    public sealed class MuteQuack : IQuackBehavior
    {

        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }

    public sealed class Squeak : IQuackBehavior
    {

        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }

    public interface IFlyBehavior
    {
        void Fly();
    }

    public sealed class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }

    public sealed class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }

    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket");
        }
    }



    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Bark();
        }

        private void Bark()
        {
            Console.WriteLine("bark sound");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Meow();
        }

        private void Meow()
        {
            Console.WriteLine("meow sound");
        }
    }
}


