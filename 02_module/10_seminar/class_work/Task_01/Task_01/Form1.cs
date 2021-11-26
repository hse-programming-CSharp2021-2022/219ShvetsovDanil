using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] numbersStr = { "one", "two", "three", "four", "five" };

        private void initButton_Click(object sender, EventArgs e)
        {
            textBox1.Lines = numbersStr;
        }

        private void changedList_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join("\n", textBox1.Lines));
        }
    }
}
