using System;
using System.Text;
using System.IO;
using System.IO.Compression;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Concurrent;
using System.Reflection;
namespace HelloWorld;

    class Scripture
    {
        public static void Memorizer()
        {
            Console.WriteLine("ok");
        }

        
            private string _book = "john"; 

            private int _chapter = 5 ;
            
            

            
        
        public string GetVerses() 
            {
                string firstVerse = "1";
                string secondVerse ="2";
                return firstVerse + ":" + secondVerse;

            }

            
        public static void Main(string[] msg)
        {
            string[]_book = {"John"};
            string[]_chapter = {"5"};
            string[]_verse = {"1-2"};


            string[] _firstWords = { "After ","this ","there ", "was ", "a ","feast ","of ","the ","Jews ","and ","Jesus ","went ","to ","Jerusalem "} ;                
                
            string[]_secondWords = { "Now ","there ", "is ", "at ","Jerusalem ", "by ","the ", "sheep ", "market ", "at ","pool ", "which ", "is ","called ", "in ","the ", "Hebrew ","tongue ", "Bethesida ", "having ","five ", "porches ","."};
            string[] Words = _firstWords.Concat (_secondWords).ToArray();
            foreach(string  word in Words)
            Console.Write(Words);

            Console.WriteLine($"Truth can be remembered even without seeing."  );
            Console.WriteLine("Let's see if you can remember  it without seeing it");

            Words[9] ="_" ;
            foreach (string word in Words)
            {
                Random rnd = new Random();
                Console.Write(word);
            }
   
        }
    }
            



//                Console.Write($"{writeWords2}");
//                Random rdm = new Random();
//                Console.Write(writeWords.Replace("went","_"));
//                Console.Write($"{writeWords2}");
//            }





            
    

        
//        }

//        private class HideWords()
//        {
//            Console.Write($"Words")
////        }



              


//        public static string Instructions()
//        {
//            Console.WriteLine("Please enter your {0} ", );
//            Console.WriteLine("Please enter your {0} ", );
//            Console.WriteLine("Please enter your {0} ", );
//            Console.WriteLine("Please enter your {0} ", );
//            Console.WriteLine("Please enter your {0} ", );
//            return "";
            
//        public static class Join
//        {
//            public void _Verses (int Numbers);
//            {
//                _Verses.Cocat(Verses)
//            } 

//        }

            
            


//        }


        
//        public static class Hide

//        {
//            Book = "";

//            Chapter = "";

//            Verse = ;
//            {
//                start = ;

//                end = ;
//            }




             

//        }



//        static string words()

















//        public string _Book;// =" John";

//        public int _chapter;// =5;

//        public char _colon;

//        public int _Verse;// = 1;



//        public string _writeWords;
//        public Scripture()        {
//            _Book = "John";
//            _chapter =05 ;
//            _Verse = 01 ;
//            _writeWords = "_";  
//        }

//    public class Hider

//    { 
//        public string _Book(string Book)
//        {
 //           return ("John");
//        }
//        public int _chapter(string chapter)
//        {
//            return (5);    
//        }
//        public string Verse(string Verse)
//        {
//            return Verse.Replace("1","_"); 
//        }
//        public void writeWords(string writeWords)
        
        
//        {
//            Console.Write(writeWords.Replace("Jerusalem","_"));
//            List <char> writeWords2 = new List <char>();
            
//            {

//                Console.Write($"{writeWords2}");
//                Random rdm = new Random();
//                Console.Write(writeWords.Replace("went","_"));
//                Console.Write($"{writeWords2}");
//            }
//        }                
//            private void List<T>(object v)
//            {
//                throw new NotImplementedException();
//            }

//        } 
    
//    static void Main(string[] args)
//    {


//        string[] writeWords = { "After ","this ","there ", "was ", "a ","feast ","of ","the ","Jews ","and ","Jesus ","went ","to ","Jerusalem "};

//        Console.WriteLine("Remind your self what John 5:1 says");
//        for (int i = 0; i< writeWords.Length; i++)
//        Console.Write(writeWords[i]);
//        }
//    }     
//}
