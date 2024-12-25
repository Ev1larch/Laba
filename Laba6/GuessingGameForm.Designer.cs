namespace Laba6
{
    partial class GuessingGameForm
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
            this.lblRemainingAttempts = new System.Windows.Forms.Label();
            this.pbxFormula = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtAttempts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAttemptsCount = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRemainingAttempts
            // 
            this.lblRemainingAttempts.AutoSize = true;
            this.lblRemainingAttempts.Location = new System.Drawing.Point(323, 228);
            this.lblRemainingAttempts.Name = "lblRemainingAttempts";
            this.lblRemainingAttempts.Size = new System.Drawing.Size(150, 16);
            this.lblRemainingAttempts.TabIndex = 2;
            this.lblRemainingAttempts.Text = "Оставшиеся попытки: ";
            // 
            // pbxFormula
            // 
            this.pbxFormula.Location = new System.Drawing.Point(12, 12);
            this.pbxFormula.Name = "pbxFormula";
            this.pbxFormula.Size = new System.Drawing.Size(776, 159);
            this.pbxFormula.TabIndex = 3;
            this.pbxFormula.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(344, 247);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 66);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Поиграем?";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(688, 232);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(688, 291);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 6;
            // 
            // txtAttempts
            // 
            this.txtAttempts.Location = new System.Drawing.Point(660, 416);
            this.txtAttempts.Name = "txtAttempts";
            this.txtAttempts.Size = new System.Drawing.Size(100, 22);
            this.txtAttempts.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(693, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Параметр a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Параметр b";
            // 
            // lblAttemptsCount
            // 
            this.lblAttemptsCount.AutoSize = true;
            this.lblAttemptsCount.Location = new System.Drawing.Point(625, 397);
            this.lblAttemptsCount.Name = "lblAttemptsCount";
            this.lblAttemptsCount.Size = new System.Drawing.Size(163, 16);
            this.lblAttemptsCount.TabIndex = 10;
            this.lblAttemptsCount.Text = "Задайте число попыток";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(353, 349);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 22);
            this.txtGuess.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ваш ответ";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(344, 377);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(119, 66);
            this.btnGuess.TabIndex = 13;
            this.btnGuess.Text = "Ответить";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // GuessingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblAttemptsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAttempts);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbxFormula);
            this.Controls.Add(this.lblRemainingAttempts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GuessingGameForm";
            this.Text = "GuessingGameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuessingGameForm_FormClosing);
            this.Load += new System.EventHandler(this.GuessingGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRemainingAttempts;
        private System.Windows.Forms.PictureBox pbxFormula;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtAttempts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAttemptsCount;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuess;
    }
}