
namespace Tyuiu.ShtolVA.Sprint6.Task6.V27
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
            this.buttonOpenFile_SVA = new System.Windows.Forms.Button();
            this.buttonDone_SVA = new System.Windows.Forms.Button();
            this.buttonHelp_SVA = new System.Windows.Forms.Button();
            this.groupBoxCondition_SVA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_SVA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_SVA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_SVA = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_SVA = new System.Windows.Forms.TextBox();
            this.textBoxOutPut_SVA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask6_SVA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask6_SVA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxCondition_SVA.SuspendLayout();
            this.groupBoxInPut_SVA.SuspendLayout();
            this.groupBoxOutPut_SVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile_SVA
            // 
            this.buttonOpenFile_SVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SVA.Image")));
            this.buttonOpenFile_SVA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_SVA.Name = "buttonOpenFile_SVA";
            this.buttonOpenFile_SVA.Size = new System.Drawing.Size(75, 67);
            this.buttonOpenFile_SVA.TabIndex = 0;
            this.toolTipTask6_SVA.SetToolTip(this.buttonOpenFile_SVA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_SVA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SVA.Click += new System.EventHandler(this.buttonOpenFile_SVA_Click);
            // 
            // buttonDone_SVA
            // 
            this.buttonDone_SVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SVA.Image")));
            this.buttonDone_SVA.Location = new System.Drawing.Point(93, 12);
            this.buttonDone_SVA.Name = "buttonDone_SVA";
            this.buttonDone_SVA.Size = new System.Drawing.Size(80, 67);
            this.buttonDone_SVA.TabIndex = 1;
            this.toolTipTask6_SVA.SetToolTip(this.buttonDone_SVA, "Производит поиск в файле вхождений символов и конкатенирует строки , в которых на" +
        "ходятся эти символы");
            this.buttonDone_SVA.UseVisualStyleBackColor = true;
            this.buttonDone_SVA.Click += new System.EventHandler(this.buttonDone_SVA_Click);
            // 
            // buttonHelp_SVA
            // 
            this.buttonHelp_SVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SVA.Image")));
            this.buttonHelp_SVA.Location = new System.Drawing.Point(894, 12);
            this.buttonHelp_SVA.Name = "buttonHelp_SVA";
            this.buttonHelp_SVA.Size = new System.Drawing.Size(75, 67);
            this.buttonHelp_SVA.TabIndex = 2;
            this.toolTipTask6_SVA.SetToolTip(this.buttonHelp_SVA, "Сведения о программе");
            this.buttonHelp_SVA.UseVisualStyleBackColor = true;
            this.buttonHelp_SVA.Click += new System.EventHandler(this.buttonHelp_SVA_Click);
            // 
            // groupBoxCondition_SVA
            // 
            this.groupBoxCondition_SVA.Controls.Add(this.textBoxCondition_SVA);
            this.groupBoxCondition_SVA.Location = new System.Drawing.Point(4, 86);
            this.groupBoxCondition_SVA.Name = "groupBoxCondition_SVA";
            this.groupBoxCondition_SVA.Size = new System.Drawing.Size(965, 90);
            this.groupBoxCondition_SVA.TabIndex = 3;
            this.groupBoxCondition_SVA.TabStop = false;
            this.groupBoxCondition_SVA.Text = "Условие:";
            // 
            // textBoxCondition_SVA
            // 
            this.textBoxCondition_SVA.Location = new System.Drawing.Point(6, 22);
            this.textBoxCondition_SVA.Multiline = true;
            this.textBoxCondition_SVA.Name = "textBoxCondition_SVA";
            this.textBoxCondition_SVA.ReadOnly = true;
            this.textBoxCondition_SVA.Size = new System.Drawing.Size(945, 62);
            this.textBoxCondition_SVA.TabIndex = 0;
            this.textBoxCondition_SVA.Text = resources.GetString("textBoxCondition_SVA.Text");
            // 
            // groupBoxInPut_SVA
            // 
            this.groupBoxInPut_SVA.Controls.Add(this.textBoxInPut_SVA);
            this.groupBoxInPut_SVA.Location = new System.Drawing.Point(4, 182);
            this.groupBoxInPut_SVA.Name = "groupBoxInPut_SVA";
            this.groupBoxInPut_SVA.Size = new System.Drawing.Size(471, 413);
            this.groupBoxInPut_SVA.TabIndex = 4;
            this.groupBoxInPut_SVA.TabStop = false;
            this.groupBoxInPut_SVA.Text = "Ввод:";
            // 
            // groupBoxOutPut_SVA
            // 
            this.groupBoxOutPut_SVA.Controls.Add(this.textBoxOutPut_SVA);
            this.groupBoxOutPut_SVA.Location = new System.Drawing.Point(481, 182);
            this.groupBoxOutPut_SVA.Name = "groupBoxOutPut_SVA";
            this.groupBoxOutPut_SVA.Size = new System.Drawing.Size(501, 413);
            this.groupBoxOutPut_SVA.TabIndex = 5;
            this.groupBoxOutPut_SVA.TabStop = false;
            this.groupBoxOutPut_SVA.Text = "Вывод:";
            // 
            // textBoxInPut_SVA
            // 
            this.textBoxInPut_SVA.Location = new System.Drawing.Point(0, 56);
            this.textBoxInPut_SVA.Multiline = true;
            this.textBoxInPut_SVA.Name = "textBoxInPut_SVA";
            this.textBoxInPut_SVA.ReadOnly = true;
            this.textBoxInPut_SVA.Size = new System.Drawing.Size(465, 351);
            this.textBoxInPut_SVA.TabIndex = 0;
            // 
            // textBoxOutPut_SVA
            // 
            this.textBoxOutPut_SVA.Location = new System.Drawing.Point(6, 21);
            this.textBoxOutPut_SVA.Multiline = true;
            this.textBoxOutPut_SVA.Name = "textBoxOutPut_SVA";
            this.textBoxOutPut_SVA.ReadOnly = true;
            this.textBoxOutPut_SVA.Size = new System.Drawing.Size(489, 392);
            this.textBoxOutPut_SVA.TabIndex = 0;
            // 
            // openFileDialogTask6_SVA
            // 
            this.openFileDialogTask6_SVA.FileName = "openFileDialog1";
            // 
            // toolTipTask6_SVA
            // 
            this.toolTipTask6_SVA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTask6_SVA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 598);
            this.Controls.Add(this.groupBoxOutPut_SVA);
            this.Controls.Add(this.groupBoxInPut_SVA);
            this.Controls.Add(this.groupBoxCondition_SVA);
            this.Controls.Add(this.buttonHelp_SVA);
            this.Controls.Add(this.buttonDone_SVA);
            this.Controls.Add(this.buttonOpenFile_SVA);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 27 | Штоль В.А.";
            this.groupBoxCondition_SVA.ResumeLayout(false);
            this.groupBoxCondition_SVA.PerformLayout();
            this.groupBoxInPut_SVA.ResumeLayout(false);
            this.groupBoxInPut_SVA.PerformLayout();
            this.groupBoxOutPut_SVA.ResumeLayout(false);
            this.groupBoxOutPut_SVA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_SVA;
        private System.Windows.Forms.Button buttonDone_SVA;
        private System.Windows.Forms.Button buttonHelp_SVA;
        private System.Windows.Forms.GroupBox groupBoxCondition_SVA;
        private System.Windows.Forms.TextBox textBoxCondition_SVA;
        private System.Windows.Forms.ToolTip toolTipTask6_SVA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SVA;
        private System.Windows.Forms.TextBox textBoxInPut_SVA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SVA;
        private System.Windows.Forms.TextBox textBoxOutPut_SVA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask6_SVA;
    }
}

