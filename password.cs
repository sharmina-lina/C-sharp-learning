using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength =8;
      string uppercase= "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "1234567890" ;
      string specialChars = "!@#$%^&*?<>|";
      Console.WriteLine("Enter Your password ");
      string password = Console.ReadLine();
      int score = 0;
      if ( password.Length >= minLength ) {
        score += 1;
        
      }
      if (Tools.Contains(password,uppercase)){
        score += 1;
       
      }
      if (Tools.Contains(password,lowercase)){
        score += 1;
        
      }

      if (Tools.Contains(password,digits)){
        score += 1;
        
      }
    if (Tools.Contains(password,specialChars)){
        score += 1;
        
      }
Console.WriteLine(score);
switch(score){
  case 5:
    Console.WriteLine("Extremely Strong!");
    break;
  case 4:
    Console.WriteLine("Extremely Strong!");
    break;
  case 3:
    Console.WriteLine("The Password is strong");
    break;
  case 2:
    Console.WriteLine("The password is medium!");
    break;
  case 1:
    Console.WriteLine("The password is weak!");
    break;
  default:
    Console.WriteLine("The password doesn't meet any of the standards!");
    break;
}
    }
  }
}
