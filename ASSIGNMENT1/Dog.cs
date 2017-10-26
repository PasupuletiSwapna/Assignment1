using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    public class Dog:Animal
    {
        private string breed;
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public Dog(string nam, int wght, int ag, string brd) : base(nam, wght, ag)
        {
            Breed=brd;

        }
        public override string Stats()
        {
                  return this.GetType().Name + base.Stats() + "\n The dog's breed is" + breed;

        }
    }
}
