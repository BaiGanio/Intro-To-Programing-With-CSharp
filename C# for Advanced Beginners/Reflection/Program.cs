using System;

namespace Reflection
{
    /*
     * Reflection is the ability to inspect assemblies metadata at runtime.
     * 
     * It is used to find all types in the assembly &/or dynamically to invoke methods.
     * 
     * Metadata contains information about all TYPES within the assembly. What they hav in it.
     * who are the member of the class. All this data is packaged into that assembly in the form of metadata.
     * Reflection is inspecting this assembly contents to find how many classes, enums, structs that 
     * assembly contains...
     */
    class Program
    {
        static void Main()
        {
            /* Still TO DO */

            Object obj = new object();
           // Type
            
        }
    }

    class Rabbit
    {
        public Rabbit()
        {
            this.Name = "This rabbit has no name!";
            this.Age = 101;
        }
        public Rabbit(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
