using System;
using System.Collections.Generic;
using System.Text;

namespace ZooConsoleApp.Models
{
    /*
    Balloon child of Tool
        - Property for PumpedUpWith (Ex: Air/Gas)
    */
    internal class Balloon : Tool
    {
        public Gas PumpedUpWith { get; set; }
        public Balloon(int id) : base(id)
        {
        }
    }

    public enum Gas
    {
        Air,
        Helium
    }
}
