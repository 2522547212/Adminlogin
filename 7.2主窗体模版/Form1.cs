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
    public partial class Form1 : Form
    {
        public Form1(string admin, string control)
        {
            InitializeComponent();
            this.label7.Text = admin;
            lalcontrol.Text = control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Normal)//判断窗体的状态
            {
                this.WindowState = FormWindowState.Maximized;//窗体最大化
                this.button2.Image = Properties.Resources.arrow_minimise;//切换图标
            }
            else
            {
                this.WindowState = FormWindowState.Normal;//窗体最小化
                this.button2.Image = Properties.Resources.arrow_maximise;//切换图标
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//最小化
        }
        public bool MoveEnable = false;//判断是否移动导航栏
        int panelWidth = 130;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MoveEnable)
            {
                this.panel1.Width += 10;//展开导航栏
                //判断导航栏是否大于窗体初始的宽度
                if (this.panel1.Width>panelWidth)//
                {
                    this.timer1.Stop();//停止计时
                    MoveEnable = false;//取消展开状态
                    this.panel1.Width = 130;//设置成功初始的宽度
                    this.Refresh();//窗体刷新重绘
                }
            }
            else
            {
                this.panel1.Width -= 10;//展开导航栏
                //判断导航栏是否大于窗体初始的宽度
                if (this.panel1.Width <77)//
                {
                    this.timer1.Stop();//停止计时
                    MoveEnable = true;//取消展开状态
                    this.panel1.Width = 77;//设置成功初始的宽度
                    this.Refresh();//窗体刷新重绘
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.label5.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");//大写的MM代表月，小写mm代表分钟
        }

        private void MovePanel(Control button)
        {
            this.panel5.Top = button.Top;//panel到大容器的距离与按钮一致
            this.panel5.Height = button.Height;//panel的高与按钮的高一致
        }


        //*************************************************************************************

        /// <summary>
        /// 关闭之前的已经打开的窗体
        /// </summary>
        private void ClosePreForm()
        {
            foreach (Control item in this.panel6.Controls)//遍历Panel6里所有的控件
            {
                if (item is Form)//判断遍历的控件是否是窗体
                {
                    Form objControl = (Form)item;//如果是窗体类型的进行转换
                    objControl.Close();//关闭窗体
                }
            }
        }

        /// <summary>
        /// 嵌入式界面
        /// </summary>
        /// <param name="objForm"></param>
        private void OpenForm(Form objForm)
        {
            ClosePreForm();//关闭前面打开的窗体
            objForm.TopLevel = false;//将子窗体设置成非顶级窗体
            objForm.Dock = DockStyle.Fill;//让参数的窗体的与父窗体最大化自适应
            objForm.Parent = this.panel6;//指定子窗体容器的大小
            objForm.Show();//显示窗体

        } 
        //*************************************************************************************     
        private void button6_Click(object sender, EventArgs e)
        {
            MovePanel((Button)sender);//sender:表示当前触发事件的对象即当前button
            OpenForm(new _7._2主窗体模版.son_Form.monitor());


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MovePanel((Button)sender);//sender:表示当前触发事件的对象即当前button
            OpenForm(new _7._2主窗体模版.son_Form.dataForm());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MovePanel((Button)sender);//sender:表示当前触发事件的对象即当前button
            OpenForm(new _7._2主窗体模版.son_Form.log());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MovePanel((Button)sender);//sender:表示当前触发事件的对象即当前button
            OpenForm(new _7._2主窗体模版.son_Form.UserForm());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MovePanel((Button)sender);//sender:表示当前触发事件的对象即当前button
            OpenForm(new _7._2主窗体模版.son_Form.parameterForm());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MovePanel((Button)sender);//sender:表示当前触发事件的对象即当前button
            OpenForm(new _7._2主窗体模版.son_Form.edition());

        }

        
    }
}
