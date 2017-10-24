using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PersonHandler
    {
         public void SetAge(Person pers, int age)
         {
             pers.Age = age;                                 
         }
     

        public Person CreatePerson(int age1, string fName, string lName,
            float height, float weight)
        {
            Person create = new Person();
            create.Age = age1;
            create.FName = fName;
            create.LName = lName;
            create.Height = height;
            create.Weight = weight;
            return create;

            
            
        }

       
/*
        private List<Person> list = new List<Person>();

        public void CreatePerson(Person create)
        {
            list.Add(create);
        }

        public void List()
        {
            foreach (var create in CreatePerson)
            {
                Console.WriteLine(create);
            }
        }
        
   */


    }



}

