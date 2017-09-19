using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End.Models
{
    class Person
    {

        //private field
        private string _Name;
        public string Name
        {
            get
            {
                
                
                return _Name;
                
                
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException($"Field {Name} Can not be null or empty");
                }

                value = _Name;
            }
        }

       

        //manually implemented 
        public int Age
        {
            get
            {
                TimeSpan span = DateTime.Now - DateOfBirth;
                return Convert.ToInt32(span.Days / 365);
            }
        }

        

        //auto implemented 

        public DateTime DateOfBirth { get; set; }

     
        //constructor 
        public Person(string name)
        {
            _Name = name;
        }


        #region a Bit harder



        #region properties
        //public DateTime Birthday { get; set; }
        //public List<Person> Children { get; set; }
        //public int Age { get; set; }

        //// public string Name { get; set; }
        ////the above does the exact same as the below
        //private string _Name;
        //public string Name
        //{
        //    get
        //    {
        //        return _Name;
        //    }
        //    set
        //    {
        //        _Name = value;
        //    }
        //}

        //#endregion


        //public string SayName()
        //{
        //    return "My Name is " + this.Name;
        //}

        //public void addOneToAge()
        //{
        //    this.Age = this.Age + 1;
        //    // below is same as above
        //    //this.Age++;
        //}

        //public string GetAllInformation()
        //{
        //    string returnValue = "";
        //    returnValue += "Name: " + this.Name + "\n"; // \n is a new line 
        //    returnValue += "Age: " + this.Age.ToString() + "\n";
        //    returnValue += "Birthday " + this.Birthday.ToString() + "\n";

        //    return returnValue;
        //}

        //public void ChangeName(string newName)
        //{
        //    this.Name = newName;
        //}






        #endregion
        #endregion



        #region HomeWork
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

        UpgradeGrade : takes new average as param and sets equal to ave grade 
        FinishSchool : sets isGraduated to true 
        changeCourse : takes new course as param; updates current course 

        StudentInformation: Returns all information about the student 


        in main, create 5 students and use your methods/properties to set them as objects

        call methods to change course, finish school etc. 

         */

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
