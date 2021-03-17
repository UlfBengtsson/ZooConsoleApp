using System;
using System.Collections.Generic;
using System.Text;

namespace ZooConsoleApp.Models
{
    /*
    IdGenerator class
        - Field that is private int idCounter
        - Method to GetNewId
        - Method to LastGivenId
    */
    internal class IdGenerator
    {
        int idCounter = 0;

        //1.access moderfirer
        //2.return type ex: void or string
        //3.Name of the method
        //4.input parameters/varibles with good names
        internal int GetNewId()
        {
            //idCounter = idCounter + 1;
            //return idCounter;
            return ++idCounter;
        }

        internal int LastGivenId()
        {
            return idCounter;
        }
    }
}
