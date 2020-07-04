using IntroCSharp.Common.Enums.StarTrek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.Common.Models
{
   public class Planet
    {
        public string Name { get; set; }
        public StarTrekClasification PlanetType { get; set; }
        public PlanetDescription Description { get; set; }

    }
}
