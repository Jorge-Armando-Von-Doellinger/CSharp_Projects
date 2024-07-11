using HMS.CommunicationAPI.Entities.Response;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HMS.CommunicationAPI.ResponseDeserialization
{
    public class PatientDeserialization
    {
        public static async Task<PatientResponse> GetDesserialized(JsonElement root)
        {
            PatientResponse patient = new PatientResponse
            {
                YearsOld = root.GetProperty("YearsOld").GetInt32(),
                PhoneNumber = root.GetProperty("PhoneNumber").GetString(),
                Email = root.GetProperty("Email").GetString(),
                ScheduledFor = root.GetProperty("ScheduledFor").GetDateTime(),
                FirstName = root.GetProperty("FirstName").GetString(),
                LastName = root.GetProperty("LastName").GetString(),
                CPF = root.GetProperty("CPF").GetString(),
                DateBirth = root.GetProperty("DateBirth").GetDateTime(),
                ID = root.GetProperty("ID").GetInt32(),
                UpdatedAt = root.GetProperty("UpdatedAt").GetDateTime()
            };
            return await Task.FromResult(patient);
        }
        public static async Task<List<PatientResponse>> Desserialization(string json)
        {
            JsonDocument doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;

            List<PatientResponse> patients = new List<PatientResponse>();
            if(root.ValueKind == JsonValueKind.Array)
            {
                foreach(JsonElement element in root.EnumerateArray())
                {
                    patients.Add(await GetDesserialized(element));
                }
            }
            else
            {
                patients.Add(await GetDesserialized(root));
            }
            return patients;
        }
    }
}
