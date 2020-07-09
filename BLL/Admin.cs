using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class Admin
    {
        public Administrator Login(Administrator ad)
        {
            string sql = "select * from 记录 where 用户 = '{0}'and 密码 = '{1}'";
            sql = string.Format(sql, ad.LoginName, ad.LoginPwd);
            DAL.Login dl = new DAL.Login();
            SqlDataReader sr = dl.DalLogin(sql);
            if (sr.Read())//判断是否有数据
            {
                ad.LoginName = sr["用户"].ToString();
                ad.LoginPwd = sr["密码"].ToString();
                ad.Control = sr["权限"].ToString();               
                return ad;
            }
            else
            {
                return ad = null;
            }


        }
       
    }
}
