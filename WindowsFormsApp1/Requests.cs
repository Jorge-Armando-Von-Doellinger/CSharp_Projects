using MetroFramework.Controls;

using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Requests
    {
        public static async Task Request(string barcode, MetroTextBox name, MaskedTextBox expirationdate, MetroTextBox brands, MetroTextBox codbar)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://world.openfoodfacts.org/api/v0/product/{barcode}.json";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject productInfo = JObject.Parse(jsonResponse);

                        string productName = productInfo["product"]?["product_name"]?.ToString() ?? "N/A";
                        string brand = productInfo["product"]?["brands"]?.ToString() ?? "N/A";
                        string expiryDate = productInfo["product"]?["expiration_date"]?.ToString() ?? "N/A";

                        if (productName == "N/A")
                        {
                            throw new Exception("Produto não encontrado");
                        }
                        else if (brand == "N/A")
                        {
                            MessageBox.Show("Marca não encontrada!", "Deseja continuar?", MessageBoxButtons.YesNo);
                        }

                        name.Text = productName;
                        expirationdate.Text = expiryDate ?? null;
                        brands.Text = brand;
                        codbar.Text = barcode;
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }
    }
}
