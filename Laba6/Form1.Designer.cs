namespace Laba6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartSnakeGame = new System.Windows.Forms.Button();
            this.btnArraysFormStart = new System.Windows.Forms.Button();
            this.btnGuessingGame = new System.Windows.Forms.Button();
            this.btnAuthorInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartSnakeGame
            // 
            this.btnStartSnakeGame.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnStartSnakeGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartSnakeGame.Location = new System.Drawing.Point(12, 158);
            this.btnStartSnakeGame.Name = "btnStartSnakeGame";
            this.btnStartSnakeGame.Size = new System.Drawing.Size(224, 113);
            this.btnStartSnakeGame.TabIndex = 0;
            this.btnStartSnakeGame.Text = "Удавчик";
            this.btnStartSnakeGame.UseVisualStyleBackColor = false;
            this.btnStartSnakeGame.Click += new System.EventHandler(this.OpenSnakeGameForm);
            // 
            // btnArraysFormStart
            // 
            this.btnArraysFormStart.BackColor = System.Drawing.Color.Aquamarine;
            this.btnArraysFormStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnArraysFormStart.Location = new System.Drawing.Point(546, 158);
            this.btnArraysFormStart.Name = "btnArraysFormStart";
            this.btnArraysFormStart.Size = new System.Drawing.Size(224, 113);
            this.btnArraysFormStart.TabIndex = 1;
            this.btnArraysFormStart.Text = "Массивчики";
            this.btnArraysFormStart.UseVisualStyleBackColor = false;
            this.btnArraysFormStart.Click += new System.EventHandler(this.OpenArraysForm);
            // 
            // btnGuessingGame
            // 
            this.btnGuessingGame.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnGuessingGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGuessingGame.Location = new System.Drawing.Point(12, 304);
            this.btnGuessingGame.Name = "btnGuessingGame";
            this.btnGuessingGame.Size = new System.Drawing.Size(224, 113);
            this.btnGuessingGame.TabIndex = 2;
            this.btnGuessingGame.Text = "Угадайка";
            this.btnGuessingGame.UseVisualStyleBackColor = false;
            this.btnGuessingGame.Click += new System.EventHandler(this.btnGuessingGame_Click);
            // 
            // btnAuthorInfo
            // 
            this.btnAuthorInfo.BackColor = System.Drawing.Color.Aqua;
            this.btnAuthorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuthorInfo.Location = new System.Drawing.Point(546, 304);
            this.btnAuthorInfo.Name = "btnAuthorInfo";
            this.btnAuthorInfo.Size = new System.Drawing.Size(224, 113);
            this.btnAuthorInfo.TabIndex = 3;
            this.btnAuthorInfo.Text = "Автор";
            this.btnAuthorInfo.UseVisualStyleBackColor = false;
            this.btnAuthorInfo.Click += new System.EventHandler(this.btnAuthorInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вот она, финалочка";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(279, 428);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(224, 113);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Закрыть\r\nпрограмму\r\n";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAuthorInfo);
            this.Controls.Add(this.btnGuessingGame);
            this.Controls.Add(this.btnArraysFormStart);
            this.Controls.Add(this.btnStartSnakeGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartSnakeGame;
        private System.Windows.Forms.Button btnArraysFormStart;
        private System.Windows.Forms.Button btnGuessingGame;
        private System.Windows.Forms.Button btnAuthorInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}

