using HMS.Application.DTOs.Request.Employee;
using HMS.Application.DTOs.Request.Patient;
using HMS.Application.DTOs.Response;
using HMS.Application.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Interfaces
{
    public interface IEmployeeApplication
    {
        public Task<Response<EmployeeDataResponse>> GetEmployeesAsync();
        public Task<Response<EmployeeDataResponse>> GetEmployeeByIdAsync(Int64 ID);
        public Task<Response<EmployeeDataResponse>> GetEmployeeByName(string name, string lastname);
        public Task<Response<EmployeeDataResponse>> GetEmployeeByCPF(Int64 CPF);
        public Task<Response<EmployeeDataResponse>> CreateEmployeeAsync(CreateEmployeeDTO patient);
        public Task<Response<EmployeeDataResponse>> UpdateEmployeeAsync(EmployeeUpdateDTO patient);
        public Task<Response<EmployeeDataResponse>> DeleteEmployeeAsync(Int64 ID);
    }
}
