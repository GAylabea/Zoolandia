using System;

namespace Zoolandia.Species
{
// Properties go here in this file + Methods
public class PantheraLeo : Animal
    {
        public PantheraLeo(string name) : base(name)
        {
            //nothing needed here because we are calling the base constructor - base means the Parent class;
            // you have to have/call a constructor because the animal.cs has the main constructor
        }

        public string maneFullness{ get; set; }
        public int teethNumber{ get; set; }

        public void roar () {
        Console.WriteLine("ROARRRRRRR!!!");
        }

    }


}