using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba6
{
    /// <summary>
    /// Форма для игры "Угадай число".
    /// </summary>
    public partial class GuessingGameForm : Form
    {
        private double correctResult;
        private int attempts;
        private int remainingAttempts;

        /// <summary>
        /// Initializes a new instance of the <see cref="GuessingGameForm"/> class.
        /// </summary>
        public GuessingGameForm()
        {
            InitializeComponent();
            pbxFormula.Image = Image.FromFile("B:\\Learning c#\\Laba6\\Formula.png");
            pbxFormula.SizeMode = PictureBoxSizeMode.StretchImage;
            btnGuess.Enabled = false;
        }

        /// <summary>
        /// Обработчик события Click для кнопки Start. 
        /// Запускает игру и проверяет введенные данные.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAttempts.Text, out attempts) || attempts <= 0)
            {
                MessageBox.Show("Введите положительное количество попыток.");
                return;
            }

            if (!double.TryParse(txtA.Text, out double a) || !double.TryParse(txtB.Text, out double b) || b <= -2)
            {
                MessageBox.Show("Введите допустимые значения для a и b (b должно быть больше -2).");
                return;
            }

            btnGuess.Enabled = true;
            txtA.Enabled = false;
            txtB.Enabled = false;
            txtAttempts.Enabled = false;
            btnStart.Enabled = false;

            remainingAttempts = attempts;
            lblRemainingAttempts.Text = $"Оставшиеся попытки: {remainingAttempts}";

            // Вычисляем правильный результат на основе введенных a и b
            correctResult = CalculateFormula(a, b);
        }

        /// <summary>
        /// Сбрасывает состояние игры.
        /// </summary>
        private void ResetGame()
        {
            // Сброс игры
            txtA.Enabled = true;
            txtB.Enabled = true;
            txtAttempts.Enabled = true;
            btnStart.Enabled = true;
            btnGuess.Enabled = false;
            lblRemainingAttempts.Text = "Оставшиеся попытки: ";
            txtA.Text = "";
            txtB.Text = "";
            txtGuess.Text = "";
            txtAttempts.Text = "";
        }

        /// <summary>
        /// Вычисляет правильный результат на основе заданной формулы.
        /// </summary>
        /// <param name="a">Первый параметр формулы.</param>
        /// <param name="b">Второй параметр формулы.</param>
        /// <returns>Результат вычисления формулы.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если b меньше или равно 0.</exception>
        private double CalculateFormula(double a, double b)
        {
            if (b <= 0)
                throw new ArgumentException("b должно быть больше 0 для логарифма.");
            return Math.Round(-4 * Math.Pow(Math.Sin(3 * a), 3) + (Math.Sqrt(b) / Math.Log(b + 2)), 2);
        }

        /// <summary>
        /// Обработчик события Click для кнопки Guess. 
        /// Проверяет угаданное значение и обрабатывает попытки.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (remainingAttempts <= 0)
            {
                MessageBox.Show("Попытки исчерпаны! Начните заново.");
                return;
            }

            if (!double.TryParse(txtGuess.Text, out double userGuess))
            {
                MessageBox.Show("Введите правильное число для вашей попытки.");
                return;
            }

            remainingAttempts--;
            lblRemainingAttempts.Text = $"Оставшиеся попытки: {remainingAttempts}";

            // Проверка ответа пользователя
            if (Math.Round(userGuess, 2) == Math.Round(correctResult, 2))
            {
                MessageBox.Show("Поздравляем! Вы угадали!");
                ResetGame();
            }
            else
            {
                MessageBox.Show($"Неправильно. ");
                if (remainingAttempts <= 0)
                {
                    MessageBox.Show("Вы исчерпали все попытки! Правильный ответ: " + correctResult.ToString("F2"));
                    ResetGame();
                }
            }
        }

        /// <summary>
        /// Обработчик события Closing для формы. 
        /// Подтверждает, что пользователь хочет выйти.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события, определяющие, должен ли закрыть форму.</param>
        private void GuessingGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            string message = "Вы точно хотите выйти?";
            string caption = "Выход";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Обработчик события Load для формы.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void GuessingGameForm_Load(object sender, EventArgs e)
        {

        }
    }
}