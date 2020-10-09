using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream301
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Table stol = new Table(30, 15, "красный", "дерево", "квадратная");
            Console.WriteLine($"Цвет вашего стола {stol.ReturnColorTable()}");
            Console.WriteLine($"Размеры вашего стола {stol.SquareTable()}");
            Console.WriteLine("Введите новый цвет стола ");
            stol.SetColor(Console.ReadLine());
           Console.WriteLine($"New Цвет вашего стола {stol.ReturnColorTable()}");
            Console.ReadLine();

        }
    }
}
