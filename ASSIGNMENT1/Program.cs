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
            Person per = new Person();
            
            Console.WriteLine("Enter your age:",per.Age);
            int Age=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your first name:");
             string FName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string LName = Console.ReadLine();


            string str = "Here is your full name: " + FName + LName;
            Console.WriteLine(str);

            Console.WriteLine("Enter your height:");
            float Height = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Weight:");
            float Weight = float.Parse(Console.ReadLine());

            Personhandler ph = new Personhandler();
            ph.CreatePerson(Age, FName, LName, Height, Weight);
            








            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();





        }

       









        }

        }


   

