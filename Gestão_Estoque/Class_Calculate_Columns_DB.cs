using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_Estoque
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
    class Class_Calculate_Columns_DB : IDisposable
    {
        public Class_Calculate_Columns_DB(string name = "", string status = "", int index = -100)
        {
            /*            SetInventoryQuantity(name, index, status);
                        SetInventoryAmountUN(name, status, index);
                        SetProfitUN(name, status, index);
                        SetTotalAmountRaised(name, status, index);
                        SetTotalProfit(name, status, index);
                        SetTotalSolds(name, status, index);
                        SetDateExpiration(name,status, index);*/
            if (name == "" && status == "" && index == -100)
            {
            }


        }

        public void SetInventoryQuantity(string name, int index, string status = "Valido") // AUTOMATICO
        {
            //Index == ID que esta na Coluna 0 do DataTable
            string query = $@"SELECT
                                Int_Quantity_Products
                            FROM
                                Lots_Management
                            WHERE
                                String_Product = '{name}' AND String_Stauts='{status}'";
            var dt = SQLite.DataQueryLanguage(query).AsEnumerable();
            int quantity = 0;
            foreach (var row in dt)
            {
                quantity += Convert.ToInt32(row.Field<Int64>("Int_Quantity_Products"));
            }
            query = $@"UPDATE Inventory_Management1 SET Product_Quantity = @quantity WHERE Product_ID = @ID";
            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
            keyValuePairs.Add("@quantity", quantity);
            keyValuePairs.Add("@ID", index);
            SQLite.DataManipulationLanguage(query, keyValuePairs);
        }

        public void SetInventoryAmountUN(string name, string status, int index = 0) //STRUCT --- Passilvel para modificação do usuario
        {
            string query = $@"SELECT 
                                Decimal_Price_Lote,
                                Decimal_Total_Profit_Percentage,
                                Int_Quantity_Products
                            FROM 
                                Lots_Management
                            WHERE
                                String_Product = '{name}' AND String_Stauts= '{status}'";
            var dt = SQLite.DataQueryLanguage(query).AsEnumerable();
            decimal AmountUN = 0;
            /*int lines = 0;*/
            foreach (var row in dt)
            {
                AmountUN += (
                    (decimal)row.Field<decimal>("Decimal_Price_Lote") /
                    (Int32)row.Field<Int64>("Int_Quantity_Products") *
                    ((decimal)row.Field<decimal>("Decimal_Total_Profit_Percentage") / 100 + 1));


            }
            AmountUN /= dt.Count();



            query = @"UPDATE 
                        Inventory_Management1
                    SET
                        Product_Amount_UN = @AmountUN
                    WHERE
                        Product_Name = @name
                    ";
            //COLOCAR NOME EM UNIQUE
            Dictionary<string, object> keyValues = new Dictionary<string, object>();
            keyValues.Add("@name", name);
            keyValues.Add("@AmountUN", AmountUN);
            SQLite.DataManipulationLanguage(query, keyValues);
        }

        public void SetProfitUN(string name, string status, int index = 0) //STRUCT --- Passilvel para modificação do usuario
        {
            string query = $@"SELECT 
                                Decimal_Price_Lote,
                                Decimal_Total_Profit_Percentage,
                                Int_Quantity_Products
                            FROM 
                                Lots_Management
                            WHERE
                                String_Product = '{name}' AND String_Stauts='{status}'";
            var dt = SQLite.DataQueryLanguage(query).AsEnumerable();
            decimal ProfitUN = 0;
            foreach (var row in dt)
            {
                ProfitUN += (
                    (decimal)row.Field<decimal>("Decimal_Price_Lote") /
                    (Int32)row.Field<Int64>("Int_Quantity_Products") *
                    ((decimal)row.Field<decimal>("Decimal_Total_Profit_Percentage") / 100)
                    );
            }
            ProfitUN /= dt.Count();

            query = @"UPDATE 
                        Inventory_Management1
                    SET
                       Product_Profit_UN = @profitUN 
                    WHERE 
                        Product_Name = @name";
            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
            keyValuePairs.Add("@name", name);
            keyValuePairs.Add("@profitUN", ProfitUN);
            SQLite.DataManipulationLanguage(query, keyValuePairs);
        }

        public void SetTotalAmountRaised(string name, string status, int index = 0) //STRUCT --- AUTOMATICO 
        {
            /*Total arrecadado é a quantidade de vendidos
                    multiplicado pelo valor unitario    */

            /*
                Vai ser o valor anterior += total arrecadado
                        Resetará após acabar/estiver acabando os produtos dos lotes e/ou com a
                            vontade do usuario! Botão*/

            /*            string query = $@"SELECT
                                            Lots_Management.Int_Number_Of_Units_Sold,
                                            Inventory.Product_Amount_UN
                                        FROM 
                                            Lots_Management
                                        INNER JOIN 
                                            Inventory_Management1 AS 'Inventory'
                                        ON
                                            Lots_Management.String_Product = Inventory.Product_Name
                                        WHERE
                                            Inventory.Product_Name = '{name}'";*/
            string query = $@"SELECT
                                Decimal_Price_Lote,
                                Int_Quantity_Products,
                                Int_Number_Of_Units_Sold,
                                Decimal_Total_Profit_Percentage
                            FROM
                                Lots_Management
                            WHERE 
                                String_Product = '{name}'";
            var dt = SQLite.DataQueryLanguage(query);
            /*            int numSolds = 0;*/
            decimal AmountUN = 0;
            foreach (var row in dt.AsEnumerable())
            {
                AmountUN += ((row.Field<decimal>("Decimal_Price_Lote") /
                    row.Field<Int64>("Int_Quantity_Products")) *
                    (row.Field<decimal>("Decimal_Total_Profit_Percentage") / 100 + 1)) *
                    (Int32)row.Field<Int64>("Int_Number_Of_Units_Sold");
            }

            /*AmountUN /= dt.Rows.Count;*/
            query = @"UPDATE 
                        Inventory_Management1 
                    SET
                        Product_Amount = @amount
                    WHERE
                        Product_ID = @ID";
            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
            keyValuePairs.Add("@ID", index);
            keyValuePairs.Add("@amount", AmountUN);
            SQLite.DataManipulationLanguage(query, keyValuePairs);

        }

        public void SetTotalProfit(string name, string status, int index = 0) //STRUCT --- AUTOMATICo
        {
            //TOTAL DOS VALORES DOS LOTE / QUANTIDADE DE PRODUTOS
            /*
    Vai ser o valor anterior += total arrecadado
            Resetará após acabar/estiver acabando os produtos dos lotes e/ou com a
                vontade do usuario! Botão*/
            string query = $@"SELECT
                                Decimal_Price_Lote,
                                Int_Quantity_Products,
                                Int_Number_Of_Units_Sold,
                                Decimal_Total_Profit_Percentage
                            FROM
                                Lots_Management
                            WHERE 
                                String_Product = '{name}'";
            DataTable dt = SQLite.DataQueryLanguage(query);
            decimal totalProfit = 0;
            foreach (var row in dt.AsEnumerable())
            {
                totalProfit +=
                    row.Field<decimal>("Decimal_Price_Lote") /
                    (Int32)row.Field<Int64>("Int_Quantity_Products") *
                    (Int32)row.Field<Int64>("Int_Number_Of_Units_Sold") *
                    (row.Field<decimal>("Decimal_Total_Profit_Percentage") / 100);
            }
            /*totalProfit /= dt.Rows.Count;*/

            query = @"UPDATE
                        Inventory_Management1
                    SET 
                        Product_Profit = @totalProfit
                    WHERE 
                        Product_Name = @name";

            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
            keyValuePairs.Add("@name", name);
            keyValuePairs.Add("@totalProfit", totalProfit);
            SQLite.DataManipulationLanguage(query, keyValuePairs);
        }

        public void SetTotalSolds(string name, string status, int index = 0) //SEMI - AUTOMATICO /NAO PRECISA MEXER AGORA
        {
            string query = $@"SELECT
                                Int_Number_Of_Units_Sold
                            FROM
                                Lots_Management
                            WHERE
                                String_Product = '{name}'";
            DataTable dt = SQLite.DataQueryLanguage(query);
            int UnitsSolds = 0;
            foreach (DataRow row in dt.Rows)
            {
                UnitsSolds += (Int32)row.Field<Int64>("Int_Number_Of_Units_Sold");
            }

            query = $@"UPDATE
                        Inventory_Management1
                    SET
                        Products_Sold = @unitsSolds
                    WHERE
                        Product_Name = @name";
            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
            keyValuePairs.Add("@name", name);
            keyValuePairs.Add("@unitsSolds", UnitsSolds);
            SQLite.DataManipulationLanguage(query, keyValuePairs);
        }

        public void SetDateExpiration(string name, string status, int index = 0) // AUTOMATICO
        {
            string query = $@"SELECT
                                String_Date_Expiration
                            FROM 
                                Lots_Management
                            WHERE
                                String_Product = '{name}' AND String_Stauts = '{status}'";
            DataTable dt = SQLite.DataQueryLanguage(query);
            List<DateTime> dateTimes = new List<DateTime>();
            foreach (DataRow row in dt.Rows)
            {
                dateTimes.Add(DateTime.Parse(row.Field<string>("String_Date_Expiration")));
            }
            DateTime dateOrdened = dateTimes.OrderBy(d => Math.Abs((d - DateTime.Now).TotalDays)).First();

            query = @"UPDATE
                        Inventory_Management1
                    SET
                        Products_Date_Expiration = @Date_Expiration
                    WHERE
                        Product_ID =@ID";
            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
            keyValuePairs.Add("@ID", index);
            keyValuePairs.Add("@Date_Expiration", dateOrdened.ToShortDateString());
            SQLite.DataManipulationLanguage(query, keyValuePairs);
        }

        public static Dictionary<string, object> CalculateAllColumns(string name) //Pode precisar
        {
            //-----------------------------Set Qqntd de produtos
            string query = $@"SELECT
                                *
                            FROM
                                {Properties.Resources.Lot_Table_Name}
                            WHERE
                                {Properties.Resources.Lot_Name_Column} = '{name}' 
                            AND 
                                {Properties.Resources.Lot_Status_Column} <> 'Vencido'";
            /*String_Stauts<>'{status}'*/
            var dt = SQLite.DataQueryLanguage(query).AsEnumerable();

            int quantity = 0;
            int UnitsSolds = 0;
            decimal AmountUN = 0;
            decimal ProfitUN = 0;
            decimal totalAmountRaised = 0;
            decimal totalProfit = 0;
            /*decimal loteTotalPrice = 0;*/
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
            /*totalProfit -= loteTotalPrice;*/
            DateTime dateFirst = dateTimes.OrderBy(d => Math.Abs((d - DateTime.Now).TotalDays)).First();

            /*            query = $@"UPDATE 
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
                        keyValues.Add("@date_expiration", dateFirst.ToShortDateString());*/

            Dictionary<string, object> list = new Dictionary<string, object>();
            list.Add("quantity", quantity);
            list.Add("amountUN", AmountUN);
            list.Add("profitUN", ProfitUN);
            list.Add("amount", totalAmountRaised);
            list.Add("profit", totalProfit);
            list.Add("units_solds", UnitsSolds);
            list.Add("date_expiration", dateFirst.ToShortDateString());/* Int_Number_Of_Units_Sold*/
            return list;

        }

        public static void UpdateAllInventory()
        {
            string query = $@"
                            SELECT DISTINCT 
                                {Properties.Resources.Lot_Name_Column}
                            FROM 
                                {Properties.Resources.Lot_Table_Name}";

            using (DataTable dataTable = SQLite.DataQueryLanguage(query))
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
                    var list = CalculateAllColumns(
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

                    SQLite.DataManipulationLanguage(query, keyValuePairs);
                }
            }
        }
        public static void SetAllIntoInventory() // PEGO OS DIFERENTES E IGNORO OS QUE TENHO NO INVENTARIO E DPS INSIRO
        {
            /*string query = $@"SELECT DISTINCT 
                                String_Product
                            FROM 
                                {Properties.Resources.Lot_Table_Name}";
            if(namesExclude.Length > 0)
            {
                query += $@" WHERE ";
                for(int i = 0; i < namesExclude.Length; i++)
                {
                    query += $@" String_Product <> '{namesExclude[i]}'";
                    if(i < namesExclude.Length - 1)
                    {
                        query += " AND ";
                    }
                }
            } 
            PEGA OS NOMES QUE NÃO TEM NO INV MAS TEM NO LOTE
            using (DataTable dataTable = SQLite.DataQueryLanguage(query))
            {
                string query1 = $@"
                            BEGIN TRANSACTION;
                                INSERT INTO Inventory_Management1
                                (
                                    Product_Name, Product_Quantity, Product_Amount_UN, Product_Profit_UN,
                                    Product_Amount, Product_Profit, Products_Sold, Products_Date_Expiration
                                )
                                SELECT 
                                    @name, @quantity, @amountUN, @profitUN, @amount, @profit, @solds, @date_expiration
                                WHERE NOT EXISTS 
                                (
                                    SELECT 1 FROM Inventory_Management1 WHERE Product_Name = @name
                                );
                            COMMIT;
                            ";*/
            string query = $@"SELECT 
                                {Properties.Resources.Lot_Name_Column} 
                            FROM 
                                {Properties.Resources.Lot_Table_Name} 
                            WHERE
                                {Properties.Resources.Lot_Name_Column} 
                            NOT IN (
                                SELECT
                                    {Properties.Resources.Inventory_Name_Column} 
                                FROM 
                                    {Properties.Resources.Inventory_Table_Name}
                                    )";
            using (DataTable dataTable = SQLite.DataQueryLanguage(query))
            {
                query = $@"
                            BEGIN TRANSACTION;
                                INSERT INTO Inventory_Management1
                                (
                                    Product_Name, Product_Quantity, Product_Amount_UN, Product_Profit_UN,
                                    Product_Amount, Product_Profit, Products_Sold, Products_Date_Expiration
                                )
                                SELECT 
                                    @name, @quantity, @amountUN, @profitUN, @amount, @profit, @solds, @date_expiration
                                WHERE NOT EXISTS 
                                (
                                    SELECT 1 FROM Inventory_Management1 WHERE Product_Name = @name
                                );
                            COMMIT;
                            ";
                foreach (var x in dataTable.AsEnumerable()) // PEGO O NUMERO LINHAS
                {
                    var list = CalculateAllColumns(
                                            x.Field<string>("String_Product"));

                    Dictionary<string, object> keyValuePairs = new Dictionary<string, object>(); // PEGO NOME
                    keyValuePairs.Add("@name", x.Field<string>("String_Product"));
                    keyValuePairs.Add("@quantity", list["quantity"]);
                    keyValuePairs.Add("@amountUN", list["amountUN"]);
                    keyValuePairs.Add("@profitUN", list["profitUN"]);
                    keyValuePairs.Add("@amount", list["amount"]);
                    keyValuePairs.Add("@profit", list["profit"]);
                    keyValuePairs.Add("@solds", list["units_solds"]);
                    keyValuePairs.Add("@date_expiration", list["date_expiration"]);

                    SQLite.DataManipulationLanguage(query, keyValuePairs);

                }
                
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

