
namespace Tyuiu.ShtolVA.Sprint6.Task3.V29
{
    partial class FormMain
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
            this.groupBoxUslovie_SVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SVA = new System.Windows.Forms.DataGridView();
            this.textBoxUslovie_SVA = new System.Windows.Forms.TextBox();
            this.groupBoxVivod_SVA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SVA = new System.Windows.Forms.TextBox();
            this.labelResult_SVA = new System.Windows.Forms.Label();
            this.buttonSpravka_SVA = new System.Windows.Forms.Button();
            this.buttonDone_SVA = new System.Windows.Forms.Button();
            this.groupBoxUslovie_SVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SVA)).BeginInit();
            this.groupBoxVivod_SVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_SVA
            // 
            this.groupBoxUslovie_SVA.Controls.Add(this.dataGridViewResult_SVA);
            this.groupBoxUslovie_SVA.Controls.Add(this.textBoxUslovie_SVA);
            this.groupBoxUslovie_SVA.Location = new System.Drawing.Point(25, 29);
            this.groupBoxUslovie_SVA.Name = "groupBoxUslovie_SVA";
            this.groupBoxUslovie_SVA.Size = new System.Drawing.Size(802, 409);
            this.groupBoxUslovie_SVA.TabIndex = 0;
            this.groupBoxUslovie_SVA.TabStop = false;
            this.groupBoxUslovie_SVA.Text = "Условие";
            // 
            // dataGridViewResult_SVA
            // 
            this.dataGridViewResult_SVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SVA.ColumnHeadersVisible = false;
            this.dataGridViewResult_SVA.Location = new System.Drawing.Point(412, 31);
            this.dataGridViewResult_SVA.Name = "dataGridViewResult_SVA";
            this.dataGridViewResult_SVA.ReadOnly = true;
            this.dataGridViewResult_SVA.RowHeadersVisible = false;
            this.dataGridViewResult_SVA.RowHeadersWidth = 51;
            this.dataGridViewResult_SVA.RowTemplate.Height = 24;
            this.dataGridViewResult_SVA.Size = new System.Drawing.Size(364, 354);
            this.dataGridViewResult_SVA.TabIndex = 1;
            this.dataGridViewResult_SVA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_SVA_CellContentClick);
            // 
            // textBoxUslovie_SVA
            // 
            this.textBoxUslovie_SVA.Location = new System.Drawing.Point(6, 15);
            this.textBoxUslovie_SVA.Multiline = true;
            this.textBoxUslovie_SVA.Name = "textBoxUslovie_SVA";
            this.textBoxUslovie_SVA.ReadOnly = true;
            this.textBoxUslovie_SVA.Size = new System.Drawing.Size(789, 388);
            this.textBoxUslovie_SVA.TabIndex = 0;
            this.textBoxUslovie_SVA.Text = "Дана матрица 5 на 5 \r\n-2 -13 -15 -9  -17\r\n 13 -20 -15  27  18\r\n-12 -1  -20  13   " +
    " 0 \r\n 15  32  18 -12 -18\r\n 16   5    3   -5    -8\r\nвыполнить сортировку по возвр" +
    "астанию в пятом столбце.\r\n";
            this.textBoxUslovie_SVA.TextChanged += new System.EventHandler(this.textBoxUslovie_SVA_TextChanged);
            // 
            // groupBoxVivod_SVA
            // 
            this.groupBoxVivod_SVA.Controls.Add(this.textBoxResult_SVA);
            this.groupBoxVivod_SVA.Controls.Add(this.labelResult_SVA);
            this.groupBoxVivod_SVA.Location = new System.Drawing.Point(833, 29);
            this.groupBoxVivod_SVA.Name = "groupBoxVivod_SVA";
            this.groupBoxVivod_SVA.Size = new System.Drawing.Size(182, 110);
            this.groupBoxVivod_SVA.TabIndex = 1;
            this.groupBoxVivod_SVA.TabStop = false;
            this.groupBoxVivod_SVA.Text = "Вывод данных";
            // 
            // textBoxResult_SVA
            // 
            this.textBoxResult_SVA.Location = new System.Drawing.Point(10, 61);
            this.textBoxResult_SVA.Name = "textBoxResult_SVA";
            this.textBoxResult_SVA.ReadOnly = true;
            this.textBoxResult_SVA.Size = new System.Drawing.Size(100, 22);
            this.textBoxResult_SVA.TabIndex = 1;
            this.textBoxResult_SVA.TextChanged += new System.EventHandler(this.textBoxResult_SVA_TextChanged);
            // 
            // labelResult_SVA
            // 
            this.labelResult_SVA.AutoSize = true;
            this.labelResult_SVA.Location = new System.Drawing.Point(7, 31);
            this.labelResult_SVA.Name = "labelResult_SVA";
            this.labelResult_SVA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SVA.TabIndex = 0;
            this.labelResult_SVA.Text = "Результат:";
            // 
            // buttonSpravka_SVA
            // 
            this.buttonSpravka_SVA.Location = new System.Drawing.Point(843, 406);
            this.buttonSpravka_SVA.Name = "buttonSpravka_SVA";
            this.buttonSpravka_SVA.Size = new System.Drawing.Size(39, 32);
            this.buttonSpravka_SVA.TabIndex = 3;
            this.buttonSpravka_SVA.Text = "?";
            this.buttonSpravka_SVA.UseVisualStyleBackColor = true;
            this.buttonSpravka_SVA.Click += new System.EventHandler(this.buttonSpravka_SVA_Click_);
            // 
            // buttonDone_SVA
            // 
            this.buttonDone_SVA.Location = new System.Drawing.Point(888, 408);
            this.buttonDone_SVA.Name = "buttonDone_SVA";
            this.buttonDone_SVA.Size = new System.Drawing.Size(103, 30);
            this.buttonDone_SVA.TabIndex = 4;
            this.buttonDone_SVA.Text = "Выполнить";
            this.buttonDone_SVA.UseVisualStyleBackColor = true;
            this.buttonDone_SVA.Click += new System.EventHandler(this.buttonDone_SVA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.buttonDone_SVA);
            this.Controls.Add(this.buttonSpravka_SVA);
            this.Controls.Add(this.groupBoxVivod_SVA);
            this.Controls.Add(this.groupBoxUslovie_SVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 29 | Штоль В.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUslovie_SVA.ResumeLayout(false);
            this.groupBoxUslovie_SVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SVA)).EndInit();
            this.groupBoxVivod_SVA.ResumeLayout(false);
            this.groupBoxVivod_SVA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_SVA;
        private System.Windows.Forms.TextBox textBoxUslovie_SVA;
        private System.Windows.Forms.GroupBox groupBoxVivod_SVA;
        private System.Windows.Forms.TextBox textBoxResult_SVA;
        private System.Windows.Forms.Label labelResult_SVA;
        private System.Windows.Forms.Button buttonSpravka_SVA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SVA;
        private System.Windows.Forms.Button buttonDone_SVA;
    }
}

