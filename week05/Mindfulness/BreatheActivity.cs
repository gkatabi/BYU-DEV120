using System;
namespace Mindfulness
{


    public class Breathe
    {
        protected string _prompt = " ";
        public string _breatheOption =" ";

        public void GetPrompt()
        {
            _prompt = _prompt;
            
        }

        public string GetBreathe()
        {
            return _breatheOption;
        }
        public void Set_breatheOption(string breatheOption)
        {
            _breatheOption = breatheOption;
        } 


    }

    
}    