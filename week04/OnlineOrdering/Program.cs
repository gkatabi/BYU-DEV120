using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
namespace VideoTracker
 public class Vedeo
    {
        public string _title = " ";    //"Big bookings", "Where Mammy wasn't", "The debt man owes God", "Learn to let go");

        public string _author =" ";

        public string _length = " ";

//              Space for returning
        public Vedeo()
        {
            
        }


//      Since it's public lets display
        public void Show_title()
        {
            Console.Write($"{_title}");

        }
        public void Show_author()
        {
            Console.Write($"{_author}");
        }
        public void Show_length()
        {
            Console.Write($"{_length}");
        }

    }
    public class  Comment
    {
        public string[] _name = new string[0];

        public string[] _comment = new string[0];

        public int[] _numberOfComments = new int[0];  


        public Comment()
        {
            
        } 
        public static void Show_name()
        {
            Console.Write(" ");
        }
        public static void Show_comment()
        {
            Console.Write(" ");
        }


        public static void Show_numberOfComments()
        {
            Console.Write(" ");
        }


    
    
    
    static void Main(string[] args)
    {
        string _title1          = "The money man Owes God";
    //    string _title2          = "Where Mammy wasn't";
    //    string _title3          = "My man Mr.Godfrey";
    //    string _title4          = "Learn to let go";

        
        string[] _comment1     = ["I hate not having a Mom"];//"actors, pls consider fathers too","Nice to watch with my kids"];
    //    string[] _comment3     = ["I love Irene", "He is a very patient father","I wish all rich men are a Godfrey","Would have gone for the classy Cornereah!!!"];
    //    string[] _comment4     = ["Stupid fly burried on a cacus###", "What a pain","That was too much....for him","I need one of such heart broken men"];

    //    List <string> Vedeo   = new List <string>();
        List <string> Comment = new List<string>();
        
        {
            Console.WriteLine($"Viewers  had these comments on{_title1}: ");
            Console.WriteLine ($"{_comment1}");
    //        Console.WriteLine($"Viewers had these comments on{_title2}: ");
    //        Console.WriteLine ($"{_comment2}");
    //        Console.WriteLine($"Viewers had these comments on{_title3}: ");
    //        Console.WriteLine ($"{_comment3}");
    //        Console.WriteLine($"Viewers had these comments on{_title4}: ");
    //        Console.WriteLine ($"{_comment4}");

        }
    }
}
 