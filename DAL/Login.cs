using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Login
    {
        private static string constring = @"server =LAPTOP-PRPGFGCD\MSSQLSERVER2;database=student1;uid=sa;pwd=123456;";
        public SqlDataReader DalLogin(string sql)
        {

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    //System.Data.CommandBehavior.CloseConnection:用完就关闭端口释放资源
                }
            }
            //注意：当Connection 与SqlCommand之间配合使用时，尽量不要用using
            //SqlConnection con = new SqlConnection(constring);
            //SqlCommand cmd = new SqlCommand(sql, con);
            //con.Open();
            //return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            ////System.Data.CommandBehavior.CloseConnection:用完就关闭端口释放资源

            //注意：修改完成以后要生成，不然其它项目调用的还是原来的DLL动态连接库
        }
    }
}
