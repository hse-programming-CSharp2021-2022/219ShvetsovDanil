using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.changedLabel.Text = "from code";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (changedLabel.Text == "from code")
            {
                this.changedLabel.Text = "after press";
            }
            else if (changedLabel.Text == "after press")
            {
                this.changedLabel.Text = "from code";
            }
        }
    }
}