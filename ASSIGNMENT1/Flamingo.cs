using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    public class Flamingo:Bird
    {
        private int tall;
        public int Tall
        {
            get { return tall; }
            set { tall = value; }
        }
        public Flamingo(string nam, int wght, int ag,int ws, int tall) : base(nam, wght, ag, ws)
        {
           Tall=tall;
        }
    }
}
