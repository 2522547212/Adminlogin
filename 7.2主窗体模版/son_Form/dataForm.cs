using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._2主窗体模版.son_Form
{
    public partial class dataForm : Form
    {
        public dataForm()
        {
            InitializeComponent();
        }       
        string str = "server=LAPTOP-PRPGFGCD\\MSSQLSERVER2;Initial Catalog = mysever;User ID=sa;Password=123456";//Data Source=
        List<person> p1 = new List<person>();
        delegate void Mydel(person SetDLV);// 定义一个委托类型 参数是Model.Resdata类的对象
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DGV.ClearSelection();
            SqlConnection con = new SqlConnection(str);
            //try
            //{
                con.Open();
                string sql = "select * from person ";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();//
                Mydel Set_DGV = SHowListData;//定义一个委托类型下的方法变量  //给委托赋值
                if (reader.HasRows)//判断数据库是否有数据                        
                {
                    while (reader.Read())
                    {

                        person data = new person();
                        data.ID = Convert.ToInt32(reader["ID"].ToString()); ;//序列号展示为客户
                        data.name = reader["Name"].ToString();
                        data.Age = Convert.ToInt32(reader["Age"].ToString());
                        p1.Add(data);
                        DGV.Invoke(Set_DGV, new object[] { data });//一个已被赋值的委托类型的方法                       
                    }//end while
                }
                MessageBox.Show("操作成功");
                cmd.Dispose();
            //}
            //catch (Exception)
            //{
            //}
            con.Close();
            con.Dispose();

        }
        /// <summary>
        /// DGV
        /// </summary>
        /// <param name="mr"></param>
        public void SHowListData(person mr)//  //线层委托访问控件
        {
            int IRows;
            IRows = DGV.Rows.Add();
            DGV.Rows[IRows].Cells[0].Value = mr.ID;
            DGV.Rows[IRows].Cells[1].Value = mr.name;
            DGV.Rows[IRows].Cells[2].Value = mr.Age;

            DataGridViewColumn col = DGV.Columns[0];//让第一列有可以升序或者降序的调节
            ListSortDirection Dir = ListSortDirection.Ascending;
            DGV.Sort(col, Dir);//降序排列   
        }
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            //using (SqlTransaction tan = con.BeginTransaction())
            //{
            try
            {
                con.Open();
                string sql = "insert into person VALUES('5','吕布','40')";
                SqlCommand cmd = new SqlCommand(sql, con);
                //   cmd.Connection = con;
                cmd.CommandText = sql;
                // cmd.Transaction = tan;
                int nuss = cmd.ExecuteNonQuery();
                //tan.Commit();                
                MessageBox.Show("操作成功");
                cmd.Dispose();
            }
            catch
            {

            }
            con.Close();
            con.Dispose();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            //using (SqlTransaction tan = con.BeginTransaction())
            //{
            try
            {
                con.Open();
                string sql = "Update person set Age='20'where Name='李四'";
                SqlCommand cmd = new SqlCommand(sql, con);
                //   cmd.Connection = con;
                cmd.CommandText = sql;
                // cmd.Transaction = tan;
                int nuss = cmd.ExecuteNonQuery();
                //tan.Commit();               
                MessageBox.Show("操作成功");
                cmd.Dispose();
            }
            catch
            {

            }
            con.Close();
            con.Dispose();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            //using (SqlTransaction tan = con.BeginTransaction())
            //{
            try
            {
                con.Open();
                string sql = "Delete from person Where ID='5'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Connection = con;
                cmd.CommandText = sql;
                //cmd.Transaction = tan;
                int nuss = cmd.ExecuteNonQuery();
                //tan.Commit();
                MessageBox.Show("操作成功");
                cmd.Dispose();
            }
            catch
            {

            }
            con.Close();
            con.Dispose();

        }
        public struct person
        {
            public int ID;
            public string name;
            public int Age;
        }        
    }
}
