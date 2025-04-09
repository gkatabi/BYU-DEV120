using System;
using System.Collections.Generic;
namespace Mindfulness

{
    class Breathe : Activity
    {
        protected string _breathe1 ;
        protected string _breathe2 ;
    

        public void Breathebreathe1()
        {

//Call for time count down        
            for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("You can now ");
        }
        
        public void Breathebreathe1(string breathe1)       
        {
            for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("You can now  "+ breathe1);
        }


        public void Breathebreathe2()
        {

            for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("You can now  ");
        }
        
        public void Breathebreathe2(string breathe2)       
        {
            for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("You can now "+ breathe2);
        }

    }

}


//            Console.WriteLine("Breathe in !!!");
//            Console.Write(">");
//            Thread.Sleep(6000);
//            Console.WriteLine("Breathe out !!!");
//            Console.Write(">");
//            Thread.Sleep(6000);
//        }

//        public void BreatheOpt2()
//        {
//            Console.WriteLine("How many seconds  will you spend on each here?");
//            string Jiffy = Console.ReadLine();
//            int jiffy = Convert.ToInt32(Jiffy);
//            for(int e = jiffy; e > 0; e--)
//            {
                    
//                Console.Write(">");
//                Thread.Sleep(1000);
                
//            }
//            Console.WriteLine("Breathe in !!!");
//            Console.Write(">");
//            Thread.Sleep(6000);
//            Console.WriteLine("Breathe out !!!");
//            Console.Write(">");
//            Thread.Sleep(6000);

//        }

//             space for coding brreathe in
//        public string breathe1
//        {
//            get{return _breathe1;}
//            set{_breathe1 = value;}
//        }

//            Code breathe out

//        public string breathe2
//        {
//            get{return _breathe2;}
//            set{_breathe2 = value;}
//        }
//    }


//    public class Activity
//    {
//        internal string GetDescription()
//        {
//            string _description = "Welcome";
//            return _description;
//        }
//    }
//}
