using System;

namespace Zoolandia
{
    public class Animal
    {
        // it would be an empty constructor if it did not have anything in the ()
        // using a constructor to get all our classes and dependencies
        public Animal (string name)
        {
            this.Name = name;
        }

       //this is a PROPERTY
        public string Name {get; set;} //property name = Name; the get/set allows us to do dot notation

        //this is a METHOD; by making it virtual you can override the parent 
        public virtual string Eat(int numberOfFoodz)  
        {
            return "YUM!";
        }
    }



}