using System;
using System.Reflection;

namespace EnumsDemo
{
    /*
     * If program uses integral numbers consider to replacing them with enums.
     * Enums are value types.
     * Default underlaying type of enums is int & it is possible to customize the underlying type & values.
     * 
     */
    class Program
    {
        static void Main()
        {
            int[] enumValues = (int[])Enum.GetValues(typeof (Gender));
            foreach (var enumValue in enumValues)
            {
                Console.WriteLine(enumValue);
            }

            string[] enumNames = Enum.GetNames(typeof(Gender));
            foreach (var enumName in enumNames)
            {
                Console.WriteLine(enumName);
            }

            Console.WriteLine();
            Console.WriteLine("============================");

            /* Changed Enums */
            short[] changedEnumValues = (short[]) Enum.GetValues(typeof (GenderWithChangedUnderlayingDataTypeAndValues));
            foreach (var changedEnumValue in changedEnumValues)
            {
                Console.WriteLine("Now this is short -> " + changedEnumValue);
            }
            /* Names will be the same */
            string[] changedEnumNames = Enum.GetNames(typeof(GenderWithChangedUnderlayingDataTypeAndValues));
            foreach (var changedEnumName in changedEnumNames)
            {
                Console.WriteLine(changedEnumName);
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            /* Since enums are strongly typed constants we need casting */
            int num = (int)Season.Autumn;
            Console.WriteLine(num);
        }
    }

    enum Gender
    {
        Unknown,
        Male,
        Female
    }
    enum GenderWithChangedUnderlayingDataTypeAndValues : short
    {
        Unknown = 69,
        Male =15,
        /* This will lead to compile time error */
        //Male = 15897867896,
        Female = 23
    }

    enum Season
    {
        Winter = 100,
        Spring = 200,
        Autumn  = 300,
        Summer = 400
    }
}


