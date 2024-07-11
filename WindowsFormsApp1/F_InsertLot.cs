using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using ZXing;
using System.Reflection;
using System.Data.SQLite;
using System.Data.Entity.Migrations.Model;

namespace WindowsFormsApp1
{
    public partial class F_InsertLot : MetroFramework.Forms.MetroForm
    {
        public bool RowAddedSuccess = false;
        public F_InsertLot()
        {
            InitializeComponent();
            PopulateCategoryes();
        }

        private void PopulateCategoryes()
        {
            string[] categoryes = {
                "Alimentos",
                "Bebidas",
                "Produtos de Limpeza",
                "Higiene Pessoal",
                "Produtos para Casa",
                "Cuidados com Bebês e Crianças",
                "Outro" };
            mComboBox_Category.Items.AddRange(categoryes);
        }

        private async void mButton_close_Click(object sender, EventArgs e)
        {
            C_CalculateAndSetOrInsertProducts.UpdateColumns();
            await Task.Delay(1);
            
            this.Close();
        }

        private void mButton_add_lot_Click(object sender, EventArgs e)
        {
            
            bool dateExpirationValid = DateTime.TryParseExact(maskedTextBox_expiration_date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime expiration);
            if (!dateExpirationValid)
            {
                MessageBox.Show(expiration.ToString());
                throw new Exception("Data invalidos!");
            }
            if (ItemsNull())
            {
                throw new Exception("Dados insuficientes. Há campos curtos, vazios ou igual a zero!");
            }
            try
            {
                string insert = $@"INSERT INTO
                    {Properties.Resources.Lot_Table_Name}
                (
                    {Properties.Resources.Lot_Name_Column}, 
                    {Properties.Resources.Lot_Quatity_Products_Column}, 
                    {Properties.Resources.Lot_Price_Lote_Column}, 
                    {Properties.Resources.Lot_Profit_Percentage_Column}, 
                    {Properties.Resources.Lot_CodBar_Column}, 
                    {Properties.Resources.Lot_CodLot},
                    {Properties.Resources.Lot_Brand_Column},
                    {Properties.Resources.Lot_Category_Column}, 
                    {Properties.Resources.Lot_Date_Expiration_Column}
                )
                VALUES
                    (
                        @name,
                        @quantity,
                        @price_lot,
                        @profit_percentage,
                        @codbar,
                        @codLot,
                        @brand,
                        @category,
                        @date_expiration
                    )
                ";
                Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
                keyValuePairs.Add("@name", mTextBox_name_lot.Text);
                keyValuePairs.Add("@quantity", nUpDown_quantity.Value);
                keyValuePairs.Add("@price_lot", nUpDown_Price_Lot.Value);
                keyValuePairs.Add("@profit_percentage", nUpDown_profit_percentage.Value);
                keyValuePairs.Add("@codbar", mTextBox_CodBar.Text);
                keyValuePairs.Add("@codLot", mTextBox_CodLot.Text);
                keyValuePairs.Add("@brand", mTextBox_brand.Text);
                keyValuePairs.Add("@category", mComboBox_Category.SelectedItem);
                keyValuePairs.Add("@date_expiration", expiration.ToString("dd/MM/yyyy"));
                SQLite.C_SQLite.DataManipulationLanguage(insert, keyValuePairs);
                Clear();
                C_CalculateAndSetOrInsertProducts.InsertItemsInInveoryIfNotExists();
                RowAddedSuccess = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ItemsNull()
        {
            string name = mTextBox_name_lot.Text;
            int quantity = (Int32)nUpDown_quantity.Value;
            decimal priceLot = nUpDown_Price_Lot.Value;
            decimal profitPercentage = nUpDown_profit_percentage.Value;
            string codbar = mTextBox_CodLot.Text;
            string brand = mTextBox_brand.Text;
            string category = mComboBox_Category.SelectedItem.ToString();
            string dateExpiration = maskedTextBox_expiration_date.Text;

            bool validName = name.Trim().Length > 1;
            bool validCodBar = codbar.Trim().Length > 1;
            bool validBrand = brand.Trim().Length > 1;
            bool validCategory = category.Trim().Length > 1;
            bool validDateExpiration = dateExpiration.Trim().Length >= 8 && dateExpiration.Trim().Length <= 10;
            if(validName || validCodBar || validBrand || validCategory || validDateExpiration)
            {
                if(quantity > 0 || priceLot > 0 || profitPercentage > 0)
                {
                    return false;
                } 
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        private void Clear()
        {
            mComboBox_Category.SelectedItem = null;
            mTextBox_CodBar.Clear();
            mTextBox_name_lot.Clear();
            mTextBox_CodLot.Clear();
            maskedTextBox_expiration_date.Clear();
            nUpDown_Price_Lot.Value = 0;
            nUpDown_profit_percentage.Value = 1;
            nUpDown_quantity.Value = 0;
        }

        private void mButton_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void mButton_delete_last_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Excluir ultima linha adicionada?", "Deletar ultimo lote adicionado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string deleteLast = $@"DELETE FROM {Properties.Resources.Lot_Table_Name} 
                WHERE {Properties.Resources.Lot_ID_Column} = (SELECT MAX ({Properties.Resources.Lot_ID_Column}) 
                                                                FROM {Properties.Resources.Lot_Table_Name})";
                SQLite.C_SQLite.DataManipulationLanguage(deleteLast);
            }
        }

        private async void mButton_scann_codBar_Click(object sender, EventArgs e)
        {
            try
            {
                var barcode = ReadBarFromImage.GetCodBarFromImage(openFileDialog1);
                if (checkBox_request.Checked)
                {
                    await Requests.Request(barcode, mTextBox_name_lot, maskedTextBox_expiration_date, mTextBox_brand,
                        mTextBox_CodLot);
                }
                else
                {
                    mTextBox_CodBar.Text = barcode;
                    /*string dateExtracted = ReadBarFromImage.ExtractDate(barcode);*/
                    /*await Task.Delay(10);
                    maskedTextBox_expiration_date.Text = dateExtracted;*/
                }
                var row = GetDataRowIfProductsExists(barcode);
                if (row.Rows.Count > 0)
                {
                    mTextBox_name_lot.Text = row.Rows[0].Field<string>($"{Properties.Resources.Lot_Name_Column}");
                    mTextBox_brand.Text = row.Rows[0][$"{Properties.Resources.Lot_Brand_Column}"].ToString();
                    mComboBox_Category.SelectedItem = row.Rows[0][$"{Properties.Resources.Lot_Category_Column}"].ToString();
                    nUpDown_profit_percentage.Value = Convert.ToDecimal(row.Rows[0][$"{Properties.Resources.Lot_Profit_Percentage_Column}"]);
                    nUpDown_quantity.Value = Convert.ToDecimal(row.Rows[0][$"{Properties.Resources.Lot_Profit_Percentage_Column}"]);
                    nUpDown_Price_Lot.Value = Convert.ToDecimal(row.Rows[0][$"{Properties.Resources.Lot_Price_Lote_Column}"]);
                }
            }
                catch
                {
                    throw;
                }
        }

        private static DataTable GetDataRowIfProductsExists(string codbar)
        {
            try
            {
                string getProduct = $@"
                SELECT * FROM 
                    {Properties.Resources.Lot_Table_Name} 
                WHERE 
                    {Properties.Resources.Lot_CodBar_Column} = '{codbar}'
                LIMIT 1";
                return SQLite.C_SQLite.DataQueryLanguage(getProduct);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        




    }
}

