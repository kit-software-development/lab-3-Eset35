using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {

        float first = 0, second = 0, result=0;
        string operation;
        bool isResult = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpClick(object sender, EventArgs e)
        {
            first = float.Parse(label1.Text);
            isResult = true;
            var button = sender as Button;
            operation = button.Text;
        }

        private void SetPoint(object sender, EventArgs e)
        {
            if(label1.Text.IndexOf(',')==-1)
            {
                if (label1.Text == "0") label1.Text = "0,";
                else label1.Text += ",";
            }
        }

        private void ResClick(object sender, EventArgs e)
        {
            if (!isResult)
            {
                isResult = true;
                second = float.Parse(label1.Text);
                Calc calc = new Calc();
                result = calc.MakeOperation(first, second, operation);
                label1.Text = result.ToString();
            }
                else
            {
                Calc calc = new Calc();
                result = calc.MakeOperation(result, second, operation);
                label1.Text = result.ToString();
            }

            Clipboard.SetText(result.ToString());
        }

        private void NumClick(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (label1.Text != "0" && !isResult)
            {
                isResult = false;
                label1.Text += button.Text;
            }
            else
            {
                isResult = false;
                label1.Text = button.Text;
            }
        }
    }
}
