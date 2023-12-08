using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShtolVA.Sprint6.Task3.V29.Lib;

namespace Tyuiu.ShtolVA.Sprint6.Task3.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrx = new int[5, 5]  {  { -2, -13, -15, -9, -17 },
                                           { 13, -20, -15, 27, 18 },
                                           { -12, -1, -20, 13, 0 },
                                           { 15, 32, 18, -12, -18 },
                                           { 16, 5, 3, -5, -8 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrx.GetUpperBound(0) + 1;
            int columns = matrx.Length / rows;

            dataGridViewResult_SVA.ColumnCount = columns;
            dataGridViewResult_SVA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_SVA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_SVA.Rows[i].Cells[j].Value = Convert.ToString(matrx[i, j]);
                }
            }
        }
        private void buttonSpravka_SVA_Click_(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-23-3 Штоль Виктория Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SVA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] matrx = new int[5, 5]{ { -2, -13, -15, -9, -17 },
                                           { 13, -20, -15, 27, 18 },
                                           { -12, -1, -20, 13, 0 },
                                           { 15, 32, 18, -12, -18 },
                                           { 16, 5, 3, -5, -8 } };
            int[,] mtrx = ds.Calculate(matrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult_SVA.ColumnCount = columns;
            dataGridViewResult_SVA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_SVA.Columns[i].Width = 25;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_SVA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        
        private void textBoxResult_SVA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUslovie_SVA_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewResult_SVA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }
    }
}
