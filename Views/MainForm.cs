using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator.Views
{
    public partial class MainForm : Form
    {
        string _tekstW = string.Empty;
        string _tekstW2 = string.Empty;
        char operation = '0';
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _tekstW += "1";
            textBoxResult.Text = _tekstW;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _tekstW += "2";
            textBoxResult.Text = _tekstW;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _tekstW += "3";
            textBoxResult.Text = _tekstW;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _tekstW += "4";
            textBoxResult.Text = _tekstW;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _tekstW += "5";
            textBoxResult.Text = _tekstW;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _tekstW += "6";
            textBoxResult.Text = _tekstW;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _tekstW += "7";
            textBoxResult.Text = _tekstW;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _tekstW += "8";
            textBoxResult.Text = _tekstW;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _tekstW += "9";
            textBoxResult.Text = _tekstW;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            _tekstW += "0";
            textBoxResult.Text = _tekstW;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _tekstW = string.Empty;
            textBoxResult.Text = _tekstW;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _tekstW2 = _tekstW;
            _tekstW = string.Empty;
            textBoxResult.Text = string.Empty;
            operation = '+';
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            _tekstW2 = _tekstW;
            _tekstW = string.Empty;
            textBoxResult.Text = string.Empty;
            operation = '-';
        }

        private void buttonMno_Click(object sender, EventArgs e)
        {
            _tekstW2 = _tekstW;
            _tekstW = string.Empty;
            textBoxResult.Text = string.Empty;
            operation = '*';
        }

        private void buttonDzi_Click(object sender, EventArgs e)
        {
            _tekstW2 = _tekstW;
            _tekstW = string.Empty;
            textBoxResult.Text = string.Empty;
            operation = '/';
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            int a = 0;
            switch(operation)
            {
                case '+':
                    a = int.Parse(_tekstW2) + int.Parse(_tekstW);
                    textBoxResult.Text = a.ToString();
                    break;
                case '-':
                    a = int.Parse(_tekstW2) - int.Parse(_tekstW);
                    textBoxResult.Text = a.ToString();
                    break;
                case '*':
                    a = int.Parse(_tekstW2) * int.Parse(_tekstW);
                    textBoxResult.Text = a.ToString();
                    break;
                case '/':
                    a = int.Parse(_tekstW2) / int.Parse(_tekstW);
                    textBoxResult.Text = a.ToString();
                    break;
                    default:
                    break;
            }    
        }
    }
}
