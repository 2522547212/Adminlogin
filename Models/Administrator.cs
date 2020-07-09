using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Administrator
    {
        private string loginName;
        private string loginPwd;
        private string control;

        public string LoginName
        {
            get
            {
                return loginName;
            }

            set
            {
                loginName = value;
            }
        }

        public string LoginPwd
        {
            get
            {
                return loginPwd;
            }

            set
            {
                loginPwd = value;
            }
        }

        public string Control
        {
            get
            {
                return control;
            }

            set
            {
                control = value;
            }
        }
    }
}
