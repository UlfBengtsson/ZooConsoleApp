using System;
using System.Collections.Generic;
using System.Text;
using ZooConsoleApp.Models;

namespace ZooConsoleApp.Data
{
    /*
    Zoo manager class
    - Field of list of animals
    - Field of list of tools
    - Field of IdGenerator
    - Property to get tools/animal list (not set, at least not public access)
    - Methods to add tool/animal into these lists and assign a unique id for them (no tool or animal can have the same Id)
    - Method to FindById for tools & animals
    - Method to get all the IDangerous from both the lists
    */
    public class ZooManager
    {
        List<Animal> animals;
        List<Tool> tools;
        IdGenerator idGenerator;

        public List<Animal> Animals 
        { 
            get//read
            {
                return animals;
            }
            private set//write
            {
                animals = value;// value is of type List<Animal> here
            }
        }

        public List<Tool> Tools
        {
            get//read
            {
                return tools;
            }
            private set//write
            {
                tools = value;// value is of type List<Tool> here
            }
        }

        public ZooManager()
        {
            Animals = new List<Animal>();
            Tools = new List<Tool>();
            idGenerator = new IdGenerator();

            //demo code not ment to be here normely
            animals.Add(new Butterfly(idGenerator.GetNewId()));
            animals.Add(new Dog(idGenerator.GetNewId()));
            animals.Add(new Butterfly(idGenerator.GetNewId()));
            animals.Add(new Butterfly(idGenerator.GetNewId()));

            tools.Add(new Chainsaw(idGenerator.GetNewId()));
            tools.Add(new Balloon(idGenerator.GetNewId()));
            tools.Add(new Chainsaw(idGenerator.GetNewId()));
        }

        public List<IDangerous> DangerousThingsAtZoo()
        {
            List<IDangerous> dangerous = new List<IDangerous>();

            foreach (Animal animalFromList in animals)
            {
                if (animalFromList is IDangerous)
                {
                    dangerous.Add(animalFromList as IDangerous);
                }
            }

            foreach (Tool toolFromList in tools)
            {
                if (toolFromList is IDangerous)
                {
                    dangerous.Add(toolFromList as IDangerous);
                }
            }

            return dangerous;
        }
    }
}
