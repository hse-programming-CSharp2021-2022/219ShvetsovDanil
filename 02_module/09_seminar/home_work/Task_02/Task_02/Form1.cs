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
        private string[] _lines = new string[] { "один", "два", "три", "четыре", "пять", "шесть", "семь" };
        private string[] _newLines = null;

        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "ListBox";

            listBox1.Visible = false;
            buttonDelete.Visible = false;
        }

        async private void Form1_Load(object sender, EventArgs e)
        {
            for (Opacity = 0; Opacity < 1; Opacity += 0.1)
            {
                await Task.Delay(100);
            }
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(_lines);
            _newLines = _lines;

            buttonDelete.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Список пуст или\nнет выделенного элемента!");
                return;
            }
            
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
