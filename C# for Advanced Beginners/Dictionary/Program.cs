using System;
using System.Collections.Generic;

namespace Dictionary
{
    /*
     * Dictionary is collection of (key, value) pairs.
     * When creating dictionary, we need to specify the type for key and value.
     * Keys in dictionary must be unique.
     */
    class Program
    {
        static void Main()
        {
            CartoonCharacter ch1 = new CartoonCharacter { ID = 100, Name = "Bugsy", Age = 20 };
            CartoonCharacter ch2 = new CartoonCharacter { ID = 101, Name = "Daffy", Age = 200 };
            CartoonCharacter ch3 = new CartoonCharacter { ID = 01, Name = "TAZ", Age = 5 };

            /* We need to specify the datatype for the Key & Value*/
            Dictionary<int, CartoonCharacter> cartCharDict = new Dictionary<int, CartoonCharacter>
            {
                {ch1.ID, ch1},
                {ch2.ID, ch2},
                {ch3.ID, ch3}
            };
            if (!cartCharDict.ContainsKey(500))
            {
                cartCharDict.Add(500, new CartoonCharacter {ID = 500, Name = "Franki", Age = 69});
            }

            foreach (var cartoonCharacter in cartCharDict)
            {
                Console.WriteLine("Key is: {0}; & the values are: \ncartoonCharacter.Value.ID = {1} \ncartoonCharacter.Value.Name = {2} \ncartoonCharacter.Value.Age = {3}", cartoonCharacter.Key, cartoonCharacter.Value.ID, cartoonCharacter.Value.Name, cartoonCharacter.Value.Age);
                Console.WriteLine("----------------------------------------------");
            }

            /* OR */

            foreach (CartoonCharacter cartoonCharacter in cartCharDict.Values)
            {
                Console.WriteLine("ID = {0}; Name = {1}; Age ={2}", cartoonCharacter.ID, cartoonCharacter.Name, cartoonCharacter.Age);
                Console.WriteLine("--------------------------------------");
            }

        }
    }

    class CartoonCharacter
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
