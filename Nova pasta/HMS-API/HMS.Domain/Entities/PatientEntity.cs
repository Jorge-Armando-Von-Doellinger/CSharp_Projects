using HMS.Domain.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Entities
{
    public class PatientEntity : PersonBase
    {
        public DateTime? ScheduledFor { get; set; }

        
    }
}
