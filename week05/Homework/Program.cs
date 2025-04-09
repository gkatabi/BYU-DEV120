using System;
namespace Homework
{
    class Student
    {

        public class Students
        {
            public string _firstName ;
            public string _lastName ;

    public class Assignments
    {
        public string _topic;
        public string _assignment;
    }   
//        }
    
        static void Main(string[] args)
        {
            Students student = new Students();
            student.FirstName("Godfrey");
            student.LastName("Katabira"); 

            Assignment maths = new Assignment();
            maths.assignment(" Caliculations,");
            maths.topic(" fumndamentals");             
        }

            private void LastName(string lastName)
            {
                Console.WriteLine(", "+ lastName);   
            }

            private void FirstName(string firstName)
            {
                Console.WriteLine("Mr. "+firstName);    
            }

            private void topic(string topic)
            {
                
            }

            private void assignment(string assignment)
            {
               
            }
        }
    }
}