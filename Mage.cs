// Mage.cs
using System;

namespace MagicalInheritance
{
  class Mage : Pupil
  {
    public Mage(string ss) : base(ss)
    {

    }
    public virtual Storm CastRainStorm()
       {
         Storm Mage = new Storm("Rain",false, Title);
      return Mage;
       }
    

  }
  
}
