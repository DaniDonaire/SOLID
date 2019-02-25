using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosed
{
    public class Coche
    {
        public string Name { get; set; }
        public SubType Type { get; set; }
        public Model Modelo { get; set; }
    }

    public class CochesFilter
    {
        public List<Coche> FilterByType(IEnumerable<Coche> coches, SubType type) =>
                coches.Where(m => m.Type == type).ToList();
    }
}
