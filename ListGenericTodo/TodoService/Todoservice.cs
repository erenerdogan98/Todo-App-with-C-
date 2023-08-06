using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanalDatabaseClassLibrary;
using TodoLibrary;

namespace TodoService
{
    public class Todoservice
    {
        List<Todo> registrations;
        public int RegistrationControl()
        {
            // we added references sanaldatabe and todolibrary 
            return Sanaldatabase.TodoTable.Count;
        }
        public List<Todo> RegistrationList()
        {
            return Sanaldatabase.TodoTable;
        }
        public int NewRegistration(Todo data)
        {
            try
            {
                Sanaldatabase.TodoTable.Add(data);
                return 1;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        
    }
}
