
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
namespace VideoTracker;
 public class Video
    {
        public string _title = " ";

        public string _author =" ";

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


        static void Main(string[] args)

    //        Console.WriteLine($"Viewers had these comments on{_title2}: ");
    //        Console.WriteLine ($"{_comment2}");
    //        Console.WriteLine($"Viewers had these comments on{_title3}: ");
    //        Console.WriteLine ($"{_comment3}");
    //        Console.WriteLine($"Viewers had these comments on{_title4}: ");
    //        Console.WriteLine ($"{_comment4}");
    //"actors, pls consider fathers too","Nice to watch with my kids"];
    //    string[] _comment3     = ["I love Irene", "He is a very patient father","I wish all rich men are a Godfrey","Would have gone for the classy Cornereah!!!"];
    //    string[] _comment4     = ["Stupid fly burried on a cacus###", "What a pain","That was too much....for him","I need one of such heart broken men"];

        {
            Video video = new Video();
        
            Video _title = new Video();
            string _title1  = "Why Cub drivers park near the bush";
            string _author1 = "Long Foot";
            int _length1 = 2344;
            Console.WriteLine($"On your video\n{_title1}\nBy {_author1}\nOf length {_length1} Seconds");   
            
           Comments _comments = new Comments();
           string _name = "Gerald";
           string _comment1   = "Why is it so long?";  
           Console.WriteLine($"{_name}Commented:\n{_comment1}");


           Video myVideo =  new Video();
           myVideo._title = "True Roads to Africa";
           
           
           
           

        }
        
    }
}
 