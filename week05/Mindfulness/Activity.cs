using System;

class Activity
{
    public string _activityDescription;
    protected int _activityDuration = 3000 ;
    private string _activityBreath ;
    private string _activityEndMessage;
    private string description;
    private string breath;

    public Activity(string breath)
    {
        this.breath = breath;
    }

    //    private int duration;


    public class Breath:Activity
{
    protected string _breath;
    public void BreathOut(string breath)
    {
    }
        public Breath(string breath) : base(breath)
        {
      _breath  = breath;
    } 

}



    public string Get_description()
    {
        _activityDescription = description;
        return _activityDescription;

    }
    public void Set_activityDescription(string description )
    {
        _activityDescription = description;
    

    }
    public  void  GetActivityEndMessage()
    {
        _activityEndMessage = "OK";
        Console.WriteLine("Tell me so");

    }


    public class Listing
    {

    }

    public class duration
    {
    }
}