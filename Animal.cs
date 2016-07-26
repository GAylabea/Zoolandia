using System;

namespace Zoolandia
{
    public class Animal {
         // This is the constructor. It would be an empty constructor if it did not have anything in the ()
        // using a constructor to get all our classes and dependencies
         public Animal (string name)
        {
            //this sets the name - remember, the Name is different from name
            this.Name = name;
        }
        public int legs { get; set; }
        public string Name { get; set; }
        public int weight { get; set; }
        public string habitat { get; set; }
        public bool carnivore { get; set; }
        public double speed { get; set; }
        public virtual void walk () {
            Console.WriteLine("Animal class walk method"); 
            speed = speed + (0.1 * legs);
        }

        public void sleep () {
        Console.WriteLine("I am sleeping");
        }
    }
}
 

