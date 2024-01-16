using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Car
    {
        private string _name;
        private int _hp;
        private string _color;

        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "red";
        }

        public Car(string name, int hp = 0, string color = "White")
        {
            _name = name;
            Console.WriteLine($"{_name} was created");
            _hp = hp;
            _color = color;
        }

        public void SetName(string name)
        {
            _name = name == "" ? "DefaultName" : name;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetHp()
        {
            return _hp;
        }

        public void Drive()
        {
            Console.WriteLine($"{_name} is Driving");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} is Stopped");
        }

        public void Details()
        {
            Console.WriteLine($"The {_color} {_name} has {_hp} Horsepower");
        }
    }
}
