using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    class Pelican : Bird
    {
        private string longbeak;

        public string Longbeak
        {
            get
            {
                return longbeak;
            }
            set
            {
                longbeak = value;
            }
        }
    }
}
