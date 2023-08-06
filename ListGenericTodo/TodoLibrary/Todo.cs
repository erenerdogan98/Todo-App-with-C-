using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLibrary
{
    public class Todo
    {
        [DisplayName("ID")]
        public Guid ID { get; set; }
        [DisplayName("Title")]
        public string Title { get; set; }
        [DisplayName("Brief Description")]
        public string Briefdescription { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Situation")]
        public string StatusDescripton { get; set; }
        [DisplayName("Importance")]
        public int Importance { get; set; }
        [DisplayName("Creation Date")]
        public DateTime Creationdate { get; set; }
    }
}
