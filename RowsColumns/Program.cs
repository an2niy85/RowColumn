using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowColumn
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            int[,] numbers = { { 1, 2, 3 }, { 6, 5, 4 }, { 7, 8, 9 } };

            while (isOpen)
            {
                Console.WriteLine("Матрица.");
                Console.WriteLine("\n1 - найти сумму чисел в ряду.\n\n2 - найти произведение чисел в столбце.\n\n3 - Вывести матрицу.\n\n4 - Выход.");
                Console.WriteLine("Введите пункт меню:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int row;
                        int sum = 0;
                        Console.WriteLine("Введите номер ряда");
                        row = Convert.ToInt32(Console.ReadLine()) - 1;
                        for (int j = 0; j < numbers.GetLength(1); j++)
                        {
                            sum += numbers[row, j];
                        }
                        Console.WriteLine("Сумма чисел ряда " + sum);
                        break;
                    case 2:
                        int column;
                        int com = 1;
                        Console.WriteLine("Введите номер колонки");
                        column = Convert.ToInt32(Console.ReadLine()) - 1;
                        for (int i = 0; i < numbers.GetLength(0); i++)
                        {
                            com *= numbers[i, column];
                        }
                        Console.WriteLine("Произведение чисел колонки " + com);
                        break;
                    case 3:
                        for (int i = 0; i < numbers.GetLength(0); i++)
                        {
                            for (int j = 0; j < numbers.GetLength(1); j++)
                            {
                                Console.Write(numbers[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Выход");
                        isOpen = false;
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
