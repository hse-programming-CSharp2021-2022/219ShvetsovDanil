using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int mode = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                if (this.Size.Width * 2 < this.MaximumSize.Width &&
                    this.Size.Height * 2 < this.MaximumSize.Height)
                {
                    this.Size = new Size(this.Size.Width * 2, this.Size.Height * 2);
                }
                else
                {
                    mode = 2;
                    button1.Text = "decrease";
                }
            }
            else
            {
                if (this.Size.Width / 2 > this.MinimumSize.Width &&
                    this.Size.Height / 2 > this.MinimumSize.Height)
                {
                    this.Size = new Size(this.Size.Width / 2, this.Size.Height / 2);
                }
                else
                {
                    mode = 1;
                    button1.Text = "increase";
                }
            }
        }
    }
}
