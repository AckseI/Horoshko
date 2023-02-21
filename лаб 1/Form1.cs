using System;
using System.Windows.Forms;

namespace лаб_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valueOne;
            float valueTwo;

            float result = 0;
            string operation = comboBox1.Text;


            valueOne = float.Parse(textBox1.Text);
            valueTwo = float.Parse(textBox2.Text);

            if (operation == "+") result = valueOne + valueTwo;
            else if (operation == "-") result = valueOne - valueTwo;
            else if (operation == "/") result = valueOne / valueTwo;
            else if (operation == "*") result = valueOne * valueTwo;
            //todo цифры
            //todo . -> ,


            label4.Text = result.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label4.Text = e.KeyChar.ToString();
            if (char.IsDigit(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
            //Только цифры и запятая
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            label4.Text = e.KeyChar.ToString();
            if (char.IsDigit(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
