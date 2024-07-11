using HMS.CommunicationAPI.Entities.Response;
using HMS.CommunicationAPI.ResponseDeserialization;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.CommunicationAPI.Services
{
    public class PatientServices
    {
        public static async Task<List<PatientResponse>> GetPatients()
        {
            try
            {
                List<PatientResponse> patient;
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage
                        
                        
                        response = await client.GetAsync("https://localhost:7119/api/patient");
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
    }
}
