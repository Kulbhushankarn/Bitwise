using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise
{
    internal class Program
    {
        static void Main()
        {

            string userInput;

            userInput = Console.ReadLine();
            int a = Convert.ToInt32(userInput);
            Console.WriteLine(a);

            userInput = Console.ReadLine();
            long b = Convert.ToInt64(userInput);
            Console.WriteLine(b);

            userInput = Console.ReadLine();
            char c = Convert.ToChar(userInput);
            Console.WriteLine(c);

            userInput = Console.ReadLine();
            float d = Convert.ToSingle(userInput);
            Console.WriteLine(d);

            userInput = Console.ReadLine();
            double e = Convert.ToDouble(userInput);
            Console.WriteLine(e);



            int num1 = 10;
            int num2 = 6;


            if (num1 > num2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


            int resultAnd = num1 & num2; 
            Console.WriteLine($"Bitwise AND: {resultAnd}");

            int resultOr = num1 | num2;
            Console.WriteLine($"Bitwise OR: {resultOr}");

            int resultXor = num1 ^ num2;
            Console.WriteLine($"Bitwise XOR: {resultXor}");

            int num3 = 5;  
            int resultNot = ~ num3; 
            Console.WriteLine($"Bitwise NOT: {resultNot}");

            int num4 = 8; 
            int resultLeftShift = num4 << 2; 
            Console.WriteLine($"Left Shift: {resultLeftShift}");

            int num5 = 16; 
            int resultRightShift = num5 >> 2; 
            Console.WriteLine($"Right Shift: {resultRightShift}");

        }
    }
}