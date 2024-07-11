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
    public partial class UControl_Department_Sales : UserControl
    {
        public UControl_Department_Sales()
        {
            InitializeComponent();
            /*Populate("Batata", 10, "10/10/2024");*/
        }

        private void AddItemsOnListView()
        {

            DataTable row = SelectDataByCodBar(ReadBarFromImage.GetCodBarFromImage(openFileDialog1));
            string name = row.Rows[0].Field<string>($"{Properties.Resources.Lot_Name_Column}");
            decimal price = row.Rows[0].Field<decimal>($"{Properties.Resources.Lot_Price_Lote_Column}");
            string dateExpiration = row.Rows[0][$"{Properties.Resources.Lot_Date_Expiration_Column}"].ToString();
            Populate(name, price, dateExpiration);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            /*string barcode = ReadBarFromImage.GetCodBarFromImage(openFileDialog1);*/
            /*Populate("Batata", 10, "10/10/2024");*/
            AddItemsOnListView();

        }

        private static DataTable SelectDataByCodBar(string codbar)
        {
            string select = $@"
                SELECT * 
                FROM {Properties.Resources.Lot_Table_Name} lot
                WHERE lot.{Properties.Resources.Lot_CodBar_Column} = '{codbar}' 
                AND ABS(
                    julianday(date('now', 'localtime')) - 
                    julianday(
                        substr(lot.{Properties.Resources.Lot_Date_Expiration_Column}, 7, 4) || '-' || 
                        substr(lot.{Properties.Resources.Lot_Date_Expiration_Column}, 4, 2) || '-' || 
                        substr(lot.{Properties.Resources.Lot_Date_Expiration_Column}, 1, 2)
                    )
                ) = (
                    SELECT MIN(
                        ABS(
                            julianday(date('now', 'localtime')) - 
                            julianday(
                                substr(inner_lot.{Properties.Resources.Lot_Date_Expiration_Column}, 7, 4) || '-' || 
                                substr(inner_lot.{Properties.Resources.Lot_Date_Expiration_Column}, 4, 2) || '-' || 
                                substr(inner_lot.{Properties.Resources.Lot_Date_Expiration_Column}, 1, 2)
                            )
                        )
                    )
                    FROM {Properties.Resources.Lot_Table_Name} inner_lot
                    WHERE inner_lot.{Properties.Resources.Lot_CodBar_Column} = '{codbar}'
                )
                LIMIT 1
            ";
            return SQLite.C_SQLite.DataQueryLanguage(select);
        }

        private void Populate(string product, decimal price, string date_expiration)
        {
            ListViewItem existItem = metroListView2.FindItemWithText(product);
            if (metroListView2.Items.Count > 0)
            {
                if (existItem != null)
                {
                    int quantity = Convert.ToInt32(existItem.SubItems[2].Text) + 1;
                    decimal totalprice = price * quantity;
                    existItem.SubItems[2].Text = quantity.ToString();
                    existItem.SubItems[1].Text = totalprice.ToString();
                    return;
                }
            }
            
            ListViewItem item = new ListViewItem(product);
            item.SubItems.Add(price.ToString());
            item.SubItems.Add("1");
            item.SubItems.Add(date_expiration);
            metroListView2.Items.Add(item);


        }
    }
}
