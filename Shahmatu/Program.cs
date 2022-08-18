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
            { 0, 1, 0, 0, 0, 0, 0 , 0},
            { 0, 0, 0, 0, 0, 0, 0 , 1},
            { 0, 0, 0, 0, 0, 0, 0 , 1},
            { 0, 0, 0, 0, 0, 0, 0 , 1},
            { 0, 0, 0, 0, 0, 0, 0 , 1},
            { 0, 0, 0, 0, 0, 0, 0 , 1},
            { 0, 0, 0, 0, 0, 0, 0 , 1},
            { 0, 0, 0, 0, 0, 0, 0 , 1}

        };

        static void Show()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 1)
                    {
                        Console.Write(map[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Show();
            Console.ReadKey();
        }
    }
}
