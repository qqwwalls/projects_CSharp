using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10
{
    public class Shark : ISeaCreature
    {
        public string Name { get; }
        public string Species { get; }

        public Shark(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public override string ToString()
        {
            return $"Shark: {Name}, Species: {Species}";
        }
    }
}
