using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    public class Personhandler
    {

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
            
        }

        public Person CreatePerson(int age1, string fName, string lName, float height, float weight)
        {

            Person per1 = new Person();
            per1.Age = age1;
            per1.FName = fName;
            per1.LName = lName;
            per1.Height = height;
            per1.Weight = weight;
            return per1;


        }
               



            
        }

    }

