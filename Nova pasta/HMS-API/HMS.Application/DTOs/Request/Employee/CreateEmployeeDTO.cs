using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.DTOs.Request.Employee
{
    public class CreateEmployeeDTO : EmployeeDTO
    {
        public Int64 SocialIntegrationProgramNumber { get; set; }
    }
}
