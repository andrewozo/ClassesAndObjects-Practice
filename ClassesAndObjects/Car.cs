using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Car
    {
        private string name;

        public Car(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name} was created");
        }

        public void Drive()
        {
            Console.WriteLine($"{this.name} is Driving");
        }

        public void Stop()
        {
            Console.WriteLine($"{this.name} is Stopped");
        }
    }
}
