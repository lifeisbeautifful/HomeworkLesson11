using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
   Создайте статический класс с методом void Print (string stroka, int color), который выводит на экран строку заданным цветом.Используя 
    перечисление, создайте набор цветов, доступных пользователю. Ввод строки и выбор цвета предоставьте пользователю.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text for printing:");
            string text = Console.ReadLine();

            Console.WriteLine("Enter one of the suggested colors for the text:\n - Red\n - DarkRed\n - Yellow\n - Green\n - DarkBlue\n - Blue\n - DarkYellow");
            string color = Console.ReadLine();

            Colors[] textColors = { Colors.Red, Colors.DarkRed, Colors.Green, Colors.DarkBlue, Colors.Blue, Colors.Yellow, Colors.DarkYellow };
            foreach (var item in textColors)
            {
                if (item.ToString().Equals(color))
                {
                    PrintText.Print(text,(int)item);
                }
            }
           
            Console.ReadLine();
        }
    }
    public static class PrintText
    {
        public static void Print(string text,int color)
        {
            switch (color)
            {
                case (int)Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(text);
                    break;
                case (int)Colors.DarkRed:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(text);
                    break;
                case (int)Colors.Yellow:
                    Console.ForegroundColor=ConsoleColor.Yellow;
                    Console.WriteLine(text);
                    break;
                case (int)Colors.Green:
                    Console.ForegroundColor=ConsoleColor.Green;
                    Console.WriteLine(text);
                    break;
                case (int)Colors.DarkBlue:
                    Console.ForegroundColor=ConsoleColor.DarkBlue;
                    Console.WriteLine(text);
                    break;
                case (int)Colors.Blue:
                    Console.ForegroundColor=ConsoleColor.Blue;
                    Console.WriteLine(text);
                    break;
                case (int)Colors.DarkYellow:
                    Console.ForegroundColor=ConsoleColor.DarkYellow;
                    Console.WriteLine(text);
                    break;
            }
        }
        }
    }
    public enum Colors
    {
        Red = 1,
        DarkRed,
        Yellow,
        Green,
        DarkBlue,
        Blue,
        DarkYellow
    }



