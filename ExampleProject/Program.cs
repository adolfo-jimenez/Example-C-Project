using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    class ExampleProject
    {
        static void Main(string[] args)
        {
           static int multiply(int a, int b)
            {
                int result = a * b;
                Console.WriteLine("Good Job");
                return result;
            }

            Console.WriteLine("Hello World! I'm Johnny Knoxville and welcome to C# Programming!");
            Console.WriteLine("Please enter two numbers to test out our multiplication function:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            //Should Print Out correct result in this test case.
            Console.WriteLine(multiply(num1, num2));
    }
    }
}