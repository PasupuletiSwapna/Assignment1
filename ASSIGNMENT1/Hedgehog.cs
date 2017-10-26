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

        public Hedgehog(string nam, int wght, int ag, int nos) : base(nam, wght, ag)
        {
            NoOfSpikes = nos;
        }
        public override string Stats()
        {
            string op = base.Stats();
            if (noofspikes <= 20)
            {
                op = "Hedgehog has less spikes" + op;
            }
            else
            {

                op = "Hedgehog has lot of spikes" + op;
            }
            return op;
        }







    }
    }

