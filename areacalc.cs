using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine(areaRectangle(4,5));
        Console.WriteLine(areaCircle(4));
        Console.WriteLine(areaTriangle(10,9));
      double totalArea = areaRectangle(1500,2500)+ areaTriangle(750,500)+ areaCircle(375)/2;
      double totalCost = totalArea*180;
      Console.WriteLine("Total cost of Floor is:  "+ totalCost);
    }
    static double areaRectangle(double length,double width){
      return length* width;

    }
    static double areaCircle(double radius){
      return Math.Floor(Math.PI*Math.Pow(radius,2));
    }
    static double areaTriangle(double bottom,double height){
      return 0.5* bottom*height;

    }
  }
}
