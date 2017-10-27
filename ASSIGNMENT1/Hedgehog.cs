using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    public class Hedgehog:Animal
    {
        private int noofspikes;
        public int NoOfSpikes
        {
            get { return noofspikes; }
            set { noofspikes = value; }
        }

        //Creating a hedgehog
        /*public Hedgehog(string name, int weight, int age, string noofspikes):
            base(name, weight, age)
        {
            Name = "Harry";
            Weight = 40;
            Age = 3;
            NoOfSpikes = 200;
        }
        */


        //3.3.2 Method calling stats() from Animal to Hedgehog
        public override string Stats()
        {
            return base.Stats() +
                "\nIt has " + NoOfSpikes + " spikes";
        }






    }
    }

