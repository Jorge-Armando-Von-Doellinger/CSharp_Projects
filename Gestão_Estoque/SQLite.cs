using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace Gestão_Estoque
{
    public class SQLite
    {
        public static SQLiteConnection SqliteConnection()
        {
            try
            {
                string dataSourceConnection = $"Data Source={Environment.CurrentDirectory}\\database\\InventoryManagement.db";
                /*string dataSourceConnection = @"C:\\Users\\myadr\\OneDrive\\Documentos\\GitHub\\CSharp_Projects\\
                 * CSharp_Projects\\Gestão_Estoque\\bin\\Debug\\database\\InventoryManagement.db";*/
                SQLiteConnection connection = new SQLiteConnection(dataSourceConnection);
                
                    return connection;
                
            }
            catch (Exception error)
            {
                /*MessageBox.Show(error.Message);*/
                throw error;
            }
            
        }

        public static void DataManipulationLanguage(string query, Dictionary<string, object> keyValuePairs = null)
        {
            try
            {
                
                using (SQLiteConnection connection = SqliteConnection())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        if (keyValuePairs != null)
                        {

                            foreach (KeyValuePair<string, object> values in keyValuePairs)
                            {
                                command.Parameters.AddWithValue($"{values.Key}", values.Value);
                            }
                        }
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw new Exception(error.Message);
            }
            
        }

        public static DataTable DataQueryLanguage(string query)
        {
            try
            {
                using (SQLiteConnection connection = SqliteConnection())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }
        }
    }
}
