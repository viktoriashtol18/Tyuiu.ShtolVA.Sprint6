using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShtolVA.Sprint6.Task6.V27.Lib;
using System.IO;


namespace Tyuiu.ShtolVA.Sprint6.Task6.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_SVA_Click(object sender, EventArgs e)
        {
            textBoxOutPut_SVA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_SVA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpenFile_SVA_Click(object sender, EventArgs e)
        {
            openFileDialogTask6_SVA.ShowDialog();
            openFilePath = openFileDialogTask6_SVA.FileName;
            textBoxInPut_SVA.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_SVA.Text = groupBoxInPut_SVA.Text + " " + openFileDialogTask6_SVA.FileName;
            buttonDone_SVA.Enabled = true;

        }
    }
}
