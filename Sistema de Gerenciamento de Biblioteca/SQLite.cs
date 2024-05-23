using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using System;*/
using System.Windows.Forms;

namespace database
{
    public class SQLite
    {
        public static SQLiteConnection GetSQLiteConnection()
        {
            string directoryDB = AppDomain.CurrentDomain.BaseDirectory + "\\database\\ToDoList.db";
            string connectionString = $@"Data Source={directoryDB}";
            return new SQLiteConnection(connectionString);
        }

        public static void DataManipulationLanguage(string query, Dictionary<string, object> param = null)
        {
            try
            {

                using (SQLiteConnection connection = SQLite.GetSQLiteConnection())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        if(param != null && param.Count > 0) 
                        {
                            foreach (var parameter in param)
                            {
                                command.Parameters.AddWithValue($"{parameter.Key}", parameter.Value);
                            }
                            command.ExecuteNonQuery();
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw err;
            }
        }

        public static DataTable DataQueryLanguage(string query)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (SQLiteConnection connection = GetSQLiteConnection())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                    connection.Close();
                }
                return dataTable;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw new Exception(error.Message);
            }
        }
    }
}
