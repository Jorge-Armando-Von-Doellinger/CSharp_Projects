using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gestão_Estoque
{


    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private bool? IsNewRow = null;

        public Form1()
        {
            UpdateInventory();
            InitializeComponent();
            verifyItemsOnInventoryByLots();
            RefreshDataSource();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            try
            {
                
                string query = $@"SELECT 
                                    {Properties.Resources.Lot_Category_Column} as 'Category'
                                FROM 
                                    {Properties.Resources.Lot_Table_Name}";
                using (DataTable dt = SQLite.DataQueryLanguage(query))
                {
                    string[] strings = dt.AsEnumerable()
                        .Select(name => name.Field<string>("Category"))
                        .Distinct()
                        .ToArray();
                    metroComboBox1.DataSource = strings;
                    metroComboBox1.DisplayMember = "Category";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }
        }

        private static void verifyItemsOnInventoryByLots()
        {
            string query = $@"
                SELECT 
                    {Properties.Resources.Inventory_Name_Column} as 'Nome'
                FROM
                    {Properties.Resources.Inventory_Table_Name}";
            using (DataTable dt = SQLite.DataQueryLanguage(query))
            {
                query = $@"SELECT {Properties.Resources.Lot_Name_Column} FROM {Properties.Resources.Lot_Table_Name}";
                using (DataTable dtLots = SQLite.DataQueryLanguage(query))
                {
                    try
                    {
                        int rowsDistinc = dtLots.AsEnumerable()
                                                .GroupBy(row => row.Field<string>("String_Product"))
                                                .Count();
                        if (rowsDistinc != dt.AsEnumerable().Count())
                        {
                            string[] strings = dt.AsEnumerable()
                                .Select(row => row.Field<string>("Nome"))
                                .ToArray();
                            //Pega os nomes que tem e passa para o SetAllIntoInventory ignora-los
                            Class_Calculate_Columns_DB.SetAllIntoInventory(strings);

                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                        throw;
                    }
                }
            }
        }

        private void UpdateInventory()
        {
            Class_Calculate_Columns_DB.UpdateAllInventory();
        }

        private async void RefreshDataSource()
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
                                {Properties.Resources.Inventory_Table_Name}";
            DataTable dt = SQLite.DataQueryLanguage(query);
            metroGrid1.DataSource = null;
            metroGrid1.DataSource = dt;
            metroGrid1.Columns["ID"].Visible = false;
/*            metroGrid1.Columns["Nome"].ReadOnly = true;
            metroGrid1.Columns["Quantidade"].ReadOnly = true;*/

            metroGrid1.Columns[3].DefaultCellStyle.Format = "C2";
            metroGrid1.Columns[4].DefaultCellStyle.Format = "C2";
            metroGrid1.Columns[5].DefaultCellStyle.Format = "C2";
            metroGrid1.Columns[6].DefaultCellStyle.Format = "C2";

            metroGrid1.ContextMenuStrip = metroContextMenu1;

/*            await Task.Delay(10000);
            *//*metroGrid1.DataSource = dt;*//*

            metroGrid1.Columns["ID"].Visible = false;
            metroGrid1.Columns["Nome"].ReadOnly = true;
            metroGrid1.Columns[3].DefaultCellStyle.Format = "C2";
            metroGrid1.Columns[4].DefaultCellStyle.Format = "C2";
            metroGrid1.Columns[5].DefaultCellStyle.Format = "C2";
            metroGrid1.Columns[6].DefaultCellStyle.Format = "C2";

            metroGrid1.ContextMenuStrip = metroContextMenu1;*/
        }

        private static void ExpiredProductsOrNotHaveProducts() // IF not have products
        {
            string query = $@"
                        SELECT 
                            {Properties.Resources.Inventory_Table_Name}
                        FROM
                            {Properties.Resources.Inventory_Table_Name}";
            using (DataTable dataTable = SQLite.DataQueryLanguage(query))
            {
                query = $@"SELECT DISTINCT
                                {Properties.Resources.Lot_Name_Column}
                            FROM
                                {Properties.Resources.Lot_Table_Name}";
                using (DataTable dataTable2 = SQLite.DataQueryLanguage(query))
                {
                    if(dataTable.Rows.Count == dataTable2.Rows.Count)
                    {
                        return;
                    }
                    else if(dataTable2.Rows.Count < dataTable.Rows.Count)//If true, inventory have lines more
                    {

                    }
                }
            }
        }

        private bool RowIsNullOrIncompleted() //SERA DELETADA
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                for (int i = 1; i < metroGrid1.SelectedRows[0].Cells.Count; i++)
                {
                    if (metroGrid1.SelectedRows[0].Cells[i].Value.ToString().Trim().Length == 0 || metroGrid1.SelectedRows[0].Cells[i].Value == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void AddRowDataBase(int index) //EXCLUIR
        {
            try
            {
                string query = $@"
                    INSERT INTO
                        {Properties.Resources.Inventory_Table_Name}
                        (
                        {Properties.Resources.Inventory_Table_Name}, {Properties.Resources.Inventory_Quantity_Column},
                        {Properties.Resources.Inventory_AmountUN_Column}, {Properties.Resources.Inventory_Amount_Column}, 
                        {Properties.Resources.Inventory_Date_Expiration_Column}, {Properties.Resources.Inventory_Solds_Column}, 
                        {Properties.Resources.Inventory_ProfitUN_Column}, {Properties.Resources.Inventory_ProfitUN_Column}
                        )
                    VALUES
                        (@name, @quantity, @amountUN ,@amount, @expiration_date, @sold, @profitUN,@profit)
                        ";
                Dictionary<string, object> keyValues = new Dictionary<string, object>();
                keyValues.Add("@name", metroGrid1.Rows[index].Cells["Nome"].Value); //Nome vem do lote
                keyValues.Add("@quantity", metroGrid1.Rows[index].Cells["Quantidade"].Value);
                keyValues.Add("@amountUN", metroGrid1.Rows[index].Cells["Valor (un)"].Value);
                keyValues.Add("@amount", metroGrid1.Rows[index].Cells["Valor total arrecadado"]);
                keyValues.Add("@profitUN", metroGrid1.Rows[index].Cells["Lucro (un)"].Value);
                keyValues.Add("@profit", metroGrid1.Rows[index].Cells["Lucro total arrecadado"]);
                keyValues.Add("@sold", metroGrid1.Rows[index].Cells["Vendidos"].Value);
                keyValues.Add("@expiration_date", metroGrid1.Rows[index].Cells["Validade"].Value);
                SQLite.DataManipulationLanguage(query, keyValues);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }
        }

        private void EditRowDataBase(int index) //EXCLUIR
        {

            try
            {
                string query = @"
                    UPDATE
                        Inventory_Management1
                    SET
                        Product_Name = @name,
                         Product_Quantity = @quantity,
                        Product_Amount = @amount, Product_Amount_UN = @amountUN,
                        Products_Date_Expiration = @expiration_date, 
                        Products_Sold = @sold, Product_Profit = @profit, Product_Profit_UN = @profitUN
                    WHERE
                        Product_ID = @ID
                       
                    AND EXISTS (
                        SELECT 1
                            FROM 
                                Lots_Management 
                        WHERE 
                            String_Product = @name
                        )";

                Dictionary<string, object> keyValues = new Dictionary<string, object>();
                keyValues.Add("@ID", metroGrid1.Rows[index].Cells["ID"].Value);

                keyValues.Add("@name", metroGrid1.Rows[index].Cells["Nome"].Value); //Nome vem do lote
                keyValues.Add("@quantity", metroGrid1.Rows[index].Cells["Quantidade"].Value);
                keyValues.Add("@amountUN", metroGrid1.Rows[index].Cells["Valor (un)"].Value);
                keyValues.Add("@amount", metroGrid1.Rows[index].Cells["Valor total arrecadado"].Value);
                keyValues.Add("@profitUN", metroGrid1.Rows[index].Cells["Lucro (un)"].Value);
                keyValues.Add("@profit", metroGrid1.Rows[index].Cells["Lucro total arrecadado"].Value);
                keyValues.Add("@sold", metroGrid1.Rows[index].Cells["Vendidos"].Value);
                keyValues.Add("@expiration_date", metroGrid1.Rows[index].Cells["Validade"].Value);
                SQLite.DataManipulationLanguage(query, keyValues);


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }
        }

        private void DeleteRowDataBase(int index) //SAIR
        {
            string query = @"
                    DELETE FROM
                        Inventory_Management1
                    WHERE
                        Product_ID = @ID";
            Dictionary<string, object> valuePairs = new Dictionary<string, object>();
            valuePairs.Add("@ID", index);
            SQLite.DataManipulationLanguage(query, valuePairs);
        }

        private async void metroGrid1_CellEndEdit(object sender, DataGridViewCellEventArgs e) //SAIR
        {
            //Row leave com NewRow true, faz criação de linha no database
            bool rowCompleted = true;
            foreach (DataGridViewCell cell in metroGrid1.Rows[e.RowIndex].Cells)
            {
                if (cell.Value == null || cell.Value.ToString().Trim().Length < 1)
                {
                    rowCompleted = false;
                    break;
                }

            }
            if (IsNewRow == true && rowCompleted == true)
            {
                IsNewRow = false;
                AddRowDataBase(e.RowIndex);
                await Task.Delay(1);
                RefreshDataSource();
                if (e.RowIndex >= 0)
                {
                    metroGrid1.Rows[e.RowIndex].Selected = true;
                }

            }
            else if (IsNewRow == false && rowCompleted == true)
            {
                EditRowDataBase(e.RowIndex);
            }
        }

        private void metroGrid1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) //SAIR
        {
            switch (metroGrid1.Rows[e.RowIndex].IsNewRow)
            {
                case true:
                    IsNewRow = true;
                    break;

                case false:
                    IsNewRow = false;
                    break;
            }
        }

        private void metroGrid1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) //SAIR
        {
            DialogResult confirm = MessageBox.Show("Confirmar exclusão?", "Excluir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                int index = Convert.ToInt32(e.Row.Cells["ID"].Value);
                DeleteRowDataBase(index);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void metroGrid1_MouseDown(object sender, MouseEventArgs e) // MODIFICAR
        {
            if (e.Button == MouseButtons.Right)
            {

                DataGridView.HitTestInfo hitTestInfo = metroGrid1.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    metroGrid1.ClearSelection();
                    metroGrid1.Rows[hitTestInfo.RowIndex].Selected = true;
                    metroGrid1.ContextMenuStrip.Show(metroGrid1, new Point(e.X, e.Y));

                }
            }
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e) //MODIFICAR
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                string cell = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
                Form_Gestão_Produto gestão_Produto = new Form_Gestão_Produto(cell);
                gestão_Produto.ShowDialog();

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_deletarLinha_Click(object sender, EventArgs e)
        {
            int index = metroGrid1.SelectedRows[0].Index;
            DeleteRowDataBase(index);
        }

        private async void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //SAIR
        {
            if (e.ColumnIndex == 1)
            {
                Int16 Rowindex = Convert.ToInt16(e.RowIndex);
                Object cell1 = metroGrid1.SelectedRows[Rowindex].Cells[1].Value;
                Form_SelectProduct _SelectProduct = new Form_SelectProduct(this);
                _SelectProduct.ShowDialog();
                if (_SelectProduct.OperatioCompleted == false)
                {
                    metroGrid1.Rows[Rowindex].Cells[1].Value = cell1;
                }
                else if (_SelectProduct.OperatioCompleted == true)
                {
                    //EDITA A TABELA APÓS FINALIZAR
                    EditRowDataBase(Rowindex);
                }
                string name = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string status = "Vencido";
                int index = Convert.ToInt32(metroGrid1.Rows[e.RowIndex].Cells[0].Value);
                Class_Calculate_Columns_DB reCalculate = new Class_Calculate_Columns_DB(name, status, index);
                await Task.Delay(10);
                RefreshDataSource();
                

            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
