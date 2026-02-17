using csharp.StrategyPattern;

namespace csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StrategyPatternExample();
        }

        static void StrategyPatternExample()
        {
            Console.WriteLine("Running Strategy Pattern example");

            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();
            Console.WriteLine();
            ModelDuck modelDuck = new ModelDuck();
            modelDuck.Display();
            modelDuck.Swim();

            modelDuck.PerformQuack();
            modelDuck.PerformFly();

            modelDuck.SetFlyBehavior(new FlyRocketPowered());
            modelDuck.PerformFly();

            Console.WriteLine();

            Character king = new King();
            king.Fight();

            Character queen = new Queen();
            queen.Fight();

            Character knight = new Knight();
            knight.Fight();

            Character troll = new Troll();
            troll.Fight();

            Console.WriteLine("Completed Strategy Pattern example");
        }
    }
}