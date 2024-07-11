using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.DTOs.Response
{
    public class EmployeeDataResponse
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
        // ------- Dados de empregado
        public string Department { get; set; }
        public TimeOnly StartWork { get; set; }
        public TimeOnly LunchTime { get; set; }
        public TimeOnly EndtWork { get; set; }
        public string PositionWork { get; set; } // Ex: Medico Junior
        public Int64? SocialIntegrationProgramNumber { get; set; }
        public DateTime? UpdatedAt { get; internal set; }
    }
}
