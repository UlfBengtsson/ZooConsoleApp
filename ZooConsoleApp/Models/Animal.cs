using System;
using System.Collections.Generic;
using System.Text;

namespace ZooConsoleApp.Models
{
    /*
     Animal abstract class
        - Field for Id
        - Property for string Name
        - Property for int Age
        - Property for Breed
    */
    public abstract class Animal
    {
        public readonly int id;

        public string Name { get; set; }//behind the code, C# will create a field to this property
        public int Age { get; set; }
        public string Breed { get; set; }

        public Animal(int id)
        {
            this.id = id;
        }
    }
}
