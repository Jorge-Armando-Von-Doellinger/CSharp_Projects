using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForms.DataContract
{
    public class BaseEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? YearsOld { get; set; }
        public string DateBirth { get; set; }

        // --- CONTATO
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Int64? CPF { get; set; }
        // ------- AGENDAMENTO 
        public string Department { get; set; }
        public string StartWork { get; set; }
        //public string FormattedStartWork => StartWork.ToString("hh:mm");
        public string LunchTime { get; set; }
        //public string FormattedLunchTime => StartWork.ToString("hh:mm");
        public string EndtWork { get; set; }
        //public string FormattedEndWork => StartWork.ToString("hh:mm");
        public string PositionWork { get; set; } // Ex: Medico Junior
        public Int64? SocialIntegrationProgramNumber { get; set; }
    }
}
