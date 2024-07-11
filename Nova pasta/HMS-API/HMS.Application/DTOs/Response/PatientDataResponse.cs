using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.DTOs.Response
{
    public class PatientDataResponse
    {
        public Int64 ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? YearsOld { get; set; }
        public DateOnly DateBirth { get; set; }

        // --- CONTATO
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Int64? CPF { get; set; }
        // ------- AGENDAMENTO 
        public DateTime? ScheduledFor { get; set; }
        public DateTime? UpdatedAt { get; internal set; }
    }
}
