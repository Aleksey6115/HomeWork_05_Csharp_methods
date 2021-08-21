using System;

namespace HomeWork_05_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsItProgression(2, 4, 8));

            Console.Write($"\nЗначение функции Аккермана равно - {Accerman(2, 2)}");
            Console.ReadKey();
        }

        /// <summary>
        /// Метод возвращает строку в которой описывается 
        /// является ли набор чисел прогрессией, и если да то какой
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static string IsItProgression(params int[] number)
        {
            if (number.Length < 3) return "Этот набор чисел не может быть прогресией";
            else
            {
                int count_arephmetic = 0; // Считает числа в последовательности подходящие под определение арефметической прогрессии
                int count_geometric = 0; // Считает числа в последовательности подходящие под определение геометрической прогрессии
                int difference = number[1] - number[0]; // разница между числами для проверки условия арефмитической прорессии
                int denominator = number[1] / number[0]; // знаменатель геометрической прогрессии
                int count; // начало счётчика в цикле for

                if (difference == denominator) // Если первое действие будет подходить под оба вида прогрессии
                {
                    count_arephmetic++;
                    count_geometric++;
                    count = 2;
                }

                else count = 1;

                // Проверяем какой прогрессией является набор чисел
                for (int i = count; i < number.Length; i++)
                {
                    if ((number[i] - number[i - 1]) == difference) count_arephmetic++; // Арефметическая прогрессия
                    else if ((number[i] / number[i - 1]) == denominator) count_geometric++; // Геометрическая прогрессия
                }

                if (count_arephmetic == (number.Length - 1)) return "Это арефметическая прогрессия";
                else if (count_geometric == (number.Length - 1)) return "Это геометрическая прогрессия";
                else return "Это просто набор чисел";
            }
        }


        /// <summary>
        /// Функция Аккермана
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        static int Accerman(int n, int m)
        {
            if (n == 0) return m + 1;
            else if (n != 0 && m == 0) return Accerman(n - 1, 1);
            else return Accerman(n - 1, Accerman(n, m - 1));
        }
    }
}
