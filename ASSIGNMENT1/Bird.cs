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
        public int Wingsspan
        {
            get { return wingspan; }
            set { Wingsspan = value; }
        }

        public Bird(string nam, int wght, int ag, int ws) : base(nam, wght, ag)
        {
            Wingsspan = ws;

        }



        public override string Stats()
        {
            string op = base.Stats();
            {
                if (wingspan < 3)
                {
                    Console.WriteLine("This bird has a short wingspan..\n");
                }
                else
                    Console.WriteLine("This bird has a giant wingspan..\n");
                return op;
            }
        }

    }
}

