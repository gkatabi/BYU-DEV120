using System;

class Program
{
    public class Assignment
    {
        protected string _studentName;
        protected string _topic;
    }

    static void Main(string[] args)
    { 
        GetStudentName();
        Console.WriteLine();
    }

    public static string GetStudentName()
    {
        string studentName = "Godfrey";
        string _studentName = studentName;
        return studentName;
        
    }

}