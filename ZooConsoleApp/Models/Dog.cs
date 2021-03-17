using System;
using System.Collections.Generic;
using System.Text;

namespace ZooConsoleApp.Models
{
    /*
    Dog child of Animal and implements the IDangerous interface
        - Property for Vaccinated
    */
    public class Dog : Animal, IDangerous
    {
        int dangerLevel;
        string dangerDescription;

        public bool Vaccinated { get; set; }
        public int Level
        { 
            get 
            { 
                return dangerLevel; 
            } 
            set 
            { 
                dangerLevel = value; 
            } 
        }
        public string Description 
        { 
            get
            {
                return dangerDescription;
            }
            set
            {
                dangerDescription = value;
            }
        }

        public Dog(int id) : base(id)
        {
            
        }

        public Dog(int id, bool vaccinated) : this(id)
        {
            Vaccinated = vaccinated;
        }
    }
}
