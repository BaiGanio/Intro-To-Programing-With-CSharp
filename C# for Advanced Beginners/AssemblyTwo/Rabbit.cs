using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTwo
{
    public class Rabbit
    {
        /* This will be available only to the classes within this assembly */
        internal string Name = "Bugs Bunny";

        /* This will be available anywhere within the containing assembly & within derived class in any other assembly */
        protected internal string NickName = "Зайко Байко";
    }
}
