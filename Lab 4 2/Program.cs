using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Введите значение а: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат поразрядной операции И равен: ");
            Console.Write("Для десятичной: ");
            Console.Write(a & b);    
        }
    }
}
