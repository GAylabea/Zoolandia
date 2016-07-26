using System;

namespace Zoolandia.Species
{
public class GiraffaCamelopardalis : Animal
    {
        public GiraffaCamelopardalis(string name) : base(name)
        {
            //nothing needed here because we are calling the base constructor - base means the Parent class;
            // you have to have/call a constructor because the animal.cs has the main constructor
        }

        public int height{ get; set; }
        public int tongueLength{ get; set; }
        
    }


}