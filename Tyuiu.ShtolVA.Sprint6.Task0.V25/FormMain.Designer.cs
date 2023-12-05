
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxUslovie_SVA = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_SVA = new System.Windows.Forms.TextBox();
            this.groupBoxVVod_SVA = new System.Windows.Forms.GroupBox();
            this.labelPerX_SVA = new System.Windows.Forms.Label();
            this.textBoxPerX_SVA = new System.Windows.Forms.TextBox();
            this.groupBoxVivod_SVA = new System.Windows.Forms.GroupBox();
            this.labelResult_SVA = new System.Windows.Forms.Label();
            this.textBoxResult_SVA = new System.Windows.Forms.TextBox();
            this.buttonDone_SVA = new System.Windows.Forms.Button();
            this.buttonSpravka_SVA = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_SVA = new System.Windows.Forms.PictureBox();
            this.groupBoxUslovie_SVA.SuspendLayout();
            this.groupBoxVVod_SVA.SuspendLayout();
            this.groupBoxVivod_SVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SVA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_SVA
            // 
            this.groupBoxUslovie_SVA.Controls.Add(this.pictureBox_SVA);
            this.groupBoxUslovie_SVA.Controls.Add(this.textBoxUslovie_SVA);
            this.groupBoxUslovie_SVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_SVA.Name = "groupBoxUslovie_SVA";
            this.groupBoxUslovie_SVA.Size = new System.Drawing.Size(763, 286);
            this.groupBoxUslovie_SVA.TabIndex = 0;
            this.groupBoxUslovie_SVA.TabStop = false;
            this.groupBoxUslovie_SVA.Text = "Условие";
            this.groupBoxUslovie_SVA.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxUslovie_SVA
            // 
            this.textBoxUslovie_SVA.Location = new System.Drawing.Point(6, 21);
            this.textBoxUslovie_SVA.Multiline = true;
            this.textBoxUslovie_SVA.Name = "textBoxUslovie_SVA";
            this.textBoxUslovie_SVA.ReadOnly = true;
            this.textBoxUslovie_SVA.Size = new System.Drawing.Size(545, 238);
            this.textBoxUslovie_SVA.TabIndex = 0;
            this.textBoxUslovie_SVA.Text = "Вычислить выражение по формуле\r\n";
            this.textBoxUslovie_SVA.TextChanged += new System.EventHandler(this.textBoxUslovie_SVA_TextChanged);
            // 
            // groupBoxVVod_SVA
            // 
            this.groupBoxVVod_SVA.Controls.Add(this.textBoxPerX_SVA);
            this.groupBoxVVod_SVA.Controls.Add(this.labelPerX_SVA);
            this.groupBoxVVod_SVA.Location = new System.Drawing.Point(18, 304);
            this.groupBoxVVod_SVA.Name = "groupBoxVVod_SVA";
            this.groupBoxVVod_SVA.Size = new System.Drawing.Size(446, 95);
            this.groupBoxVVod_SVA.TabIndex = 1;
            this.groupBoxVVod_SVA.TabStop = false;
            this.groupBoxVVod_SVA.Text = "Ввод данных";
            // 
            // labelPerX_SVA
            // 
            this.labelPerX_SVA.AutoSize = true;
            this.labelPerX_SVA.Location = new System.Drawing.Point(7, 22);
            this.labelPerX_SVA.Name = "labelPerX_SVA";
            this.labelPerX_SVA.Size = new System.Drawing.Size(108, 17);
            this.labelPerX_SVA.TabIndex = 0;
            this.labelPerX_SVA.Text = "Переменная Х:";
            // 
            // textBoxPerX_SVA
            // 
            this.textBoxPerX_SVA.Location = new System.Drawing.Point(10, 53);
            this.textBoxPerX_SVA.Name = "textBoxPerX_SVA";
            this.textBoxPerX_SVA.Size = new System.Drawing.Size(105, 22);
            this.textBoxPerX_SVA.TabIndex = 1;
            // 
            // groupBoxVivod_SVA
            // 
            this.groupBoxVivod_SVA.Controls.Add(this.textBoxResult_SVA);
            this.groupBoxVivod_SVA.Controls.Add(this.labelResult_SVA);
            this.groupBoxVivod_SVA.Location = new System.Drawing.Point(491, 304);
            this.groupBoxVivod_SVA.Name = "groupBoxVivod_SVA";
            this.groupBoxVivod_SVA.Size = new System.Drawing.Size(297, 95);
            this.groupBoxVivod_SVA.TabIndex = 2;
            this.groupBoxVivod_SVA.TabStop = false;
            this.groupBoxVivod_SVA.Text = "Вывод данных";
            // 
            // labelResult_SVA
            // 
            this.labelResult_SVA.AutoSize = true;
            this.labelResult_SVA.Location = new System.Drawing.Point(6, 22);
            this.labelResult_SVA.Name = "labelResult_SVA";
            this.labelResult_SVA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SVA.TabIndex = 0;
            this.labelResult_SVA.Text = "Результат:";
            // 
            // textBoxResult_SVA
            // 
            this.textBoxResult_SVA.Location = new System.Drawing.Point(9, 53);
            this.textBoxResult_SVA.Name = "textBoxResult_SVA";
            this.textBoxResult_SVA.ReadOnly = true;
            this.textBoxResult_SVA.Size = new System.Drawing.Size(121, 22);
            this.textBoxResult_SVA.TabIndex = 1;
            // 
            // buttonDone_SVA
            // 
            this.buttonDone_SVA.BackColor = System.Drawing.Color.White;
            this.buttonDone_SVA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDone_SVA.ImageKey = "(none)";
            this.buttonDone_SVA.Location = new System.Drawing.Point(655, 405);
            this.buttonDone_SVA.Name = "buttonDone_SVA";
            this.buttonDone_SVA.Size = new System.Drawing.Size(133, 33);
            this.buttonDone_SVA.TabIndex = 3;
            this.buttonDone_SVA.Text = "Выполнить";
            this.buttonDone_SVA.UseVisualStyleBackColor = false;
            this.buttonDone_SVA.Click += new System.EventHandler(this.buttonDone_SVA_Click);
            // 
            // buttonSpravka_SVA
            // 
            this.buttonSpravka_SVA.Location = new System.Drawing.Point(611, 405);
            this.buttonSpravka_SVA.Name = "buttonSpravka_SVA";
            this.buttonSpravka_SVA.Size = new System.Drawing.Size(38, 33);
            this.buttonSpravka_SVA.TabIndex = 4;
            this.buttonSpravka_SVA.Text = "?";
            this.buttonSpravka_SVA.UseVisualStyleBackColor = true;
            this.buttonSpravka_SVA.Click += new System.EventHandler(this.buttonSpravka_SVA_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox_SVA
            // 
            this.pictureBox_SVA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_SVA.Image")));
            this.pictureBox_SVA.Location = new System.Drawing.Point(572, 21);
            this.pictureBox_SVA.Name = "pictureBox_SVA";
            this.pictureBox_SVA.Size = new System.Drawing.Size(181, 107);
            this.pictureBox_SVA.TabIndex = 1;
            this.pictureBox_SVA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.buttonSpravka_SVA);
            this.Controls.Add(this.buttonDone_SVA);
            this.Controls.Add(this.groupBoxVivod_SVA);
            this.Controls.Add(this.groupBoxVVod_SVA);
            this.Controls.Add(this.groupBoxUslovie_SVA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 0 | Вариант 25 | Штоль В.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUslovie_SVA.ResumeLayout(false);
            this.groupBoxUslovie_SVA.PerformLayout();
            this.groupBoxVVod_SVA.ResumeLayout(false);
            this.groupBoxVVod_SVA.PerformLayout();
            this.groupBoxVivod_SVA.ResumeLayout(false);
            this.groupBoxVivod_SVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_SVA;
        private System.Windows.Forms.TextBox textBoxUslovie_SVA;
        private System.Windows.Forms.GroupBox groupBoxVVod_SVA;
        private System.Windows.Forms.TextBox textBoxPerX_SVA;
        private System.Windows.Forms.Label labelPerX_SVA;
        private System.Windows.Forms.GroupBox groupBoxVivod_SVA;
        private System.Windows.Forms.Label labelResult_SVA;
        private System.Windows.Forms.TextBox textBoxResult_SVA;
        private System.Windows.Forms.Button buttonDone_SVA;
        private System.Windows.Forms.Button buttonSpravka_SVA;
        private System.Windows.Forms.PictureBox pictureBox_SVA;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}

