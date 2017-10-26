using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    class Swan : Bird
    {
        private string colour;

        public string Colour {
            get {
                return colour;
            }
            set {
                colour = value;
            }
        }

    }
}
