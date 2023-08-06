using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoLibrary; // I added references that
using UserLibrary; // that too

namespace SanalDatabaseClassLibrary
{
    public class Sanaldatabase
    {
        public static List<User> UserTable; // we sample these by new in constructor method
        public static List<Todo> TodoTable;

        static Sanaldatabase() // constructor method
        {
            UserTable = new List<User>();
            UserTable.Add(new User() { ID = Guid.NewGuid(), UserName = "test123", Password = "test123" });
            TodoTable = new List<Todo>();
        }
    }
}
