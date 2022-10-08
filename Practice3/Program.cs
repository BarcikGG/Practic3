using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice3
{
    internal class Program
    {

        static void Third(int[] ThirdhOctava)
        {
            Console.WriteLine("3-ая октава\nEscape для выхода к выбору октав");
            while (true)
            {
                ConsoleKeyInfo note = Console.ReadKey(true);
                switch (note.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(ThirdhOctava[0], 200);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(ThirdhOctava[1], 200);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(ThirdhOctava[2], 200);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(ThirdhOctava[3], 200);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(ThirdhOctava[4], 200);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(ThirdhOctava[5], 200);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(ThirdhOctava[6], 200);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(ThirdhOctava[7], 200);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(ThirdhOctava[8], 200);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(ThirdhOctava[9], 200);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(ThirdhOctava[10], 200);
                        break;
                    case ConsoleKey.J:
                        Console.Beep(ThirdhOctava[11], 200);
                        break;
                    case ConsoleKey.K:
                        Console.Beep(ThirdhOctava[0], 200);
                        break;
                    case ConsoleKey.L:
                        Console.Beep(ThirdhOctava[1], 200);
                        break;
                    case ConsoleKey.O:
                        Console.Beep(ThirdhOctava[2], 200);
                        break;
                    case ConsoleKey.P:
                        Console.Beep(ThirdhOctava[3], 200);
                        break;
                }
                if (note.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Выберите октаву(F3-F5)");
                    break;
                }
            }
        }

        static void Fourth(int[] FourthOctava)
        {
            Console.WriteLine("4-ая октава\nEscape для выхода к выбору октав");
            while (true)
            {
                ConsoleKeyInfo note = Console.ReadKey(true);
                switch (note.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(FourthOctava[0], 200);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(FourthOctava[1], 200);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(FourthOctava[2], 200);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(FourthOctava[3], 200);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(FourthOctava[4], 200);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(FourthOctava[5], 200);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(FourthOctava[6], 200);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(FourthOctava[7], 200);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(FourthOctava[8], 200);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(FourthOctava[9], 200);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(FourthOctava[10], 200);
                        break;
                    case ConsoleKey.J:
                        Console.Beep(FourthOctava[11], 200);
                        break;
                    case ConsoleKey.K:
                        Console.Beep(FourthOctava[0], 200);
                        break;
                    case ConsoleKey.L:
                        Console.Beep(FourthOctava[1], 200);
                        break;
                    case ConsoleKey.O:
                        Console.Beep(FourthOctava[2], 200);
                        break;
                    case ConsoleKey.P:
                        Console.Beep(FourthOctava[3], 200);
                        break;
                }
                if (note.Key == ConsoleKey.Escape) 
                {
                    Console.WriteLine("Выберите октаву(F3-F5)");
                    break;
                }
            }
        }

        static void Fith(int[] FifthOctava) 
        {
            Console.WriteLine("5-ая октава\nEscape для выхода к выбору октав");
            while (true)
            {
                ConsoleKeyInfo note = Console.ReadKey(true);
                switch (note.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(FifthOctava[0], 200);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(FifthOctava[1], 200);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(FifthOctava[2], 200);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(FifthOctava[3], 200);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(FifthOctava[4], 200);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(FifthOctava[5], 200);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(FifthOctava[6], 200);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(FifthOctava[7], 200);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(FifthOctava[8], 200);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(FifthOctava[9], 200);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(FifthOctava[10], 200);
                        break;
                    case ConsoleKey.J:
                        Console.Beep(FifthOctava[11], 200);
                        break;
                    case ConsoleKey.K:
                        Console.Beep(FifthOctava[0], 200);
                        break;
                    case ConsoleKey.L:
                        Console.Beep(FifthOctava[2], 200);
                        break;
                    case ConsoleKey.O:
                        Console.Beep(FifthOctava[1], 200);
                        break;
                    case ConsoleKey.P:
                        Console.Beep(FifthOctava[3], 200);
                        break;
                }
                if (note.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Выберите октаву(F3-F5)");
                    break;
                }
            }
        }

        static void Change()
        {
            int[] ThirdOctava = new int[] { 131, 139, 147, 156, 165, 172, 185, 246, 209, 220, 231, 250 };
            int[] FourthOctava = new int[] { 261, 277, 293, 311, 329, 344, 370, 492, 417, 440, 461, 499 };
            int[] FifthOctava = new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };

            ConsoleKeyInfo Octava = Console.ReadKey(true);
            switch (Octava.Key)
            {
                case ConsoleKey.F5:
                    Fith(FifthOctava);
                    break;
                case ConsoleKey.F4:
                    Fourth(FourthOctava);
                    break;
                case ConsoleKey.F3:
                    Third(ThirdOctava);
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите октаву(F3-F5)");

            while (true)
            {
                Change();
                Console.Clear();
            }
        }
    }
}