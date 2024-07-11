using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Data.Entity.Infrastructure.Design.Executor;

namespace WindowsFormsApp1
{
    struct Calculate
    {
        internal static decimal CalculateAmountUN(decimal priceLote, decimal percentage, int quantity)
        {
            return priceLote / quantity * (percentage / 100 + 1);
        }

        internal static decimal CalculateProfitUN(decimal priceLote, decimal percentage, int quantity)
        {
            return priceLote / quantity * (percentage / 100);
        }

        internal static decimal CalculateTotalAmount(decimal priceLote, decimal percentage, int Unitsolds, int quantity)
        {
            return ((priceLote / quantity) * (percentage / 100 + 1)) * Unitsolds;
        }

        internal static decimal CalculateTotalProfit(decimal priceLote, decimal percentage, int quantity, int units_solds)
        {
            return priceLote / quantity * units_solds * (percentage / 100);
        }

        internal static decimal CalculateUn(decimal value, int rows)
        {
            return value / rows;
        }

    }
    internal class C_CalculateAndSetOrInsertProducts
    {
/*        private static Dictionary<string, object> CalculateColumns(string name)
        {
            string query = $@"SELECT
                                *
                            FROM
                                {Properties.Resources.Lot_Table_Name}
                            WHERE
                                {Properties.Resources.Lot_Name_Column} = '{name}' 
                            AND 
                                {Properties.Resources.Lot_Status_Column} <> 'Vencido'";
            *//*String_Stauts<>'{status}'*//*
            var dt = SQLite.C_SQLite.DataQueryLanguage(query).AsEnumerable();

            int quantity = 0;
            int UnitsSolds = 0;
            decimal AmountUN = 0;
            decimal ProfitUN = 0;
            decimal totalAmountRaised = 0;
            decimal totalProfit = 0;
            *//*decimal loteTotalPrice = 0;*//*
            List<DateTime> dateTimes = new List<DateTime>();



            foreach (var row in dt)
            {
                quantity += Convert.ToInt32(row.Field<Int64>("Int_Quantity_Products"));

                AmountUN +=
                Calculate.CalculateAmountUN(
                    (decimal)row.Field<decimal>("Decimal_Price_Lote"),
                    (decimal)row.Field<decimal>("Decimal_Total_Profit_Percentage"),
                    (Int32)row.Field<Int64>("Int_Quantity_Products")
                    );

                ProfitUN +=
                Calculate.CalculateProfitUN(
                    (decimal)row.Field<decimal>("Decimal_Price_Lote"),
                    (decimal)row.Field<decimal>("Decimal_Total_Profit_Percentage"),
                    (Int32)row.Field<Int64>("Int_Quantity_Products")
                    );

                totalAmountRaised +=
                    Calculate.CalculateTotalAmount(
                    row.Field<decimal>("Decimal_Price_Lote"),
                    row.Field<decimal>("Decimal_Total_Profit_Percentage"),
                    (Int32)row.Field<Int64>("Int_Number_Of_Units_Sold"),
                    (Int32)row.Field<Int64>("Int_Quantity_Products")
                        );

                totalProfit +=
                    Calculate.CalculateTotalProfit(
                    row.Field<decimal>("Decimal_Price_Lote"),
                    row.Field<decimal>("Decimal_Total_Profit_Percentage"),
                    (Int32)row.Field<Int64>("Int_Quantity_Products"),
                    (Int32)row.Field<Int64>("Int_Number_Of_Units_Sold")
                        );

                UnitsSolds += (Int32)row.Field<Int64>("Int_Number_Of_Units_Sold");

                dateTimes.Add(DateTime.Parse(row.Field<string>("String_Date_Expiration")));
            }
            //Quantidade de produtos, valor do lote, % lucro, units solds, data de expiração
            ProfitUN = Calculate.CalculateUn(ProfitUN, dt.Count());
            AmountUN = Calculate.CalculateUn(AmountUN, dt.Count());
            *//*totalProfit -= loteTotalPrice;*//*
            DateTime dateFirst = dateTimes.OrderBy(d => Math.Abs((d - DateTime.Now).TotalDays)).First();

            *//*            query = $@"UPDATE 
                                    Inventory_Management1
                                SET
                                    Product_Quantity = @quatity,
                                    Product_Amount_UN = @amountUN,
                                    Product_Profit_UN = @profitUN,
                                    Product_Amount = @amount,
                                    Product_Profit = @profit,
                                    Products_Sold = @solds,
                                    Products_Date_Expiration = @date_expiration
                                WHERE
                                    Product_ID = @ID AND Product_Name = @name
                                    ";
                            keyValues.Add("@ID", index);
                            //Caso seja edição, ai necessitará de um index

                        keyValues.Add("@name", name);
                        keyValues.Add("@quatity", quantity);
                        keyValues.Add("@amountUN", AmountUN);
                        keyValues.Add("@profitUN", ProfitUN);
                        keyValues.Add("@amount", totalAmountRaised);
                        keyValues.Add("@profit", totalProfit);
                        keyValues.Add("@solds", UnitsSolds);
                        keyValues.Add("@date_expiration", dateFirst.ToShortDateString());*//*

            Dictionary<string, object> list = new Dictionary<string, object>();
            list.Add("quantity", quantity);
            list.Add("amountUN", AmountUN);
            list.Add("profitUN", ProfitUN);
            list.Add("amount", totalAmountRaised);
            list.Add("profit", totalProfit);
            list.Add("units_solds", UnitsSolds);
            list.Add("date_expiration", dateFirst.ToShortDateString());*//* Int_Number_Of_Units_Sold*//*
            return list;

            *//*            string query = $@"
                                SELECT {Properties.Resources.Lot_Name_Column} as String_Product,
                                    SUM({Properties.Resources.Lot_Quatity_Products_Column}) as ProductsQuantity,
                                    SUM({Properties.Resources.Lot_Price_Lote_Column}) as PriceLote,
                                    SUM({Properties.Resources.Lot_Profit_Percentage_Column}) as ProfitPorcentage,
                                    SUM({Properties.Resources.Lot_Units_Solds_Column}) UnitsSolds,
                                    COUNT(*) as Quantity,
                                    (
                                        SELECT 
                                            {Properties.Resources.Lot_Date_Expiration_Column}
                                        FROM 
                                            {Properties.Resources.Lot_Table_Name}
                                        WHERE
                                            {Properties.Resources.Lot_Name_Column} = L.{Properties.Resources.Lot_Name_Column}
                                        ORDER BY 
                                            ABS
                                            (
                                            julianday({Properties.Resources.Lot_Date_Expiration_Column}) - 
                                            julianday('now')
                                            ) LIMIT 1
                                    ) as DataExpiration
                                FROM
                                    {Properties.Resources.Lot_Table_Name} L
                                WHERE 
                                    {Properties.Resources.Lot_Name_Column} = '{name}'
                                GROUP BY
                                    {Properties.Resources.Lot_Name_Column}";
                        using (var dt = SQLite.C_SQLite.DataQueryLanguage(query))
                        {
                            MessageBox.Show(dt.Rows[0].Field<decimal>("PriceLote").ToString());

                            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();

                            int quantity = Convert.ToInt32(dt.Rows[0][$"ProductsQuantity"]);
                            int unitsSolds = Convert.ToInt32(dt.Rows[0]["UnitsSolds"]);
                            decimal priceLote = Convert.ToDecimal(dt.Rows[0]["PriceLote"]);
                            decimal profitPercentage = Convert.ToDecimal(dt.Rows[0]["ProfitPorcentage"]);
                            decimal amount = priceLote / quantity * (profitPercentage / 100 + 1) * unitsSolds;
                            decimal profit = priceLote / quantity * (profitPercentage / 100) * unitsSolds;
                            decimal amountUN = priceLote / quantity * (profitPercentage / 100 + 1);
                            decimal profitUN = priceLote / quantity * (profitPercentage / 100);

                            keyValuePairs.Add("@quantity", quantity);
                            keyValuePairs.Add("@amount", amount);
                            keyValuePairs.Add("@profit", profit);
                            keyValuePairs.Add("@amountUN", amountUN);
                            keyValuePairs.Add("@profitUN", profitUN);
                            keyValuePairs.Add("@solds", unitsSolds);
                            keyValuePairs.Add("@date_expiration", dt.Rows[0].Field<string>("DataExpiration"));
                            return keyValuePairs;*//*
        }



        internal static void UpdateInventoryColumns()
        {
            string query = $@"
                            SELECT DISTINCT 
                                {Properties.Resources.Lot_Name_Column}
                            FROM 
                                {Properties.Resources.Lot_Table_Name}";

            using (DataTable dataTable = SQLite.C_SQLite.DataQueryLanguage(query))
            {
                query = $@"
                            UPDATE 
                                {Properties.Resources.Inventory_Table_Name}
                            SET 
                                {Properties.Resources.Inventory_Quantity_Column} = @quantity, 
                                {Properties.Resources.Inventory_AmountUN_Column} = @amountUN,
                                {Properties.Resources.Inventory_ProfitUN_Column} = @profitUN,
                                {Properties.Resources.Inventory_Amount_Column} = @amount,
                                {Properties.Resources.Inventory_Profit_Column} = @profit,
                                {Properties.Resources.Inventory_Solds_Column} = @solds,
                                {Properties.Resources.Inventory_Date_Expiration_Column} = @date_expiration
                            WHERE
                                {Properties.Resources.Inventory_Name_Column} = @name";

                foreach (var x in dataTable.AsEnumerable())
                {
                    var list = CalculateColumns(
                                            x.Field<string>("String_Product"));

                    Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
                    keyValuePairs.Add("@name", x.Field<string>("String_Product"));
                    keyValuePairs.Add("@quantity", list["quantity"]);
                    keyValuePairs.Add("@amountUN", list["amountUN"]);
                    keyValuePairs.Add("@profitUN", list["profitUN"]);
                    keyValuePairs.Add("@amount", list["amount"]);
                    keyValuePairs.Add("@profit", list["profit"]);
                    keyValuePairs.Add("@solds", list["units_solds"]);
                    keyValuePairs.Add("@date_expiration", list["date_expiration"]);
                    MessageBox.Show("");
                    SQLite.C_SQLite.DataManipulationLanguage(query, keyValuePairs);
                }
            }
        }*/

        public static void UpdateColumns() // ADICIONAR OS STATUS
        {
            /*string query = $@"   
                WITH DistinctNames AS
                (
                    SELECT DISTINCT {Properties.Resources.Lot_Name_Column} 
                    FROM {Properties.Resources.Lot_Table_Name}
                )
                UPDATE {Properties.Resources.Inventory_Table_Name}
                SET
                {Properties.Resources.Inventory_Quantity_Column} = 
                    (
                        SELECT SUM({Properties.Resources.Lot_Quatity_Products_Column})
                        FROM {Properties.Resources.Lot_Table_Name}
                        WHERE {Properties.Resources.Lot_Table_Name} = @name
                    ),
                {Properties.Resources.Inventory_Amount_Column} = 
                    (
                        SELECT 
                        {Properties.Resources.Lot_Price_Lote_Column} / 
                        {Properties.Resources.Lot_Quatity_Products_Column} *
                        ({Properties.Resources.Lot_Profit_Percentage_Column} + 1) * 
                        {Properties.Resources.Lot_Units_Solds_Column}
                        FROM {Properties.Resources.Lot_Table_Name}
                        WHERE {Properties.Resources.Lot_Table_Name} = @name
                    ),
                {Properties.Resources.Inventory_Profit_Column} =
                (
                    SELECT 
                        {Properties.Resources.Lot_Price_Lote_Column} / 
                        {Properties.Resources.Lot_Quatity_Products_Column} *
                        {Properties.Resources.Lot_Profit_Percentage_Column} * {Properties.Resources.Lot_Units_Solds_Column} 
                        FROM {Properties.Resources.Lot_Table_Name}
                        WHERE {Properties.Resources.Lot_Table_Name} = @name
                ),
                {Properties.Resources.Inventory_AmountUN_Column} = 
                    (
                    SELECT 
                        {Properties.Resources.Lot_Price_Lote_Column} / 
                        {Properties.Resources.Lot_Quatity_Products_Column} *
                        ({Properties.Resources.Lot_Profit_Percentage_Column} + 1)
                        FROM {Properties.Resources.Lot_Table_Name}
                        WHERE {Properties.Resources.Lot_Table_Name} = @name
                    ),
                {Properties.Resources.Inventory_ProfitUN_Column} = 
                    (
                    SELECT 
                        {Properties.Resources.Lot_Price_Lote_Column} / 
                        {Properties.Resources.Lot_Quatity_Products_Column} *
                        ({Properties.Resources.Lot_Profit_Percentage_Column} + 1)
                        FROM {Properties.Resources.Lot_Table_Name}
                        WHERE {Properties.Resources.Lot_Table_Name} = @name
                    ),
                {Properties.Resources.Inventory_Solds_Column} = 
                    (
                        SELECT SUM({Properties.Resources.Lot_Units_Solds_Column})
                        FROM {Properties.Resources.Lot_Table_Name}
                        WHERE {Properties.Resources.Lot_Table_Name} = @name
                    ),
                {Properties.Resources.Inventory_Date_Expiration_Column} = 
                    (
                        SELECT {Properties.Resources.Lot_Date_Expiration_Column} as 'Data'
                        FROM {Properties.Resources.Lot_Table_Name}
                        WHERE {Properties.Resources.Lot_Table_Name} = @name
                        ORDER BY ABS
                        (
                            julianday(date('now', 'localtime')) - julianday(date(Data, 'DD/MM/YYYY'))
                        )
                            ASC
                            LIMIT 1
                    )
                WHERE {Properties.Resources.Lot_Table_Name} = @name
            ";*/
            /*            string query = $@"
                WITH DistinctNames AS (
                    SELECT DISTINCT {Properties.Resources.Lot_Name_Column} AS UniqueName
                    FROM {Properties.Resources.Lot_Table_Name}
                )
                UPDATE {Properties.Resources.Inventory_Table_Name} AS inv
                SET
                    {Properties.Resources.Inventory_Quantity_Column} = (
                        SELECT SUM({Properties.Resources.Lot_Quatity_Products_Column})
                        FROM {Properties.Resources.Lot_Table_Name} AS lot
                        WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.{Properties.Resources.Inventory_Name_Column}
                    ),
                    {Properties.Resources.Inventory_Amount_Column} = (
                        SELECT 
                            {Properties.Resources.Lot_Price_Lote_Column} / 
                            {Properties.Resources.Lot_Quatity_Products_Column} *
                            ({Properties.Resources.Lot_Profit_Percentage_Column} + 1) * 
                            {Properties.Resources.Lot_Units_Solds_Column}
                        FROM {Properties.Resources.Lot_Table_Name} AS lot
                        WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.{Properties.Resources.Inventory_Name_Column}
                    ),
                    {Properties.Resources.Inventory_Profit_Column} = (
                        SELECT 
                            {Properties.Resources.Lot_Price_Lote_Column} / 
                            {Properties.Resources.Lot_Quatity_Products_Column} *
                            {Properties.Resources.Lot_Profit_Percentage_Column} * {Properties.Resources.Lot_Units_Solds_Column} 
                        FROM {Properties.Resources.Lot_Table_Name} AS lot
                        WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.{Properties.Resources.Inventory_Name_Column}
                    ),
                    {Properties.Resources.Inventory_AmountUN_Column} = (
                        SELECT 
                            {Properties.Resources.Lot_Price_Lote_Column} / 
                            {Properties.Resources.Lot_Quatity_Products_Column} *
                            ({Properties.Resources.Lot_Profit_Percentage_Column} + 1)
                        FROM {Properties.Resources.Lot_Table_Name} AS lot
                        WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.{Properties.Resources.Inventory_Name_Column}
                    ),
                    {Properties.Resources.Inventory_ProfitUN_Column} = (
                        SELECT 
                            {Properties.Resources.Lot_Price_Lote_Column} / 
                            {Properties.Resources.Lot_Quatity_Products_Column} *
                            ({Properties.Resources.Lot_Profit_Percentage_Column} + 1)
                        FROM {Properties.Resources.Lot_Table_Name} AS lot
                        WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.{Properties.Resources.Inventory_Name_Column}
                    ),
                    {Properties.Resources.Inventory_Solds_Column} = (
                        SELECT SUM({Properties.Resources.Lot_Units_Solds_Column})
                        FROM {Properties.Resources.Lot_Table_Name} AS lot
                        WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.{Properties.Resources.Inventory_Name_Column}
                    ),
                    {Properties.Resources.Inventory_Date_Expiration_Column} = (
                        SELECT {Properties.Resources.Lot_Date_Expiration_Column}
                        FROM {Properties.Resources.Lot_Table_Name} AS lot
                        WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.{Properties.Resources.Inventory_Name_Column}
                        ORDER BY ABS(julianday(date('now', 'localtime')) - julianday(date(lot.{Properties.Resources.Lot_Date_Expiration_Column}, 'DD/MM/YYYY')))
                        LIMIT 1
                    )
                WHERE
                    inv.{Properties.Resources.Inventory_Name_Column} IN (SELECT UniqueName FROM DistinctNames)";*/
            string query = $@"
                UPDATE {Properties.Resources.Inventory_Table_Name} AS inv
                SET
                {Properties.Resources.Inventory_Quantity_Column} = (
                SELECT SUM(lot.{Properties.Resources.Lot_Quatity_Products_Column})
                FROM {Properties.Resources.Lot_Table_Name}
                    AS lot
                INNER JOIN {Properties.Resources.Inventory_Table_Name}
                    AS inv2 ON lot.{Properties.Resources.Lot_Name_Column} = inv2.{Properties.Resources.Inventory_Name_Column}
                    WHERE inv2.{Properties.Resources.Inventory_Name_Column} = inv.{Properties.Resources.Inventory_Name_Column}
            ),
            {Properties.Resources.Inventory_Amount_Column} = (
                SELECT
                    SUM({Properties.Resources.Lot_Price_Lote_Column}) * 1.0 /
                    SUM(CAST({Properties.Resources.Lot_Quatity_Products_Column} AS DECIMAL)) *1.0 *
                    SUM({Properties.Resources.Lot_Profit_Percentage_Column} / 100.0 + 1.0) *
                    SUM(CAST({Properties.Resources.Lot_Units_Solds_Column} AS DECIMAL)) * 1.0 /
                    COUNT({Properties.Resources.Lot_ID_Column}) * 1.0
                    FROM {Properties.Resources.Lot_Table_Name} AS lot
                WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.{Properties.Resources.Inventory_Name_Column}
            ),
            {Properties.Resources.Inventory_Profit_Column} = (
                SELECT
                    SUM({Properties.Resources.Lot_Price_Lote_Column}) * 1.0 /
                    SUM(CAST({Properties.Resources.Lot_Quatity_Products_Column} AS DECIMAL)) *1.0 *
                    SUM({Properties.Resources.Lot_Profit_Percentage_Column} / 100.0) *
                    SUM(CAST({Properties.Resources.Lot_Units_Solds_Column} AS DECIMAL)) * 1.0 /
                    COUNT({Properties.Resources.Lot_ID_Column}) * 1.0
                    FROM {Properties.Resources.Lot_Table_Name}
                    AS lot
                WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.{Properties.Resources.Inventory_Name_Column}
            ),
            {Properties.Resources.Inventory_AmountUN_Column} = (
                SELECT
                    SUM({Properties.Resources.Lot_Price_Lote_Column}) * 1.0 /
                    SUM({Properties.Resources.Lot_Quatity_Products_Column}) *
                    SUM({Properties.Resources.Lot_Profit_Percentage_Column} / 100.0 + 1.0) /
                    COUNT({Properties.Resources.Lot_ID_Column}) * 1.0
                FROM {Properties.Resources.Lot_Table_Name}
                    AS lot
                WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.{Properties.Resources.Inventory_Name_Column}
            ),
            {Properties.Resources.Inventory_ProfitUN_Column} = (
                SELECT
                    SUM({Properties.Resources.Lot_Price_Lote_Column}) * 1.0 /
                    SUM({Properties.Resources.Lot_Quatity_Products_Column}) *
                    SUM({Properties.Resources.Lot_Profit_Percentage_Column} / 100.0) /
                    COUNT({Properties.Resources.Lot_ID_Column}) * 1.0
                FROM {Properties.Resources.Lot_Table_Name}
                    AS lot
                WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.{Properties.Resources.Inventory_Name_Column}
            ),
            {Properties.Resources.Inventory_Solds_Column} = (
                SELECT SUM({Properties.Resources.Lot_Units_Solds_Column})
                FROM {Properties.Resources.Lot_Table_Name}
                    AS lot
                WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.{Properties.Resources.Inventory_Name_Column}
            ),
            {Properties.Resources.Inventory_Date_Expiration_Column} = (
                SELECT {Properties.Resources.Lot_Date_Expiration_Column}
                    FROM {Properties.Resources.Lot_Table_Name}
                    AS lot
                WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.{Properties.Resources.Inventory_Name_Column}
                    ORDER BY 
                        ABS(julianday(date('now', 'localtime')) - 
                        julianday(substr(lot.{Properties.Resources.Lot_Date_Expiration_Column}, 7, 4) || '-' || substr(lot.{Properties.Resources.Lot_Date_Expiration_Column}, 4, 2) || '-' || substr(lot.{Properties.Resources.Lot_Date_Expiration_Column}, 1, 2)))
                LIMIT 1
            )";

            SQLite.C_SQLite.DataManipulationLanguage(query);
        }

        public static void InsertItemsInInveoryIfNotExists() // ADICIONAR OS STATUS
        {
            try
            {
                string invName = Properties.Resources.Inventory_Name_Column;
                string invQuantity = Properties.Resources.Inventory_Quantity_Column;
                string invAmount = Properties.Resources.Inventory_Amount_Column;
                string invProfit = Properties.Resources.Inventory_Profit_Column;
                string invAmountUN = Properties.Resources.Inventory_AmountUN_Column;
                string invProfitUN = Properties.Resources.Inventory_ProfitUN_Column;
                string invSolds = Properties.Resources.Inventory_Solds_Column;
                string invExpiration = Properties.Resources.Inventory_Date_Expiration_Column;
                string insert = $@"
                INSERT INTO
                    {Properties.Resources.Inventory_Table_Name}
                (
                    {Properties.Resources.Inventory_Name_Column}, 
                    {Properties.Resources.Inventory_Quantity_Column}, 
                    {Properties.Resources.Inventory_Amount_Column}, 
                    {Properties.Resources.Inventory_AmountUN_Column}, 
                    {Properties.Resources.Inventory_Profit_Column}, 
                    {Properties.Resources.Inventory_ProfitUN_Column}, 
                    {Properties.Resources.Inventory_Solds_Column},
                    {Properties.Resources.Inventory_Date_Expiration_Column}
                )
                SELECT 
                    inv.Name,
                    (
                        SELECT SUM({Properties.Resources.Lot_Quatity_Products_Column}) 
                        FROM {Properties.Resources.Lot_Table_Name} 
                        WHERE {Properties.Resources.Lot_Name_Column} = inv.Name
                    ) AS Quantity,
                    (
                        SELECT 
                            SUM({Properties.Resources.Lot_Price_Lote_Column}) * 1.0 /
                            SUM(CAST({Properties.Resources.Lot_Quatity_Products_Column} AS DECIMAL)) *1.0 *
                            SUM({Properties.Resources.Lot_Profit_Percentage_Column} / 100.0 + 1.0) *
                            SUM(CAST({Properties.Resources.Lot_Units_Solds_Column} AS DECIMAL)) * 1.0 /
                            COUNT({Properties.Resources.Lot_ID_Column}) * 1.0
                        FROM {Properties.Resources.Lot_Table_Name} AS lot
                        WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.Name
                    ) AS Amount,
                    (
                        SELECT 
                                SUM({Properties.Resources.Lot_Price_Lote_Column}) * 1.0 /
                                SUM({Properties.Resources.Lot_Quatity_Products_Column}) *
                                SUM({Properties.Resources.Lot_Profit_Percentage_Column} / 100.0 + 1.0) /
                                COUNT({Properties.Resources.Lot_ID_Column}) * 1.0
                        FROM {Properties.Resources.Lot_Table_Name} AS lot
                        WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.Name
                    ) AS AmountUN,
                    (
                        SELECT 
                            SUM({Properties.Resources.Lot_Price_Lote_Column}) * 1.0 /
                            SUM(CAST({Properties.Resources.Lot_Quatity_Products_Column} AS DECIMAL)) *1.0 *
                            SUM({Properties.Resources.Lot_Profit_Percentage_Column} / 100.0) *
                            SUM(CAST({Properties.Resources.Lot_Units_Solds_Column} AS DECIMAL)) * 1.0 /
                            COUNT({Properties.Resources.Lot_ID_Column}) * 1.0
                        FROM {Properties.Resources.Lot_Table_Name} AS lot
                        WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.Name
                    ) AS Profit,
                    (
                        SELECT 
                            SUM({Properties.Resources.Lot_Price_Lote_Column}) * 1.0 /
                            SUM({Properties.Resources.Lot_Quatity_Products_Column}) *
                            SUM({Properties.Resources.Lot_Profit_Percentage_Column} / 100.0) /
                            COUNT({Properties.Resources.Lot_ID_Column}) * 1.0
                        FROM {Properties.Resources.Lot_Table_Name} AS lot
                        WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.Name
                    ) AS ProfitUN,
                    (
                        SELECT SUM({Properties.Resources.Lot_Units_Solds_Column})
                        FROM {Properties.Resources.Lot_Table_Name} AS lot
                        WHERE lot.{Properties.Resources.Lot_Name_Column} = inv.Name
                    ) AS Solds,
                    (
                        SELECT 
                            {Properties.Resources.Lot_Date_Expiration_Column}
                        FROM 
                            {Properties.Resources.Lot_Table_Name} AS lot
                        WHERE 
                            lot.{Properties.Resources.Lot_Name_Column} = 
                            inv.Name
                        ORDER BY 
                            ABS(julianday(date('now', 'localtime')) - julianday(substr(lot.{Properties.Resources.Lot_Date_Expiration_Column}, 7, 4) || '-' || substr(lot.{Properties.Resources.Lot_Date_Expiration_Column}, 4, 2) || '-' || substr(lot.{Properties.Resources.Lot_Date_Expiration_Column}, 1, 2)))
                        LIMIT 1
                    ) AS Date_Expiration
                FROM 
                    (SELECT DISTINCT {Properties.Resources.Lot_Name_Column} as Name 
                    FROM {Properties.Resources.Lot_Table_Name}
                    WHERE NOT EXISTS (
                        SELECT 1 FROM {Properties.Resources.Inventory_Table_Name} 
                        WHERE {Properties.Resources.Inventory_Name_Column} = {Properties.Resources.Lot_Name_Column})
                    ) AS inv";

                SQLite.C_SQLite.DataManipulationLanguage(insert);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
         }   
    }
}

