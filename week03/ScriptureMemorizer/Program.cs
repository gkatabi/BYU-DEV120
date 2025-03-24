using System;
namespace Memorizer;

    class Scripture
    {
        public string _book = " ";
        public string _chapter =  " "; 

        public string _verseStart = " ";
        public string _verseEnd = "";

        public Scripture()
        {

        }
        public void Display_book()
        {
            Console.WriteLine($"{_book}");
        }
        public void Display_chapter()
        {
            Console.WriteLine($"{_chapter}");
        }
        public void Display_verseStart()
        {
            Console.WriteLine($"{_verseStart}");
        }
        public void Display_verseEnd()
        {
            Console.WriteLine($"{_verseEnd}");
        }


    }

    class Reference
    {
        public string _dispensation = " ";

        public Reference()
    
        {
            Console.WriteLine("Ok");
        }
        
        

  

    }


    class Reminder
    {
        public string  _hour = " " ;

        public string _message = " ";

        public Reminder()
        {

        }
        public void Show_hour()
        {
            Console.WriteLine($"{_hour}");
        }

        public void Show_message()
        {
            Console.WriteLine($"{_message}");
        }

    }


    class Hider
    {
        public string _words =" ";
        public string _replacement = "_ ";

        private Hider()
        {

        }
        public void Show_words()
        {
            Console.Write(_words);
        }
        public void Show_replacement()
        {
            Console.Write(_replacement);
        }
    
    static void Main(string[] args)
    {
        List <string> Scripture    = new List<string>();
        List <string> Reference    = new List<string>();
        List <string> Reminder    = new List<string>();
        List <string> Hider    = new List<string>();
        
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }
    
}