using Start.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constants

            //Console.WriteLine("Please Write your first and last name, no space");

            //string userName = Console.ReadLine() + $"{Constants.domain}";

            //Console.WriteLine($"UserName is: {userName}");

            //Write a program that asks users what the greatest country in the world is, then 
            //checks the user value against your constant for greatest country, tell them if they 
            //were correct and if they are wrong, correct them. 

            //Console.WriteLine("What is the greatest country?");

            //string userAnswer = Console.ReadLine();

            //if (userAnswer != Constants.greatestCountry)
            //{
            //    Console.WriteLine($"Noo.... {userAnswer} is not the greatest. Its {Constants.greatestCountry}");
            //}

            //else if (userAnswer == Constants.greatestCountry)
            //{
            //    Console.WriteLine("Correct");
            //}
            #endregion

            //Write out to the console how many weekdays there are using your constant for days of the week 

            //int weekDays = Constants.daysInTheWeek - 2;
            //Console.WriteLine(weekDays);

            #region IntroToClassesGettersAndSetters

            //Person p1 = new Person("James");

            //Console.WriteLine(p1.Name);

            //set the date of birth property for p1 then print their age to the console 

            //console.WriteLine("Input dob, format: YYYY-MM-DD");
            //p1.DateOfBirth = d


            //p1.DateOfBirth = DateTime.Parse("1991-02-05");

            //Console.WriteLine(p1.Age);

            #endregion

            #region MoreInterestingPerson

            //Person james = new Person();

            //james.Age = 26;

            //james.Name = "James";

            ////DateTime date = DateTime.Parse("1991-02-05");
            ////james.Birthday = date;

            //james.Birthday = DateTime.Parse("1991-02-05");

            ////Console.WriteLine(james.SayName());
            //james.addOneToAge();
            ////Console.WriteLine(james.Age);


            //james.ChangeName("SuperJames");

            ////Console.WriteLine(james.Name);

            //Console.WriteLine(james.GetAllInformation());




            #endregion

            #region InClass/Homework 
            //Create a project with two classes: Student; School

            //Students: 
            //Should have the following fields, properties and methods: 
            /* 

            public string Name { get; set; }
            public int Age { get; set; }
            public string CurrentCourse { get; set; }
            public double AveGrade { get; set; }
            public bool IsGraduated { get; set; }
            public string FavoriteTeacher { get; set; }

            ----methods: 

            //Make a constructor to create new students with all properties filled in 


            UpgradeGrade : takes new average as param and sets equal to ave grade 
            FinishSchool : sets isGraduated to true 
            changeCourse : takes new course as param; updates current course 

            StudentInformation: Returns all information about the student 


            in main, create 5 students and use your methods/properties to set them as objects

            call methods to change course, finish school etc.
            
            
        //School 

        //Props
        /*
          public string Name 
        public string Address 
        public string PhoneNumber 
        public List<Student> Students */


            //Methods

            //GetSchoolInfo() return school info neatly formated 
            //AddStudent() add a Student to your students list prop 
            //GetAllStudentInfo return all students and their information neatly formatted 


            //create a 2 schools, add students to it, run your other methods 


#endregion






        }
    }
}
