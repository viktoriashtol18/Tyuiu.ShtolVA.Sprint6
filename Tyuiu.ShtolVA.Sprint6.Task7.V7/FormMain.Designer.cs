
namespace Tyuiu.ShtolVA.Sprint6.Task7.V7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_SVA = new System.Windows.Forms.Panel();
            this.buttonHelp_SVA = new System.Windows.Forms.Button();
            this.buttonSaveFile_SVA = new System.Windows.Forms.Button();
            this.buttonDone_SVA = new System.Windows.Forms.Button();
            this.buttonOpenFile_SVA = new System.Windows.Forms.Button();
            this.panelCondition_SVA = new System.Windows.Forms.Panel();
            this.groupBoxCondition_SVA = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelInPut_SVA = new System.Windows.Forms.Panel();
            this.groupBoxInPut_SVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_SVA = new System.Windows.Forms.DataGridView();
            this.splitterInPut_SVA = new System.Windows.Forms.Splitter();
            this.panelOutPut_SVA = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_SVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_SVA = new System.Windows.Forms.DataGridView();
            this.splitterOutPut_SVA = new System.Windows.Forms.Splitter();
            this.toolTipButton_SVA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_SVA = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTask7_SVA = new System.Windows.Forms.OpenFileDialog();
            this.panelButtons_SVA.SuspendLayout();
            this.panelCondition_SVA.SuspendLayout();
            this.groupBoxCondition_SVA.SuspendLayout();
            this.panelInPut_SVA.SuspendLayout();
            this.groupBoxInPut_SVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_SVA)).BeginInit();
            this.panelOutPut_SVA.SuspendLayout();
            this.groupBoxOutPut_SVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SVA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_SVA
            // 
            this.panelButtons_SVA.BackColor = System.Drawing.Color.White;
            this.panelButtons_SVA.Controls.Add(this.buttonHelp_SVA);
            this.panelButtons_SVA.Controls.Add(this.buttonSaveFile_SVA);
            this.panelButtons_SVA.Controls.Add(this.buttonDone_SVA);
            this.panelButtons_SVA.Controls.Add(this.buttonOpenFile_SVA);
            this.panelButtons_SVA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_SVA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_SVA.Name = "panelButtons_SVA";
            this.panelButtons_SVA.Size = new System.Drawing.Size(1061, 94);
            this.panelButtons_SVA.TabIndex = 4;
            // 
            // buttonHelp_SVA
            // 
            this.buttonHelp_SVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_SVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SVA.Image")));
            this.buttonHelp_SVA.Location = new System.Drawing.Point(965, 12);
            this.buttonHelp_SVA.Name = "buttonHelp_SVA";
            this.buttonHelp_SVA.Size = new System.Drawing.Size(84, 76);
            this.buttonHelp_SVA.TabIndex = 3;
            this.toolTipButton_SVA.SetToolTip(this.buttonHelp_SVA, " О программе");
            this.buttonHelp_SVA.UseVisualStyleBackColor = true;
            this.buttonHelp_SVA.Click += new System.EventHandler(this.buttonHelp_SVA_Click);
            this.buttonHelp_SVA.MouseEnter += new System.EventHandler(this.buttonHelp_SVA_MouseEnter);
            // 
            // buttonSaveFile_SVA
            // 
            this.buttonSaveFile_SVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveFile_SVA.Enabled = false;
            this.buttonSaveFile_SVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_SVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_SVA.Image")));
            this.buttonSaveFile_SVA.Location = new System.Drawing.Point(212, 12);
            this.buttonSaveFile_SVA.Name = "buttonSaveFile_SVA";
            this.buttonSaveFile_SVA.Size = new System.Drawing.Size(83, 76);
            this.buttonSaveFile_SVA.TabIndex = 2;
            this.toolTipButton_SVA.SetToolTip(this.buttonSaveFile_SVA, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_SVA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_SVA.Click += new System.EventHandler(this.buttonSaveFile_SVA_Click);
            this.buttonSaveFile_SVA.MouseEnter += new System.EventHandler(this.buttonSaveFile_SVA_MouseEnter);
            // 
            // buttonDone_SVA
            // 
            this.buttonDone_SVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SVA.Enabled = false;
            this.buttonDone_SVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_SVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SVA.Image")));
            this.buttonDone_SVA.Location = new System.Drawing.Point(110, 12);
            this.buttonDone_SVA.Name = "buttonDone_SVA";
            this.buttonDone_SVA.Size = new System.Drawing.Size(86, 76);
            this.buttonDone_SVA.TabIndex = 1;
            this.toolTipButton_SVA.SetToolTip(this.buttonDone_SVA, "Выполнить обработку данных");
            this.buttonDone_SVA.UseVisualStyleBackColor = true;
            this.buttonDone_SVA.Click += new System.EventHandler(this.buttonDone_SVA_Click);
            this.buttonDone_SVA.MouseEnter += new System.EventHandler(this.buttonDone_SVA_MouseEnter);
            // 
            // buttonOpenFile_SVA
            // 
            this.buttonOpenFile_SVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_SVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SVA.Image")));
            this.buttonOpenFile_SVA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_SVA.Name = "buttonOpenFile_SVA";
            this.buttonOpenFile_SVA.Size = new System.Drawing.Size(83, 76);
            this.buttonOpenFile_SVA.TabIndex = 0;
            this.toolTipButton_SVA.SetToolTip(this.buttonOpenFile_SVA, "Открыть файл для обработки данных в формат СSV\r\n");
            this.buttonOpenFile_SVA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SVA.Click += new System.EventHandler(this.buttonOpenFile_SVA_Click);
            this.buttonOpenFile_SVA.MouseEnter += new System.EventHandler(this.buttonOpenFile_SVA_MouseEnter);
            // 
            // panelCondition_SVA
            // 
            this.panelCondition_SVA.BackColor = System.Drawing.Color.White;
            this.panelCondition_SVA.Controls.Add(this.groupBoxCondition_SVA);
            this.panelCondition_SVA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_SVA.Location = new System.Drawing.Point(0, 94);
            this.panelCondition_SVA.Name = "panelCondition_SVA";
            this.panelCondition_SVA.Size = new System.Drawing.Size(1061, 78);
            this.panelCondition_SVA.TabIndex = 5;
            // 
            // groupBoxCondition_SVA
            // 
            this.groupBoxCondition_SVA.Controls.Add(this.textBox1);
            this.groupBoxCondition_SVA.Location = new System.Drawing.Point(3, 7);
            this.groupBoxCondition_SVA.Name = "groupBoxCondition_SVA";
            this.groupBoxCondition_SVA.Size = new System.Drawing.Size(1055, 89);
            this.groupBoxCondition_SVA.TabIndex = 0;
            this.groupBoxCondition_SVA.TabStop = false;
            this.groupBoxCondition_SVA.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1055, 57);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelInPut_SVA
            // 
            this.panelInPut_SVA.BackColor = System.Drawing.Color.White;
            this.panelInPut_SVA.Controls.Add(this.groupBoxInPut_SVA);
            this.panelInPut_SVA.Controls.Add(this.splitterInPut_SVA);
            this.panelInPut_SVA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_SVA.Location = new System.Drawing.Point(0, 172);
            this.panelInPut_SVA.Name = "panelInPut_SVA";
            this.panelInPut_SVA.Size = new System.Drawing.Size(522, 449);
            this.panelInPut_SVA.TabIndex = 6;
            // 
            // groupBoxInPut_SVA
            // 
            this.groupBoxInPut_SVA.Controls.Add(this.dataGridViewInPut_SVA);
            this.groupBoxInPut_SVA.Location = new System.Drawing.Point(3, 6);
            this.groupBoxInPut_SVA.Name = "groupBoxInPut_SVA";
            this.groupBoxInPut_SVA.Size = new System.Drawing.Size(519, 440);
            this.groupBoxInPut_SVA.TabIndex = 1;
            this.groupBoxInPut_SVA.TabStop = false;
            this.groupBoxInPut_SVA.Text = "Ввод:";
            // 
            // dataGridViewInPut_SVA
            // 
            this.dataGridViewInPut_SVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_SVA.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewInPut_SVA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInPut_SVA.Name = "dataGridViewInPut_SVA";
            this.dataGridViewInPut_SVA.RowHeadersWidth = 51;
            this.dataGridViewInPut_SVA.RowTemplate.Height = 24;
            this.dataGridViewInPut_SVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewInPut_SVA.Size = new System.Drawing.Size(513, 419);
            this.dataGridViewInPut_SVA.TabIndex = 0;
            // 
            // splitterInPut_SVA
            // 
            this.splitterInPut_SVA.Location = new System.Drawing.Point(0, 0);
            this.splitterInPut_SVA.Name = "splitterInPut_SVA";
            this.splitterInPut_SVA.Size = new System.Drawing.Size(3, 449);
            this.splitterInPut_SVA.TabIndex = 0;
            this.splitterInPut_SVA.TabStop = false;
            // 
            // panelOutPut_SVA
            // 
            this.panelOutPut_SVA.BackColor = System.Drawing.Color.White;
            this.panelOutPut_SVA.Controls.Add(this.groupBoxOutPut_SVA);
            this.panelOutPut_SVA.Controls.Add(this.splitterOutPut_SVA);
            this.panelOutPut_SVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_SVA.Location = new System.Drawing.Point(522, 172);
            this.panelOutPut_SVA.Name = "panelOutPut_SVA";
            this.panelOutPut_SVA.Size = new System.Drawing.Size(539, 449);
            this.panelOutPut_SVA.TabIndex = 7;
            // 
            // groupBoxOutPut_SVA
            // 
            this.groupBoxOutPut_SVA.Controls.Add(this.dataGridViewOutPut_SVA);
            this.groupBoxOutPut_SVA.Location = new System.Drawing.Point(6, 6);
            this.groupBoxOutPut_SVA.Name = "groupBoxOutPut_SVA";
            this.groupBoxOutPut_SVA.Size = new System.Drawing.Size(530, 440);
            this.groupBoxOutPut_SVA.TabIndex = 1;
            this.groupBoxOutPut_SVA.TabStop = false;
            this.groupBoxOutPut_SVA.Text = "Вывод:";
            // 
            // dataGridViewOutPut_SVA
            // 
            this.dataGridViewOutPut_SVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_SVA.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewOutPut_SVA.Location = new System.Drawing.Point(0, 18);
            this.dataGridViewOutPut_SVA.Name = "dataGridViewOutPut_SVA";
            this.dataGridViewOutPut_SVA.RowHeadersWidth = 51;
            this.dataGridViewOutPut_SVA.RowTemplate.Height = 24;
            this.dataGridViewOutPut_SVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPut_SVA.Size = new System.Drawing.Size(527, 419);
            this.dataGridViewOutPut_SVA.TabIndex = 0;
            // 
            // splitterOutPut_SVA
            // 
            this.splitterOutPut_SVA.Location = new System.Drawing.Point(0, 0);
            this.splitterOutPut_SVA.Name = "splitterOutPut_SVA";
            this.splitterOutPut_SVA.Size = new System.Drawing.Size(3, 449);
            this.splitterOutPut_SVA.TabIndex = 0;
            this.splitterOutPut_SVA.TabStop = false;
            // 
            // toolTipButton_SVA
            // 
            this.toolTipButton_SVA.IsBalloon = true;
            this.toolTipButton_SVA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // openFileDialogTask7_SVA
            // 
            this.openFileDialogTask7_SVA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 621);
            this.Controls.Add(this.panelOutPut_SVA);
            this.Controls.Add(this.panelInPut_SVA);
            this.Controls.Add(this.panelCondition_SVA);
            this.Controls.Add(this.panelButtons_SVA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сприант 6 | Таск 7 | Вариант 7 | Штоль В.А.";
            this.panelButtons_SVA.ResumeLayout(false);
            this.panelCondition_SVA.ResumeLayout(false);
            this.groupBoxCondition_SVA.ResumeLayout(false);
            this.groupBoxCondition_SVA.PerformLayout();
            this.panelInPut_SVA.ResumeLayout(false);
            this.groupBoxInPut_SVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_SVA)).EndInit();
            this.panelOutPut_SVA.ResumeLayout(false);
            this.groupBoxOutPut_SVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_SVA;
        private System.Windows.Forms.Panel panelCondition_SVA;
        private System.Windows.Forms.Panel panelInPut_SVA;
        private System.Windows.Forms.Panel panelOutPut_SVA;
        private System.Windows.Forms.Button buttonOpenFile_SVA;
        private System.Windows.Forms.Button buttonSaveFile_SVA;
        private System.Windows.Forms.Button buttonDone_SVA;
        private System.Windows.Forms.Button buttonHelp_SVA;
        private System.Windows.Forms.GroupBox groupBoxCondition_SVA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxInPut_SVA;
        private System.Windows.Forms.DataGridView dataGridViewInPut_SVA;
        private System.Windows.Forms.Splitter splitterInPut_SVA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SVA;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_SVA;
        private System.Windows.Forms.Splitter splitterOutPut_SVA;
        private System.Windows.Forms.ToolTip toolTipButton_SVA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SVA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask7_SVA;
    }
}

