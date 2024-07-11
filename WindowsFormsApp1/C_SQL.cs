using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace SQLite
{
    internal class C_SQLite
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

            using (SQLiteConnection connection = SqliteConnection())
            {
                connection.Open();
                using (SQLiteTransaction transation = connection.BeginTransaction())
                {
                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Transaction = transation;
                            if (keyValuePairs != null)
                            {

                                foreach (KeyValuePair<string, object> values in keyValuePairs)
                                {
                                    command.Parameters.AddWithValue($"{values.Key}", values.Value);
                                }
                            }
                            command.ExecuteNonQuery();
                        }
                        transation.Commit();
                    }
                    catch (Exception error)
                    {
                        transation.Rollback();
                        MessageBox.Show(error.Message);
                        throw;
                    }
                }
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
