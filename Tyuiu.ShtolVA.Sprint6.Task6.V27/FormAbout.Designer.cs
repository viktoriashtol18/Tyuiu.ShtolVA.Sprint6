
namespace Tyuiu.ShtolVA.Sprint6.Task6.V27
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_SVA = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_SVA = new System.Windows.Forms.TextBox();
            this.buttonOk_SVA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SVA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_SVA
            // 
            this.pictureBoxAvatar_SVA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SVA.Image")));
            this.pictureBoxAvatar_SVA.Location = new System.Drawing.Point(24, 12);
            this.pictureBoxAvatar_SVA.Name = "pictureBoxAvatar_SVA";
            this.pictureBoxAvatar_SVA.Size = new System.Drawing.Size(163, 211);
            this.pictureBoxAvatar_SVA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_SVA.TabIndex = 0;
            this.pictureBoxAvatar_SVA.TabStop = false;
            // 
            // textBoxInfo_SVA
            // 
            this.textBoxInfo_SVA.Location = new System.Drawing.Point(203, 12);
            this.textBoxInfo_SVA.Multiline = true;
            this.textBoxInfo_SVA.Name = "textBoxInfo_SVA";
            this.textBoxInfo_SVA.ReadOnly = true;
            this.textBoxInfo_SVA.Size = new System.Drawing.Size(295, 222);
            this.textBoxInfo_SVA.TabIndex = 1;
            this.textBoxInfo_SVA.Text = resources.GetString("textBoxInfo_SVA.Text");
            this.textBoxInfo_SVA.TextChanged += new System.EventHandler(this.textBoxInfo_SVA_TextChanged);
            // 
            // buttonOk_SVA
            // 
            this.buttonOk_SVA.Location = new System.Drawing.Point(410, 240);
            this.buttonOk_SVA.Name = "buttonOk_SVA";
            this.buttonOk_SVA.Size = new System.Drawing.Size(87, 23);
            this.buttonOk_SVA.TabIndex = 2;
            this.buttonOk_SVA.Text = "Ok";
            this.buttonOk_SVA.UseVisualStyleBackColor = true;
            this.buttonOk_SVA.Click += new System.EventHandler(this.buttonOk_SVA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 268);
            this.Controls.Add(this.buttonOk_SVA);
            this.Controls.Add(this.textBoxInfo_SVA);
            this.Controls.Add(this.pictureBoxAvatar_SVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SVA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_SVA;
        private System.Windows.Forms.TextBox textBoxInfo_SVA;
        private System.Windows.Forms.Button buttonOk_SVA;
    }
}