using System;
using System.Collections.Generic;
using System.Text;

namespace ZooConsoleApp.Models
{
    /*
    Chainsaw child of Tool and implements the IDangerous interface
        - Property for EngineType
        - Property for Brand
    */
    internal class Chainsaw : Tool, IDangerous
    {
        public string Brand { get; set; }
        public Engine EngineType { get; set; }

        public int Level { get; set; }
        public string Description { get; set; }


        public Chainsaw(int id) : base(id)
        {
        }
    }

    public enum Engine
    {
        Petrol,
        Electrical,
        Gas
    }
}
