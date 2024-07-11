using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForms.DataContract
{
    public class EmployeeResponse : BaseEmployee
    {
        public Int64 ID { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
