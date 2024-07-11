using HMS.CommunicationAPI.Entities.Response;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.CommunicationAPI.ResponseDeserialization
{
    public class PatientDeserialization
    {
        public static async Task<PatientResponse> GetDesserialized(JsonElement root)
        {
            try
            {
                PatientResponse patient = new PatientResponse
                {
                    YearsOld = root.TryGetProperty("yearsOld", out var yearsOld) ? yearsOld.GetInt32() : 0,
                    PhoneNumber = root.TryGetProperty("phoneNumber", out var phoneNumber) ? phoneNumber.GetString() : null,
                    Email = root.TryGetProperty("email", out var email) ? email.GetString() : null,
                    ScheduledFor = root.TryGetProperty("scheduledFor", out var scheduledFor) ? scheduledFor.GetDateTime() : DateTime.MinValue,
                    FirstName = root.TryGetProperty("firstName", out var firstName) ? firstName.GetString() : null,
                    LastName = root.TryGetProperty("lastName", out var lastName) ? lastName.GetString() : null,
                    CPF = root.TryGetProperty("cpf", out var cpf) ? cpf.GetString() : null,
                    DateBirth = root.TryGetProperty("dateBirth", out var dateBirth) ? dateBirth.GetDateTime() : DateTime.MinValue,
                    ID = root.TryGetProperty("id", out var id) ? id.GetInt32() : 0,
                    UpdatedAt = root.TryGetProperty("updatedAt", out var updatedAt) ? updatedAt.GetDateTime() : DateTime.MinValue
                };
                return await Task.FromResult(patient);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao desserializar paciente: {ex.Message}");
                throw;
            }
        }

        public static async Task<List<PatientResponse>> Desserialization(string json)
        {
            try
            {
                using (JsonDocument doc = JsonDocument.Parse(json))
                {
                    JsonElement root = doc.RootElement;
                    if (root.TryGetProperty("data", out JsonElement dataElement) && dataElement.ValueKind == JsonValueKind.Array)
                    {
                        List<PatientResponse> patients = new List<PatientResponse>();
                        foreach (var patientElement in dataElement.EnumerateArray())
                        {
                            patients.Add(await GetDesserialized(patientElement));
                        }
                        return patients;
                    }
                    else
                    {
                        throw new Exception("O JSON não contém um array 'data'.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na desserialização de pacientes: {ex.Message}");
                throw;
            }
        }
    }
}
