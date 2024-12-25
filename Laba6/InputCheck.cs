using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    public static class InputCheck
    {
        /// <summary>
        /// Проверяет и возвращает допустимое значение параметра a
        /// </summary>
        /// <returns>Значение параметра a </returns>
        public static double IsValidA()
        {
            double a;
            Console.WriteLine("Введите параметр a");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Введите ЧИСЛО\n");
            }
            return a;
        }

        /// <summary>
        /// Проверяет и возвращает допустимое значение параметра b 
        /// </summary>
        /// <returns>Значение параметра b </returns>
        public static double IsValidB()
        {
            double b;
            Console.WriteLine("Введите значение параметра b (оно должно быть больше -2): \n");
            while (!double.TryParse(Console.ReadLine(), out b) || b <= -2)
            {
                Console.WriteLine("Введи ЧИСЛО больше -2");
            }
            return b;
        }

        /// <summary>
        /// Проверяет и возвращает допустимое значение произвольного числа.
        /// </summary>
        /// <returns>Значение числа.</returns>
        public static double IsValid()
        {
            double userAnswer;
            while (!double.TryParse(Console.ReadLine(), out userAnswer))
            {
                Console.WriteLine("Введите ЧИСЛО\n");
            }
            return userAnswer;
        }

        /// <summary>
        /// Проверяет и возвращает допустимый размер массива.
        /// </summary>
        /// <returns> Размер массива </returns>
        public static int GetArraySize()
        {
            int size;
            Console.WriteLine("Введите размер массива");
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Размер массива - это целое число больше 0, если что ");
            }
            return size;
        }
    }
}

