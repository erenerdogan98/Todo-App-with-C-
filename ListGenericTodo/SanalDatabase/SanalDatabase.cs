using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProps; // I added references that
using UserProps; // that too

namespace SanalDatabase
{
    public static class SanalDatabase
    {      
        public static List<User> UserTable; // we sample these by new in constructor method
        public static List<Todo> TodoTable;

        static SanalDatabase() // constructor method
        {
            UserTable = new List<User>();
            UserTable.Add(new User() { ID = Guid.NewGuid() , UserName = "test123",Password = "test123"});
            TodoTable = new List<Todo>();
        }
    }
}
