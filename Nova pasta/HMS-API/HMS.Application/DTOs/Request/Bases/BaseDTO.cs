using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.DTOs.Request.Bases
{
    public class BaseDTO
    {
        public DateTime? CreatedAt { get; internal set; }
        public DateTime? UpdatedAt { get; internal set; }
    }
}
