using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Domain.Entities
{
    public class EntityBase
    {
        public Guid? Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        //public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        //public bool Status { get; set; }
        //public bool IsDeleted { get; set; }
    }
}
