using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What is you first  name?");
        string firstName = Console.ReadLine();


        Console.WriteLine("What is your last name?");
     
        string lastName = Console.ReadLine();
        string names =string.Concat(lastName + " " + firstName);
        Console.Write("Your name is " + firstName + "," + "" + names);
        Console.WriteLine("What is your first name? ");
        string firstNamez = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lastNamez = Console.ReadLine();
        string namez = string.Concat(firstNamez, " ", lastNamez);
        Console.Write("Your name is " + lastNamez + " , " + namez);
    }
}
