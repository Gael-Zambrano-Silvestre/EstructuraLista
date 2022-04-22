using System;
using System.Windows.Forms;

namespace EstructuraLista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCalcular_Click(object sender, EventArgs e)
        {
            double cal_1, cal_2, cal_3, promedio;
            cal_1 = double.Parse(txtCal1.Text);
            cal_2 = double.Parse(txtCal2.Text);
            cal_3 = double.Parse(txtCal3.Text);

            promedio = (cal_1 + cal_2 + cal_3) / 3;
            txtpromedio.Text = promedio.ToString();
        }
    }
}
