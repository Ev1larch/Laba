using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laba6
{
    public class SnakeGame
    {
        private const int HEIGHT = 20;
        private const int WIDTH = 20;
        private const int OBSTACLES_COUNT = 10;
        private int[,] field = new int[HEIGHT, WIDTH];
        private int[] snakeX = new int[100], snakeY = new int[100];
        private int snakeLength = 1, score = 0;
        private int[,] obstacles = new int[OBSTACLES_COUNT, 2];
        private int foodX, foodY;
        private ConsoleKey direction = ConsoleKey.RightArrow;

        /// <summary>
        /// Запускает игру 
        /// </summary>
        public void StartGame()
        {
            while (true)
            {
                InitializeGame();
                bool isGameOver = false;

                while (!isGameOver)
                {
                    DrawField();
                    DirectionLogic();
                    isGameOver = Logic();
                    Thread.Sleep(300);
                }

                Console.Clear();
                Console.WriteLine($"Вы задушили Удава! Количество грешков: {score}");
                Console.WriteLine("Нажмите R, чтобы начать заново, или любую другую клавишу для выхода.");

                if (Console.ReadKey(true).Key != ConsoleKey.R)
                    break;
            }
        }

        /// <summary>
        /// Инициализирует игру
        /// </summary>
        private void InitializeGame()
        {
            Array.Clear(field, 0, field.Length);
            snakeX[0] = HEIGHT / 2;
            snakeY[0] = WIDTH / 2;
            snakeLength = 1;
            score = 0;
            direction = ConsoleKey.RightArrow;
            GenerateObstacles();
            GenerateFood();
        }

        /// <summary>
        /// Генерирует препятствия
        /// </summary>
        private void GenerateObstacles()
        {
            Random rand = new Random();

            for (int i = 0; i < OBSTACLES_COUNT; i++)
            {
                int x = rand.Next(HEIGHT), y = rand.Next(WIDTH);

                while (field[x, y] != 0)
                {
                    x = rand.Next(HEIGHT);
                    y = rand.Next(WIDTH);
                }

                obstacles[i, 0] = x;
                obstacles[i, 1] = y;
                field[x, y] = 2;
            }
        }

        /// <summary>
        /// Генерирует еду
        /// </summary>
        private void GenerateFood()
        {
            Random rand = new Random();

            int x = rand.Next(HEIGHT), y = rand.Next(WIDTH);

            while (field[x, y] != 0 || IsSnakeBody(x, y))
            {
                x = rand.Next(HEIGHT);
                y = rand.Next(WIDTH);
            }

            foodX = x;
            foodY = y;
        }

        /// <summary>
        /// Отрисовывает поле игры и показывает количество очков
        /// </summary>
        private void DrawField()
        {
            Console.Clear();

            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    if (i == snakeX[0] && j == snakeY[0])
                        Console.Write("O");
                    else if (IsSnakeBody(i, j))
                        Console.Write("o");
                    else if (field[i, j] == 2)
                        Console.Write("X");
                    else if (i == foodX && j == foodY)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Грешки: {score}");
        }

        /// <summary>
        /// Логика управления змейкой
        /// </summary>
        private void DirectionLogic()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.UpArrow && direction != ConsoleKey.DownArrow) direction = ConsoleKey.UpArrow;
                if (key == ConsoleKey.DownArrow && direction != ConsoleKey.UpArrow) direction = ConsoleKey.DownArrow;
                if (key == ConsoleKey.LeftArrow && direction != ConsoleKey.RightArrow) direction = ConsoleKey.LeftArrow;
                if (key == ConsoleKey.RightArrow && direction != ConsoleKey.LeftArrow) direction = ConsoleKey.RightArrow;
            }
        }

        /// <summary>
        /// Обрабатывает основную логику игры (движение змейки по полю, коллизию, 
        /// увеличение размера тела после съеденной еды, очков)
        /// </summary>
        /// <returns>Флаг окончания игры </returns>
        private bool Logic()
        {
            int headX = snakeX[0], headY = snakeY[0];
            switch (direction)
            {
                case ConsoleKey.UpArrow:
                    headX--;
                    break;
                case ConsoleKey.DownArrow:
                    headX++;
                    break;
                case ConsoleKey.LeftArrow:
                    headY--;
                    break;
                case ConsoleKey.RightArrow:
                    headY++;
                    break;
            }
            if (headX < 0 || headX >= HEIGHT || headY < 0 || headY >= WIDTH || IsSnakeBody(headX, headY) || field[headX, headY] == 2)
                return true;
            if (headX == foodX && headY == foodY)
            {
                score++;
                snakeLength++;
                GenerateFood();
            }
            for (int i = snakeLength - 1; i > 0; i--)
            {
                snakeX[i] = snakeX[i - 1];
                snakeY[i] = snakeY[i - 1];
            }
            snakeX[0] = headX;
            snakeY[0] = headY;
            return false;
        }

        /// <summary>
        /// Проверяет, является ли заданная позиция частью тела змейки
        /// </summary>
        /// <param name="x"> Координата X </param>
        /// <param name="y"> Координата Y </param>
        /// <returns> Флаг, является ли позиция частью тела змейки </returns>
        private bool IsSnakeBody(int x, int y)
        {
            for (int i = 1; i < snakeLength; i++)
            {
                if (snakeX[i] == x && snakeY[i] == y)
                    return true;
            }
            return false;
        }
    }
}
