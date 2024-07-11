using HMS.Domain.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Entities
{
    public class EmployeeEntity : PersonBase
    {
        public string Department { get; set; }
        public TimeOnly StartWork { get; set; }
        public TimeOnly LunchTime { get; set; }
        public TimeOnly EndtWork { get; set; }
        public string PositionWork { get; set; } // Ex: Medico Junior
        public Int64? SocialIntegrationProgramNumber { get; set; }
    }
}
