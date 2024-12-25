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
    /// <summary>
    /// Форма информации, отображающая изображения и сообщения пользователю.
    /// </summary>
    public partial class InfoForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoForm"/> class.
        /// </summary>
        public InfoForm()
        {
            InitializeComponent();
            pbxAuthor.Image = Image.FromFile("B:\\Learning c#\\Laba6\\GigaChad2.jpeg");
            pbxAuthor.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// Обработчик события закрытия формы.
        /// Выводит сообщение с запросом о выходе из формы.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события, определяющие, должен ли закрыть форму.</param>
        private void InfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            string message = "Вы устали смотреть на своё прекрасное лицо?";
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
    }
}