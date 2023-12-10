using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ShtolVA.Sprint6.Task5.V19.Lib;

namespace Tyuiu.ShtolVA.Sprint6.Task5.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\vikto\source\repos\Tyuiu.ShtolVA.Sprint6\Tyuiu.ShtolVA.Sprint6.Task5.V19\bin\Debug\InPutFileTask5V19.txt";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_SVA_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_SVA.ColumnCount = 2;
            dataGridViewOutPut_SVA.Columns[0].Width = 20;
            dataGridViewOutPut_SVA.Columns[1].Width = 50;

            this.chartDiag_SVA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_SVA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_SVA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutPut_SVA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_SVA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
        private void buttonHelp_SVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-23-3 Штоль Виктория Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_SAS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
}
}
