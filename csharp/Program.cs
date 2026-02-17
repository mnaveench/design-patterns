namespace csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ModelDuck modelDuck = new ModelDuck();
            modelDuck.PerformQuash();
            modelDuck.PerformFly();
            modelDuck.Display();
            modelDuck.Swim();
            Console.WriteLine("Completed");
        }
    }
}