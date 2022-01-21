using System;
using System.Collections.Generic;
using System.Linq;
using Conways_SpieldesLebens;
namespace MyApp // Note: actual namespace depends on the project name.
{
    //Luca Have Help
    public class Program
    {
        static bool[,] field = new bool[40, 40];

        public static void Main(string[] args)
        {
            bool[,] bufferfield = new bool[40, 40];

            field[9, 10] = true; field[9, 11] = true; field[9, 12] = true;
            field[10, 10] = true; field[10, 12] = true;
            field[11, 10] = true; field[11, 12] = true;

            field[13, 10] = true; field[13, 12] = true;
            field[14, 10] = true; field[14, 12] = true;
            field[15, 10] = true; field[15, 11] = true; field[15, 12] = true;

            //field[2, 2] = true;
            //field[2, 3] = true;
            //field[2, 4] = true;


            do
            {
                for (int i = 0; i < 40; i++)
                {

                    for (int a = 0; a < 40; a++)
                    {
                        if (field[i, a])
                        {
                            Console.Write('X');

                        }
                        else
                        {
                            Console.Write(' ');
                        }
                        
                    }
                    Console.WriteLine();
                }
               
                Thread.Sleep(500);
                //Console.WriteLine("----------------------------------------------------------------------------------------- \n");
                Console.Clear();
                bufferfield = new bool[40, 40];
                for (int i = 0; i < 40; i++)
                {
                    for (int a = 0; a < 40; a++)
                    {
                        bufferfield[i,a] = test(i,a); 

                    }
                }
                field = bufferfield;
            } while (true);
            
            
        }
        private static bool test(int x, int y)
        {
            bool[,] test = field;
            int count = 0;
            if (field[x,y])
            {
                count--;
            }
            for (int xi = x-1; xi < x+2; xi++)
            {
                for (int yi = y-1; yi < y+2; yi++)
                {
                    if (xi >= 0 && yi >= 0 && xi< field.GetLength(0) && yi < field.GetLength(1) && field[xi,yi])
                    {
                        count++;
                    }


                }
            }

            if(field[x,y])
                if (count == 2 || count == 3)
                {
                    return true;
                }
                else { return false; }

            if (count == 3)
                return true;
            return false;
        }
    }
    
}
