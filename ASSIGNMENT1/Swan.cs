using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    public class Swan: Bird
    {
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Swan(string nam, int wght, int ag,int ws, string col) : base(nam, wght, ag,ws)
        {
            Color = col;
        }

        //public override 




    }
}
