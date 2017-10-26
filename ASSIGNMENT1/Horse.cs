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

        public Horse(string nam, int wght, int ag, int mls) : base(nam, wght, ag)
        {
            Miles = mls;
        }

        public override string Stats()
        {

            string op = base.Stats();
            if (miles <= 17)
            {
                op="This is an average horse walking speed..\n " +op;
            }
            else if ((miles >= 18) && (miles <= 50))
            {
                op= "This is a race horse..\n" +op;
            }
            else if (miles > 50)
            {
                op= "This is an Arabian Horse..\n" +op;
            }
            else
                op= "This is a Standard breed horse..\n" +op;

            return op;

        }

    }
}
