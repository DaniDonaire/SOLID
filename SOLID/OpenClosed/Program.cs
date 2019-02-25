using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {

            var coches = new List<Coche>
            {
                new Coche { Name = "Ibiza normal", Modelo = Model.Ibiza, Type = SubType.Normal },
                new Coche { Name = "Ibiza FR", Modelo = Model.Ibiza, Type = SubType.Fr },
                new Coche { Name = "Leon FR", Modelo = Model.Leon, Type = SubType.Fr },
                new Coche { Name = "Ibiza Coupra", Modelo = Model.Ibiza, Type = SubType.Coupra },
                new Coche { Name = "Leon Coupra", Modelo = Model.Leon, Type = SubType.Coupra }
            };

            var filter = new CochesFilter();

            var cochesFr = filter.FilterByType(coches, SubType.Fr);
            Console.WriteLine("All Cars Fr");
            foreach (var coche in cochesFr)
            {
                Console.WriteLine($"Name: {coche.Name}, Type: {coche.Type}, Screen: {coche.Modelo}");
            }

            Console.ReadLine();
        }
    }



    public enum SubType
    {
        Normal,
        Fr,
        Coupra
    }
    public enum Model
    {
        Ibiza,
        Leon
    }
    

}
