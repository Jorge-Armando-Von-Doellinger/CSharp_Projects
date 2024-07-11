using HMS.Application.DTOs.Request.Bases;
using HMS.Application.Json;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HMS.Application.DTOs.Request.Employee
{
    public class EmployeeDTO : PersonBaseDTO
    {
        public string Department { get; set; }
        [JsonConverter(typeof(TimeOnlyConverter))]
        public TimeOnly StartWork { get; set; }
        [JsonConverter(typeof(TimeOnlyConverter))]
        public TimeOnly LunchTime { get; set; }
        [JsonConverter(typeof(TimeOnlyConverter))]
        public TimeOnly EndtWork { get; set; }
        public string PositionWork { get; set; } // Ex: Medico Junior
    }
}
