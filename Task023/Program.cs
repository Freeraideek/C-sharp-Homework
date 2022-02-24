// Написать программу масштабирования фигуры

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "2";
            double k = double.Parse(a);


            string input = "(0,0) (2,0) (2,2) (0,2)";
            string[] arrInput = input.Split(' ');

            List<double> numbers = new List<double> { };
            foreach (string i in arrInput)
            {
                string element = i;
                element = element.Replace("(", "");
                element = element.Replace(")", "");
                numbers.Add(double.Parse(element));
            }


            foreach (double i in numbers)
                Console.Write($"({i * k:F1}) ");

            Console.WriteLine();

        }
    }
}