using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LittleDuck
{
    internal class Program
    {
        //Practica 9
        /*
         El becario de la empresa "Little Duck" se equivoco y registro a clientes en un arreglo
        en vez de una matriz

        Ayudale a corregir su error.
        1. Transforma el array en una matriz
        2. Imprime la matriz con formato a manera de tabla
        3. Los encabezados son "Nombre, Edad, Ciudad"
        */

        public static string[,] Slice(string[] myArray)
        {
            int cols = 3;//3
            int rows = myArray.Length / cols;//4
            string[,] correctedList = new string[rows, cols];//rows, cols
            for (int row = 0; row < rows; row++)//0-3  
            {
                for (int col = 0; col < cols; col++)//0-2
                {
                    correctedList[row, col] = myArray[(cols * row) + col];//Formula = (n * i) + j
                }
            }

            return correctedList;
        }

        public static void Printer(string[,] correctedList)
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(correctedList[row, col] + " ");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            string[] wrongList = { "jorge Suarez", "36", "CDMX", "Josue Vizcarra", "31", "Tijuana", 
                "Alba Chavez", "55", "Monterrey", "Joel Lopez", "31", "Tijuana" };
            string[,] correctedList = Slice(wrongList);
            Printer(correctedList);

            Console.ReadLine();
        }

    }
}
