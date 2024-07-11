using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Entities.Base
{
    public abstract class PersonBase : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } // Mudara
        public int YearsOld { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; } // OPCIONAL
        //CPF = UNIQUE
        public Int64 CPF { get; set; }
        public DateOnly DateBirth { get; set; }
    }
}
