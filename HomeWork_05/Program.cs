using System;

namespace HomeWork_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int user_num; // Число которое вводит пользователь и на которое будет умножаться матрица
            int[,] matrix_array; // Массив будет содержать матрицу_1
            int[,] matrix_array_2; // Массив будет содержать матрицу_2
            int matrix_string; // Колличество строк в матрице
            int matrix_column; // Колличество столбцов в матрице
            int[,] result_array; // Результат действий с матрицами
            bool input_variable; // Переменная для проверки условий ввода
            int select = 1; // Переменная для выбора в меню

            while(select != 5)
            {
                Console.WriteLine("Выберите то, что Вас интересует!\n" +
                      "1. Умножение числа на матрицу\t2. Умножение матриц\t3. Сложение матриц\t4. Вычитание матриц\n5. Закрыть программу\n");

                // Ввод select и проверка на правильность ввода
                do
                {
                    input_variable = Int32.TryParse(Console.ReadLine(), out select);
                    if (select < 1 ^ select > 5)
                    {
                        Console.Write("Введите ещё раз: ");
                        input_variable = false;
                    }
                    else if (!input_variable) Console.Write("Введите ещё раз: ");
                }
                while (!input_variable);

                switch (select)
                {
                    case 1:
                        #region Умножение матрицы на число
                        // Ввод user_num и проверка на правильность ввода
                        Console.Write("\nВведите число (От 1 до 10) на которое будет умножаться матрица: ");
                        do
                        {
                            input_variable = Int32.TryParse(Console.ReadLine(), out user_num);
                            if (user_num < 1 ^ user_num > 10)
                            {
                                Console.Write("Введите ещё раз: ");
                                input_variable = false;
                            }
                            else if (!input_variable) Console.Write("Введите ещё раз: ");
                        }
                        while (!input_variable);

                        // Ввод matrix_string и проверка на правильность ввода
                        Console.Write("\nВведите колличество строк матрицы (От 2 до 10): ");
                        do
                        {
                            input_variable = Int32.TryParse(Console.ReadLine(), out matrix_string);
                            if (matrix_string < 2 ^ matrix_string > 10)
                            {
                                Console.Write("Введите ещё раз: ");
                                input_variable = false;
                            }
                            else if (!input_variable) Console.Write("Введите ещё раз: ");
                        }
                        while (!input_variable);

                        // Ввод matrix_column и проверка на правильность ввода
                        Console.Write("\nВведите колличество столбцов матрицы (Не меньше чем кол-во строк и не больше 10): ");
                        do
                        {
                            input_variable = Int32.TryParse(Console.ReadLine(), out matrix_column);
                            if (matrix_column < matrix_string ^ matrix_column > 10)
                            {
                                Console.Write("Введите ещё раз: ");
                                input_variable = false;
                            }
                            else if (!input_variable) Console.Write("Введите ещё раз: ");
                        }
                        while (!input_variable);

                        // Создаём и заполняем массив matrix_array 
                        matrix_array = CreateFillingMatrix(matrix_string, matrix_column);

                        //Считаем результат
                        result_array = MatrixNumMultiplication(user_num, matrix_array);

                        //Выводим результат
                        ShowMatrix(user_num, matrix_array, result_array, '*');
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    #endregion

                    case 2:
                        #region Умножение матриц
                        // Ввод matrix_string и проверка на правильность ввода
                        Console.Write("\nВведите колличество строк матриц (От 2 до 10): ");
                        do
                        {
                            input_variable = Int32.TryParse(Console.ReadLine(), out matrix_string);
                            if (matrix_string < 2 ^ matrix_string > 10)
                            {
                                Console.Write("Введите ещё раз: ");
                                input_variable = false;
                            }
                            else if (!input_variable) Console.Write("Введите ещё раз: ");
                        }
                        while (!input_variable);

                        // Ввод matrix_column и проверка на правильность ввода
                        Console.Write("\nВведите колличество столбцов матрицы (Не меньше чем кол-во строк и не больше 10): ");
                        do
                        {
                            input_variable = Int32.TryParse(Console.ReadLine(), out matrix_column);
                            if (matrix_column < matrix_string ^ matrix_column > 10)
                            {
                                Console.Write("Введите ещё раз: ");
                                input_variable = false;
                            }
                            else if (!input_variable) Console.Write("Введите ещё раз: ");
                        }
                        while (!input_variable);

                        // Заполняем массивы matrix_array и matrix_array_2
                        matrix_array = CreateFillingMatrix(matrix_string, matrix_column);
                        matrix_array_2 = CreateFillingMatrix(matrix_column, matrix_string);

                        // Считаем результат
                        result_array = MatrixMultiplication(matrix_array, matrix_array_2);

                        //Выводим результат
                        ShowMatrix(matrix_array, matrix_array_2, result_array, '*');
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    #endregion

                    case 3:
                        #region Сложение матриц
                        // Ввод matrix_string и проверка на правильность ввода
                        Console.Write("\nВведите колличество строк матриц (От 2 до 10): ");
                        do
                        {
                            input_variable = Int32.TryParse(Console.ReadLine(), out matrix_string);
                            if (matrix_string < 2 ^ matrix_string > 10)
                            {
                                Console.Write("Введите ещё раз: ");
                                input_variable = false;
                            }
                            else if (!input_variable) Console.Write("Введите ещё раз: ");
                        }
                        while (!input_variable);

                        // Ввод matrix_column и проверка на правильность ввода
                        Console.Write("\nВведите колличество столбцов матрицы (Не меньше чем кол-во строк и не больше 10): ");
                        do
                        {
                            input_variable = Int32.TryParse(Console.ReadLine(), out matrix_column);
                            if (matrix_column < matrix_string ^ matrix_column > 10)
                            {
                                Console.Write("Введите ещё раз: ");
                                input_variable = false;
                            }
                            else if (!input_variable) Console.Write("Введите ещё раз: ");
                        }
                        while (!input_variable);

                        // Заполняем массивы matrix_array и matrix_array_2
                        matrix_array = CreateFillingMatrix(matrix_string, matrix_column);
                        matrix_array_2 = CreateFillingMatrix(matrix_string, matrix_column);

                        // Считаем результат
                        result_array = MatrixAddition(matrix_array, matrix_array_2);

                        //Выводим результат
                        ShowMatrix(matrix_array, matrix_array_2, result_array, '+');
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    #endregion

                    case 4:
                        #region Вычитание матриц
                        // Ввод matrix_string и проверка на правильность ввода
                        Console.Write("\nВведите колличество строк матриц (От 2 до 10): ");
                        do
                        {
                            input_variable = Int32.TryParse(Console.ReadLine(), out matrix_string);
                            if (matrix_string < 2 ^ matrix_string > 10)
                            {
                                Console.Write("Введите ещё раз: ");
                                input_variable = false;
                            }
                            else if (!input_variable) Console.Write("Введите ещё раз: ");
                        }
                        while (!input_variable);

                        // Ввод matrix_column и проверка на правильность ввода
                        Console.Write("\nВведите колличество столбцов матрицы (Не меньше чем кол-во строк и не больше 10): ");
                        do
                        {
                            input_variable = Int32.TryParse(Console.ReadLine(), out matrix_column);
                            if (matrix_column < matrix_string ^ matrix_column > 10)
                            {
                                Console.Write("Введите ещё раз: ");
                                input_variable = false;
                            }
                            else if (!input_variable) Console.Write("Введите ещё раз: ");
                        }
                        while (!input_variable);

                        // Заполняем массивы matrix_array и matrix_array_2
                        matrix_array = CreateFillingMatrix(matrix_string, matrix_column);
                        matrix_array_2 = CreateFillingMatrix(matrix_string, matrix_column);

                        // Считаем результат
                        result_array = MatrixSubtraction(matrix_array, matrix_array_2);

                        //Выводим результат
                        ShowMatrix(matrix_array, matrix_array_2, result_array, '-');
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        #endregion
                }
            }
        }

        /// <summary>
        /// Метод осуществляет сложение матриц
        /// </summary>
        /// <param name="matrix_1"></param>
        /// <param name="matrix_2"></param>
        /// <returns></returns>
        static int[,] MatrixAddition(int[,] matrix_1, int[,] matrix_2)
        {
            int[,] result = new int[matrix_1.GetLength(0), matrix_1.GetLength(1)]; 

            for (int i = 0; i<matrix_1.GetLength(0); i++) 
            {
                for (int j = 0; j<matrix_1.GetLength(1); j++)
                {
                    result[i, j] = matrix_1[i, j] + matrix_2[i, j];
                }
            }
            return result;
        }


        /// <summary>
        /// Метод осуществляет вычитание матриц
        /// </summary>
        /// <param name="matrix_1"></param>
        /// <param name="matrix_2"></param>
        /// <returns></returns>
        static int[,] MatrixSubtraction(int[,] matrix_1, int[,] matrix_2)
        {
            int[,] result = new int[matrix_1.GetLength(0), matrix_1.GetLength(1)]; 

            for (int i = 0; i < matrix_1.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix_1.GetLength(1); j++)
                {
                    result[i, j] = matrix_1[i, j] - matrix_2[i, j];
                }
            }
            return result;
        }


        /// <summary>
        /// Метод осуществляет умножение числа на матрицу
        /// </summary>
        /// <param name="num"></param>
        /// <param name="matrix"></param>
        /// <returns></returns>
        static int[,] MatrixNumMultiplication(int num, int[,] matrix)
        {
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i< matrix.GetLength(0); i++)
            {
                for (int j = 0; j<matrix.GetLength(1); j++)
                {
                    result[i, j] = num * matrix[i, j];
                }
            }
            return result;
        }


        /// <summary>
        /// Метод осуществляет умножение матриц
        /// </summary>
        /// <param name="matrix_1"></param>
        /// <param name="matrix_2"></param>
        /// <returns></returns>
        static int[,] MatrixMultiplication(int [,] matrix_1, int [,] matrix_2)
        {
            int[,] result = new int[matrix_1.GetLength(0), matrix_2.GetLength(1)];

            // Условия совместимости матриц, если нет возвращает пустой массив
            if (matrix_1.GetLength(0) != matrix_2.GetLength(1))
            {
                Console.WriteLine("Умножение не возможно!");
                return result;
            }

            for (int i = 0; i < matrix_1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_2.GetLength(1); j++)
                {
                    for (int x = 0; x < matrix_1.GetLength(1); x++)
                    {
                        result[i, j] += matrix_1[i, x] * matrix_2[x, j];
                    }
                }
            }
            return result;
        }


        /// <summary>
        /// Метод создаёт и заполняет массив
        /// </summary>
        /// <param name="matrix_rows"></param>
        /// <param name="matrix_colums"></param>
        /// <returns></returns>
        static int[,] CreateFillingMatrix(int matrix_rows, int matrix_colums)
        {
            Random random = new Random();
            int[,] result = new int[matrix_rows, matrix_colums];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = random.Next(1, 11);
                }
            }
            return result;
        }


        /// <summary>
        /// Метод выводит выражение и результат
        /// </summary>
        /// <param name="matrix_1"></param>
        /// <param name="matrix_2"></param>
        /// <param name="result"></param>
        /// <param name="sign">знак действия</param>
        static void ShowMatrix(int [,] matrix_1, int [,] matrix_2, int [,] result, char sign)
        {
            int Cursor_top = Console.CursorTop + 1; // Текущие положение курсора по оси у

            // Выводим массив matrix_1
            for (int i = 0; i < matrix_1.GetLength(0); i++)
            {
                Console.SetCursorPosition(1, Cursor_top + i);
                Console.Write("|");
                for (int j = 0, x = 3; j < matrix_1.GetLength(1); j++, x += 3)
                {
                    Console.SetCursorPosition(x, Cursor_top + i);
                    Console.Write(matrix_1[i, j]);
                }
                Console.SetCursorPosition(4 + matrix_1.GetLength(1) + ((matrix_1.GetLength(1) - 1) * 2), Cursor_top + i);
                Console.WriteLine("|");
            }

            // Точка отсчёта кординаты х для вывода следующего массива
            int coordinate_x = 5 + matrix_1.GetLength(1) + ((matrix_1.GetLength(1) - 1) * 2) + 1;

            Console.SetCursorPosition(coordinate_x + 2, matrix_1.GetLength(0) / 2 + Cursor_top); // Устонавливаем курсор 
            Console.Write(sign);

            // Выводим массив matrix_2
            for (int i = 0; i < matrix_2.GetLength(0); i++)
            {
                Console.SetCursorPosition(6 + coordinate_x, Cursor_top + i);
                Console.Write("|");
                for (int j = 0, x = 7; j < matrix_2.GetLength(1); j++, x += 3)
                {
                    Console.SetCursorPosition(x + coordinate_x, Cursor_top + i);
                    Console.Write(matrix_2[i, j]);
                }
                Console.SetCursorPosition(8 + matrix_2.GetLength(1) + ((matrix_2.GetLength(1) - 1) * 2) + coordinate_x, Cursor_top + i);
                Console.WriteLine("|");
            }

            coordinate_x += 5 + matrix_2.GetLength(1) + ((matrix_2.GetLength(1) - 1) * 2) + 1;
            Console.SetCursorPosition(coordinate_x + 6, matrix_2.GetLength(0) / 2 + Cursor_top); // Устонавливаем курсор 
            Console.Write("=");

            // Выводим массив result
            for (int i = 0; i < result.GetLength(0); i++)
            {
                Console.SetCursorPosition(10 + coordinate_x, Cursor_top + i);
                Console.Write("|");
                for (int j = 0, x = 11; j < result.GetLength(1); j++, x += 6)
                {
                    Console.SetCursorPosition(x + coordinate_x, Cursor_top + i);
                    Console.Write(result[i, j]);
                }
                Console.SetCursorPosition(12 + result.GetLength(1) + ((result.GetLength(1) - 1) * 5) + coordinate_x, Cursor_top + i);
                Console.WriteLine("|");
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Перегрузка ShowMatrix
        /// Метод выводит выражение матрицы на число и результат
        /// </summary>
        /// <param name="num"></param>
        /// <param name="matrix"></param>
        /// <param name="result"></param>
        /// <param name="sign"></param>
        static void ShowMatrix(int num, int[,] matrix, int[,] result, char sign)
        {
            int Cursor_top = Console.CursorTop + 1; // Текущие положение курсора по оси у

            Console.SetCursorPosition(0, matrix.GetLength(0) / 2 + Cursor_top); // Устонавливаем курсор 
            Console.Write($"{num}  {sign}"); // Выводим число и операцию

            // Выводим массив matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.SetCursorPosition(6, Cursor_top + i);
                Console.Write("|");
                for (int j = 0, x = 8; j < matrix.GetLength(1); j++, x += 3)
                {
                    Console.SetCursorPosition(x, Cursor_top + i);
                    Console.Write(matrix[i, j]);
                }
                Console.SetCursorPosition(9 + matrix.GetLength(1) + ((matrix.GetLength(1) - 1) * 2), Cursor_top + i);
                Console.WriteLine("|");
            }

            // Точка отсчёта кординаты х для вывода массива result
            int coordinate_x = 9 + matrix.GetLength(1) + ((matrix.GetLength(1) - 1) * 2) + 1;

            Console.SetCursorPosition(coordinate_x + 2, matrix.GetLength(0) / 2 + Cursor_top); // Устонавливаем курсор 
            Console.Write("=");

            // Выводим массив result
            for (int i = 0; i < result.GetLength(0); i++)
            {
                Console.SetCursorPosition(5 + coordinate_x, Cursor_top + i);
                Console.Write("|");
                for (int j = 0, x = 7; j < result.GetLength(1); j++, x += 6)
                {
                    Console.SetCursorPosition(x + coordinate_x, Cursor_top + i);
                    Console.Write(result[i, j]);
                }
                Console.SetCursorPosition(8 + result.GetLength(1) + ((result.GetLength(1) - 1) * 5) + coordinate_x, Cursor_top + i);
                Console.WriteLine("|");
            }
            Console.WriteLine();
        }
    }
}
