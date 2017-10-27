using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = CreateAnimals();
            List(animals);

            List<Dog> dogs = CreateDogs();
            List(dogs);
        }

        private static List<Animal> CreateAnimals()
        {
            Animal dog = new Animal("Doggie", 30, 9);
            Animal horse = new Animal("Horsey", 210, 5);
            Animal hedgehog = new Animal("Harry", 40, 3);
            Animal bird = new Animal("Birdy", 12, 3);
            List<Animal> animals = new List<Animal>();

            animals.Add(horse);
            animals.Add(hedgehog);
            animals.Add(dog);
            animals.Add(bird);
            return animals;
        }
       
        public static void List(List<Animal> animals)
        {
            foreach (var item in animals)
            {
                Console.WriteLine(item.Stats());               
            }
            Console.ReadLine();
        }

        public static void List(List<Dog> dogs)
        {
            foreach (var item in dogs)    
            {
                Console.WriteLine(item.Stats());
            }
            Console.ReadLine();
        }


    }

}





//}
//            Person per = new Person(); //created person class instance
//            var added = true;
//            do {

//                added = Addperson(per);
//            } while (added);

//}
//        private static bool Addperson(Person per)
//        {
//            Console.WriteLine("Enter your age:");
//            int Age = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter your first name:");
//            string FName = Console.ReadLine();

//            Console.WriteLine("Enter your last name:");
//            string LName = Console.ReadLine();


//            string str = "Here is your full name: " + FName + LName; //concatinating the strings
//            Console.WriteLine(str);

//            Console.WriteLine("Enter your height:");
//            float Height = float.Parse(Console.ReadLine());

//            Console.WriteLine("Enter your Weight:");
//            float Weight = float.Parse(Console.ReadLine());

//            Personhandler ph = new Personhandler();           //created personhandler class instance
//            ph.CreatePerson(Age, FName, LName, Height, Weight);  //calling the person objects using instance of person handler


//            return true;
//        }




