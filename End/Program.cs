using End.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace End
{
    class Program
    {
        static void Main(string[] args)
        {

            #region intro


            ////Constants 
            //Console.WriteLine("Please write your username");

            //string userName = Console.ReadLine() + $"{Constants.domain}";

            //Console.WriteLine(userName);


            Console.WriteLine("What is the greatest country the world?");

            string userAnswer = Console.ReadLine();

            if (userAnswer != Constants.greatestCountry)
            {
                Console.WriteLine($"No... {userAnswer} is not the greatest country. The greatest country is {Constants.greatestCountry}");
            }
            else if (userAnswer == Constants.greatestCountry)
            {
                Console.WriteLine("You got that right!");
            }

            else
            {
                Console.WriteLine("What went wrong");
            }

            int weekdays = Constants.daysInWeek - 2;

            Console.WriteLine(weekdays);


            //Intro to getters and setters 

            //Person p1 = new Person("James");

            //Person p2 = new Person("sdf");

            ////p2.Name = null;

            //Console.WriteLine(p2.Name);


            // p1.Name = "seteve"; // property is read only because there is no setter. 
            //p1.DateOfBirth = DateTime.Parse("1991-02-05");

            //Console.WriteLine(p1.Age);

            //Console.ReadLine();

            #endregion

            #region A Bit harder

            Person james = new Person();
            james.Age = 36;
            james.Name = "James";
            DateTime date = DateTime.Parse("1991-02-05");
            james.Birthday = date;
            //below is the same as the above two lines
            //david.Birthday = DateTime.Parse("1979-06-25"); 

            string jamesName = james.SayName();
            Console.WriteLine(jamesName);
            Console.WriteLine(james.Age.ToString());
            james.addOneToAge();
            Console.WriteLine(james.Age.ToString());

            james.ChangeName("super James");

            Console.WriteLine(james.GetAllInformation());


            // below does same as two code lines above. 
            // Console.WriteLine(david.SayName());

            




            // Console.WriteLine(david.Birthday.ToString());




            #endregion

        }
    }
}
