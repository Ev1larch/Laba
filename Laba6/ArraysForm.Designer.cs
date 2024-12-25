namespace Laba6
{
    partial class ArraysForm
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
            this.btnInitializeArray = new System.Windows.Forms.Button();
            this.btnGenerateRandomArray = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnFindMin = new System.Windows.Forms.Button();
            this.btnCalculateMean = new System.Windows.Forms.Button();
            this.txtArraySize = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Значение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMinFind = new System.Windows.Forms.Button();
            this.btnFindMax = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInitializeArray
            // 
            this.btnInitializeArray.Location = new System.Drawing.Point(12, 479);
            this.btnInitializeArray.Name = "btnInitializeArray";
            this.btnInitializeArray.Size = new System.Drawing.Size(98, 65);
            this.btnInitializeArray.TabIndex = 0;
            this.btnInitializeArray.Text = "Создать массив по\r\n дефолту";
            this.btnInitializeArray.UseVisualStyleBackColor = true;
            this.btnInitializeArray.Click += new System.EventHandler(this.btnInitializeArray_Click);
            // 
            // btnGenerateRandomArray
            // 
            this.btnGenerateRandomArray.Location = new System.Drawing.Point(132, 493);
            this.btnGenerateRandomArray.Name = "btnGenerateRandomArray";
            this.btnGenerateRandomArray.Size = new System.Drawing.Size(98, 46);
            this.btnGenerateRandomArray.TabIndex = 1;
            this.btnGenerateRandomArray.Text = "Случайный массив";
            this.btnGenerateRandomArray.UseVisualStyleBackColor = true;
            this.btnGenerateRandomArray.Click += new System.EventHandler(this.btnGenerateRandomArray_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(424, 488);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(98, 48);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Сортируем";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnFindMin
            // 
            this.btnFindMin.Location = new System.Drawing.Point(0, 0);
            this.btnFindMin.Name = "btnFindMin";
            this.btnFindMin.Size = new System.Drawing.Size(75, 23);
            this.btnFindMin.TabIndex = 7;
            // 
            // btnCalculateMean
            // 
            this.btnCalculateMean.Location = new System.Drawing.Point(736, 488);
            this.btnCalculateMean.Name = "btnCalculateMean";
            this.btnCalculateMean.Size = new System.Drawing.Size(134, 48);
            this.btnCalculateMean.TabIndex = 4;
            this.btnCalculateMean.Text = "Среднее Арифметическое";
            this.btnCalculateMean.UseVisualStyleBackColor = true;
            this.btnCalculateMean.Click += new System.EventHandler(this.btnCalculateMean_Click);
            // 
            // txtArraySize
            // 
            this.txtArraySize.Location = new System.Drawing.Point(236, 505);
            this.txtArraySize.Name = "txtArraySize";
            this.txtArraySize.Size = new System.Drawing.Size(84, 22);
            this.txtArraySize.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Значение});
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(881, 472);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // Значение
            // 
            this.Значение.HeaderText = "Value";
            this.Значение.MinimumWidth = 6;
            this.Значение.Name = "Значение";
            this.Значение.ReadOnly = true;
            this.Значение.Width = 125;
            // 
            // btnMinFind
            // 
            this.btnMinFind.Location = new System.Drawing.Point(528, 487);
            this.btnMinFind.Name = "btnMinFind";
            this.btnMinFind.Size = new System.Drawing.Size(98, 48);
            this.btnMinFind.TabIndex = 8;
            this.btnMinFind.Text = "Поиск Min";
            this.btnMinFind.UseVisualStyleBackColor = true;
            this.btnMinFind.Click += new System.EventHandler(this.btnMinFind_Click);
            // 
            // btnFindMax
            // 
            this.btnFindMax.Location = new System.Drawing.Point(632, 488);
            this.btnFindMax.Name = "btnFindMax";
            this.btnFindMax.Size = new System.Drawing.Size(98, 49);
            this.btnFindMax.TabIndex = 9;
            this.btnFindMax.Text = "Поиск Max";
            this.btnFindMax.UseVisualStyleBackColor = true;
            this.btnFindMax.Click += new System.EventHandler(this.btnFindMax_Click);
            // 
            // ArraysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btnFindMax);
            this.Controls.Add(this.btnMinFind);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtArraySize);
            this.Controls.Add(this.btnCalculateMean);
            this.Controls.Add(this.btnFindMin);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnGenerateRandomArray);
            this.Controls.Add(this.btnInitializeArray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ArraysForm";
            this.Text = "ArraysForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArraysForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInitializeArray;
        private System.Windows.Forms.Button btnGenerateRandomArray;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnFindMin;
        private System.Windows.Forms.Button btnCalculateMean;
        private System.Windows.Forms.TextBox txtArraySize;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Значение;
        private System.Windows.Forms.Button btnMinFind;
        private System.Windows.Forms.Button btnFindMax;
    }
}