using System;
namespace Mindfulness
{

    class Listing : Activity
    {
        protected string _listedItems = " ";
        protected string _numberOfItems = " ";
    
        public Listing()
        {

        }
    
        public string GetListedItems()
        {
            return _listedItems;
        }

        public void SetListedItems(string listedItems)
        {
            _listedItems = listedItems;
        }

        public string GetNumberOfItems()
        {
            return _numberOfItems;
        }

        public void SetNumberOfItems(string numberOfItems)
        {
            _numberOfItems = numberOfItems;
        }

    }

//    internal class Activity
//    {
//    }
}  
