namespace Laba6
{
    partial class InfoForm
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
            this.pbxAuthor = new System.Windows.Forms.PictureBox();
            this.lblTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxAuthor
            // 
            this.pbxAuthor.Location = new System.Drawing.Point(3, -1);
            this.pbxAuthor.Name = "pbxAuthor";
            this.pbxAuthor.Size = new System.Drawing.Size(1091, 765);
            this.pbxAuthor.TabIndex = 0;
            this.pbxAuthor.TabStop = false;
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTxt.Location = new System.Drawing.Point(70, 767);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(830, 50);
            this.lblTxt.TabIndex = 1;
            this.lblTxt.Text = "Создатель - Жулимов Андрей 6102. Сверху не он, а тот, кто сейчас проверяет эту ла" +
    "бу\r\n\r\n";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1094, 803);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.pbxAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAuthor;
        private System.Windows.Forms.Label lblTxt;
    }
}