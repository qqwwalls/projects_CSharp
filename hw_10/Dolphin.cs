using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10
{
    public class Dolphin : ISeaCreature
    {
        public string Name { get; }
        public string Species { get; }

        public Dolphin(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public override string ToString()
        {
            return $"Dolphin: {Name}, Species: {Species}";
        }
    }
}
