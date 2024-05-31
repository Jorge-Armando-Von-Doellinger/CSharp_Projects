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
    public partial class Form_SelectProduct : MetroFramework.Forms.MetroForm
    {
        public bool OperatioCompleted;
        Form1 formulario;
        public Form_SelectProduct(Form1 form)
        {
            InitializeComponent();
            string query = @"
                SELECT
                    String_Product as 'Produto',
                    Int_Quantity_Products as 'Quantidade',
                    String_Stauts as 'Status',
                    String_Date_Expiration as 'Validade'
                FROM 
                    Lots_Management 
                GROUP BY 
                    String_Product";
            DataTable dataTable = SQLite.DataQueryLanguage(query);
            metroGrid1.DataSource = dataTable;
            formulario = form;
        }

        private void metroGrid1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridView row = (DataGridView)sender;
                /*MessageBox.Show(row.SelectedRows[0].Cells[0].Value.ToString());*/
                formulario.metroGrid1.CurrentRow.Cells[1].Value = row.SelectedRows[0].Cells[0].Value;
                OperatioCompleted = true;
                this.Close();
            }
            catch(Exception error)
            {
                OperatioCompleted = false;
                MessageBox.Show(error.Message);
                throw;

            }
        }
    }
}
