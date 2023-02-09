using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string x;
            Console.WriteLine("enter first number");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter second number");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the type of task you want:");
            Console.WriteLine("A) jam B) tafrigh C) zarb D) taghsim E) baghimande taghsim F) tavan");
            Console.WriteLine("or press '!' to Exit");
            x = Convert.ToString(Console.ReadLine());
            if (x == "a")
            { Console.WriteLine(a + b); }
            else if (x == "b")
            { Console.WriteLine(a - b); }
            else if (x == "c")
            { Console.WriteLine(a * b); }
            else if (x == "d")
            { Console.WriteLine(a / b); }
            else if (x == "e")
            { Console.WriteLine(a % b); }
            else if (x == "f")
            { Console.WriteLine(Math.Pow(a, b)); }
            else if (x == "!")
            { Environment.Exit(0); }
            else { Console.WriteLine("invalid"); }
            Console.ReadKey();


        }
    }
}
