using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter operand");
            string ope = Console.ReadLine();

            Console.WriteLine("enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (ope == "+")
            {
                Console.WriteLine(" the answer is = " + (num1 + num2));
            }
            else if(ope == "-")
            {
                Console.WriteLine(" the answer is = " + (num1 - num2));
            }
            else if (ope == "*")
            {
                Console.WriteLine(" the answer is = " +(num1 * num2));
            }
            else if (ope == "/")
            {
                Console.WriteLine(" the answer is = "+ (num1 / num2));
            }
            else
            {
                Console.WriteLine(" the operand not found");
            }

            //freeze line
            Console.ReadLine();
        }
    }
}
