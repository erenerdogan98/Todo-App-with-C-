using SanalDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProps;

namespace UserService
{
    public class Userservicebll
    {
        
        public User UserControl(string username,string password)
        {
            return SanalDatabase.SanalDatabase.UserTable.Where(x=> x.UserName == username && x.Password == password).FirstOrDefault();
        }
    }
}
