using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShtolVA.Sprint6.Task2.V11.Lib;

namespace Tyuiu.ShtolVA.Sprint6.Task2.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_SVA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SVA.BackColor = Color.Red;
        }
        private void buttonDone_SVA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SVA.BackColor = Color.Green;
        }
        private void buttonDone_SVA_MouseDown(object sender, EventArgs e)
        {
            buttonDone_SVA.BackColor = Color.Blue;
        }

        DataService ds = new DataService();
        private void buttonDone_SVA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SVA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SVA.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartGraf_SVA.Titles.Add("График функции");

                this.chartGraf_SVA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartGraf_SVA.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_SVA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartGraf_SVA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_SVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-23-3 Штоль Виктория Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
