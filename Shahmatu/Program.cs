using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shahmatu
{
    internal class Program
    {
        static int[,] map =
        {
            { 3,  5,  7,  11,  9, 7,  5,  3},
            { 1,  1,  1,  1,  1,  1,  1,  1},
            { 0,  0,  0,  0,  0,  0,  0,  0},
            { 0,  0,  0,  0,  0,  0,  0,  0},
            { 0,  0,  0,  0,  0,  0,  0,  0},
            { 0,  0,  0,  0,  0,  0,  0,  0},
            { 2,  2,  2,  2,  2,  2,  2,  2},
            { 4,  6,  8,  12, 10, 8,  6,  4}

        };

        static int X = 7;
        static int Y = 7;

        static void Show()
        {
            Console.Clear();
            for (int i = 0; i < map.GetLength(0); i++)
            {
                
                Console.Write("---------------------------------\n|");
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] > 0)
                    {
                        if (map[i,j] % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                    }


                    if (Y == i && X == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(">");
                    }
                    else
                    {
                        Console.Write(" ");
                    }




                    if (map[i, j] == 1 || map[i, j] == 2 )
                    {
                        Console.Write("i ");
                    }
                    else if (map[i, j] == 3 || map[i, j] == 4)
                    {
                        Console.Write("■ ");
                    }
                    else if (map[i, j] == 5 || map[i, j] == 6)
                    {
                        Console.Write("$ ");
                    }
                    else if (map[i, j] == 7 || map[i, j] == 8)
                    {
                        Console.Write("+ ");
                    }
                    else if (map[i, j] == 9 || map[i, j] == 10)
                    {
                        Console.Write("K ");
                    }
                    else if (map[i, j] == 11 || map[i, j] == 12)
                    {
                        Console.Write("Q ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }


                    Console.ResetColor();
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine(key);
        }
        

        static void Init()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(34, 19);
            Console.SetBufferSize(34, 19);

        }

        static void Main(string[] args)
        {
            Init();

            while(true)
            {
                Show();
                ReadCursor();
            }
        }

        static string key = "";

        static void ReadCursor()
        {
            ConsoleKey keydown = Console.ReadKey().Key;

            if (keydown == ConsoleKey.W || keydown == ConsoleKey.UpArrow)
            {
                key = "W";
            }
            else if(keydown == ConsoleKey.D)
            {
                key = "D";
            }
            else if (keydown == ConsoleKey.S)
            {
                key = "S";
            }
            else if (keydown == ConsoleKey.A)
            {
                key = "A";
            }
        }
    }
}
