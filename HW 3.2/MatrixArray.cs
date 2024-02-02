using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3._2
{
    public sealed class MatrixArray : ParentArray
    {
        private int[,] array;
        public MatrixArray(int rows, int columns)
        {
            this.array = new int[rows, columns];
        }
        public override float GetAverage()
        {
            float sum = 0;

            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                for (int j = 0; j < this.array.GetLength(1); j++)
                {
                    sum += this.array[i, j];
                }

            }
            return sum / (this.array.GetLength(0) * this.array.GetLength(1));

        }

        public override void Display()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

    }
}