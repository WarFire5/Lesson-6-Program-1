using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Program_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A, B, multiplication, remainder;
           
            Console.WriteLine("Задайте число 'A':");
            A = Console.ReadLine();
                       
            Console.WriteLine("Задайте число 'B':");
            B = Console.ReadLine();

            int a = Convert.ToInt32(A);

            int b = Convert.ToInt32(B);

            int c = a * b;
            
            int d = b % a;

            multiplication = "Результат умножения A на B: " + c + ";";

            remainder = "Остаток от деления B на A: " + d + ".";

            Console.WriteLine(multiplication);

            Console.WriteLine(remainder);
            
            Console.ReadLine();
        }
    }
}
