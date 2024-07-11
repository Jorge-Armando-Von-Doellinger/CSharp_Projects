using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.CommunicationAPI.Entities.Response
{
    public class PatientResponse
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? YearsOld { get; set; }
        public DateTime DateBirth { get; set; }

        // --- CONTATO
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string? CPF { get; set; }
        // ------- AGENDAMENTO 
        public DateTime? ScheduledFor { get; set; }
        public DateTime? UpdatedAt { get; internal set; }
    }
}
