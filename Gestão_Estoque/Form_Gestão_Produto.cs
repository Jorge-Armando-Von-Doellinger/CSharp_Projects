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
    public partial class Form_Gestão_Produto : MetroFramework.Forms.MetroForm
    {
        public Form_Gestão_Produto(string name)
        {
            InitializeComponent();
            string query =
                    $@"SELECT
                        {Properties.Resources.Lot_ID_Column} AS 'ID',
                        {Properties.Resources.Lot_Name_Column} AS 'Nome do Lote',
                        {Properties.Resources.Lot_Price_Lote_Column} AS 'Valor',
                        {Properties.Resources.Lot_Quatity_Products_Column} AS 'Qntd de Produtos',
                        {Properties.Resources.Lot_Units_Solds_Column} AS 'Qntd de Vendidos',
                        {Properties.Resources.Lot_Profit_Percentage_Column} AS 'Porcentagem de lucro',
                        {Properties.Resources.Lot_Status_Column} AS 'Status',
                        {Properties.Resources.Lot_Category_Column} AS 'Categoria',
                        {Properties.Resources.Lot_Date_Expiration_Column} AS 'Validade'
                    FROM 
                        {Properties.Resources.Lot_Table_Name}
                    WHERE
                        String_Product= '{name}'";
            using (DataTable dt = SQLite.DataQueryLanguage(query))
            {
                metroGrid1.DataSource = dt;
            }
            metroGrid1.Columns["ID"].Visible = false;
        }

        private static void AddRowDataBase()
        {
            
            string query = $@"
                INSERT INTO 
                    {Properties.Resources.Lot_Table_Name} 
                SET 
                    (
                        {Properties.Resources.Lot_Name_Column}, 
                        {Properties.Resources.Lot_Price_Lote_Column}, 
                        {Properties.Resources.Lot_Quatity_Products_Column}, 
                        {Properties.Resources.Lot_Profit_Percentage_Column}, 
                        {Properties.Resources.Lot_Status_Column}, 
                        {Properties.Resources.Lot_Category_Column},
                        {Properties.Resources.Lot_Date_Expiration_Column}
                    )
                VALUES 
                    (
                        @name,
                        @price_lote,
                        @quantity_products,
                        @percetage_profit,
                        @status,
                        @category,
                        @date_expiration    
                    )";
            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            using(Form_AddLote _form_Add = new Form_AddLote())
            {
                _form_Add.ShowDialog();
            }
        }
    }
}
