using MetroFramework.Controls;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UControl_Products_Management : UserControl
    {
        public UControl_Products_Management()
        {
            InitializeComponent();
            DeleteLineInventoryCaseNotHaveProducts();
            UpdateInventory();
            verifyItemsOnInventoryByLots();
            RefreshDataSource();
        }

        private static void verifyItemsOnInventoryByLots()
        {
            try
            {
                string query = $@"SELECT  
                                COUNT(DISTINCT {Properties.Resources.Lot_ID_Column}) AS count_tb1,
                                (SELECT COUNT(*) FROM {Properties.Resources.Inventory_Table_Name}) AS count_tb2
                            FROM {Properties.Resources.Lot_Table_Name};";
                using (DataTable countRows = SQLite.C_SQLite.DataQueryLanguage(query))
                {
                    if (countRows.Rows[0].Field<Int64>("count_tb1") >
                        countRows.Rows[0].Field<Int64>("count_tb2"))
                    {
                        C_CalculateAndSetOrInsertProducts.InsertItemsInInveoryIfNotExists();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void UpdateInventory()
        {
            C_CalculateAndSetOrInsertProducts.UpdateColumns();
        }

        public void RefreshDataSource()
        {
            string query = $@"
                            SELECT 
                                {Properties.Resources.Inventory_ID_Column} as 'ID',
                                {Properties.Resources.Inventory_Name_Column} as 'Nome',
                                {Properties.Resources.Inventory_Quantity_Column} as 'Quantidade',
                                {Properties.Resources.Inventory_AmountUN_Column} as 'Valor (un)',
                                {Properties.Resources.Inventory_ProfitUN_Column} as 'Lucro (un)',
                                {Properties.Resources.Inventory_Amount_Column} as 'Valor total arrecadado',
                                {Properties.Resources.Inventory_Profit_Column} as 'Lucro total arrecadado',
                                {Properties.Resources.Inventory_Solds_Column} as 'Vendidos',
                                {Properties.Resources.Inventory_Date_Expiration_Column} as 'Validade'
                            FROM
                                {Properties.Resources.Inventory_Table_Name}
                            ORDER BY
                                Nome";
            DataTable dt = SQLite.C_SQLite.DataQueryLanguage(query);
            metroGrid1.DataSource = null;
            metroGrid1.DataSource = dt;
            metroGrid1.Columns["ID"].Visible = false;

            metroGrid1.Columns[3].DefaultCellStyle.Format = "C2";
            metroGrid1.Columns[4].DefaultCellStyle.Format = "C2";
            metroGrid1.Columns[5].DefaultCellStyle.Format = "C2";
            metroGrid1.Columns[6].DefaultCellStyle.Format = "C2";

            metroGrid1.ContextMenuStrip = metroContextMenu1;
        }

        private static void DeleteLineInventoryCaseNotHaveProducts() // IF not have products
        {
            string query = $@"
                DELETE FROM 
                    {Properties.Resources.Inventory_Table_Name} 
                WHERE
                   {Properties.Resources.Inventory_Name_Column} 
                NOT IN (
                    SELECT DISTINCT {Properties.Resources.Lot_Name_Column} 
                FROM 
                    {Properties.Resources.Lot_Table_Name}
                    )";
            SQLite.C_SQLite.DataManipulationLanguage(query);
        }
    }
}
