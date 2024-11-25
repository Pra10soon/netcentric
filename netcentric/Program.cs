using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcentric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 20;
            Console.WriteLine("Before swapping");
            Console.WriteLine($"First Number = {firstNumber}\nSecond Number = {secondNumber}");
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("After swapping");
            Console.WriteLine($"First Number = {firstNumber}\n Second Number = {secondNumber}");

        }
    }
}
