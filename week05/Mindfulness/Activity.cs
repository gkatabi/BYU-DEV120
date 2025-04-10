using System;
using System.Data;
namespace Mindfulness
{

    public class Activity
    {
       protected int _duration = 15;
       protected string _description = " ";
       protected string[] _activities;//  = ["1). The breathing actiity ","2). The reflection activity ","3). The listing activity"];
    
       protected int _timePause =10;
       protected string _endMessage;


       protected void Duration()
       {
           for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
           Console.WriteLine("For only ");
       }
       protected void Duration(string duration)
       {
           Console.WriteLine("For only "+ duration);
       }

       protected void Description()
       {
           for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
           Console.WriteLine("Not more than ");
       }
       protected void Description(string description)
       {
           for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
           Console.WriteLine("Not more than "+ description);
       }

       protected void Activities()
       {
           for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
           Console.WriteLine("So there is a ");
       }
       protected void Activities(string activities)
       {
           for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
           Console.WriteLine("So we have a "+ activities);
       }

       protected void TimePause()
       {
           for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
           Console.WriteLine("Let's pause seconds ");
       }
       protected void TimePause(string timePause)
       {
           for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
           Console.WriteLine("Let's pause for seconds "+ timePause);

       }

       protected void EndMessage()
       {
           for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
           Console.WriteLine("Time is up ");
       }
       protected void EndMessage(string endMessage)
       {
           for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
           Console.WriteLine("Time is up "+ endMessage);
       }
    }
}    

