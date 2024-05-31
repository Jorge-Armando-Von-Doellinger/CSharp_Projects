using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_Estoque
{
    public partial class Form_AddLote : MetroFramework.Forms.MetroForm
    {
        public Form_AddLote()
        {
            InitializeComponent();
            metroTextBox_lote_date_expiration.Enabled = false;

            string[] option =
            {
                "Alimentos",
                "Bebidas",
                "Produtos de Limpeza",
                "Higiene Pessoal",
                "Produtos para Casa",
                "Cuidados com Bebês e Crianças",
                "Outro"
            };

            metroComboBox_lot_category.Items.AddRange(option);
        }

        private bool verifyIsNullOrEmpty()
        {
            bool name = metroTextBox_lote_name.Text.Trim().Length > 0;
            bool price = metroTextBox_lote_price.Text.Trim().Length > 0;
            bool quantity = metroTextBox_lote_quantity.Text.Trim().Length > 0;
            bool profitPercentage = metroTextBox_lot_profit_percentage.Text.Trim().Length > 0;
            bool category = metroComboBox_lot_category.SelectedItem.ToString().Trim().Length > 0;
            bool date_expiration;
            
            if(metroCheckBox_insert_by_checkbox.Checked)
            {
                date_expiration = metroTextBox_lote_date_expiration.Text.Trim().Length > 0;
            } 
            else
            {
                date_expiration = metroDateTime_lot_date_expiration.Value.ToString("dd/MM/yyyy").Trim().Length > 0;
            }

            if(name && price && quantity && profitPercentage && category && date_expiration)
            {
                MessageBox.Show("");
                return false;
            } 
            else
            {
                MessageBox.Show("Dados insufientes. Por favor, preencha todas as informações");
                return true;
            }
        }

        private void Lots_InsertToDB()
        {
            string query = $@"
                Insert Into
                    {Properties.Resources.Lot_Table_Name}
                (
                {Properties.Resources.Lot_Name_Column}, 
                {Properties.Resources.Lot_Price_Lote_Column},
                {Properties.Resources.Lot_Quatity_Products_Column},
                {Properties.Resources.Lot_Units_Solds_Column},
                {Properties.Resources.Lot_Profit_Percentage_Column},
                {Properties.Resources.Lot_Status_Column},
                {Properties.Resources.Lot_Category_Column},
                {Properties.Resources.Lot_Date_Expiration_Column}
                )
                VALUES
                (
                    @name, 
                    @price,
                    @quantity, 
                    @units_solds, 
                    @profit_percentage, 
                    @status, 
                    @category, 
                    @date_expiration
                )";
            bool? dateIsDate = null;
            DateTime date_expiration; 

            if (metroCheckBox_insert_by_checkbox.Checked)
            {
                dateIsDate = DateTime.TryParse(metroTextBox_lote_date_expiration.Text, out DateTime date_expiration_result);
                date_expiration = date_expiration_result;
            }
            else
            {
                date_expiration = metroDateTime_lot_date_expiration.Value;
                dateIsDate = true;
            }
            string name = metroTextBox_lote_name.Text;
            bool priceIsNumber = decimal.TryParse(metroTextBox_lote_price.Text, out decimal priceResult);
            bool quantityIsNumber = int.TryParse(metroTextBox_lote_quantity.Text, out int quantityResult);
            bool profitPercentageIsNumber = decimal.TryParse(metroTextBox_lot_profit_percentage.Text, out decimal profitPercentage);

            

            
            if (!priceIsNumber || !quantityIsNumber || !profitPercentageIsNumber || dateIsDate == false)
            {
                MessageBox.Show("Dados incorretos. Verifique as caixas de entrada e tente novamente!");
                return;
            }
            if(dateIsDate == null)
            {
                return;
            }

            string status = null;
            TimeSpan timeSpan = date_expiration - DateTime.Now;

            if (timeSpan.TotalDays <= 1)
            {
                status = "Vencido";
            }
            else if(timeSpan.TotalDays <= 31)
            {
                status = "Menos de 1 mês para Vencer";
            }
            else if (timeSpan.TotalDays <= 60)
            {
                status = "Próximo ao Vencimento";
            } 
            else if(timeSpan.TotalDays > 60)
            {
                status = "Na Validade";
            }
            else if (status == null)
            {
                MessageBox.Show("Não aceito!");
                return;
            }
            


            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
            keyValuePairs.Add("@name", name);
            keyValuePairs.Add("@price", priceResult);
            keyValuePairs.Add("@quantity", quantityResult);
            keyValuePairs.Add("@units_solds", 0);
            keyValuePairs.Add("@profit_percentage", profitPercentage);
            keyValuePairs.Add("@status", status);
            keyValuePairs.Add("@category", metroComboBox_lot_category.SelectedItem.ToString());
            keyValuePairs.Add("@date_expiration", date_expiration.ToString("dd/MM/yyyy"));
            SQLite.DataManipulationLanguage(query, keyValuePairs);

        }

        private void metroButton_lot_add__Click(object sender, EventArgs e)
        {
            if (verifyIsNullOrEmpty()) { return; }
            else
            {
                Lots_InsertToDB();
            }
        }

        private void metroCheckBox_insert_by_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                if(checkBox.Checked)
                {
                    metroDateTime_lot_date_expiration.Enabled = false;
                    metroTextBox_lote_date_expiration.Enabled = true;
                    metroTextBox_lote_date_expiration.ReadOnly = true;
                }
                else
                {
                    metroDateTime_lot_date_expiration.Enabled = true;
                    metroTextBox_lote_date_expiration.Enabled = false;
                    metroTextBox_lote_date_expiration.ReadOnly = false;

                }
            }
        }
    }
}
