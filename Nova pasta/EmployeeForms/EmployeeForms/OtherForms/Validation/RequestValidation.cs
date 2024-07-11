using EmployeeForms.DataContract;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeForms.OtherForms.Validation
{
    public class RequestValidation
    {
        public static async Task<bool> ValidateBasicData(EmployeeRequest employeeRequest)
        {
            bool name = employeeRequest.FirstName.Length > 0;
            bool lastName = employeeRequest.LastName.Length > 0;
            bool cpf = employeeRequest.CPF.Value.ToString().Length == 11 && employeeRequest.CPF != null;
            bool email = employeeRequest.Email.Contains("@") && 
                employeeRequest.Email.Contains(".com") && 
                employeeRequest.Email != null;
            DateTime dateBirthExtracted = DateTime.ParseExact(employeeRequest.DateBirth, "yyyy-MM-dd", CultureInfo.InvariantCulture); 
            bool DateBirth = DateTime.Now.Year - dateBirthExtracted.Year >= 18;
            bool phoneNumber = Regex.Replace(employeeRequest.PhoneNumber, "[^0-9]", "").Length == 11;
            if (!name && !lastName)
                MessageBox.Show("Nome e/ou sobrenome incorretos!");
            if(!cpf && !email)
                MessageBox.Show("CPF e/ou Email incorretos!");
            if(!DateBirth && !phoneNumber)
                MessageBox.Show("Data de aniversario e/ou Numero de telefone incorretos!");
                return await Task.FromResult(name && lastName && cpf && email && phoneNumber && DateBirth);
        }

        public static bool ValidateDateWork(EmployeeRequest employeeRequest)
        {
            //Futuramente, talvez....
            return true;
        }
    }
}
