using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    class Hedgehog : Animal
    {
        private int numberofspikes;

        public int NumberOfSpikes {
            get { return numberofspikes; }
            set { numberofspikes = value; }
        }

        
    }
}
