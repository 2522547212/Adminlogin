using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BLL;


namespace _7._2主窗体模版
{
  
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
   
        private void button3_Click(object sender, EventArgs e)
        {            
            if (this.textBox1.Text.Trim().Length==0)
            {
                this.textBox1.Focus();
                MessageBox.Show("用户名为空");
                return;
            }
            if (this.textBox2.Text.Trim().Length == 0)
            {
                this.textBox2.Focus();
                MessageBox.Show("密码为空");
                return;
            }
            Administrator ad = new Administrator();
            ad.LoginName = this.textBox1.Text.Trim();
            ad.LoginPwd= this.textBox2.Text.Trim();
            Admin ba = new Admin();
            Administrator adlogin =ba.Login(ad);           
            if (adlogin != null)
            {
                Program.loginadmin = adlogin.LoginName;
                Program.logincontrol = adlogin.Control;
                this.DialogResult = DialogResult.OK;//用于返回Program判断让Form1创建 
            }
            else
            {
                MessageBox.Show("用户或者密码不正确");
                this.textBox1.Clear();
                this.textBox2.Clear();
                this.textBox1.Focus();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
