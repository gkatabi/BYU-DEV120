using System;
namespace Mindfulness
{

    class Reflection : Activity
    {
        protected string _randomPrompt = " ";
        protected string _reflect = " ";
    
        public Reflection()
        {

        }
    
        public string GetRandomPrompt()
        {
            return _randomPrompt;
        }

        public void SetRandomPrompt(string randomPrompt)
        {
            _randomPrompt = randomPrompt;
        }

        public string GetReflect()
        {
            return _reflect;
        }

        public void SetReflect(string reflect)
        {
            _reflect = reflect;
        }

    }

}  
