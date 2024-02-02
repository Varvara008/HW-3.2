using HW_3._2;
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("С какими массивами вы хотите работать?");
        Console.WriteLine("1 - Одномерные, 2 - Двумерные, 3 - Ступенчатые");
        int answer = int.Parse(Console.ReadLine());

        if (answer == 1)
        {
            Console.WriteLine("Сколько элементов вы хотите?");
            int count = int.Parse(Console.ReadLine());

            LineArray array = new LineArray(count);

            while (true)
            {
                Console.WriteLine("Какой метод вы хотите вызвать?");
                Console.WriteLine("0 - Выйти");
                Console.WriteLine("1 - Отобразить");
                Console.WriteLine("2 - Показать среднее арифметическое всех элементов");

                int metod = int.Parse(Console.ReadLine());

                if (metod == 0)
                {
                    break;
                }
                if (metod == 1)
                {
                    array.Display();
                }
                if (metod == 2)
                {
                    Console.WriteLine(array.GetAverage());
                }
            }

        }
        else if (answer == 2)
        {
            Console.WriteLine("Сколько рядов вы хотите?");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Сколько столбцов вы хотите?");
            int columns = int.Parse(Console.ReadLine());

            MatrixArray array = new MatrixArray(rows, columns);

            while (true)
            {
                Console.WriteLine("Какой метод вы хотите вызвать?");
                Console.WriteLine("0 - Выйти");
                Console.WriteLine("1 - Отобразить");
                Console.WriteLine("2 - Показать среднее арифметическое всех элементов");


                int metod = int.Parse(Console.ReadLine());

                if (metod == 0)
                {
                    break;
                }
                if (metod == 1)
                {
                    array.Display();
                }
                if (metod == 2)
                {
                    array.GetAverage();
                }
            }
        }
        else if (answer == 3)
        {
            Console.WriteLine("Сколько рядов вы хотите?");
            int rows = int.Parse(Console.ReadLine());

            int[] columns = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Сколько элементов вы хотите в ряду с индексом {i} ?");
                columns[i] = int.Parse(Console.ReadLine());
            }

            StepArray array = new StepArray(new int[][]{
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 7 },
                new int[] { 8, 9 }
            });

            while (true)
            {
                Console.WriteLine("Какой метод вы хотите вызвать?");
                Console.WriteLine("0 - Выйти");
                Console.WriteLine("1 - Отобразить");
                Console.WriteLine("2 - Показать среднее арифметическое всех элементов");

                int metod = int.Parse(Console.ReadLine());

                if (metod == 0)
                {
                    break;
                }
                if (metod == 1)
                {
                    array.Display();
                }
                if (metod == 2)
                {
                    Console.WriteLine(array.GetAverage());
                }
            }
        }
    }


}