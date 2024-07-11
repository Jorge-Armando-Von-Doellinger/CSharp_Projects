using System.Net.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UControl_Lots_Management : MetroFramework.Controls.MetroUserControl
    {
        Form1 form1;
        public UControl_Lots_Management(Form1 form)
        {
            InitializeComponent();
            RefreshDataSource();
            form1 = form;
        }

        private void RefreshDataSource()
        {
            string table = $@"
                SELECT 
                    {Properties.Resources.Lot_ID_Column} as 'ID',
                    {Properties.Resources.Lot_Name_Column} as 'Lote',
                    {Properties.Resources.Lot_Price_Lote_Column} as 'Preço do lote',
                    {Properties.Resources.Lot_Quatity_Products_Column} as 'Quantidade',
                    {Properties.Resources.Lot_Units_Solds_Column} as 'Vendidos',
                    {Properties.Resources.Lot_Profit_Percentage_Column} as 'Porcentagem de lucro',
                    {Properties.Resources.Lot_Status_Column} as 'Status',
                    {Properties.Resources.Lot_Category_Column} as 'Categoria',
                    {Properties.Resources.Lot_CodBar_Column} as 'N. do lote',
                    {Properties.Resources.Lot_Brand_Column} as 'Marca',
                    {Properties.Resources.Lot_Date_Expiration_Column} as 'Data de validade'
                FROM 
                    {Properties.Resources.Lot_Table_Name}
                ORDER BY Lote";
            metroGrid1.DataSource = null;
            metroGrid1.DataSource = SQLite.C_SQLite.DataQueryLanguage(table);

            metroGrid1.Columns["ID"].Visible = false;
            metroGrid1.ContextMenuStrip = metroContextMenu1;
        }

        private void adicionarLoteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            F_InsertLot _InsertLot = new F_InsertLot();
            _InsertLot.ShowDialog();
            if(_InsertLot.RowAddedSuccess == true)
            {
                form1.mButton_refreshInv.Enabled = true;
                form1.mButton_refreshInv.Visible = true;
                RefreshDataSource();
            }
        }
    }
}
