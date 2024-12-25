using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba6
{
    public partial class SnakeGameForm : Form
    {
        private const int HEIGHT = 20;
        private const int WIDTH = 20;
        private const int OBSTACLES_COUNT = 10;
        private const int cellSize = 20;
        private const int keyPressDelay = 150;
        private bool isGameOver = false;
        private int[,] field = new int[HEIGHT, WIDTH];
        private int[] snakeX = new int[100], snakeY = new int[100];
        private int snakeLength = 1, score = 0, maxScore = 0;
        private int[,] obstacles = new int[OBSTACLES_COUNT, 2];
        private int foodX, foodY;
        private Keys direction = Keys.D;
        private Timer gameTimer;
        private DateTime lastKeyPressTime = DateTime.Now;
        public SnakeGameForm()
        {
            InitializeComponent();
            gameTimer = new Timer();
            gameTimer.Interval = 300;
            gameTimer.Tick += TimerTick;
            lblCurrentScore.Visible = false;
            lblMaxScore.Visible = false;
            CenterButton();
        }
        
        private void StartGame()
        {
            isGameOver = false;
            lblCurrentScore.Visible = true;
            lblMaxScore.Visible = true;
            score = 0;
            snakeLength = 1;
            direction = Keys.D;
            btnStartGame.Visible = false;
            gameTimer.Start(); 
            GameField.Invalidate();
            InitializeGame();
        }

        private void InitializeGame()
        {
            Array.Clear(field, 0, field.Length);
            snakeX[0] = HEIGHT / 2;
            snakeY[0] = WIDTH / 2;
            GenerateObstacles();
            GenerateFood();
            GameField.Refresh();
        }


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

        private bool IsSnakeBody(int x, int y)
        {
            for (int i = 1; i < snakeLength; i++)
            {
                if (snakeX[i] == x && snakeY[i] == y)
                    return true;
            }
            return false;
        }
        private void StartGameButtonClick(object sender, EventArgs e)
        {
            StartGame();
        }
        private bool Logic()
        {
            int newHeadX = snakeX[0];
            int newHeadY = snakeY[0];

           
            switch (direction)
            {
                case Keys.W: newHeadX--; break;
                case Keys.S: newHeadX++; break;
                case Keys.A: newHeadY--; break;
                case Keys.D: newHeadY++; break;
            }

            
            if (newHeadX < 0 || newHeadX >= HEIGHT ||
                newHeadY < 0 || newHeadY >= WIDTH ||
                field[newHeadX, newHeadY] == 2)
            {
                return true; 
            }

            if (IsSnakeBody(newHeadX, newHeadY))
            {
                return true; 
            }

            
            if (newHeadX == foodX && newHeadY == foodY)
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
            snakeX[0] = newHeadX;
            snakeY[0] = newHeadY;
        return false;
        }



        private void GameField_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            // Удаляем старую голову змейки и тело
                Rectangle oldHeadCell = new Rectangle(snakeY[0] * cellSize, snakeX[0] * cellSize, cellSize, cellSize);
                graphics.FillRectangle(Brushes.White, oldHeadCell); 

                
                for (int i = 1; i < snakeLength; i++)
                {
                    Rectangle bodyCell = new Rectangle(snakeY[i] * cellSize, snakeX[i] * cellSize, cellSize, cellSize);
                    graphics.FillRectangle(Brushes.White, bodyCell); 
                }

                // Рисуем новую голову змейки и тело
                Rectangle newHeadCell = new Rectangle(snakeY[0] * cellSize, snakeX[0] * cellSize, cellSize, cellSize);
                graphics.FillRectangle(Brushes.LightGreen, newHeadCell);

                
                for (int i = 1; i < snakeLength; i++)
                {
                    Rectangle bodyCell = new Rectangle(snakeY[i] * cellSize, snakeX[i] * cellSize, cellSize, cellSize);
                    graphics.FillRectangle(Brushes.DarkGreen, bodyCell);
                }

                // Если еда была съедена, обновляем позицию
                Rectangle foodCell = new Rectangle(foodY * cellSize, foodX * cellSize, cellSize, cellSize);
                graphics.FillEllipse(Brushes.Yellow, foodCell);

                // Препятствия
                for (int i = 0; i < OBSTACLES_COUNT; i++)
                {
                    Rectangle obstacleCell = new Rectangle(obstacles[i, 1] * cellSize, obstacles[i, 0] * cellSize, cellSize, cellSize);
                    graphics.FillRectangle(Brushes.Red, obstacleCell);
                }

                // Рисуем сетку (границы черных линий)
                for (int i = 0; i <= HEIGHT; i++)
                {
                    graphics.DrawLine(Pens.Black, 0, i * cellSize, WIDTH * cellSize, i * cellSize); 
                }
                for (int j = 0; j <= WIDTH; j++)
                {
                    graphics.DrawLine(Pens.Black, j * cellSize, 0, j * cellSize, HEIGHT * cellSize); 
                }

                lblCurrentScore.Text = $"Очки: {score}";
                lblMaxScore.Text = $"Максимум: {maxScore}";
        }


        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if ((DateTime.Now - lastKeyPressTime).TotalMilliseconds < keyPressDelay) return; // Добавляем задержку
            lastKeyPressTime = DateTime.Now;
            if ((direction == Keys.W && e.KeyCode == Keys.S) || (direction == Keys.W && e.KeyCode == Keys.Down) ||
            (direction == Keys.S && e.KeyCode == Keys.W) || (direction == Keys.S && e.KeyCode == Keys.Up) ||
            (direction == Keys.A && e.KeyCode == Keys.D) || (direction == Keys.A && e.KeyCode == Keys.Right) ||
            (direction == Keys.D && e.KeyCode == Keys.A) || (direction == Keys.D && e.KeyCode == Keys.Left)) 
            {
                return;
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) direction = Keys.W;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) direction = Keys.S;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) direction = Keys.A;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) direction = Keys.D;
           
        }

        private void TimerTick(object sender, EventArgs e)
        {

            if (Logic())
            {
                GameOver();
            }

            GameField.Invalidate();
        }
        private void GameOver()
        {
            isGameOver = true;
            gameTimer.Stop(); 
            MessageBox.Show($"Игра окончена! Ваш счёт: {score}"); 

            if (score > maxScore)
            {
                maxScore = score; 
            }
            lblCurrentScore.Visible = false;
            lblMaxScore.Visible = false;
            CenterButton();
            btnStartGame.Visible = true;
            btnStartGame.Text = "Ещё разок?";
        }

        private void CenterButton()
        {
            btnStartGame.Location = new Point((GameField.Width - btnStartGame.Width) / 2, (GameField.Height - btnStartGame.Height) / 2);
        }

        private void SnakeGameFormClosing(object sender, FormClosingEventArgs e)
        {
            gameTimer.Stop();
            DialogResult result;
            string message = "Вы точно хотите выйти?";
            string caption = "Выход";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                gameTimer.Stop();
            }
            else
            {
                e.Cancel = true;
                if (!isGameOver)
                {
                    gameTimer.Start();
                }
            }
        }
    }
}
