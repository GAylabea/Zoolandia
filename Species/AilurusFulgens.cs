using System;

namespace Zoolandia.Species
{
    public class AilurusFulgens : Animal
    {
        public AilurusFulgens(string name) : base(name)
        {
            //nothing needed here because we are calling the base constructor - base means the Parent class;
            // you have to have/call a constructor because the animal.cs has the main constructor
        }
        public override string Eat(int numberOfFoodz) 
        {
            string animalEat = base.Eat(3);
            return animalEat + "nom nom nom";
        }

        public string Eat() {
            return "Don't know what I just ate but it was good!";
            }

        public string Welcome (string name)
        {
            this.Name = name;
            return Welcome();
        }
        public string Welcome() {
        return "Welcome, " + this.Name;
        }
    }
}
