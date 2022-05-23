using System;

namespace MagicalInheritance
{
  class Program
  {

    static void Main(string[] args)
    {
      Storm s1 = new Storm("wind",false,"Zul'rajas");
      s1.Announce();
      Pupile p1 = new Pupile("Mezil-Kree");
      p1.CastWindStorm().Announce();
      Mage m1 = new Mage("Rambod");
      m1.CastRainStorm().Announce();
      

    }
  }
}