using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLibrary;

namespace UserServiceBll
{
    public class UserServicebll
    {
        public User UserControl(string username, string password)
        {
            return SanalDatabaseClassLibrary.Sanaldatabase.UserTable.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();
        }
    }
}
