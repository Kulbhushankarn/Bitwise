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
            int num1 = 10;
            int num2 = 6;
            int resultAnd = num1 & num2; 
            Console.WriteLine($"Bitwise AND: {resultAnd}");

            int resultOr = num1 | num2;
            Console.WriteLine($"Bitwise OR: {resultOr}");

            int resultXor = num1 ^ num2;
            Console.WriteLine($"Bitwise XOR: {resultXor}");

            int num3 = 5;  
            int resultNot = ~num3; 
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