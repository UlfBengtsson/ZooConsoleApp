using System;
using System.Collections.Generic;
using System.Text;

namespace ZooConsoleApp.Models
{
    /*
    Butterfly child of Animal
        - Property for WingSpan
        - Property for LifeTimeExpectances
    */
    public class Butterfly : Animal
    {
        public double WingSpan { get; set; }
        public TimeSpan LifeTimeExpectances { get; set; }

        public Butterfly(int id) : base(id)
        {
            
        }
    }
}
