using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    public class Bird : Animal
    {
        private int wingspan;
        public int Wingspan
        {
            get { return wingspan; }
            set { wingspan = value; }
        }
       
        public Bird() { }
        
        //Creating a bird
        /*public Bird(string name, int weight, int age, int wingspan):
            base(name, weight, age)
        {
            Name = "Birdy";
            Weight = 12;
            Age = 3;
            Wingspan = 30;
        }
        */

        //3.3.2 Method calling stats() from Animal to Bird
        public override string Stats()
        {
            return base.Stats() +
                "\nIt has a wingspan of: " + Wingspan + " centimeters.";
        }



    }

}

