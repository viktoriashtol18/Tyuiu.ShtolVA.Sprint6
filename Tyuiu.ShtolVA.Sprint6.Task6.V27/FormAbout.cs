﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ShtolVA.Sprint6.Task6.V27
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void textBoxInfo_SVA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_SVA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
