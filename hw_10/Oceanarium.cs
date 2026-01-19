using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10
{
    public class Oceanarium<T> : IEnumerable<T> where T : ISeaCreature
    {
        private List<T> inhabitants = new List<T>();

        public void Add(T creature)
        {
            inhabitants.Add(creature);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return inhabitants.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
