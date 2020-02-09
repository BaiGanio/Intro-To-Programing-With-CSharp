using System;
using System.Text;

namespace WhatIsClass
{
    /*
        So far we know simple data types like int, float, double ...
        But what if we want to have custom and more complex types? We use classes!
        
        !!!
        Class consist:
        1. Data/State - represented by fields;
        2. Behavior - represented by methods;
         
    */
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            CustomApplicationUser defaultUser = new CustomApplicationUser();
            defaultUser.PrintUserData();

            Console.WriteLine("-------------------------------------------");

            CustomApplicationUser realUser = new CustomApplicationUser("Bugs Bunny", "123456");
            realUser.PrintUserData();
        }
    }

    class CustomApplicationUser
    {
        private string _username;
        private string _password;

        /* Constructors are used to initialize class fields & doesn't have return type. They are called automatically when we create instance of the class. We can use debugger for better understanding. Notice that constructors can be overloaded by the number and type of parameters  */
        public CustomApplicationUser() 
            : this("No username", "No password")
        {
            
        }
        public CustomApplicationUser(string name, string pass)
        {
            this._username = name;
            this._password = pass;
        }

        public void PrintUserData()
        {
            Console.WriteLine("User: {0} \nPass: {1}", this._username, this._password);
        }

    }


}
