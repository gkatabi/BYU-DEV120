using System;
namespace Documents
{
    class Journal()
    {
        static void JournaRecordReminder(string[]args)
        {
            Console.WriteLine("These are what stop you from writing in your journal daily");
//      
            Console.Write  (" I forget", " Iam too bizy", "It's useless", " Idon't know how", " It's npne pf your business");
            string numbers = "Mynumber.txt";
            string[] lines = System.IO.File.ReadAllLines(numbers);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string firstnumber = parts[0];
                string lastnumber = parts[4];
            
                Console.WriteLine(line);
            }

            
            Console.WriteLine("Write a number related to why you dont write in it");
            string Reasons = Console.ReadLine();
            // Call for a while loop and a break point in case of irritations
        }

// create the function you will always use to invoke current time

        public static void Time(string[])
        {
            import Time
            time = tim.now();
            return time; 
            
        }        



        static int  SixHourReminder1(num)
        {
            startingTime();
            firstHour + 5;
            {
                
            }
        https://github.com/byui-cse/cse210-ww-student-template    
     
        }

        int SixHourlyReminder2(int)
        {
            Time();
        
            {
                Console.WriteLine("Bip!!!! Bip!!! It's time for journaling");
            }


        }

        public int SixHourlyReminder3(int)
        {
            Time();
            int currentTime = new int Time();
            // if condition which will awaken the alarm
            {
                Console.WriteLine("Bip!!!!1Bip!!! It's time for journaling");
            }
        }
    }
}