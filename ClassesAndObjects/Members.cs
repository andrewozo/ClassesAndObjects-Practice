using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Members
    {
        // member - private field
        private string _name;
        private string _jobTitle;
        private int _salary;

        // member - public field
        public int age;

        //member - property - exposes jobtitle safely
        public string JobTitle
        {
            get { return _jobTitle;}
            set { _jobTitle = value; }
        }

        // public member method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi my name is {_name} my job title is {_jobTitle}. I'm {age} years old");
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {_salary}");
        }

        // member constructor

        public Members()
        {
            age = 30;
            _name = "Lucy";
            _salary = 60000;
            _jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor
        ~Members()
        {
            //cleanup statements
            Console.WriteLine("Deconstruction of Members object");
        }

    }
}
