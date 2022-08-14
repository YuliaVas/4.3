using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк и колонок: ");
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int[,] myArray = new int[X, Y];
            Random random = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            { for (int j = 0; j < myArray.GetLength(1); j++)

                    myArray[i, j] = random.Next(-100, 100);
            }

            Console.WriteLine("Вывод массива: ");

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        


                    

              
            // математические операции:
            Console.WriteLine("\n А теперь математические операции: ");
            int minValue1 = myArray[0, 0];
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)

                {
                    if (myArray[i, j] < minValue1)
                    {
                        minValue1 = myArray[i, j];
                    }
                }
            }
                    
            Console.WriteLine("\n минимальное значение в массиве: " + minValue1);

            int maxValue1 = myArray[0, 0];
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)

                {
                    if (myArray[i, j] > maxValue1)
                    {
                        maxValue1 = myArray[i, j];
                    }
                }
            }

            Console.WriteLine("максимальное значение в массиве: " + maxValue1);

            int sumValue = 0;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    sumValue = (sumValue) + myArray[i, j];
                }
            }
            Console.WriteLine("сумма всех элементов в массиве " + sumValue);


            double sumValue1 = (double)(sumValue);
            double averageValue = (double)(sumValue1 / (X*Y));
            Console.WriteLine("среднее арифметическое элементов в массиве: " + averageValue);

            
            
            


            Console.ReadKey(); 
        }
    }
}
