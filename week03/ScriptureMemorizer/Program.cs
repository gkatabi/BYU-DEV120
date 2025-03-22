using System;
using System.Text;
using System.IO;
using System.IO.Compression;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Concurrent;
using System.Reflection;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
namespace HelloWorld;

    class Scripture
    {
        public static void Memorizer()
        {

        }
            
            private string _book = "John"; 

            private int _chapter = 5 ;

            private static  string _numbers ;

        static void  JoinWords()
        {
            string[] Words; 
        

            
        }
            

        public string JoinNumbers(int first,int second,int third) 
            {
                string numbers  = first + ":" + second + ":" + third ;
                
                return numbers;

            }

    
        }
    public class HideDisplay
    
    {
        public static string  _Display()
        {
            return _book + _chapter + _numbers + _words;
        }
            public static string _book;
            public static int _chapter;
            public static string _numbers;
            

            private static string _words;

        private class  Hide
        {
            private List <string> _hidden = new List <string>();
            public void Replace(string msg)
            {
                _disappear = true;
            }
            
            
            string[] _Menu ={};
        private object _disappear;
    }

    
    
        private static string[] Words = {"After ","this ","there ", "was ", "a ","feast ","of ","the ","Jews ","and ",
            "Jesus ","went ","to ","Jerusalem " ,"Now ","there ", "is ", "at ","Jerusalem ", "by ","the ", "sheep ", "market ",
             "at ","pool ", "which ", "is ","called ", "in ","the ", "Hebrew ","tongue ", "Bethesida ", "having ",
             "five ", "porches "};   
        private static char[] result = _words.SkipLast(1).ToArray();

    

    
        

          
        public static void Main(string[] msg)
        {
//            Scripture book = new Scripture();
//            book.Memorizer();
//            book.Memorizer();
//            D.ExposeDetails();


            HideDisplay D = new HideDisplay();
//            D._Display();



            string[]_book = {"John"};
            string[]_chapter = {"5"};
            string[]_numbers = {"1-2"};


            string[] _words1 = { "After ","this ","there ", "was ", "a ","feast ","of ","the ","Jews ","and ",
            "Jesus ","went ","to ","Jerusalem "} ;                
                
            string[] _words2 = { "Now ","there ", "is ", "at ","Jerusalem ", "by ","the ", "sheep ", "market ",
             "at ","pool ", "which ", "is ","called ", "in ","the ", "Hebrew ","tongue ", "Bethesida ", "having ",
             "five ", "porches "};
            string[] Words = _words1.Concat(_words2).ToArray();
            string[] Words3 = (Words.SkipLast(1).ToArray());
        //    List <string> Words3[] = new  List Words3<string>();
 //           string Words3 = Words.




            Console.WriteLine(Words3);
            for (int i = 0; i< Words3.Length; i++)
            {


                while (i < Words3.Length)
                {
                   Console.WriteLine("Press 4" );
                   string lead = Console.ReadLine();
                   int Lead = Convert.ToInt32(Console.ReadLine());
                   while (Lead > 0)
                   {
                    
                        Console.Write(Words3[i]);
                        Random rdm = new Random();
                        Console.Write(Words3[i].Replace(_words2[i],"_"));
                        Console.Write("") ;                      i++;
                   }
                   Console.Write($"{Words3[i].SkipLast(1).ToArray()}");
                   Console.Write(Words3[i]);
                
                   i++;
                }
            }
        }
    }
