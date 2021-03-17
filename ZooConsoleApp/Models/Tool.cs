using System;
using System.Collections.Generic;
using System.Text;

namespace ZooConsoleApp.Models
{
    /*
    Tool abstract class
        - Field for Id
        - Property for string Name
        - Property for int Price
        - Property for bool RightHandedOnly
        - Property for bool LeftHandedOnly
    */
    public abstract class Tool
    {
        public readonly int id;

        public string Name { get; set; }
        public int Price { get; set; }
        public bool RightHandedOnly { get; set; }
        public bool LeftHandedOnly { get; set; }

        public Tool(int id)
        {
            this.id = id;
        }

    }
}
