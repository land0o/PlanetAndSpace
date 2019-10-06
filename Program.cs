using System;
using System.Collections.Generic;

namespace PlanetAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            planetList.Remove("Pluto");

            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanets);

            List<string> RockyPlanets = planetList.GetRange(0, 4);

            planetList.ForEach(planets => Console.WriteLine(planets));
            Console.WriteLine("-----------");
            Console.WriteLine("Rocky Planets");
            RockyPlanets.ForEach(planets => Console.WriteLine(planets));

        }
    }
}
