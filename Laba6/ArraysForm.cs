using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Laba6
{
    /// <summary>
    /// Основная форма приложения для работы с массивами.
    /// </summary>
    public partial class ArraysForm : Form
    {
        private ArrayManager arrayManager;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ArraysForm"/>.
        /// </summary>
        public ArraysForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация DataGridView для отображения значений массива.
        /// </summary>
        private void InitializeDataGridView()
        {
            dataGridView1.RowCount = arrayManager.Array.Length;
            for (int i = 0; i < arrayManager.Array.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = arrayManager.Array[i];
            }
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CellValidating += dataGridView1_CellValidating;
        }

        /// <summary>
        /// Установка размера массива по умолчанию при нажатии кнопки.
        /// </summary>
        private void btnInitializeArray_Click(object sender, EventArgs e)
        {
            txtArraySize.Text = "10"; // Установить размер массива по умолчанию
        }

        /// <summary>
        /// Генерация случайного массива и обновление отображения в DataGridView.
        /// </summary>
        private void btnGenerateRandomArray_Click(object sender, EventArgs e)
        {
            int count;
            if (int.TryParse(txtArraySize.Text, out count) && count > 0 && count <= 100)
            {
                arrayManager = new ArrayManager(count);
                int[] randomArray = ArrayManager.Initialization(count);
                arrayManager.SetArray(randomArray);
                UpdateDataGridView(randomArray); // Обновление DataGridView
                InitializeDataGridView();
            }
            else
            {
                MessageBox.Show("Введите корректный размер массива.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обновление содержимого DataGridView.
        /// </summary>
        private void UpdateDataGridView(int[] array)
        {
            InitializeDataGridView();
        }

        /// <summary>
        /// Валидация ввода значения в ячейку DataGridView.
        /// </summary>
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int newValue;
                if (!int.TryParse(e.FormattedValue.ToString(), out newValue))
                {
                    e.Cancel = true;
                    MessageBox.Show("Введите корректное число");
                }
            }
        }

        /// <summary>
        /// Сортировка массива при нажатии кнопки.
        /// </summary>
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (arrayManager != null)
            {
                arrayManager.GnomeSort();
                int[] array = arrayManager.GetArray();
                UpdateDataGridView(array); // Обновляем содержимое DataGridView
            }
        }

        /// <summary>
        /// Вычисление среднего арифметического массива и отображение результата.
        /// </summary>
        private void btnCalculateMean_Click(object sender, EventArgs e)
        {
            if (arrayManager != null)
            {
                double mean = arrayManager.CalculateMean();
                MessageBox.Show($"Среднее арифметическое: {mean}", "Результат", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Обработка изменения значения в ячейке DataGridView.
        /// </summary>
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (arrayManager != null && e.RowIndex >= 0 && e.RowIndex < arrayManager.GetArray().Length)
            {
                int newValue;
                if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]?.Value?.ToString(), out newValue))
                {
                    arrayManager.SetValue(e.RowIndex, newValue);
                }
            }
        }

        /// <summary>
        /// Поиск минимального значения массива и подсветка его.
        /// </summary>
        private void btnMinFind_Click(object sender, EventArgs e)
        {
            if (arrayManager != null)
            {
                int min = arrayManager.FindMin();
                HighlightMin(min);
            }
        }

        /// <summary>
        /// Поиск максимального значения массива и подсветка его.
        /// </summary>
        private void btnFindMax_Click(object sender, EventArgs e)
        {
            if (arrayManager != null)
            {
                int max = arrayManager.FindMax();
                HighlightMax(max);
            }
        }

        /// <summary>
        /// Подсветка максимального значения в DataGridView.
        /// </summary>
        /// <param name="max">Максимальное значение для подсветки.</param>
        private void HighlightMax(int max)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White; // Сброс цвета
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value is int value)
                {
                    if (value == max)
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Подсветка минимального значения в DataGridView.
        /// </summary>
        /// <param name="min">Минимальное значение для подсветки.</param>
        private void HighlightMin(int min)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value is int value)
                {
                    if (value == min)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        break;
                    }
                }
            }
        }
        private void ArraysForm_FormClosing(object sender, FormClosingEventArgs e)
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
        }

        /// <summary>
        /// Класс для управления массивом.
        /// </summary>
        public class ArrayManager
        {
            private int[] _array;

            /// <summary>
            /// Инициализирует новый экземпляр класса <see cref="ArrayManager"/>.
            /// </summary>
            /// <param name="size">Размер массива.</param>
            public ArrayManager(int size)
            {
                _array = new int[size]; // Создаем массив указанного размера 
            }

            /// <summary>
            /// Получает массив.
            /// </summary>
            public int[] Array
            {
                get { return _array; }
            }

            /// <summary>
            /// Инициализация массива со случайными значениями.
            /// </summary>
            /// <param name="size">Размер массива.</param>
            /// <returns>Случайный массив.</returns>
            public static int[] Initialization(int size)
            {
                int[] array = new int[size];
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(1, 101); // Случайные значения от 1 до 100 
                }
                return array;
            }

            /// <summary>
            /// Сортировка массива методом гнома.
            /// </summary>
            public void GnomeSort()
            {
                if (_array == null || _array.Length == 0) return; // Проверка массива 
                int i = 0;
                while (i < _array.Length)
                {
                    if (i == 0 || _array[i] >= _array[i - 1])
                    {
                        i++;
                    }
                    else
                    {
                        int temp = _array[i];
                        _array[i] = _array[i - 1];
                        _array[i - 1] = temp;
                        i--;
                    }
                }
            }

            /// <summary>
            /// Находит максимальное значение в массиве.
            /// </summary>
            /// <returns>Максимальное значение.</returns>
            /// <exception cref="InvalidOperationException">Выбрасывается, если массив пуст.</exception>
            public int FindMax()
            {
                if (_array == null || _array.Length == 0)
                {
                    throw new InvalidOperationException("Массив пуст.");
                }
                return _array.Max();
            }

            /// <summary>
            /// Находит минимальное значение в массиве.
            /// </summary>
            /// <returns>Минимальное значение.</returns>
            /// <exception cref="InvalidOperationException">Выбрасывается, если массив пуст.</exception>
            public int FindMin()
            {
                if (_array == null || _array.Length == 0)
                {
                    throw new InvalidOperationException("Массив пуст.");
                }
                return _array.Min();
            }

            /// <summary>
            /// Вычисляет среднее арифметическое значений в массиве.
            /// </summary>
            /// <returns>Среднее арифметическое.</returns>
            /// <exception cref="InvalidOperationException">Выбрасывается, если массив пуст.</exception>
            public double CalculateMean()
            {
                if (_array == null || _array.Length == 0)
                {
                    throw new InvalidOperationException("Массив пуст.");
                }
                return _array.Average();
            }

            /// <summary>
            /// Получает значения массива.
            /// </summary>
            /// <returns>Массив значений.</returns>
            public int[] GetArray()
            {
                return _array;
            }

            /// <summary>
            /// Устанавливает значения массива.
            /// </summary>
            /// <param name="array">Новый массив значений.</param>
            public void SetArray(int[] array)
            {
                _array = array;
            }

            /// <summary>
            /// Устанавливает значение по индексу в массиве.
            /// </summary>
            /// <param name="index">Индекс, по которому устанавливается значение.</param>
            /// <param name="value">Значение.</param>
            /// <exception cref="IndexOutOfRangeException">Выбрасывается, если индекс вне диапазона.</exception>
            public void SetValue(int index, int value)
            {
                if (index >= 0 && index < _array.Length)
                {
                    _array[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
                }
            }
        }
    }
}

