using PatientFoms.Data.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientFoms.Manipulation.Response
{
    public class PatientDeserialization
    {
        public static async Task<PatientResponse> GetDesserialized(JsonElement root)
        {
            try
            {
                PatientResponse patient = new PatientResponse
                {
                    YearsOld = root.TryGetProperty("yearsOld", out var yearsOld) && yearsOld.ValueKind != JsonValueKind.Null ? yearsOld.GetInt32() : 0,
                    PhoneNumber = root.TryGetProperty("phoneNumber", out var phoneNumber) && phoneNumber.ValueKind != JsonValueKind.Null ? phoneNumber.GetString() : null,
                    Email = root.TryGetProperty("email", out var email) && email.ValueKind != JsonValueKind.Null ? email.GetString() : null,
                    ScheduledFor = root.TryGetProperty("scheduledFor", out var scheduledFor) && scheduledFor.ValueKind != JsonValueKind.Null ? scheduledFor.GetDateTime() : DateTime.MinValue,
                    FirstName = root.TryGetProperty("firstName", out var firstName) && firstName.ValueKind != JsonValueKind.Null ? firstName.GetString() : null,
                    LastName = root.TryGetProperty("lastName", out var lastName) && lastName.ValueKind != JsonValueKind.Null ? lastName.GetString() : null,
                    CPF = root.TryGetProperty("cpf", out var cpf) && cpf.ValueKind != JsonValueKind.Null ? cpf.GetInt64() : 0,
                    DateBirth = root.TryGetProperty("dateBirth", out var dateBirth) && dateBirth.ValueKind != JsonValueKind.Null ? dateBirth.GetDateTime() : DateTime.MinValue,
                    ID = root.TryGetProperty("id", out var id) && id.ValueKind != JsonValueKind.Null ? id.GetInt64() : 0,
                    UpdatedAt = root.TryGetProperty("updatedAt", out var updatedAt) && updatedAt.ValueKind != JsonValueKind.Null ? updatedAt.GetDateTime() : DateTime.MinValue
                };
                //MessageBox.Show(patient.ID.ToString());
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
                    bool isData = root.TryGetProperty("data", out JsonElement dataElement);
                    bool isSingleData = root.TryGetProperty("singleData", out JsonElement singleDataElement);
                    if (isData)
                    {
                        //MessageBox.Show(dataElement.ToString());
                        if (dataElement.ValueKind == JsonValueKind.Array)
                        {
                            List<PatientResponse> patients = new List<PatientResponse>();
                            foreach (var patientElement in dataElement.EnumerateArray())
                            {
                                patients.Add(await GetDesserialized(patientElement));
                            }
                            return patients;
                        }
                        else if (dataElement.ValueKind == JsonValueKind.Object)
                        {
                            List<PatientResponse> patients = new List<PatientResponse>();
                            foreach (var patientElement in dataElement.EnumerateArray())
                            {
                                patients.Add(await GetDesserialized(patientElement));
                            }
                            return patients;
                        }
                    }
                    if (isSingleData)
                    {
                        //MessageBox.Show(singleDataElement.ToString());
                        List<PatientResponse> patients = new List<PatientResponse>();
                        if (singleDataElement.ValueKind == JsonValueKind.String)
                        {
                            patients.Add(await GetDesserialized(singleDataElement));
                            return patients;
                        }
                        else if (singleDataElement.ValueKind == JsonValueKind.Object)
                        {
                            patients.Add(await GetDesserialized(singleDataElement));
                            return patients;
                        }
                        else
                        {
                            throw new Exception("Erro inesperado no singleData");
                        }
                    }
                    throw new Exception("Nenhum dado desserializado!");
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
