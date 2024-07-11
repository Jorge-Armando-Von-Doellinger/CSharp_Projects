using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForms.DataContract
{
    public class EmployeeUpdateRequest : EmployeeRequest
    {
        public long ID { get; set; }
    }
}
