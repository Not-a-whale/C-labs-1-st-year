using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Title = "Logger" ;
            Console.WriteLine(" Высота буфера {0} строк.", Console.BufferHeight);
            Console.WriteLine(" Ширина {0} колонок.", Console.BufferWidth);
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Введите бал в болонской системе(A, B, C, D, E) и нажмите Enter");
                string bal = Console.ReadLine();
                int[] CursorSize = new int[5] { 20, 40, 60, 80, 100 };
                switch (bal.ToUpper())
                {
                    case "A":
                        Console.CursorSize = CursorSize[0];
                        Console.SetCursorPosition(10, 20);
                        Console.WriteLine("Ваш бал:" +bal.ToUpper() + "соответсвует оценке - отлично");
                        break;
                    case "B":
                        Console.CursorSize = CursorSize[1];
                        Console.WriteLine("Ваш бал:" +bal.ToUpper() + "соответсвует оценкe - хорошо");
                        break;
                    case "C":
                        Console.SetCursorPosition(10, 20);
                        Console.CursorSize = CursorSize[2];
                        Console.WriteLine("Ваш бал:" +bal.ToUpper() + "соответсвует оценке - хорошо");
                        break;
                    case "D":
                        Console.CursorSize = CursorSize[3];
                        Console.WriteLine("Ваш бал:" +bal.ToUpper() + "соответсвует оценке - удовлетворительно");
                        break;
                    case "E":
                        Console.CursorSize = CursorSize[4];
                        Console.WriteLine("Ваш бал" +bal.ToUpper() + "соответсвует оценке - удовлетворительно");
                        break;
                    default:
                        Console.WriteLine("Неправильно введен бал");
                        break;
                }
                Console.WriteLine("Для продолжения нажмите клавишу Enter. Для выхода - любую другую клавишу.");
                key = Console.ReadKey();
            }
            while (key.KeyChar == 13);
            do
            {
                Console.WriteLine("\n Нажмите клавишу, информацию о которой вы хотите просмотреть");
                key = Console.ReadKey();
                Console.WriteLine(key.Key + key.KeyChar + key.Modifiers.ToString());
            }
            while (key.KeyChar != 27);
            if (key.KeyChar == 27)
            {
                Console.WriteLine("Выход!!!", "Внимание ");
                Environment.Exit(0);
            }
        }
    }
}