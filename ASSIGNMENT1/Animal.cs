using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    class Animal
    {
        private string name;
        private int weight;
        private int age;
        //2.properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public int Age
        {
            get {
                return age;
            }
            set {
                age = value;
            }
        }

//3.2.3 Empty Constructor
        public Animal()
        { }

       

    }

    }

