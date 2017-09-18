using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End.Models
{
    class Person
    {

        private string _Name;
        public string Name
        {
            get
            {
                if (_Name == null)
                {
                    
                }
                
                return _Name;
                
                
            }
        }

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

     

        public Person(string name)
        {
            _Name = name;
        }

    }
}
