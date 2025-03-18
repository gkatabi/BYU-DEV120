using System;
using System.Text;
using System.IO;
using System.IO.Compression;
using Microsoft.VisualBasic;
namespace HelloWorld
{
    public class Scripture
    {
        public string _Book;// =" John";

        public int _chapter;// =5;

        public char _colon;

        public int _Verse;// = 1;



        public string _writeWords;
        public Scripture()
        {
            _Book = "John";
            _chapter =05 ;
            _Verse = 01 ;
            _writeWords = "After this there was afeast of Jews and Jesus went to Jerusalem";  
        }

    public class Hider

    { 
        public string _Book(string Book)
        {
            return ("John");
        }
        public int _chapter(string chapter)
        {
            return (5);    
        }
        public string Verse(string Verse)
        {
            return Verse.Replace("1","_"); 
        }
        public void writeWords(string writeWords)
        
        
        {
            Console.Write(writeWords.Replace("Jerusalem","_"));
            List <char> writeWords2 = new List <char>();
            
            {

                Console.Write($"{writeWords2}");
                Random rdm = new Random();
                Console.Write(writeWords.Replace("went","_"));
                Console.Write($"{writeWords2}");
            }
        }                
            private void List<T>(object v)
            {
                throw new NotImplementedException();
            }

        } 
    
    static void Main(string[] args)
    {


        string[] writeWords = { "After ","this ","there ", "was ", "a ","feast ","of ","the ","Jews ","and ","Jesus ","went ","to ","Jerusalem "};

        Console.WriteLine("Remind your self what John 5:1 says");
        for (int i = 0; i< writeWords.Length; i++)
        Console.Write(writeWords[i]);
        }
    }     
}
