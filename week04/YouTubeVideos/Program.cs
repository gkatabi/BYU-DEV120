using System;
using System.Security.Cryptography.X509Certificates;
namespace VideoTracker;

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
        public string _name = " ";

        public string _comment = " ";

        static int _numberOfComments ;  


        public Comment()
        {
            
        } 
        public void Show_name()
        {
            Console.Write(" ");
        }
        public void Show_comment()
        {
            Console.Write(" ");
        }


        public void Show_numberOfComments()
        {
            Console.Write(" ");
        }


    
    
    
    static void Main(string[] args)
    {
        Vedeo vedeo    = new Vedeo();
         Comment comment = new Comment();
        
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }

}
 