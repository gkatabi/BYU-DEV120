
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
namespace VideoTracker;
 public class Video
    {
        public string _title = "";

        public string _author = "";

        public string _length = " ";

     //   Video video = new Video(); 
        string video1_title  = "The money man Owes God";
        string video1_Author = "Bruchagger";
        int video1_length    = 230;

        public Video()
        {

        }
        public void ShowvideoCritics()
        {
            Console.Write($"{video1_title}\n{video1_Author}\n{video1_length }");
               
        } 

        public class Comments
        {
            public string _name = " "; 

            public string _comments =" ";

            public string _numberOfComments = " ";

    //        Comment coment = new Comment(); 
            string _name1 = "";
            string _name2 = "" ;     
            string _comments1 = " slow nbit nice";
            string _comments2 = " cool movie";
            
            
            
            public Comments()
            {

            }
            public void ShowComments()
            {
                Console.Write($"{_name1} {_comments1}\n {_name2} {_comments2}");
            }
        }
        public class Count
        {
            public string _allComments = " ";
            public Count()
            {

            }
            public void ShowNumberOfComments()
            {
                Console.WriteLine("They were: ");
            }
                    static void Main(string[] arg)
        {
            Video video = new Video();
        
            Video _title = new Video();
            string _title1  = "Why Cub drivers park near the bush";
            string _author1 = "Long Foot";
            int _length1 = 2344;
            Console.WriteLine($"On your video\n1: {_title1}\nBy {_author1}\nOf length {_length1} Seconds");   
            
            Comments _comments = new Comments();
            string _name = "Linda";
            string _comment1   = "Knock it off?";  
            Console.WriteLine($"{_name}Commented:\n{_comment1}");

            string _title2  = "Why Cub drivers park near the bush";
            string _author2 = "Long Foot";
            int _length2 = 2344;
            Console.WriteLine($"On your video\n2: {_title2}\nBy {_author2}\nOf length {_length2} Seconds");   
            
            Comments _comments2 = new Comments();
            string _name1 = "Gerald";
            string _comment3   = "Why is it so long?";  
            Console.WriteLine($"{_name1}Commented:\n{_comment3}");

            string _title3  = "When My Mother Left Me";
            string _author3 = "Frost Redboots";
            int _length3 = 2534;
            Console.WriteLine($"On your video\n3: {_title3}\nBy {_author3}\nOf length {_length3} Seconds");   
            
            Comments _comments3 = new Comments();
            string _name3 = "Racheal";
            string _comment4   = "Sell it not needed?";  
            Console.WriteLine($"{_name3}Commented:\n{_comment4}");
            string _title4  = "Big bat";
            string _author4 = "Preasley Elvis";
            int _length4 = 2734;
            Console.WriteLine($"On your video\n3: {_title4}\nBy {_author4}\nOf length {_length4} Seconds");   
            
            Comments _comments5 = new Comments();
            string _name4 = "Racheal";
            string _comment6   = "Sell it not needed?";  
            Console.WriteLine($"{_name4}Commented:\n{_comment4}");


            Video myVideo =  new Video();
            myVideo._title = "True Roads to Africa";
        }
        
    }
}
 