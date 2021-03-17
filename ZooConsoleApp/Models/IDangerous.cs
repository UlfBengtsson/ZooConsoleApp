using System;
using System.Collections.Generic;
using System.Text;

namespace ZooConsoleApp.Models
{
    /*
    IDangerous interface
        - Property for int Level
        - Property for string Description
    */
    public interface IDangerous
    {
        //Fileds & methods inside a interface are by defualt public.
        public int Level { get; set; }
        public string Description { get; set; }
    }
}
