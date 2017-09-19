using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End.Models
{
    class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<Student> Students { get; set; }



        /// Methods / Functions

        public string GetSchoolInfo()
        {
            return this.Name + " " + this.Address + " " + this.PhoneNumber + Environment.NewLine;

        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public string GetAllStudents()
        {
            string returnValue = "";

            foreach (Student stu in this.Students)
            {
                returnValue += stu.StudentInformation();
            }
            return returnValue;
        }

    }
}
