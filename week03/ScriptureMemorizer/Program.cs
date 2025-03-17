using System;
using System.Text;
using System.IO;
using System.IO.Compression;
namespace HelloWorld
{
    public class Scripture
    {
        public string _Book;// =" John";

        public int _chapter;// =5;

        public int _Verse;// = 1;



        public string _writeWords;//
        public Scripture()
        {
            _Book = "John";
            _chapter =05 ;
            _Verse = 01 ;
            _writeWords = "After this there was afeast of Jews and Jesus went to Jerusalem";  
        }

    private class Hider
    {
         
        private string _Book(string Book)
        {
            return Book.Replace("John", "_");
        }
//had to convert from int to strings because int would take no replacement
        private string _chapter(string chapter)
        {
            return chapter.Replace("5","_");
        }
        private string Verse(string Verse)
        {
            return Verse.Replace("1","_"); 
        }
        private string writeWords(string writeWords)
        
        {
            return writeWords.Replace("jesus","_");
        } 
    } 
    
    static void Main(string[] args)
    {

        string[] writeWords = { "After ","this ","there ", "was ", "a ","feast ","of ","the ","Jews ","and ","Jesus ","went ","to ","Jerusalem "};
//        List <string> words = new  List <string> ();
        Console.WriteLine("Remind your self what John 5:1 says");
        for (int i = 0; i< writeWords.Length; i++)
        Console.WriteLine(writeWords[i]);
//        Console.WriteLine(writeWords[0]);

///     Try to index so I may dictate what to delete

        Console.WriteLine(writeWords[0]);
        Console.WriteLine(writeWords.Count[-1]);
//        List <string> writeWords = new List <string> ();
 


        

        }
    }     
}

        
//         List <string> writeWords = new List <string> ();
        
    