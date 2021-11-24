using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_work
{
    public partial class Form1 : Form
    {
        private static string ReplaceText(string a)
        {
            var b = a.ToCharArray();
            for (var i = b.Length - 1; i >= 0; i--)
            {
                if (b[i] != ' ')
                {
                    b[i] = ' ';
                    break;
                }
            }

            return new string(b);
        }

        public Form1()
        {
            InitializeComponent();
        }

        async private void Form1_Load(object sender, EventArgs e)
        {
            for (Opacity = 0; Opacity < 1; Opacity += 0.1)
            {
                await Task.Delay(100);
            }
           
        }

        async private void timer_Tick(object sender, EventArgs e)
        {
            label.Text = ReplaceText(label.Text);

            if (label.Text[0] == ' ')
            {
                timer.Stop();
                for (Opacity = 1; Opacity > 0; Opacity -= 0.1)
                {
                    await Task.Delay(100);
                }

                await Task.Delay(2000);

                label.Text = "Кот уже ушел!";

                for (Opacity = 0; Opacity < 1; Opacity += 0.1)
                {
                    await Task.Delay(100);
                }
            }
        }
    }
}