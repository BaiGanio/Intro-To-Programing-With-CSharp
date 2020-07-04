using IntroCSharp.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.Common.Models
{
    public class Rabbit
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
        public Color Color { get; set; }
    }
}
