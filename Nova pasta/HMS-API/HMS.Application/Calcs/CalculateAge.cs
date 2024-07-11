using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Calcs
{
    public class CalculateAge
    {
        public CalculateAge()
        {
            
        }

        public static int CalculateYears(DateOnly dateBirth)
        {
            DateTime today = DateTime.Today; // Data atual

            int YearsOld = today.Year - dateBirth.Year;

            // Verifica se ainda não fez aniversário neste ano
            if (today.Month < dateBirth.Month || (today.Month == dateBirth.Month && today.Day < dateBirth.Day))
            {
                YearsOld--;
            }
            return YearsOld;
        }
    }
}
