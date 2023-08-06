using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoProps
{
    public class Todo
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Briefdescription { get; set; }
        public string Description { get; set; }
        public string StatusDescripton { get; set; }
        public int Importance { get; set; }
        public DateTime Creationdate { get; set; }
    }
}
