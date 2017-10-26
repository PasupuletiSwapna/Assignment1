using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    public class Pelican:Bird
    {
        private string beak;
        public string Beak
        {
            get { return beak; }
            set { beak = value; }
        }

        public Pelican(string nam, int wght, int ag,int ws, string bek) : base(nam,wght,ag,ws)
        {
           Beak = bek;
        }


    }
}
