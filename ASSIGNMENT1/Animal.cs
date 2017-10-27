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
        { }

        //3.3.4 Constructor to instantiate class with specific parameters
        public Animal(string name, int weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
       
        

        //3.3.1 Method to print stats from any class
        public virtual string Stats()
        {
            return "This is a " + this.GetType().Name +" "+
                "named: " + Name + "." +
                  "\nIt weighs: " + Weight +
                  "\nIt is " + Age + " years old. \n------------------";
            
        }

    }
}   