using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShtolVA.Sprint6.Task7.V7.Lib;
using System.IO;


namespace Tyuiu.ShtolVA.Sprint6.Task7.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask7_SVA.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SVA.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        
            
        private void buttonHelp_SVA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpenFile_SVA_Click(object sender, EventArgs e)
        {
            openFileDialogTask7_SVA.ShowDialog();
            openFilePath = openFileDialogTask7_SVA.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_SVA.ColumnCount = columns;
            dataGridViewInPut_SVA.RowCount = rows;
            dataGridViewOutPut_SVA.ColumnCount = columns;
            dataGridViewOutPut_SVA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_SVA.Columns[i].Width = 25;
                dataGridViewOutPut_SVA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_SVA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_SVA.Enabled = true;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_SVA.ColumnCount = 50;
            dataGridViewOutPut_SVA.ColumnCount = 50;

            dataGridViewOutPut_SVA.RowCount = 50;
            dataGridViewInPut_SVA.RowCount = 50;

            panelInPut_SVA.Width = this.Width / 2;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_SVA.Columns[i].Width = 25;
                dataGridViewOutPut_SVA.Columns[i].Width = 25;
            }
        }
        private void buttonDone_SVA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_SVA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_SVA.Enabled = true;
        }
        private void buttonSaveFile_SVA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SVA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SVA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SVA.ShowDialog();

            string path = saveFileDialogMatrix_SVA.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_SVA.RowCount;
            int columns = dataGridViewOutPut_SVA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_SVA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_SVA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpenFile_SVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SVA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_SVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SVA.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_SVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SVA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_SVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SVA.ToolTipTitle = "Справка";
        }

        private void openFileDialogTask7_SVA_FileOk(object sender, CancelEventArgs e)
        {

        }

      
    }
}

