using System;
namespace Mindfulness
{

    class Reflection : Activity
    {
        protected string _randomPrompt = " ";
        protected string _reflect = "Think of a time when you stood up for someone else ";
    
        public Reflection()
        {
            Cobsole.WriteLine("OK");

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
    public void (string[]args)
    {
        Console.WriteLine("Ok");
    }

}  
