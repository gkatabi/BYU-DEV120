using System;
using System.Collections.Generic;
namespace Mindfulne

{
    class Breathe : Activity
    {
        protected string _breathe1 = " ";
        protected string _breathe2 = " ";
    

        public void BreatheOpt1()
        {


            Console.WriteLine("How many seconds  will you spend on each here?");
            string Jiffy = Console.ReadLine();
            int jiffy = Convert.ToInt32(Jiffy);
            for(int e = jiffy; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("Breathe in !!!");
            Console.Write(">");
            Thread.Sleep(6000);
            Console.WriteLine("Breathe out !!!");
            Console.Write(">");
            Thread.Sleep(6000);
        }

        public void BreatheOpt2()
        {
            Console.WriteLine("How many seconds  will you spend on each here?");
            string Jiffy = Console.ReadLine();
            int jiffy = Convert.ToInt32(Jiffy);
            for(int e = jiffy; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("Breathe in !!!");
            Console.Write(">");
            Thread.Sleep(6000);
            Console.WriteLine("Breathe out !!!");
            Console.Write(">");
            Thread.Sleep(6000);

        }

//             space for coding brreathe in
        public string breathe1
        {
            get{return _breathe1;}
            set{_breathe1 = value;}
        }

//            Code breathe out

        public string breathe2
        {
            get{return _breathe2;}
            set{_breathe2 = value;}
        }
    }


    public class Activity
    {
        internal string GetDescription()
        {
            string _description = "Welcome";
            return _description;
        }
    }
}
