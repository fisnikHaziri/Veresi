using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Person
    {
        public Guid id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }

        //Relationships
        public List<Debt> Debts { get; set; }
        public Category Category { get; set; }
        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }

    }
}
