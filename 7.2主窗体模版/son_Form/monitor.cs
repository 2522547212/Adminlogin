using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._2主窗体模版.son_Form
{
    public partial class monitor : Form
    {
        public monitor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dswqkjfklfjlasdjfl");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (this.button12.Text == "手 动")
            {
                this.button12.Text = "自 动";
            }
            else
            {
                this.button12.Text = "手 动";
            }
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Text = "initing...";

            MessageBox.Show("初始化完成");
            this.lab_1500.BackColor = Color.Yellow;
            this.lab_1200.BackColor = Color.Yellow;
            button1.Text = "初始化";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Yellow;
            button4.BackColor = Color.Gray;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
