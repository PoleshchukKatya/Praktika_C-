using System;
namespace Task3_4
{
    class TwoDimensionalArray
    {
        private int[,] array;

        /// <summary>
        /// Свойство для доступа к двумерному массиву.
        /// </summary>
        public int[,] Array
        {
            get { return array; }
            set { array = value; }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="rows">Количество строк массива. </param>
        /// <param name="columns">Количество столбцов массива. </param>
        public TwoDimensionalArray(int rows, int columns)
        {
            array = new int[rows, columns];
        }

        /// <summary>
        /// Метод для вычисления остатков от деления всех элементов массива на заданное число.
        /// </summary>
        /// <param name="divisor">Делитель. </param>
        /// <returns>Массив остатков. </returns>
        public int[,] Modulo(int divisor)
        {
            int[,] result = new int[array.GetLength(0), array.GetLength(1)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result[i, j] = array[i, j] % divisor;
                }
            }

            return result;
        }

        /// <summary>
        /// Перегрузка оператора сложения для двух объектов TwoDimensionalArray.
        /// </summary>
        /// <param name="array1">Первый массив. </param>
        /// <param name="array2">Второй массив. </param
    }
}