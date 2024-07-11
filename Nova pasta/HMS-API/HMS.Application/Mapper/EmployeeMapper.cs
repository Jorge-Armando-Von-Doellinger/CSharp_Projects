using HMS.Application.DTOs.Request.Employee;
using HMS.Application.DTOs.Response;
using HMS.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Mapper
{
    public static class EmployeeMapper
    {
        public static EmployeeEntity Mapper(EmployeeDTO employee)
        {
            DateTime today = DateTime.Today; // Data atual

            int YearsOld = today.Year - employee.DateBirth.Year;

            // Verifica se ainda não fez aniversário neste ano
            if (today.Month < employee.DateBirth.Month || (today.Month == employee.DateBirth.Month && today.Day < employee.DateBirth.Day))
            {
                YearsOld--;
            }
            return new EmployeeEntity()
            {
                CPF = employee.CPF,
                DateBirth = employee.DateBirth,
                Department = employee.Department,
                Email = employee.Email,
                EndtWork = employee.EndtWork,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                LunchTime = employee.LunchTime,
                PhoneNumber = employee.PhoneNumber,
                PositionWork = employee.PositionWork,
                StartWork = employee.StartWork,
                YearsOld = YearsOld
            };
        }
        public static List<EmployeeEntity> Mapper(List<EmployeeDTO> employees)
        {
            List<EmployeeEntity> employeeEntities = new List<EmployeeEntity>();
            foreach (EmployeeDTO employee in employees)
            {
                employeeEntities.Add(Mapper(employee));
            }
            return employeeEntities;
        }

        public static EmployeeDataResponse Mapper(EmployeeEntity employee)
        {
            DateTime today = DateTime.Today; // Data atual

            int YearsOld = today.Year - employee.DateBirth.Year;

            // Verifica se ainda não fez aniversário neste ano
            if (today.Month < employee.DateBirth.Month || (today.Month == employee.DateBirth.Month && today.Day < employee.DateBirth.Day))
            {
                YearsOld--;
            }
            return new EmployeeDataResponse()
            {
                CPF = employee.CPF,
                DateBirth = employee.DateBirth,
                Department = employee.Department,
                Email = employee.Email,
                EndtWork = employee.EndtWork,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                LunchTime = employee.LunchTime,
                PhoneNumber = employee.PhoneNumber,
                PositionWork = employee.PositionWork,
                StartWork = employee.StartWork,
                YearsOld = YearsOld,
                ID = employee.ID,
                SocialIntegrationProgramNumber = employee.SocialIntegrationProgramNumber,
                UpdatedAt = employee.UpdatedAt
            };
        }
        public static List<EmployeeDataResponse> Mapper(List<EmployeeEntity> employees)
        {
            List<EmployeeDataResponse> employeeEntities = new List<EmployeeDataResponse>();
            foreach (EmployeeEntity employee in employees)
            {
                employeeEntities.Add(Mapper(employee));
            }
            return employeeEntities;
        }

        public static EmployeeEntity Mapper(EmployeeUpdateDTO employee)
        {
            DateTime today = DateTime.Today; // Data atual

            int YearsOld = today.Year - employee.DateBirth.Year;

            if (today.Month < employee.DateBirth.Month || (today.Month == employee.DateBirth.Month && today.Day < employee.DateBirth.Day))
            {
                YearsOld--;
            }
            return new EmployeeEntity()
            {
                CPF = employee.CPF,
                DateBirth = employee.DateBirth,
                Department = employee.Department,
                Email = employee.Email,
                EndtWork = employee.EndtWork,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                LunchTime = employee.LunchTime,
                PhoneNumber = employee.PhoneNumber,
                PositionWork = employee.PositionWork,
                StartWork = employee.StartWork,
                YearsOld = YearsOld,
                ID = employee.ID
            };
        }
        public static EmployeeEntity Mapper(CreateEmployeeDTO employee)
        {
            DateTime today = DateTime.Today; // Data atual

            int YearsOld = today.Year - employee.DateBirth.Year;

            // Verifica se ainda não fez aniversário neste ano
            if (today.Month < employee.DateBirth.Month || (today.Month == employee.DateBirth.Month && today.Day < employee.DateBirth.Day))
            {
                YearsOld--;
            }
            return new EmployeeEntity()
            {
                CPF = employee.CPF,
                DateBirth = employee.DateBirth,
                Department = employee.Department,
                Email = employee.Email,
                EndtWork = employee.EndtWork,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                LunchTime = employee.LunchTime,
                PhoneNumber = employee.PhoneNumber,
                PositionWork = employee.PositionWork,
                StartWork = employee.StartWork,
                YearsOld = YearsOld,
                SocialIntegrationProgramNumber = employee.SocialIntegrationProgramNumber
            };
        }
    }
}
