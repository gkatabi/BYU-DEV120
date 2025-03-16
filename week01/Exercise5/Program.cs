using System;

class Program
{
   static void Main(string[] args)
   {
      Console.WriteLine("Welcome to the program!");
      Console.Write("Please enter your name: ") ;
      string name = Console.ReadLine();
      Console.Write($"{name}") ;
   }
}
   static int SquaredNumber(int Number)
   {
      Console.WriteLine("Please enter your favorite number! ");
      string number = Console.ReadLine();
      int New = Convert.ToInt32(number);
      double SquaredNumber = New * New;                
      return SquaredNumber;
            
    }
}            
