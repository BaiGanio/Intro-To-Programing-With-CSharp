using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ListCollection
{
    /*
     * List is one of the generic collection classes present in System.Collection.Generic namespace.
     * There are several collection classes:
     * - Dictionary
     * - Stack
     * - Queue
     * - etc.
     * 
     * List can be use to create a collection of any type (int, string, Person, etc.).
     * Notice that they are strongly typed.
     * Object stored in a list can be accessed by index & unlike arrays, they can grow in size automatically.
     * List provides also methods to search, sort & manipulate lists.
     *  
     */
    class Program
    {
        static void Main()
        {

            Rabbit peshko = new Rabbit {Name = "Peshko Bunny", Color = Color.Brown};
            Rabbit niki = new Rabbit { Name = "NikiBoy Bunny", Color = Color.White };
            Rabbit me4o = new Rabbit { Name = "Me4o Puh Bunny", Color = Color.Grey };

            Rabbit[] rabbits = new Rabbit[2];
            rabbits[0] = peshko;
            rabbits[1] = niki;
            /* 'me4o' is outside the boundries of the array. So there will be exception thrown. */
            //rabbits[2] = me4o;

            Console.WriteLine("Array:");
            foreach (Rabbit rabbit in rabbits)
            {
                Console.WriteLine("Name = {0} & Color = {1}", rabbit.Name, rabbit.Color);
            }

            Console.WriteLine("----------------------------------------------------");

            List<Rabbit> rabbitsList = new List<Rabbit>(2);
            rabbitsList.Add(peshko);
            rabbitsList.Add(niki);
            rabbitsList.Add(me4o);
            
            /* We can insert data in the list at specific location */
            rabbitsList.Insert(0, me4o);
            Console.WriteLine("List:");
            foreach (Rabbit rabbit in rabbitsList)
            {
                Console.WriteLine("Name = {0} & Color = {1}", rabbit.Name, rabbit.Color);
            }

            /* We can find the index of the specific item in the list. By default we take the first element that matches */
            Console.WriteLine(rabbitsList.IndexOf(me4o));

            /* Start searching from specific position */
            Console.WriteLine(rabbitsList.IndexOf(me4o, 1));

            /* Another overloaded version is to search from specific posiotion a certain number of times */
            /* 4 will be outside the range & will throw exception */
            Console.WriteLine(rabbitsList.IndexOf(me4o, 1, 3));
        }
    }

    class Rabbit
    {
        public string Name { get; set; }
        public Color Color { get; set; }

    }

    enum Color
    {
        Grey,
        Brown,
        Black,
        White
    }

}
