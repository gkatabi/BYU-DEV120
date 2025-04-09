using System;
namespace Mindfulness
{

    class Listing : Activity
    {
        protected string _listedItems;
        protected string _numberOfItems;
    
        protected void ListedItems()
        {
            for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("You ");
        }
    
        protected void  ListedItems(string listedItems)
        {
            for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("You "+ listedItems);  
        }

        protected void NumberOfItems()
        {
            for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("A total of ");
            

        }

        protected void NumberOfItems(string numberOfItems)
        {
            for(int e = 10; e > 0; e--)
            {
                    
                Console.Write(">");
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("A total of "+ numberOfItems);
        }

    }    

}


//        public void SetListedItems(string listedItems)
//        {
//            _listedItems = listedItems;
//        }

//        public string GetNumberOfItems()
//        {
//            return _numberOfItems;
//        }

//        public void SetNumberOfItems(string numberOfItems)
//        {
//            _numberOfItems = numberOfItems;
//        }

//    }

//    internal class Activity
//    {
//    }
//}  
