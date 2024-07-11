using HMS.Application.DTOs.Request.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.DTOs.Request.Patient
{
    public class PatientDTO : PersonBaseDTO
    {
        // ----- INFS -----
        public DateTime? ScheduledFor { get; set; }

    }
}
