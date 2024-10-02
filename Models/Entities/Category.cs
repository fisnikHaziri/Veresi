using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Category
    {
        public Guid id { get; set; }
        public string CategoryType { get; set; }

        //Relations
        public List<Person> People { get; set; }
    }
}
