using model.fw;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{

    public class AccountModel
    {
        private OnlineShopDBContext context = null;
        public AccountModel()
        {
            context = new OnlineShopDBContext();
        }
        public bool Login(string userName, string password)
        {
            object[] sqlParam =
            {
                new SqlParameter("@UserName",userName),
                new SqlParameter("@Password", password),
            };
            var res = context.Database.SqlQuery<bool>("Sp_Account_Login @UserName,@Password", sqlParam).SingleOrDefault();
            return res;
        }
        
    }
}
