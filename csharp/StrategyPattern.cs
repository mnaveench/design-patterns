using csharp;

namespace csharp.StrategyPattern
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        internal void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }
        internal void QuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public abstract void Display();

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
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
            _quackBehavior = new QuackQuack();
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
            _quackBehavior = new QuackQuack();
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
            _quackBehavior = new QuackQuack();
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

    public sealed class QuackQuack : IQuackBehavior
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

    public interface IWeaponBehavior
    {
        void UseWeapon();
    }

    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Swining a sword");
        }
    }

    public class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Cutting with a knife");
        }
    }

    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Release an arrow");
        }
    }

    public class AxeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("chopping with an axe");
        }
    }

    public abstract class Character
    { 
        protected IWeaponBehavior WeaponBehavior { get; set; }
        internal virtual void Fight()
        {
            WeaponBehavior.UseWeapon();
        }
    }

    public class King : Character
    {
        public King()
        {
            WeaponBehavior = new SwordBehavior();
        }
    }

    public class Queen : Character
    {
        public Queen()
        {
            WeaponBehavior = new BowAndArrowBehavior();
        }
    }

    public class Knight : Character
    {
        public Knight()
        {
            WeaponBehavior = new KnifeBehavior();
        }
    }

    public class Troll : Character
    {
        public Troll()
        {
            WeaponBehavior = new AxeBehavior();
        }
    }
}


