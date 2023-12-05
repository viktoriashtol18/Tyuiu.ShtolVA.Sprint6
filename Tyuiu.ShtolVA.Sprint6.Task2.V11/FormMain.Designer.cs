
namespace Tyuiu.ShtolVA.Sprint6.Task2.V11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxUslovie_SVA = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_SVA = new System.Windows.Forms.TextBox();
            this.groupBoxVvod_SVA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_SVA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SVA = new System.Windows.Forms.TextBox();
            this.labelStop_SVA = new System.Windows.Forms.Label();
            this.labelStart_SVA = new System.Windows.Forms.Label();
            this.buttonSpravka_SVA = new System.Windows.Forms.Button();
            this.dataGridViewResult_SVA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDone_SVA = new System.Windows.Forms.Button();
            this.groupBoxVivod_SVA = new System.Windows.Forms.GroupBox();
            this.chartGraf_SVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_SVA = new System.Windows.Forms.Label();
            this.groupBoxUslovie_SVA.SuspendLayout();
            this.groupBoxVvod_SVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SVA)).BeginInit();
            this.groupBoxVivod_SVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_SVA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_SVA
            // 
            this.groupBoxUslovie_SVA.Controls.Add(this.textBoxUslovie_SVA);
            this.groupBoxUslovie_SVA.Location = new System.Drawing.Point(12, 21);
            this.groupBoxUslovie_SVA.Name = "groupBoxUslovie_SVA";
            this.groupBoxUslovie_SVA.Size = new System.Drawing.Size(522, 297);
            this.groupBoxUslovie_SVA.TabIndex = 0;
            this.groupBoxUslovie_SVA.TabStop = false;
            this.groupBoxUslovie_SVA.Text = "Условие";
            // 
            // textBoxUslovie_SVA
            // 
            this.textBoxUslovie_SVA.Location = new System.Drawing.Point(6, 21);
            this.textBoxUslovie_SVA.Multiline = true;
            this.textBoxUslovie_SVA.Name = "textBoxUslovie_SVA";
            this.textBoxUslovie_SVA.ReadOnly = true;
            this.textBoxUslovie_SVA.Size = new System.Drawing.Size(510, 276);
            this.textBoxUslovie_SVA.TabIndex = 0;
            this.textBoxUslovie_SVA.Text = "Протабулировать функцию cos(x)/x+1 - cos(x) * 1,3 + 3x на заданном диапазоне.Резу" +
    "льтат вывести в DataGndView и построить график функции.\r\n\r\n";
            // 
            // groupBoxVvod_SVA
            // 
            this.groupBoxVvod_SVA.Controls.Add(this.textBoxStop_SVA);
            this.groupBoxVvod_SVA.Controls.Add(this.textBoxStart_SVA);
            this.groupBoxVvod_SVA.Controls.Add(this.labelStop_SVA);
            this.groupBoxVvod_SVA.Controls.Add(this.labelStart_SVA);
            this.groupBoxVvod_SVA.Location = new System.Drawing.Point(12, 324);
            this.groupBoxVvod_SVA.Name = "groupBoxVvod_SVA";
            this.groupBoxVvod_SVA.Size = new System.Drawing.Size(296, 114);
            this.groupBoxVvod_SVA.TabIndex = 1;
            this.groupBoxVvod_SVA.TabStop = false;
            this.groupBoxVvod_SVA.Text = "Ввод данных";
            // 
            // textBoxStop_SVA
            // 
            this.textBoxStop_SVA.Location = new System.Drawing.Point(137, 49);
            this.textBoxStop_SVA.Name = "textBoxStop_SVA";
            this.textBoxStop_SVA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_SVA.TabIndex = 3;
            // 
            // textBoxStart_SVA
            // 
            this.textBoxStart_SVA.Location = new System.Drawing.Point(9, 49);
            this.textBoxStart_SVA.Name = "textBoxStart_SVA";
            this.textBoxStart_SVA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_SVA.TabIndex = 2;
            // 
            // labelStop_SVA
            // 
            this.labelStop_SVA.AutoSize = true;
            this.labelStop_SVA.Location = new System.Drawing.Point(134, 18);
            this.labelStop_SVA.Name = "labelStop_SVA";
            this.labelStop_SVA.Size = new System.Drawing.Size(89, 17);
            this.labelStop_SVA.TabIndex = 1;
            this.labelStop_SVA.Text = "Конец шага:";
            // 
            // labelStart_SVA
            // 
            this.labelStart_SVA.AutoSize = true;
            this.labelStart_SVA.Location = new System.Drawing.Point(6, 18);
            this.labelStart_SVA.Name = "labelStart_SVA";
            this.labelStart_SVA.Size = new System.Drawing.Size(87, 17);
            this.labelStart_SVA.TabIndex = 0;
            this.labelStart_SVA.Text = "Старт шага:";
            // 
            // buttonSpravka_SVA
            // 
            this.buttonSpravka_SVA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSpravka_SVA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSpravka_SVA.Location = new System.Drawing.Point(314, 337);
            this.buttonSpravka_SVA.Name = "buttonSpravka_SVA";
            this.buttonSpravka_SVA.Size = new System.Drawing.Size(109, 94);
            this.buttonSpravka_SVA.TabIndex = 2;
            this.buttonSpravka_SVA.Text = "Справка";
            this.buttonSpravka_SVA.UseVisualStyleBackColor = false;
            this.buttonSpravka_SVA.Click += new System.EventHandler(this.buttonSpravka_SVA_Click);
            // 
            // dataGridViewResult_SVA
            // 
            this.dataGridViewResult_SVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SVA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewResult_SVA.Location = new System.Drawing.Point(6, 41);
            this.dataGridViewResult_SVA.Name = "dataGridViewResult_SVA";
            this.dataGridViewResult_SVA.ReadOnly = true;
            this.dataGridViewResult_SVA.RowHeadersVisible = false;
            this.dataGridViewResult_SVA.RowHeadersWidth = 51;
            this.dataGridViewResult_SVA.RowTemplate.Height = 24;
            this.dataGridViewResult_SVA.Size = new System.Drawing.Size(131, 349);
            this.dataGridViewResult_SVA.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(x)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // buttonDone_SVA
            // 
            this.buttonDone_SVA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SVA.Location = new System.Drawing.Point(429, 337);
            this.buttonDone_SVA.Name = "buttonDone_SVA";
            this.buttonDone_SVA.Size = new System.Drawing.Size(105, 94);
            this.buttonDone_SVA.TabIndex = 4;
            this.buttonDone_SVA.Text = "Выполнить";
            this.buttonDone_SVA.UseVisualStyleBackColor = false;
            this.buttonDone_SVA.Click += new System.EventHandler(this.buttonDone_SVA_Click);
            this.buttonDone_SVA.MouseEnter += new System.EventHandler(this.buttonDone_SVA_MouseEnter);
            this.buttonDone_SVA.MouseLeave += new System.EventHandler(this.buttonDone_SVA_MouseLeave);
            // 
            // groupBoxVivod_SVA
            // 
            this.groupBoxVivod_SVA.Controls.Add(this.chartGraf_SVA);
            this.groupBoxVivod_SVA.Controls.Add(this.labelResult_SVA);
            this.groupBoxVivod_SVA.Controls.Add(this.dataGridViewResult_SVA);
            this.groupBoxVivod_SVA.Location = new System.Drawing.Point(540, 21);
            this.groupBoxVivod_SVA.Name = "groupBoxVivod_SVA";
            this.groupBoxVivod_SVA.Size = new System.Drawing.Size(588, 417);
            this.groupBoxVivod_SVA.TabIndex = 5;
            this.groupBoxVivod_SVA.TabStop = false;
            this.groupBoxVivod_SVA.Text = "Вывод данных";
            // 
            // chartGraf_SVA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGraf_SVA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGraf_SVA.Legends.Add(legend2);
            this.chartGraf_SVA.Location = new System.Drawing.Point(143, 44);
            this.chartGraf_SVA.Name = "chartGraf_SVA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGraf_SVA.Series.Add(series2);
            this.chartGraf_SVA.Size = new System.Drawing.Size(439, 349);
            this.chartGraf_SVA.TabIndex = 5;
            this.chartGraf_SVA.Text = "chart1";
            // 
            // labelResult_SVA
            // 
            this.labelResult_SVA.AutoSize = true;
            this.labelResult_SVA.Location = new System.Drawing.Point(14, 21);
            this.labelResult_SVA.Name = "labelResult_SVA";
            this.labelResult_SVA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SVA.TabIndex = 4;
            this.labelResult_SVA.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 450);
            this.Controls.Add(this.groupBoxVivod_SVA);
            this.Controls.Add(this.buttonDone_SVA);
            this.Controls.Add(this.buttonSpravka_SVA);
            this.Controls.Add(this.groupBoxVvod_SVA);
            this.Controls.Add(this.groupBoxUslovie_SVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 11 | Штоль В.А.";
            this.groupBoxUslovie_SVA.ResumeLayout(false);
            this.groupBoxUslovie_SVA.PerformLayout();
            this.groupBoxVvod_SVA.ResumeLayout(false);
            this.groupBoxVvod_SVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SVA)).EndInit();
            this.groupBoxVivod_SVA.ResumeLayout(false);
            this.groupBoxVivod_SVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_SVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_SVA;
        private System.Windows.Forms.TextBox textBoxUslovie_SVA;
        private System.Windows.Forms.GroupBox groupBoxVvod_SVA;
        private System.Windows.Forms.TextBox textBoxStop_SVA;
        private System.Windows.Forms.TextBox textBoxStart_SVA;
        private System.Windows.Forms.Label labelStop_SVA;
        private System.Windows.Forms.Label labelStart_SVA;
        private System.Windows.Forms.Button buttonSpravka_SVA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button buttonDone_SVA;
        private System.Windows.Forms.GroupBox groupBoxVivod_SVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf_SVA;
        private System.Windows.Forms.Label labelResult_SVA;
    }
}

