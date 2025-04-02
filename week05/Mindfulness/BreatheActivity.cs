using System;
namespace Programs
{


    public class Breathe: Activity
    {
        protected string _prompt = " ";
        public string _breatheOption =" ";

        public void GetPrompt(string prompt)
        {
            _prompt = prompt;
            
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