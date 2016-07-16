using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AilurusFulgens redPanda = new AilurusFulgens("Steve"); //using the actual class type might be easier than using var - specificity! 
            // so we REQUIRE a name because of the constructor in Animal.cs
            redPanda.Name = "Steve";
            string response = redPanda.Eat(5);

            Console.WriteLine(redPanda.Name + " says " + response);

            AilurusFulgens Joe = new AilurusFulgens("Steve");
            Console.WriteLine(Joe.Welcome("Joe"));
            Console.WriteLine(Joe.Name);
            
            Console.ReadLine();  //this prevents the console from closing after running the program, will wait for you to keep typing 

        }
    }
}
