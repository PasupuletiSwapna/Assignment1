using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    public class Animal
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int weight;
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
               
        }

        public Animal()
        {}

        public Animal(string nam, int wght, int ag)
        {
            Name = nam;
            Weight = wght;
            Age = ag;
        }
        public virtual string Stats()
        {
            return "The Animal Name is:" + name + "\n Age is:" + age + "Weight is:" + weight;
        }
    }
}