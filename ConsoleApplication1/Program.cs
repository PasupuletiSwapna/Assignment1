using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pers = new Person();           

            //    var added = true;

            //    do
            //    {
            //        added = CreatePerson(pers);
            //    }
            //    while (added);

            //    Console.WriteLine("=========================");

            //}   

            Console.WriteLine("Enter your Name: ");
            var fName = Console.ReadLine();

            Console.WriteLine("Enter your Surname: ");
            var lName = Console.ReadLine();
            
            Console.WriteLine("Enter your Age: ");
            int age1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Height: ");
            var height = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Weight: ");
            var weight = float.Parse(Console.ReadLine());

            var ph = new PersonHandler();
            ph.CreatePerson(age1, fName, lName, height, weight);

            Console.WriteLine("FullName: " +fName+" "+lName+", " +"Age: "+age1+", "
                +"Height: "+height+", " +"Weight: "+weight);
            Console.ReadLine();
        }
    }
}

