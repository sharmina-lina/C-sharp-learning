// Archmage.cs
using System;

namespace MagicalInheritance
{
 class Archmage : Mage
 {
   public Archmage(string s3) : base(s3)
   {

   }
   public override Storm CastRainStorm(){
     Storm str3 = new Storm("Rain",true,Title);
     return str3;
   }
   public Storm CastLightningStorm(){
     Storm slight = new Storm("lighting", true, Title);
     return slight;
   }
 }
}
