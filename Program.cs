using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm sidor = new Storm("wind",true,"Zul'rajas");
      Storm nargis = new Storm("wind", false,"Lina");
      Pupil Mez = new Pupil("Mezil-Kree");
       Storm dor = Mez.CastWindStrom();
        dor.Announce();   

      Mage Gul = new Mage("Gul’dan");
      Storm dan = Gul.CastRainStorm();
      dan.Announce();

      Archmage nei= new Archmage("Nielas Aran");
      Storm aran = nei.CastRainStorm();
      aran.Announce();

      Storm aran1 = nei.CastLightningStorm();
      aran1.Announce();

        //nargis.Announce();   
        //Console.WriteLine(s1);
    }
  }
}
