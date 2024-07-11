using EmployeeForms.DataContract;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeForms.Services
{
    public class EmployeeService
    {
        private readonly string defaultURl;
        public EmployeeService()
        {
            defaultURl = "https://localhost:7119/Employee";
        }
        public async Task<List<EmployeeResponse>> GetEmployees()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.GetAsync(defaultURl);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        string response = await responseMessage.Content.ReadAsStringAsync();
                        Root root = JsonConvert.DeserializeObject<Root>(response);

                        List<EmployeeResponse> employees = new List<EmployeeResponse>();
                        employees.AddRange(root.data);
                        return employees;

                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<EmployeeResponse> GetEmployeesByID(Int64 ID)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.GetAsync(defaultURl + $"/{ID}");
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        string response = await responseMessage.Content.ReadAsStringAsync();
                        Root root = JsonConvert.DeserializeObject<Root>(response);

                        EmployeeResponse employees = new EmployeeResponse();
                        employees = root.singleData;
                        return employees;

                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<EmployeeResponse> AddEmployee(EmployeeRequest employeeRequest)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string serialized = JsonConvert.SerializeObject(employeeRequest);
                    StringContent content = new StringContent(serialized, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(defaultURl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        Root root = JsonConvert.DeserializeObject<Root>(responseString);
                        EmployeeResponse employee = root.singleData;
                        return employee;
                    }
                    else
                    {
                        string errorContent = await response.Content.ReadAsStringAsync();
                        throw new Exception($"Erro ao adicionar funcionário! Status Code: {response.StatusCode}. Conteúdo do erro: {errorContent}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public async Task<EmployeeResponse> UpdateEmployee(EmployeeUpdateRequest employeeRequest)
        {
            try
            {
                using(HttpClient client = new HttpClient())
                {
                    string serilized = JsonConvert.SerializeObject(employeeRequest);
                    StringContent content = new StringContent(serilized, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync(defaultURl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        Root desserialize = JsonConvert.DeserializeObject<Root>(responseString);
                        EmployeeResponse updatedEmployee = desserialize.singleData;
                        if(updatedEmployee != null) 
                            return updatedEmployee;
                    }
                    string responseString1 = await response.Content.ReadAsStringAsync();
                    throw new Exception(responseString1);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public async Task<bool> DeleteEmployee(long ID)
        {
            try
            {
                using(HttpClient client = new HttpClient())
                {
                    
                    HttpResponseMessage response = await client.DeleteAsync($"{defaultURl}?ID={ID}");
                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        Root root = JsonConvert.DeserializeObject<Root>(responseString);
                        if (root.Success)
                            return true;
                        MessageBox.Show(root.Success.ToString());
                    }
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
