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

        public string furColor { get; set; }
        
    }
}
