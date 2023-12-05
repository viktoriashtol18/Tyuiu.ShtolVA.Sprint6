
namespace Tyuiu.ShtolVA.Sprint6.Task1.V5
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
            this.textBoxUslovie_SVA = new System.Windows.Forms.TextBox();
            this.groupBoxVvod_SVA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_SVA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SVA = new System.Windows.Forms.TextBox();
            this.labelStop_SVA = new System.Windows.Forms.Label();
            this.labelStart_SVA = new System.Windows.Forms.Label();
            this.buttonSpravka_SVA = new System.Windows.Forms.Button();
            this.buttonVipolnit_SVA = new System.Windows.Forms.Button();
            this.groupBoxVivod_SVA = new System.Windows.Forms.GroupBox();
            this.labelResult_SVA = new System.Windows.Forms.Label();
            this.textBoxResult_SVA = new System.Windows.Forms.TextBox();
            this.groupBoxUslovie_SVA.SuspendLayout();
            this.groupBoxVvod_SVA.SuspendLayout();
            this.groupBoxVivod_SVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_SVA
            // 
            this.groupBoxUslovie_SVA.Controls.Add(this.textBoxUslovie_SVA);
            this.groupBoxUslovie_SVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_SVA.Name = "groupBoxUslovie_SVA";
            this.groupBoxUslovie_SVA.Size = new System.Drawing.Size(589, 295);
            this.groupBoxUslovie_SVA.TabIndex = 0;
            this.groupBoxUslovie_SVA.TabStop = false;
            this.groupBoxUslovie_SVA.Text = "Условие";
            // 
            // textBoxUslovie_SVA
            // 
            this.textBoxUslovie_SVA.Location = new System.Drawing.Point(10, 21);
            this.textBoxUslovie_SVA.Multiline = true;
            this.textBoxUslovie_SVA.Name = "textBoxUslovie_SVA";
            this.textBoxUslovie_SVA.ReadOnly = true;
            this.textBoxUslovie_SVA.Size = new System.Drawing.Size(544, 274);
            this.textBoxUslovie_SVA.TabIndex = 0;
            this.textBoxUslovie_SVA.Text = "Протабулировать функцию sin(x) + cos(2x)/2 - 1,5x на заданном диапазоне.Результат" +
    " вывести в виде таблицы.";
            // 
            // groupBoxVvod_SVA
            // 
            this.groupBoxVvod_SVA.Controls.Add(this.textBoxStop_SVA);
            this.groupBoxVvod_SVA.Controls.Add(this.textBoxStart_SVA);
            this.groupBoxVvod_SVA.Controls.Add(this.labelStop_SVA);
            this.groupBoxVvod_SVA.Controls.Add(this.labelStart_SVA);
            this.groupBoxVvod_SVA.Location = new System.Drawing.Point(12, 313);
            this.groupBoxVvod_SVA.Name = "groupBoxVvod_SVA";
            this.groupBoxVvod_SVA.Size = new System.Drawing.Size(362, 127);
            this.groupBoxVvod_SVA.TabIndex = 1;
            this.groupBoxVvod_SVA.TabStop = false;
            this.groupBoxVvod_SVA.Text = "Ввод данных";
            // 
            // textBoxStop_SVA
            // 
            this.textBoxStop_SVA.Location = new System.Drawing.Point(145, 53);
            this.textBoxStop_SVA.Name = "textBoxStop_SVA";
            this.textBoxStop_SVA.Size = new System.Drawing.Size(108, 22);
            this.textBoxStop_SVA.TabIndex = 3;
            // 
            // textBoxStart_SVA
            // 
            this.textBoxStart_SVA.Location = new System.Drawing.Point(10, 53);
            this.textBoxStart_SVA.Name = "textBoxStart_SVA";
            this.textBoxStart_SVA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_SVA.TabIndex = 2;
            // 
            // labelStop_SVA
            // 
            this.labelStop_SVA.AutoSize = true;
            this.labelStop_SVA.Location = new System.Drawing.Point(142, 22);
            this.labelStop_SVA.Name = "labelStop_SVA";
            this.labelStop_SVA.Size = new System.Drawing.Size(89, 17);
            this.labelStop_SVA.TabIndex = 1;
            this.labelStop_SVA.Text = "Конец шага:";
            // 
            // labelStart_SVA
            // 
            this.labelStart_SVA.AutoSize = true;
            this.labelStart_SVA.Location = new System.Drawing.Point(7, 22);
            this.labelStart_SVA.Name = "labelStart_SVA";
            this.labelStart_SVA.Size = new System.Drawing.Size(87, 17);
            this.labelStart_SVA.TabIndex = 0;
            this.labelStart_SVA.Text = "Старт шага:";
            // 
            // buttonSpravka_SVA
            // 
            this.buttonSpravka_SVA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSpravka_SVA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSpravka_SVA.Location = new System.Drawing.Point(403, 333);
            this.buttonSpravka_SVA.Name = "buttonSpravka_SVA";
            this.buttonSpravka_SVA.Size = new System.Drawing.Size(97, 89);
            this.buttonSpravka_SVA.TabIndex = 2;
            this.buttonSpravka_SVA.Text = "Справка";
            this.buttonSpravka_SVA.UseVisualStyleBackColor = false;
            this.buttonSpravka_SVA.Click += new System.EventHandler(this.buttonSpravka_SVA_Click);
            // 
            // buttonVipolnit_SVA
            // 
            this.buttonVipolnit_SVA.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonVipolnit_SVA.Location = new System.Drawing.Point(506, 335);
            this.buttonVipolnit_SVA.Name = "buttonVipolnit_SVA";
            this.buttonVipolnit_SVA.Size = new System.Drawing.Size(95, 87);
            this.buttonVipolnit_SVA.TabIndex = 3;
            this.buttonVipolnit_SVA.Text = "Выполнить";
            this.buttonVipolnit_SVA.UseVisualStyleBackColor = false;
            this.buttonVipolnit_SVA.Click += new System.EventHandler(this.buttonVipolnit_SVA_Click);
            // 
            // groupBoxVivod_SVA
            // 
            this.groupBoxVivod_SVA.Controls.Add(this.textBoxResult_SVA);
            this.groupBoxVivod_SVA.Controls.Add(this.labelResult_SVA);
            this.groupBoxVivod_SVA.Location = new System.Drawing.Point(616, 12);
            this.groupBoxVivod_SVA.Name = "groupBoxVivod_SVA";
            this.groupBoxVivod_SVA.Size = new System.Drawing.Size(201, 426);
            this.groupBoxVivod_SVA.TabIndex = 4;
            this.groupBoxVivod_SVA.TabStop = false;
            this.groupBoxVivod_SVA.Text = "Вывод данных";
            // 
            // labelResult_SVA
            // 
            this.labelResult_SVA.AutoSize = true;
            this.labelResult_SVA.Location = new System.Drawing.Point(6, 24);
            this.labelResult_SVA.Name = "labelResult_SVA";
            this.labelResult_SVA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SVA.TabIndex = 0;
            this.labelResult_SVA.Text = "Результат:";
            // 
            // textBoxResult_SVA
            // 
            this.textBoxResult_SVA.Location = new System.Drawing.Point(9, 44);
            this.textBoxResult_SVA.Multiline = true;
            this.textBoxResult_SVA.Name = "textBoxResult_SVA";
            this.textBoxResult_SVA.ReadOnly = true;
            this.textBoxResult_SVA.Size = new System.Drawing.Size(161, 376);
            this.textBoxResult_SVA.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.groupBoxVivod_SVA);
            this.Controls.Add(this.buttonVipolnit_SVA);
            this.Controls.Add(this.buttonSpravka_SVA);
            this.Controls.Add(this.groupBoxVvod_SVA);
            this.Controls.Add(this.groupBoxUslovie_SVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 5 | Штоль В.А.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxUslovie_SVA.ResumeLayout(false);
            this.groupBoxUslovie_SVA.PerformLayout();
            this.groupBoxVvod_SVA.ResumeLayout(false);
            this.groupBoxVvod_SVA.PerformLayout();
            this.groupBoxVivod_SVA.ResumeLayout(false);
            this.groupBoxVivod_SVA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_SVA;
        private System.Windows.Forms.GroupBox groupBoxVvod_SVA;
        private System.Windows.Forms.TextBox textBoxStop_SVA;
        private System.Windows.Forms.TextBox textBoxStart_SVA;
        private System.Windows.Forms.Label labelStop_SVA;
        private System.Windows.Forms.Label labelStart_SVA;
        private System.Windows.Forms.TextBox textBoxUslovie_SVA;
        private System.Windows.Forms.Button buttonSpravka_SVA;
        private System.Windows.Forms.Button buttonVipolnit_SVA;
        private System.Windows.Forms.GroupBox groupBoxVivod_SVA;
        private System.Windows.Forms.Label labelResult_SVA;
        private System.Windows.Forms.TextBox textBoxResult_SVA;
    }
}

