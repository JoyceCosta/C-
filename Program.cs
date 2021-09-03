using System;

namespace c_yt
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.WriteLine(Planets.Neptune + " is planet # " + (int)Planets.Neptune);
      //Console.WriteLine(Planets.Pluto + " is planet # " + (int)Planets.Pluto); 


      String name = PlanetRadius.Earth.ToString();
      int radius = (int)PlanetRadius.Earth;

      Console.WriteLine("Planet: " + name);
      Console.WriteLine("Radius " + radius + " Km");
    }
  }

  enum Planets
  {
    Mercury = 1,
    Venus = 2,
    Earth = 3,
    Mars = 4,
    Jupter = 5,
    Saturn = 6,
    Uranus = 7,
    Neptune = 8,
    Pluto = 9
  }

  enum PlanetRadius
  {
    Mercury = 2439,
    Venus = 6051,
    Earth = 6371,
    Mars = 3389,
    Jupter = 69911,
    Saturn = 58232,
    Uranus = 25362,
    Neptune = 24622,
    Pluto = 1188
  }
}
