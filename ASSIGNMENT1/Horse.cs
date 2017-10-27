using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    public class Horse:Animal
    {
        private int miles;
        public int Miles
        {
            get { return miles; }
            set { miles = value;}
        }

        //Creating a horse
        /*public Horse(string name, int weight, int age, string miles):
            base(name, weight, age)
        {
            Name = "Horsey";
            Weight = 210;
            Age = 5;
            Miles = 80;
        }
        */

        //3.3.2 Method calling stats() from Animal to Horse
        public override string Stats()
        {
            return base.Stats() +
                "\nIt runs " + Miles + " per hour.";
        }






    }
}
