using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.Common.Models
{
    public class CustomApplicationUser
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
