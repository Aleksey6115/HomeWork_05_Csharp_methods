using System;

namespace HomeWork_05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_str; // Строка которую вводит пользователь

            #region Поиск слова с минимальным колличеством символов
            Console.WriteLine("Введите строку для поиска в ней слова с минимальным колличеством символов:");
            user_str = Console.ReadLine();
            string min_str = StringMin(user_str);
            Console.WriteLine($"Слово с минимальным колличеством символов - {min_str}");
            Console.ReadKey();
            #endregion

            #region Поиск слов с максимальным колличеством символов
            Console.WriteLine("\nВведите строку для поиска в ней слов с максимальным колличеством символов:");
            user_str = Console.ReadLine();
            string[] max_str_array = StringMax(user_str);

            Console.Write("Слова с максимальным колличеством символов - ");

            // Выводим слова с максимальным колличеством символов
            for (int i = 0; i < max_str_array.Length; i++)
            {
                Console.Write(max_str_array[i]);

                if (i == max_str_array.Length - 1) Console.Write(".");
                else Console.Write(", ");
            }
            Console.WriteLine();
            Console.ReadKey();
            #endregion

            #region Убираем повторяющиеся символы в строке
            Console.WriteLine("\nВведите строку в которой требуется убрать повторяющиеся (рядом стоящие) символы");
            user_str = Console.ReadLine();
            user_str = RemoveRepeat(user_str);
            Console.WriteLine($"Вот что получилось - {user_str}");
            Console.ReadKey();
            #endregion
        }


        /// <summary>
        /// Метод возвращает подстроку из строки с минимальным колличеством символов
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string StringMin (string str)
        {
            // Разделяем строку на подстроки
            string[] split_str = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string result_str = split_str[0]; // Строка в которой будет хранится слово с минимальным колличеством символов

            // Ищем строку с наименьшим колличеством символов
            for(int i = 0; i<split_str.Length; i++)
            {
                if (split_str[i].Length < result_str.Length) result_str = split_str[i];
            }

            return result_str;
        }
        
        /// <summary>
        /// Метод возвращает массив строк с наибольшим колличеством символов
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string[] StringMax (string str)
        {
            // Разделяем строку на подстроки
            string[] split_str = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string result_str = split_str[0]; // Строка в которой будет хранится слово с максимальным колличеством символов
            string[] result_str_array; // Массив будет хранить все строки с максимальным колличеством символов
            int count = 0; // Подсчёт колличества слов с максимальным колличеством символов

            // Ищем слово с максимальным колличеством символов
            for (int i = 0; i < split_str.Length; i++)
            {
                if (split_str[i].Length >= result_str.Length) result_str = split_str[i];
            }

            // Считаем сколько ещё слов с максимальной длинной
            for (int i = 0; i<split_str.Length; i++)
            {
                if (split_str[i].Length == result_str.Length) count++;
            }

            result_str_array = new string[count]; // Задаём массиву нужную длину

            // Добавляем слова с максимальной длинной в массив
            for (int i = 0, j = 0; i<split_str.Length; i++)
            {
                if (split_str[i].Length == result_str.Length)
                {
                    result_str_array[j] = split_str[i];
                    j++;
                }
            }
            return result_str_array;
        }

        /// <summary>
        /// Метод убирает повторяющиеся рядом стоящие символы из строки
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string RemoveRepeat(string str)
        {
            str = str.ToLower();
            char intermediate_result = str[0]; // Переменная сохраняет в себя уникальные значения
            char[] result = new char[str.Length]; // Массив хранящий уникальные значения
            result[0] = intermediate_result;
            int count = 1; // Для параметра startIndeх в методе Remove

            // Отбираем уникальные значения
            for (int i = 0; i<str.Length; i++)
            {
                if (str[i] == intermediate_result) continue;
                else
                {
                    intermediate_result = str[i];
                    result[count] = intermediate_result;
                    count++;
                }
            }

            string return_result = new string(result); // Переводим массив с уникальными значениями в строку
            return_result = return_result.Remove(count); // Удаляем пустые элементы
            return return_result;
        }
    }
}
