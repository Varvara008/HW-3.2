using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_3._2
{
    internal class StepArray
    {
        private int[][] array;

        public StepArray(int[][] array)
        {
            this.array = array;
        }
        public void Display()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }

                Console.WriteLine();
            }

        }

        public float GetAverage()
        {
            float sum = 0;
            int count = 0;

            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    sum += this.array[i][j];
                    count++;
                }

            }
            return sum / count;

        }
        public void RecreateArray(int[][] newArray)
        {
            array = newArray;
        }

    }
}