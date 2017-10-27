using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    public class Dog:Animal
    {
        private string breed;
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        //Creating a dog
        /*public Dog(string name, int weight, int age, string breed):
            base(name, weight, age)
        {
            Name = "Doggie";
            Weight = 30;
            Age = 9;
            Breed = "husky";
        }
        */


        //3.3.2 Method calling stats() from Animal to Dog
        public override string Stats()
        {
            return base.Stats() +
                "\nIt is a " + Breed + " breed";
        }


    }
}
