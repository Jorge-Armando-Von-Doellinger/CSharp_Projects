using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Entities.Base
{
    public abstract class EntityBase
    {
        [Key]
        public Int64 ID { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime UpdatedAt { get; set; } = DateTime.Now.ToLocalTime();
    }
}
