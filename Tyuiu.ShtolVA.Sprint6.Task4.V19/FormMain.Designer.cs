
namespace Tyuiu.ShtolVA.Sprint6.Task4.V19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxCondition_SVA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_SVA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_SVA = new System.Windows.Forms.GroupBox();
            this.labelStartStep_SVA = new System.Windows.Forms.Label();
            this.labelStopStep_SVA = new System.Windows.Forms.Label();
            this.textBoxStartStep_SVA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_SVA = new System.Windows.Forms.TextBox();
            this.buttonDone_SVA = new System.Windows.Forms.Button();
            this.buttonSave_SVA = new System.Windows.Forms.Button();
            this.buttonInfo_SVA = new System.Windows.Forms.Button();
            this.groupBoxOutPut_SVA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SVA = new System.Windows.Forms.TextBox();
            this.chartFunction_SVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition_SVA.SuspendLayout();
            this.groupBoxInPut_SVA.SuspendLayout();
            this.groupBoxOutPut_SVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SVA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SVA
            // 
            this.groupBoxCondition_SVA.Controls.Add(this.textBoxCondition_SVA);
            this.groupBoxCondition_SVA.Location = new System.Drawing.Point(2, 12);
            this.groupBoxCondition_SVA.Name = "groupBoxCondition_SVA";
            this.groupBoxCondition_SVA.Size = new System.Drawing.Size(508, 117);
            this.groupBoxCondition_SVA.TabIndex = 0;
            this.groupBoxCondition_SVA.TabStop = false;
            this.groupBoxCondition_SVA.Text = "Условие:";
            // 
            // textBoxCondition_SVA
            // 
            this.textBoxCondition_SVA.Location = new System.Drawing.Point(6, 21);
            this.textBoxCondition_SVA.Multiline = true;
            this.textBoxCondition_SVA.Name = "textBoxCondition_SVA";
            this.textBoxCondition_SVA.ReadOnly = true;
            this.textBoxCondition_SVA.Size = new System.Drawing.Size(492, 92);
            this.textBoxCondition_SVA.TabIndex = 0;
            this.textBoxCondition_SVA.Text = resources.GetString("textBoxCondition_SVA.Text");
            // 
            // groupBoxInPut_SVA
            // 
            this.groupBoxInPut_SVA.Controls.Add(this.textBoxStopStep_SVA);
            this.groupBoxInPut_SVA.Controls.Add(this.textBoxStartStep_SVA);
            this.groupBoxInPut_SVA.Controls.Add(this.labelStopStep_SVA);
            this.groupBoxInPut_SVA.Controls.Add(this.labelStartStep_SVA);
            this.groupBoxInPut_SVA.Location = new System.Drawing.Point(516, 12);
            this.groupBoxInPut_SVA.Name = "groupBoxInPut_SVA";
            this.groupBoxInPut_SVA.Size = new System.Drawing.Size(299, 117);
            this.groupBoxInPut_SVA.TabIndex = 1;
            this.groupBoxInPut_SVA.TabStop = false;
            this.groupBoxInPut_SVA.Text = "Ввод данных";
            // 
            // labelStartStep_SVA
            // 
            this.labelStartStep_SVA.AutoSize = true;
            this.labelStartStep_SVA.Location = new System.Drawing.Point(7, 24);
            this.labelStartStep_SVA.Name = "labelStartStep_SVA";
            this.labelStartStep_SVA.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_SVA.TabIndex = 0;
            this.labelStartStep_SVA.Text = "Старт шага:";
            // 
            // labelStopStep_SVA
            // 
            this.labelStopStep_SVA.AutoSize = true;
            this.labelStopStep_SVA.Location = new System.Drawing.Point(151, 24);
            this.labelStopStep_SVA.Name = "labelStopStep_SVA";
            this.labelStopStep_SVA.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_SVA.TabIndex = 1;
            this.labelStopStep_SVA.Text = "Конец шага:";
            // 
            // textBoxStartStep_SVA
            // 
            this.textBoxStartStep_SVA.Location = new System.Drawing.Point(6, 44);
            this.textBoxStartStep_SVA.Name = "textBoxStartStep_SVA";
            this.textBoxStartStep_SVA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartStep_SVA.TabIndex = 2;
            // 
            // textBoxStopStep_SVA
            // 
            this.textBoxStopStep_SVA.Location = new System.Drawing.Point(154, 44);
            this.textBoxStopStep_SVA.Name = "textBoxStopStep_SVA";
            this.textBoxStopStep_SVA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStopStep_SVA.TabIndex = 3;
            // 
            // buttonDone_SVA
            // 
            this.buttonDone_SVA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SVA.Location = new System.Drawing.Point(833, 26);
            this.buttonDone_SVA.Name = "buttonDone_SVA";
            this.buttonDone_SVA.Size = new System.Drawing.Size(95, 79);
            this.buttonDone_SVA.TabIndex = 2;
            this.buttonDone_SVA.Text = "Выполнить";
            this.buttonDone_SVA.UseVisualStyleBackColor = false;
            this.buttonDone_SVA.Click += new System.EventHandler(this.buttonDone_SVA_Click);
            // 
            // buttonSave_SVA
            // 
            this.buttonSave_SVA.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSave_SVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_SVA.Location = new System.Drawing.Point(934, 27);
            this.buttonSave_SVA.Name = "buttonSave_SVA";
            this.buttonSave_SVA.Size = new System.Drawing.Size(96, 77);
            this.buttonSave_SVA.TabIndex = 3;
            this.buttonSave_SVA.Text = "Сохранить";
            this.buttonSave_SVA.UseVisualStyleBackColor = false;
            this.buttonSave_SVA.Click += new System.EventHandler(this.buttonSave_SVA_Click);
            // 
            // buttonInfo_SVA
            // 
            this.buttonInfo_SVA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_SVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_SVA.Location = new System.Drawing.Point(1036, 25);
            this.buttonInfo_SVA.Name = "buttonInfo_SVA";
            this.buttonInfo_SVA.Size = new System.Drawing.Size(89, 80);
            this.buttonInfo_SVA.TabIndex = 4;
            this.buttonInfo_SVA.Text = "Справка";
            this.buttonInfo_SVA.UseVisualStyleBackColor = false;
            this.buttonInfo_SVA.Click += new System.EventHandler(this.buttonInfo_SVA_Click);
            // 
            // groupBoxOutPut_SVA
            // 
            this.groupBoxOutPut_SVA.Controls.Add(this.textBoxResult_SVA);
            this.groupBoxOutPut_SVA.Location = new System.Drawing.Point(2, 144);
            this.groupBoxOutPut_SVA.Name = "groupBoxOutPut_SVA";
            this.groupBoxOutPut_SVA.Size = new System.Drawing.Size(235, 568);
            this.groupBoxOutPut_SVA.TabIndex = 5;
            this.groupBoxOutPut_SVA.TabStop = false;
            this.groupBoxOutPut_SVA.Text = "Вывод:";
            // 
            // textBoxResult_SVA
            // 
            this.textBoxResult_SVA.Location = new System.Drawing.Point(6, 21);
            this.textBoxResult_SVA.Multiline = true;
            this.textBoxResult_SVA.Name = "textBoxResult_SVA";
            this.textBoxResult_SVA.ReadOnly = true;
            this.textBoxResult_SVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SVA.Size = new System.Drawing.Size(229, 529);
            this.textBoxResult_SVA.TabIndex = 0;
            // 
            // chartFunction_SVA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SVA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_SVA.Legends.Add(legend1);
            this.chartFunction_SVA.Location = new System.Drawing.Point(264, 144);
            this.chartFunction_SVA.Name = "chartFunction_SVA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SVA.Series.Add(series1);
            this.chartFunction_SVA.Size = new System.Drawing.Size(908, 562);
            this.chartFunction_SVA.TabIndex = 6;
            this.chartFunction_SVA.Text = "chart1";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.BorderColor = System.Drawing.Color.Transparent;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.DodgerBlue;
            title1.Name = "Title1";
            title1.Text = "График функции (5х + 2,5 ) / (sin(x) - 2 ) +2";
            this.chartFunction_SVA.Titles.Add(title1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 849);
            this.Controls.Add(this.chartFunction_SVA);
            this.Controls.Add(this.groupBoxOutPut_SVA);
            this.Controls.Add(this.buttonInfo_SVA);
            this.Controls.Add(this.buttonSave_SVA);
            this.Controls.Add(this.buttonDone_SVA);
            this.Controls.Add(this.groupBoxInPut_SVA);
            this.Controls.Add(this.groupBoxCondition_SVA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 19 | Штоль В.А. ";
            this.groupBoxCondition_SVA.ResumeLayout(false);
            this.groupBoxCondition_SVA.PerformLayout();
            this.groupBoxInPut_SVA.ResumeLayout(false);
            this.groupBoxInPut_SVA.PerformLayout();
            this.groupBoxOutPut_SVA.ResumeLayout(false);
            this.groupBoxOutPut_SVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SVA;
        private System.Windows.Forms.TextBox textBoxCondition_SVA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SVA;
        private System.Windows.Forms.TextBox textBoxStopStep_SVA;
        private System.Windows.Forms.TextBox textBoxStartStep_SVA;
        private System.Windows.Forms.Label labelStopStep_SVA;
        private System.Windows.Forms.Label labelStartStep_SVA;
        private System.Windows.Forms.Button buttonDone_SVA;
        private System.Windows.Forms.Button buttonSave_SVA;
        private System.Windows.Forms.Button buttonInfo_SVA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SVA;
        private System.Windows.Forms.TextBox textBoxResult_SVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SVA;
    }
}

