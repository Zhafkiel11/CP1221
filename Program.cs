using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESGUERRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter LastName: ");
            String a1 = Console.ReadLine();
            Console.WriteLine("Enter FirstName: ");
            String a2 = Console.ReadLine();
            Console.WriteLine("Enter MiddleName: ");
            String a3 = Console.ReadLine();
            Console.WriteLine("Enter Address:");
            String b = Console.ReadLine();

            Console.WriteLine("- - - - - - - - - - - ");
            Console.ReadLine();

            Console.WriteLine("Student: " + a1+", " +" "+ a2 +" "+ a3);
            Console.ReadLine();
            Console.WriteLine("Address: " + b);
            Console.ReadLine();


        }
    }
}
