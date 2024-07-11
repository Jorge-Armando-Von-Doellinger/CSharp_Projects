using HMS.Application.Json;

using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HMS.Application.DTOs.Request.Bases
{
    public class PersonBaseDTO : BaseDTO
    {
        // -------INFORMAÇÕES BÁSICAS
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [JsonIgnore]
        public int? YearsOld { get; set; }
        [JsonConverter(typeof(DateOnlyConverter))]
        public DateOnly DateBirth { get; set; }

        // --- CONTATO
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Int64 CPF { get; set; }
        // ------- AGENDAMENTO 
    }
}
