using Newtonsoft.Json;

using PatientFoms.Data.Entities;
using PatientFoms.Manipulation.Response;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientFoms.Services
{
    public class PatientService
    {
        string defaultURl = "https://localhost:7119/api/patient";
        public async Task<List<PatientResponse>> GetPatients()
        {
            try
            {
                List<PatientResponse> patient;
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(defaultURl);
                    if (response == null)
                    {
                        throw new Exception("Erro auqi");
                    }
                    response.EnsureSuccessStatusCode();
                    string jsonString = await response.Content.ReadAsStringAsync();
                    patient = await PatientDeserialization.Desserialization(jsonString);

                    return patient;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public async Task<PatientResponse> GetPatientById(int ID)
        {
            try
            {
                List<PatientResponse> patient;
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(defaultURl + $"/{ID}");
                    if (response == null)
                    {
                        throw new Exception("Erro auqi");
                    }
                    response.EnsureSuccessStatusCode();
                    string jsonString = await response.Content.ReadAsStringAsync();
                    patient = await PatientDeserialization.Desserialization(jsonString);
                    return patient.First();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Services");
                throw;
            }
        }
        public async Task<PatientResponse> CreatePatient(PatientRequest patientRequest)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(patientRequest);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(defaultURl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        List<PatientResponse> patientDeserialized = await PatientDeserialization.Desserialization(responseBody);
                        return patientDeserialized.First();
                    }
                    throw new Exception("Houve um erro na requisição de postagen");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public async Task<PatientResponse> UpdatePatient(PatientRequest patientRequest)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(patientRequest);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync(defaultURl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        List<PatientResponse> patientDeserialized = await PatientDeserialization.Desserialization(responseBody);
                        return patientDeserialized.First();
                    }
                    throw new Exception("Houve um erro na requisição de atualização");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public async Task<PatientResponse> DeletePatient(PatientRequest patientRequest)
        {
            try
            {
                if (patientRequest.ID == 0 || patientRequest.ID == null)
                    throw new Exception("ID 0 ou nulo");
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.DeleteAsync(defaultURl + $"/{patientRequest.ID}");
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        List<PatientResponse> patientDeserialized = await PatientDeserialization.Desserialization(responseBody);
                        if (patientDeserialized == default)
                            return default;
                    }
                    throw new Exception("Houve um erro na requisição de exclusão");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public async Task<List<PatientResponse>> GetPatientsByNameOrLastName(string name= "", string lastname = "")
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var parameters = new
                    {
                        FirstName = name,
                        LastName = lastname
                    };
                    string json = JsonConvert.SerializeObject(parameters);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.GetAsync($"{defaultURl}/find/name?name={name}&lastname={lastname}");
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        List<PatientResponse> patientDeserialized = await PatientDeserialization.Desserialization(responseBody);
                        //MessageBox.Show(patientDeserialized[0].ToString()); //Tem 0 itens, index -1
                        return patientDeserialized;
                    }
                    throw new Exception("Houve um erro na requisição de postagen");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}

