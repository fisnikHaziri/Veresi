using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Debt
    {
        public Guid id { get; set; }
        public DateTime CreatedAt { get; set; }
        public float TotalAmount { get; set; }

        //Relations
        public Person Person { get; set; }
        [ForeignKey(nameof(Person))]
        public Guid PersonId { get; set; }
    }
}
