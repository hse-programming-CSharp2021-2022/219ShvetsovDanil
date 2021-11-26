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
        private int p1 = 0;
        private int p2 = 1;

        public Form1()
        {
            InitializeComponent();
            outputText.Text = $"Член ряда Пелла = {p2}";
        }

        private void nextRowMember_Click(object sender, EventArgs e)
        {
            int p3 = p1 + 2 * p2;
            if (p3 < 0)
            {
                MessageBox.Show("Переполнение! Ряд начнем сначала!");
                p1 = 0;
                p2 = 1;
                outputText.Text = $"Член ряда Пелла = {p2}";
                return;
            }
            outputText.Text = $"Член ряда Пелла = {p3}";
            (p1, p2) = (p2, p3);
        }
    }
}
