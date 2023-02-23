// Storm.cs
using System;

namespace MagicalInheritance
{
 class Storm
 {
   public string Essence
   { get; private set; }
   public bool IsStrong
   { get; private set; }
   public string Caster
   { get; private set;}
   public Storm(string essence, bool isStrong, string caster){
     Essence = essence;
     IsStrong = isStrong;
     Caster = caster;

   }
   public void Announce(){
     string s;
     if( IsStrong){
        s = $"{Caster} caster a strong {Essence} strom!";
     }
     else
     {
       s = $"{Caster} caster a weak {Essence} strom!";
     }
     
     Console.WriteLine(s);
   }

 }
}
