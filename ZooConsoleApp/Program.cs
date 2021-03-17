using System;
using System.Collections.Generic;
using ZooConsoleApp.Data;
using ZooConsoleApp.Models;

namespace ZooConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal(); abstract class cant be instantiated by it self

            ZooManager zooManager = new ZooManager();

            //zooManager.Tools = new List<Tool>();

            List<IDangerous> dangerous = zooManager.DangerousThingsAtZoo();

            foreach (var item in dangerous)
            {
                Console.WriteLine(item);
            }
        }
    }
}
