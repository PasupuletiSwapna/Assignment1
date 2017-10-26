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



            ///* Animal<string, List<string>> animal = new Animal<string, List<string>>()

            
            //ani.Name = "Gorilla";
            //ani.Weight = 40;
            //ani.Age = 10;






        
            


    }


       // Animal ani = new Animal();

        

        Horse h = new Horse("Horsie",55,12,30);
        Dog d = new Dog("Doggie",10,18,"German Shepard");
        Hedgehog hd = new Hedgehog("Hedgehog",20,25,21);
        Bird b = new Bird("Birdie",8,2,3);
        Flamingo f = new Flamingo("Flamingo bird",80,12,4,6);
        Pelican p = new Pelican("Pelican bird",55,15,6,"longbeak");
        Swan s = new Swan("Swan Bird",60,16,3,"white");

        private List<Animal> animals = new List<Animal>();
        //public void AddAnimal(Animal animal)
        //{
        //    animals.Add(animal);
        //}
       
        public void AnimalList()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine("The Animal name you have added is: " + animal.Stats());
            }
        }



        //private List<Dog> list1 = new List<Dog>();
        //public void Doglist(Dog d1)
        //{
            

            
        //}































    }

       









        }       


   

