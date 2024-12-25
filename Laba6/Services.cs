using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    public static class Services
    {
        /// <summary>
        /// Отображает меню
        /// </summary>
        public static void Menu()
        {
            Console.WriteLine("Выберите пункт меню: \n");
            Console.WriteLine("1 - Отгадай ответ");
            Console.WriteLine("2 - Об авторе");
            Console.WriteLine("3 - Сортировка массивов");
            Console.WriteLine("4 - Душим Удава");
            Console.WriteLine("5 - Выход");
        }

        /// <summary>
        /// Отображает информацию об авторе
        /// </summary>
        public static void Author()
        {
            Console.WriteLine("Создатель - Жулимов Андрей Владимирович AKA Дрон AKA БПЛА AKA Кирилл alter AKA Алексей AKA Дебил конченный AKA " +
                "Урод, иди отсюда из группы 6102\n");
        }

        /// <summary>
        /// Обрабатывает выход из программы
        /// </summary>
        /// <returns> Флаг выхода </returns>
        public static bool Exit()
        {
            Console.WriteLine("Вы точно хотите выйти? (д/н) ");
            while (true)
            {
                string userAnswer = Console.ReadLine();
                if (userAnswer.ToLower() == "д")
                {
                    return true;
                }
                else if (userAnswer.ToLower() == "н")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод\n");
                }
            }
        }
    }
}
