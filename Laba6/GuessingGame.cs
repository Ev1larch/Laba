using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    public static class GuessingGameLogic
    {
        /// <summary>
        /// Вычисляет значение функции
        /// </summary>
        /// <param name="a"> Параметр a </param>
        /// <param name="b"> Параметр b (число, большее -2) </param>
        /// <returns> Значение функции </returns>
        public static double Calculate(double a, double b)
        {
            return Math.Round(-4 * Math.Pow(Math.Sin(3 * a), 3) + (Math.Sqrt(b) / Math.Log(b + 2)), 2);
        }

        /// <summary>
        /// Игра по отгадыванию значения функции
        /// </summary>
        /// <param name="result"> Правильный ответ </param>
        public static void GuessingGame(double result)
        {
            bool gameOver = false;
            int count = 3;
            while (!gameOver && count > 0)
            {
                Console.WriteLine("Попробуй угадать значение (С точностью до двух цифр после запятой)\n");
                double userAnswer = InputCheck.IsValid();

                if (Math.Round(userAnswer, 2) == result)
                {
                    Console.WriteLine("Ты угадал ответ, хоть в чём-то ты хорош.\n");
                    gameOver = true;
                }
                else
                {
                    count--;
                    if (count > 0)
                    {
                        Console.WriteLine($"Ты не угадал, у тебя осталось {count} попыток.\n");
                    }
                    else
                    {
                        Console.WriteLine($"К сожалению, ты не смог угадать. Правильный ответ был - {result}\n");
                    }
                }
            }
        }
    }
}


