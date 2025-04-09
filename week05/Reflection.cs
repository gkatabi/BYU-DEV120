using System;
using System.Collections.Generic;
namespace Mindfulness
{

    class Reflection : Activity
    {
        protected string _randomOpt;
        protected string _reflect;
    
        protected void ReflectionrandomOpt()
        {
            for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("So ");
        }



            

        protected void ReflectionrandomOpt(string randomOpt)
        {
            Console.WriteLine("So "+ randomOpt);
        }

        protected void Reflectionreflect()
        {
            for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("So ");

        } 

        protected void Reflectionreflect(string reflect)
        {
            Console.WriteLine("So "+ randomOpt);
        }

    }
}

//        }
//        public Reflect()
//        {
//            Console.WriteLine("How many seconds do you want to spend?");
//            string Wish1 = Console.ReadLine();
//            int wish1 = Convert.ToInt32(Wish1);
//            if (wish1 == 2)
//                Console.WriteLine("Welcome to the reflection activity.\nThe activity will train you to reflect for a while.\nHow many seconds would you want to take on each step? ");
//                string Interval1 = Console.ReadLine();
//                int interval1 = Convert.ToInt32(Interval);
//                for(int e = interval1; e > 0; e--)
//                {
                    
//                    Console.Write(">");
//                    Thread.Sleep(1000);
                
//                }
//                Console.WriteLine("Think of a time when you stood up for someone else.");
//                Console.Write(">");
//                Thread.Sleep(6000);
//                Console.WriteLine("Think of a time when you did something really difficult.");
//                Console.Write(">");
//                Thread.Sleep(6000);
//                Console.WriteLine("Think of a time when you helped someone in need.");
//                Console.Write(">");
//                Thread.Sleep(6000);
//                Console.WriteLine("Think of a time when you did something truly selfless.");
//                Console.Write(">");
//                Thread.Sleep(6000);
//                Console.WriteLine("Well done");
//        public RandomOpt()
//         public class RandomOpt: Reflction
//        {
//            public static List<RandomOpt> SelectRandomElements<RandomOpt>(List<RandomOpt> list, int n)
//            {
//                RandomOpt randomOPt = new RandomOpt();
//                List<RandomOpt> selectedItems = new List<RandomOpt>();

//                for (int i = 0; i < n; i++)
//                {
//                    if (list.Count == 0) break;  
//                    int index = randomOpt.Next(list.Count);  
//                    selectedItems.Add(list[index]);
//                    list.RemoveAt(index);  
//                }
//        
//                return selectedItems;
//            }

                                
//                Reflection reflect = new Reflection();
                 
//                Thread.Sleep( 6000);
//                string _reflect = reflect.GetReflect();
//                Console.WriteLine(reflect);
//                Thread.Sleep(6000);
//            }


//            Console.WriteLine("You are welcome to the reflection activity.The breathing activity,\nallows you to reflect on ambitions .");
//            Thread.Sleep(3000);
//            Console.WriteLine("Write the number that refers to the activity of your wish");
//            string Wish1 = Console.ReadLine();
//            int wish1 = Convert.ToInt32(Wish1);
//            if (wish1 == 2)
//            {
//                Console.WriteLine("Get ready.\nThe activity will train  you reflect on acheivements.\nHow many seconds do you wish to take reflecting? ");
//                string Interval1 = Console.ReadLine();
//                int interval1 = Convert.ToInt32(Interval1);
//                for(int e = interval1; e > 0; e--)
//                {
                    
//                    Console.Write(">");
//                    Thread.Sleep(1000);
                
//                }
//                Console.WriteLine("Why was this experience meaningful to you?");
//                Console.Write(">");
//                Thread.Sleep(6000);
//                Console.WriteLine("Have you ever done anything like this before?");
//                Console.Write(">");
//                Thread.Sleep(6000);
//                Console.WriteLine("How did you get started?");
//                Console.Write(">");
//                Thread.Sleep(6000);
//                Console.WriteLine("How did you feel when it was complete?");
//                Console.Write(">");
//                Thread.Sleep(6000);
//                Console.WriteLine("What made this time different than other times when you were not as successful?");
//                Console.Write(">");/
//                Thread.Sleep(6000);
//                Console.WriteLine("What is your favorite thing about this experience?");
//                Console.Write(">");
//                Thread.Sleep(6000);
//                Console.WriteLine("What could you learn from this experience that applies to other situations?");
//                Console.Write(">");
//                Thread.Sleep(6000);
//                Console.WriteLine("What did you learn about yourself through this experience?");
//                Console.Write(">");
//                Thread.Sleep(6000);


//                Console.WriteLine("Weldone")
//            }
//        }
//        public class RandomPrompt: Reflction
//        {
//            public static List<RandomPrompt> SelectRandomElements<RandomPrompt>(List<RandomPrompt> list, int n)
//            {
//                Random random = new Random();
//                List<RandomPrompt> selectedItems = new List<RandomPrompt>();

//                for (int i = 0; i < n; i++)
//                {
//                    if (list.Count == 0) break;  
//                    int index = random.Next(list.Count);  
//                    selectedItems.Add(list[index]);
//                    list.RemoveAt(index);  
//                }
 //       
 
//                return selectedItems;
//            }
//        }
//        public string GetRandomPrompt()
//        {
//            return _randomPrompt;
//        }

//    public RandomPrompt()

//    }
//    public void (string[]args)
//    {
//        Console.WriteLine("Ok");
//    }

//}  
