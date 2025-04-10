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
