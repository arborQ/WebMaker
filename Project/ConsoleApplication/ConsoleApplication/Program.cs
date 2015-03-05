using ConsoleApplication.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Calculator v.01");
            Console.WriteLine();
            Console.WriteLine("Add two values");
            Console.WriteLine("Enter value A:");
            var inputA = Console.ReadLine();
            Console.WriteLine("Enter value B:");
            var inputB = Console.ReadLine();
            var calculate = new OperationAdd();
            Console.WriteLine("Result: {0}", calculate.Calculate(inputA, inputB));
        }
    }
}
