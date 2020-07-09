using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._2主窗体模版
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }
        int count=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.panel2.Width += 20;
            if (this.panel2.Width >= Size.Width)
            {
                this.timer1.Stop();
                this.label3.Text = "加载成功";
                count = 0;
                this.DialogResult = DialogResult.OK;//用于返回Program判断让Form1创建
            }
            else
            {
                this.label3.Text += ".";
                count++;
                if (count == 4)
                {
                    this.label3.Text = "加载系统组件";
                    count = 0;
                }
            }
        }
    }
}
