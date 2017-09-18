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
            ////Constants 
            //Console.WriteLine("Please write your username");

            //string userName = Console.ReadLine() + $"{Constants.domain}";

            //Console.WriteLine(userName);

            //Intro to getters and setters 

            Person p1 = new Person("James");

              // p1.Name = "seteve"; // property is read only because there is no setter. 
            p1.DateOfBirth = DateTime.Parse("1991-02-05");

            Console.WriteLine(p1.Age);

            Console.ReadLine();

        }
    }
}
