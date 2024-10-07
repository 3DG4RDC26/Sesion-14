using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.clases
{
   internal class Operation
   {
      public double Adition(double num1, double num2)
      { return num1 + num2; }
      public double Substrac(double num1, double num2)
      { return num1 - num2; }
      public double Mult(double num1, double num2)
      { return num1 * num2; }
      public double Div(double num1, double num2)
      {
         try
         {
            return num1 / num2;
         }
         catch(Exception ex) 
         { Console.WriteLine(ex.Message); }
         return 0; 
      }
      public double Power(double num1, double num2)
      { return Math.Pow(num1,num2); }
      public double SquareRoot(double num)
      { return Math.Sqrt(num); }
      public string ShutDown()
      {
         return "Adios";
      }
   }
}