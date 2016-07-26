using System;
using Zoolandia.Species;

namespace Zoolandia
{
    // Instances go in this file using the properties and methods devised in the seperate species classes
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        // Red Panda
            AilurusFulgens redPanda = new AilurusFulgens("Pete");
            redPanda.Name = "Pete";
            redPanda.legs = 4;
            redPanda.habitat = "High-altitude mountain forest";
            redPanda.weight = 14;
            redPanda.carnivore = true; 
            Console.WriteLine("This panda's name is " + redPanda.Name);
            Console.WriteLine(redPanda.Name + " weighs about " + redPanda.weight + "lbs");
            Console.WriteLine(redPanda.Name + "'s natural habitat is " + redPanda.habitat);
            Console.WriteLine("Is " + redPanda.Name + " a carnivore? " + redPanda.carnivore);

        // Elephants
            ElephasMaximus asianElephant = new ElephasMaximus("Packy");
            asianElephant.Name = "Packy";
            asianElephant.legs = 4;
            asianElephant.habitat = "Rainforest and tropical woodland";
            asianElephant.weight = 12000; 
            asianElephant.carnivore = false; 
            asianElephant.trunkLength = 10; 
            asianElephant.walk(); 
            Console.WriteLine("This Elephant's name is " + asianElephant.Name);
            Console.WriteLine(asianElephant.Name + " weighs over " + asianElephant.weight + " lbs!");
            Console.WriteLine(asianElephant.Name + "'s natural habitat is: " + asianElephant.habitat); 
            Console.WriteLine("Is " + asianElephant.Name + " a carnivore? " + asianElephant.carnivore);
            Console.WriteLine("Packy doesn't walk really fast, he's old. He only walks at a speed of " + asianElephant.speed);

        // Giraffes 
            GiraffaCamelopardalis Giraffe = new GiraffaCamelopardalis("Desi");
            Giraffe.Name = "Desi";
            Giraffe.legs = 4;
            Giraffe.habitat = "sub-Saharan Africa"; 
            Giraffe.height = 10; 
            Giraffe.tongueLength = 21; 
            Giraffe.carnivore = false; 
            Console.WriteLine("This Giraffe's name is " + Giraffe.Name);
            Console.WriteLine(Giraffe.Name + " is this many feet tall: " + Giraffe.height); 
            Console.WriteLine(Giraffe.Name + "'s natural habitat is: " + Giraffe.habitat); 
            Console.WriteLine("Is " + Giraffe.Name + " a carnivore? " + Giraffe.carnivore); 
            Console.WriteLine(Giraffe.Name + " has a tongue length of " + Giraffe.tongueLength + " inches!"); 

        // Lions
            PantheraLeo Lion = new PantheraLeo("Neka");
            Lion.Name = "Neka";
            Lion.legs = 4;
            Lion.habitat = "Open woodland, scrub, grassland";
            Lion.weight =  265; 
            Lion.carnivore = true; 
            Lion.maneFullness = "very";
            Lion.roar();
            Console.WriteLine("This Lion's name is " + Lion.Name);
            Console.WriteLine(Lion.Name + "'s natural habitat is: " + Lion.habitat); 
            Console.WriteLine(Lion.weight + "Lbs");
            Console.WriteLine("Is " + Lion.Name + " a carnivore? " + Lion.carnivore);
            Console.WriteLine("I have a Lion named Neka who has a {0} full mane.", Lion.maneFullness);

            Console.ReadLine();  //this prevents the console from closing after running the program, will wait for you to keep typing
            
        }
    }
}
