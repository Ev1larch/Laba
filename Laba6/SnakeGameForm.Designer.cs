namespace Laba6
{
    partial class SnakeGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.lblMaxScore = new System.Windows.Forms.Label();
            this.GameField = new System.Windows.Forms.Panel();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.GameField.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentScore.Location = new System.Drawing.Point(541, 9);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(95, 27);
            this.lblCurrentScore.TabIndex = 0;
            this.lblCurrentScore.Text = "Очки: 0";
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.AutoSize = true;
            this.lblMaxScore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxScore.Location = new System.Drawing.Point(541, 54);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(136, 24);
            this.lblMaxScore.TabIndex = 1;
            this.lblMaxScore.Text = "Максимум: 0";
            // 
            // GameField
            // 
            this.GameField.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GameField.Controls.Add(this.btnStartGame);
            this.GameField.Location = new System.Drawing.Point(0, 0);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(535, 495);
            this.GameField.TabIndex = 2;
            this.GameField.Paint += new System.Windows.Forms.PaintEventHandler(this.GameField_Paint);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStartGame.Location = new System.Drawing.Point(213, 207);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(100, 60);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Начнём?";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.StartGameButtonClick);
            // 
            // timer
            // 
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // SnakeGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 493);
            this.Controls.Add(this.GameField);
            this.Controls.Add(this.lblMaxScore);
            this.Controls.Add(this.lblCurrentScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "SnakeGameForm";
            this.Text = "SnakeGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SnakeGameFormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.GameField.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.Label lblMaxScore;
        private System.Windows.Forms.Panel GameField;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Timer timer;
    }
}