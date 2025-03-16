using System;

class Program
{
    public static string Main()
    {
        Console.WriteLine("What is your grade percentage?");
        string grades = Console.ReadLine();
        float percentage = float.Parse(grades);

        string A = "90";
        string B = "80";
        string C = "70";
        string D = "60";
        string F = "50";

        if (percentage >= "90" && parcentage < "96")
        {
            Console.WriteLine("You got  A");
           else if (percentage >= "96")
            {
                Console.WriteLine("You Passed with A");

            }
        }
        if (percentage >= "80" && percentage < "86")
        {
            Console.WriteLine("You passed with B");
           else
            {
                Console.WriteLine("You passed with  B '+',");
            }
        }

        if (percentage >= "70" && percentage < "76")
        {
            Console.WriteLine("You Passed with in C");
            else
            {
                Console.WriteLine("You passed in C");
                {
                }
                if (percentage >= "60" && percentage < "70")
                {
                    Console.WriteLine("You are in D");
                }
                if (percentage >= 50 && grades < "60")
                {
                    Console.WriteLine("You survived ");
                }
                else if (percentage < "50")
                {
                    Console.WriteLine("You failed with F");
                }
                Console.WriteLine($"Your grade is:   {percentage} ");

                if (percentage >= "70")
                {
                    Console.WriteLine("You passed");

                }
                else if (percentage < "70")
                {
                    Console.WriteLine("Better luck next time");
                }
            }
        }