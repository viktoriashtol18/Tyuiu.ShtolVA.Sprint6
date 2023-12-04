
namespace Tyuiu.ShtolVA.Sprint6.Task0.V25
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
            this.buttoneExecute_SVA = new System.Windows.Forms.Button();
            this.groupBoxCondition_SVA = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelWriteFormula_SVA = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCalculateByFormula_SVA = new System.Windows.Forms.Label();
            this.groupDataInput_SVA = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelVariableX_SVA = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.groupBoxDataOutput_SVA = new System.Windows.Forms.GroupBox();
            this.labelResult_SVA = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.buttonQuestion_SVA = new System.Windows.Forms.Button();
            this.groupBoxCondition_SVA.SuspendLayout();
            this.groupDataInput_SVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.groupBoxDataOutput_SVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttoneExecute_SVA
            // 
            this.buttoneExecute_SVA.Location = new System.Drawing.Point(655, 405);
            this.buttoneExecute_SVA.Name = "buttoneExecute_SVA";
            this.buttoneExecute_SVA.Size = new System.Drawing.Size(133, 33);
            this.buttoneExecute_SVA.TabIndex = 0;
            this.buttoneExecute_SVA.Text = "Выполнить";
            this.buttoneExecute_SVA.UseVisualStyleBackColor = true;
            this.buttoneExecute_SVA.Click += new System.EventHandler(this.buttoneExecute_SVA_Click);
            // 
            // groupBoxCondition_SVA
            // 
            this.groupBoxCondition_SVA.Controls.Add(this.flowLayoutPanelWriteFormula_SVA);
            this.groupBoxCondition_SVA.Controls.Add(this.labelCalculateByFormula_SVA);
            this.groupBoxCondition_SVA.Location = new System.Drawing.Point(12, 33);
            this.groupBoxCondition_SVA.Name = "groupBoxCondition_SVA";
            this.groupBoxCondition_SVA.Size = new System.Drawing.Size(776, 159);
            this.groupBoxCondition_SVA.TabIndex = 1;
            this.groupBoxCondition_SVA.TabStop = false;
            this.groupBoxCondition_SVA.Text = "Условие";
            // 
            // flowLayoutPanelWriteFormula_SVA
            // 
            this.flowLayoutPanelWriteFormula_SVA.Location = new System.Drawing.Point(586, 21);
            this.flowLayoutPanelWriteFormula_SVA.Name = "flowLayoutPanelWriteFormula_SVA";
            this.flowLayoutPanelWriteFormula_SVA.Size = new System.Drawing.Size(184, 75);
            this.flowLayoutPanelWriteFormula_SVA.TabIndex = 1;
            // 
            // labelCalculateByFormula_SVA
            // 
            this.labelCalculateByFormula_SVA.AutoSize = true;
            this.labelCalculateByFormula_SVA.Location = new System.Drawing.Point(16, 22);
            this.labelCalculateByFormula_SVA.Name = "labelCalculateByFormula_SVA";
            this.labelCalculateByFormula_SVA.Size = new System.Drawing.Size(241, 17);
            this.labelCalculateByFormula_SVA.TabIndex = 0;
            this.labelCalculateByFormula_SVA.Text = "Вычислить выражение по формуле";
            // 
            // groupDataInput_SVA
            // 
            this.groupDataInput_SVA.Controls.Add(this.textBox1);
            this.groupDataInput_SVA.Controls.Add(this.labelVariableX_SVA);
            this.groupDataInput_SVA.Location = new System.Drawing.Point(12, 198);
            this.groupDataInput_SVA.Name = "groupDataInput_SVA";
            this.groupDataInput_SVA.Size = new System.Drawing.Size(402, 127);
            this.groupDataInput_SVA.TabIndex = 2;
            this.groupDataInput_SVA.TabStop = false;
            this.groupDataInput_SVA.Text = "Ввод данных";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // labelVariableX_SVA
            // 
            this.labelVariableX_SVA.AutoSize = true;
            this.labelVariableX_SVA.Location = new System.Drawing.Point(19, 22);
            this.labelVariableX_SVA.Name = "labelVariableX_SVA";
            this.labelVariableX_SVA.Size = new System.Drawing.Size(108, 17);
            this.labelVariableX_SVA.TabIndex = 0;
            this.labelVariableX_SVA.Text = "Переменная X:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBoxDataOutput_SVA
            // 
            this.groupBoxDataOutput_SVA.Controls.Add(this.labelResult_SVA);
            this.groupBoxDataOutput_SVA.Location = new System.Drawing.Point(454, 198);
            this.groupBoxDataOutput_SVA.Name = "groupBoxDataOutput_SVA";
            this.groupBoxDataOutput_SVA.Size = new System.Drawing.Size(317, 127);
            this.groupBoxDataOutput_SVA.TabIndex = 3;
            this.groupBoxDataOutput_SVA.TabStop = false;
            this.groupBoxDataOutput_SVA.Text = "Вывод данных";
            // 
            // labelResult_SVA
            // 
            this.labelResult_SVA.AutoSize = true;
            this.labelResult_SVA.Location = new System.Drawing.Point(18, 22);
            this.labelResult_SVA.Name = "labelResult_SVA";
            this.labelResult_SVA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SVA.TabIndex = 0;
            this.labelResult_SVA.Text = "Результат:";
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonQuestion_SVA
            // 
            this.buttonQuestion_SVA.Location = new System.Drawing.Point(613, 405);
            this.buttonQuestion_SVA.Name = "buttonQuestion_SVA";
            this.buttonQuestion_SVA.Size = new System.Drawing.Size(36, 33);
            this.buttonQuestion_SVA.TabIndex = 4;
            this.buttonQuestion_SVA.Text = "?";
            this.buttonQuestion_SVA.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuestion_SVA);
            this.Controls.Add(this.groupBoxDataOutput_SVA);
            this.Controls.Add(this.groupDataInput_SVA);
            this.Controls.Add(this.groupBoxCondition_SVA);
            this.Controls.Add(this.buttoneExecute_SVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 25 | Штоль В.А.";
            this.groupBoxCondition_SVA.ResumeLayout(false);
            this.groupBoxCondition_SVA.PerformLayout();
            this.groupDataInput_SVA.ResumeLayout(false);
            this.groupDataInput_SVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.groupBoxDataOutput_SVA.ResumeLayout(false);
            this.groupBoxDataOutput_SVA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttoneExecute_SVA;
        private System.Windows.Forms.GroupBox groupBoxCondition_SVA;
        private System.Windows.Forms.GroupBox groupDataInput_SVA;
        private System.Windows.Forms.Label labelCalculateByFormula_SVA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelVariableX_SVA;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelWriteFormula_SVA;
        private System.Windows.Forms.ImageList imageList1;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.GroupBox groupBoxDataOutput_SVA;
        private System.Windows.Forms.Label labelResult_SVA;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button buttonQuestion_SVA;
    }
}

