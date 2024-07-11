using HMS.CommunicationAPI.Entities.Response;
using HMS.CommunicationAPI.ResponseDeserialization;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HMS.CommunicationAPI.Services
{
    public class PatientServices
    {
        public static async Task<List<PatientResponse>> GetPatients()
        {
            List<PatientResponse> patient;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("");
                response.EnsureSuccessStatusCode();
                string jsonString = await response.Content.ReadAsStringAsync();
                patient = await PatientDeserialization.Desserialization(jsonString);
            }
            return patient;
        }
    }
}
