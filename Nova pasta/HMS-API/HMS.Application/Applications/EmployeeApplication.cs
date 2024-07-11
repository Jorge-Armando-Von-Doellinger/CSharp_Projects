using HMS.Application.DTOs.Request.Employee;
using HMS.Application.DTOs.Request.Patient;
using HMS.Application.DTOs.Response;
using HMS.Application.Interfaces;
using HMS.Application.Mapper;
using HMS.Application.Models;
using HMS.Domain.Entities;
using HMS.Domain.Interfaces.Services;
using HMS.Domain.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Applications
{
    public class EmployeeApplication : IEmployeeApplication
    {
        private readonly IEmployeeService _employeeService;
        private Response<EmployeeDataResponse> response;
        public EmployeeApplication(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            response = new ();
        }
        public async Task<Response<EmployeeDataResponse>> CreateEmployeeAsync(CreateEmployeeDTO patient)
        {
            try
            {
                EmployeeEntity employeeMapped = EmployeeMapper.Mapper(patient);
                EmployeeEntity employeeCreated = await _employeeService.CreateAsync(employeeMapped)
                    ?? throw new Exception("Houve erros durante a criação do funcionario!");
                response.SingleData = EmployeeMapper.Mapper(employeeCreated);
            }
            catch(Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                
            }
            return response;
        }

        public async Task<Response<EmployeeDataResponse>> DeleteEmployeeAsync(Int64 ID)
        {
            try
            {
                EmployeeEntity employee = new EmployeeEntity() { ID = ID };
                int rowsAffected = await _employeeService.DeleteAsync(employee);
                if(rowsAffected == 1)
                {
                    response.Message = "Usuario delatado com sucesso!";
                }
                else
                {
                    throw new Exception($"Houve erros durante a exclusão do funcionario. Itens afetados = {rowsAffected}");
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;

            }
            return response;
        }

        public async Task<Response<EmployeeDataResponse>> GetEmployeesAsync()
        {
            try
            {
                List<EmployeeEntity> employees = await _employeeService.GetAllAsync();
                response.Data = EmployeeMapper.Mapper(employees);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;

            }
            return response;
        }
        public async Task<Response<EmployeeDataResponse>> GetEmployeeByCPF(Int64 CPF)
        {
            try
            {
                EmployeeDataResponse employee = EmployeeMapper.Mapper(await _employeeService.GetByCPFAsync(CPF));
                //?? throw new Exception("Empregado não encontrado!");
                response.SingleData = employee;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                response.SingleData = null;
            }
            return response;
        }

        public async Task<Response<EmployeeDataResponse>> GetEmployeeByName(string name, string lastname)
        {
            try
            {
                EmployeeEntity entity = new() { FirstName = name, LastName = lastname };
                List<EmployeeEntity> employeeByName = await _employeeService.GetByNameAsync(entity);
                response.Data = EmployeeMapper.Mapper(employeeByName);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                response.SingleData = null;
            }
            return response;

        }
        public async Task<Response<EmployeeDataResponse>> GetEmployeeByIdAsync(Int64 ID)
        {
            try
            {
                EmployeeEntity employee = await _employeeService.GetByIdAsync(ID);
                response.SingleData = EmployeeMapper.Mapper(employee);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;

            }
            return response;
        }

        public async Task<Response<EmployeeDataResponse>> UpdateEmployeeAsync(EmployeeUpdateDTO patient)
        {
            try
            {
                Console.WriteLine(patient.DateBirth);
                EmployeeEntity? employeeMapped = EmployeeMapper.Mapper(patient);
                EmployeeEntity employee = await _employeeService.UpdateAsync(employeeMapped)
                    ?? throw new Exception("Houve um ou mais erros durantea atualização do funcionario!");
                response.SingleData = EmployeeMapper.Mapper(employee);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;

            }
            return response;
        }
    }
}
