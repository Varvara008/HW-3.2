using System;

namespace HW_3._2
{
    public sealed class LineArray : ParentArray
    {
        private int[] array;
        public LineArray(int count)
        {
            this.array = new int[count];
        }

        public override float GetAverage()
        {
            float sum = 0;

            for (int i = 0; i < this.array.Length; i++)
            {
                sum += this.array[i];
            }
            return sum / this.array.Length;
        }

        public override void Display()
        {
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
        }

    }
}