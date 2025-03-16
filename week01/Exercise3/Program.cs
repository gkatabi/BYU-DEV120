using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 68, number;
        Console.WriteLine("Welcome to the magic number game.");
        Console.WriteLine("I have a number between 1 to 100");
        Console.WriteLine("Guess the number");
        int number = Convert.ToInt 32(Console.ReadLine());
        number = 68;

        while (i <= number) i++;
        {
            Console.WriteLine("That is not the number"); number++;

            if (number != 68 && number < 68)
            {
                Console.WriteLine($"Guess higher than{number}");
            }
            else if (number != 68 && number > 68)
            {
                Console.WriteLine("guess lower than" + number);
            }
            else
            {
                Console.WriteLine("you got it");
                Console.Write("Do you want to continue playing the game? ");
            }
        }
    }
}