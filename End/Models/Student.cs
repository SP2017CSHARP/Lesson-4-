using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End.Models
{
    class Student
    {
        #region properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string CurrentCourse { get; set; }
        public double AveGrade { get; set; }
        public bool IsGraduated { get; set; }
        public string FavoriteTeacher { get; set; }

        #endregion


        public void UpgradeGrade(double newAverage)
        {
            this.AveGrade = newAverage;
        }


        public void FinishSchool()
        {
            this.IsGraduated = true;
        }

        public void ChangeCourse(string newCourse)
        {
            this.CurrentCourse = newCourse;

        }

        public string StudentInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine(this.CurrentCourse);
            sb.AppendLine(this.Age.ToString());
            sb.AppendLine(this.AveGrade.ToString());
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();

            return sb.ToString();

            // above is similar to below. Different method of adding
            // strings together
            //string something = "";
            //something += "text";
            //something += "text";
            //something += "text";

            //test

        }

       
    }
}
