using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShtolVA.Sprint6.Task0.V25.Lib;

namespace Tyuiu.ShtolVA.Sprint6.Task0.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_SVA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {

                textBoxResult_SVA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxPerX_SVA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_SVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИИПб-23-3 Штоль Виктория Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxUslovie_SVA_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxVarX_SVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
