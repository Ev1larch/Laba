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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenSnakeGameForm(object sender, EventArgs e)
        {
            SnakeGameForm form = new SnakeGameForm();
            form.FormClosed += (s, args) => this.Show(); 
            this.Hide(); 
            form.ShowDialog();
        }

        private void OpenArraysForm(object sender, EventArgs e)
        {
            ArraysForm form = new ArraysForm();
            form.FormClosed += (s, args) => this.Show(); 
            this.Hide(); 
            form.ShowDialog();
        }

        private void btnGuessingGame_Click(object sender, EventArgs e)
        {
            GuessingGameForm form = new GuessingGameForm();
            form.FormClosed += (s, args) => this.Show(); 
            this.Hide(); 
            form.ShowDialog();
        }

        private void btnAuthorInfo_Click(object sender, EventArgs e)
        {
            InfoForm form = new InfoForm();
            form.FormClosed += (s, args) => this.Show(); 
            this.Hide(); 
            form.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
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
    }
}