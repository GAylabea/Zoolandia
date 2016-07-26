using System;

namespace Zoolandia.Species
{
public class ElephasMaximus : Animal
    {
        public ElephasMaximus(string name) : base(name)
        {
            //nothing needed here because we are calling the base constructor - base means the Parent class;
            // you have to have/call a constructor because the animal.cs has the main constructor
        }

        public int trunkLength{ get; set; }
        public override void walk () {
            Console.WriteLine("Elephant class walk method");
            speed = speed + (0.3 * legs); 
            }
        }
    }
