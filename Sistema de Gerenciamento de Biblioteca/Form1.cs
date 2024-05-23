using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using database;
using System.Globalization;
using System.Windows.Forms;


namespace Sistema_de_Gerenciamento_de_Biblioteca
{
    public partial class Form1 : Form
    {
        string cmdGet = @"
                SELECT 
                    task_Description as 'Descrição',
                    taks_Date_Addition as 'Data de Adição',
                    task_Date_DeadLine as 'Prazo',
                    task_Status as 'Status',
                    task_ID as 'ID'
                FROM
                    table_tasks
                ";
        public Form1()
        {
            
            DataTable dt = database.SQLite.DataQueryLanguage(cmdGet);
            InitializeComponent();
            dataGridView.DataSource = dt;
            dataGridView.Columns[0].Width = 145;

            comboBox_Status.Items.Add("Pendente");
            comboBox_Status.Items.Add("Atrasado");
            comboBox_Status.Items.Add("Esquecido");
            comboBox_Status.Items.Add("Concluido");
            dataGridView.Columns["ID"].Visible = false;
            
            textBox_desc.Text = dt.Rows[0].Field<string>("Descrição");
            comboBox_Status.Text = dt.Rows[0].Field<string>("Status");
            dateTimePicker_deadLine.Value = DateTime.ParseExact(dt.Rows[0].Field<string>("Prazo"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            maskedTextBox_date_addition.Text = dt.Rows[0].Field<string>("Data de Adição");
            /*tex = dt.Rows[0].Field<string>("Descrição");*/

            /*DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Selecione";
            dataGridView.Columns.Add(checkBoxColumn);*/


        }

        private bool IsNullOrEmpty()
        {
            int tb1 = textBox_desc.Text.Trim().Length;
            int tb2 = comboBox_Status.Text.Trim().Length;
            //int mtb1 = maskedTextBox_date_addition.Text.Trim().Length;
            int mtb2 = dateTimePicker_deadLine.Text.Trim().Length;

            if (tb1 > 1 && tb2 > 6 && mtb2 >= 12)
            {
                return false;
            }
            return true;
        }

        private void ClearText()
        {
            textBox_desc.Text = "";
            comboBox_Status.SelectedItem = "Pendente";
            maskedTextBox_date_addition.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dateTimePicker_deadLine.Text = "";
        }
        
        private void resetDataSourceDGV(string query = null)
        {
            if (query != null)
            {
                DataTable dt = SQLite.DataQueryLanguage(query);
                dataGridView.DataSource = null;
                dataGridView.DataSource = dt;
                dataGridView.Columns[0].Width = 145;
                dataGridView.Columns["ID"].Visible = false;
            }
            else
            {


                string cmdGet = @"
                    SELECT 
                        task_Description as 'Descrição',
                        taks_Date_Addition as 'Data de Adição',
                        task_Date_DeadLine as 'Prazo',
                        task_Status as 'Status',
                        task_ID as 'ID'
                    FROM
                        table_tasks
                    ";
                DataTable dt = SQLite.DataQueryLanguage(cmdGet);
                dataGridView.DataSource = null;
                dataGridView.DataSource = dt;
                dataGridView.Columns[0].Width = 145;
                dataGridView.Columns["ID"].Visible = false;
            }
        }
        private void selectTasksAttributes(string adjetivo)
        {
            try
            {
                string query = $@"
                    SELECT 
                        task_Description as 'Descrição',
                        taks_Date_Addition as 'Data de Adição',
                        task_Date_DeadLine as 'Prazo',
                        task_Status as 'Status',
                        task_ID as 'ID'
                    FROM
                        table_tasks
                    WHERE 
                        task_Status='{adjetivo}'";

                resetDataSourceDGV(query);
                ;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw new Exception(error.Message);
            }
        }

        private void btn_add_task_CLick(object sender, EventArgs e)
        {

            if (IsNullOrEmpty() == true) {
                MessageBox.Show("Texto vazio ou curto demais!");
                return;
            }
            string dateAddtion = DateTime.Now.ToString("dd/MM/yyyy");
            using (SQLiteConnection connection = SQLite.GetSQLiteConnection())
            {
                string cmdInsert = @"
                    INSERT INTO 
                        table_tasks
                            (task_Description, taks_Date_Addition, task_Date_DeadLine, task_Status)
                    VALUES
                        (@desc, @date_addition, @date_deadline, @status)";
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(cmdInsert, connection))
                {
                    command.Parameters.AddWithValue("@desc", textBox_desc.Text);
                    command.Parameters.AddWithValue("@date_addition", dateAddtion);
                    command.Parameters.AddWithValue("@date_deadline", dateTimePicker_deadLine.Value.ToString("dd/MM/yyyy"));
                    command.Parameters.AddWithValue("@status", comboBox_Status.Text);
                    command.ExecuteNonQuery();

                    ClearText();
                    resetDataSourceDGV();
                }
                connection.Close();
                
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if(dg.SelectedRows.Count == 0 ) { return; }
            textBox_desc.Text = dg.SelectedRows[0].Cells[0].Value.ToString();
            maskedTextBox_date_addition.Text = dg.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker_deadLine.Value = Convert.ToDateTime(dg.SelectedRows[0].Cells[2].Value);
            comboBox_Status.Text = dg.SelectedRows[0].Cells[3].Value.ToString();

            /*MessageBox.Show(dg.SelectedRows[0].Cells[4].Value.ToString());*/
        }

        private void btn_save_task_Click(object sender, EventArgs e)
        {
            switch (IsNullOrEmpty())
            {
                case false:
                    try
                    {
                        string query = @"
                                UPDATE
                                    table_tasks
                                SET
                                    task_Description=@desc,
                                    taks_Date_Addition=@date_addition,
                                    task_Date_DeadLine=@date_deadLine,
                                    task_Status=@status
                                WHERE   
                                    task_ID=@id
                                ";

                        Dictionary<string, object> keyValues = new Dictionary<string, object>();
                        keyValues.Add("@desc", textBox_desc.Text);
                        keyValues.Add("@date_addition", maskedTextBox_date_addition.Text);
                        keyValues.Add("@date_deadLine", dateTimePicker_deadLine.Value.ToString("dd/MM/yyyy"));
                        keyValues.Add("@status", comboBox_Status.Text);
                        keyValues.Add("@id", Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ID"].Value));

                        SQLite.DataManipulationLanguage(query, keyValues);

                        dataGridView.SelectedRows[0].Cells[0].Value = textBox_desc.Text;
                        dataGridView.SelectedRows[0].Cells[1].Value = maskedTextBox_date_addition.Text;
                        dataGridView.SelectedRows[0].Cells[2].Value = dateTimePicker_deadLine.Value;
                        dataGridView.SelectedRows[0].Cells[3].Value = comboBox_Status.Text;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                        throw error;
                    }
                    break;

                case true:
                    MessageBox.Show("Há campos vazios ou curtos demais!");
                    break;
            }
            
        }

        private void btn_remove_task_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"DELETE FROM table_tasks WHERE task_ID=@id";
                Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
                keyValuePairs.Add("@id", dataGridView.SelectedRows[0].Cells["ID"].Value);
                SQLite.DataManipulationLanguage(query, keyValuePairs);

                dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw new Exception(error.Message);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ClearText();
            resetDataSourceDGV();
        }

        private void tarefasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearText();
            selectTasksAttributes("Concluido");
        }

        private void tarefasEsquecidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearText();
            selectTasksAttributes("Esquecido");
        }

        private void tarefasAtrasadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearText();
            selectTasksAttributes("Atrasado");
        }

        private void tarefasPendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearText();
            selectTasksAttributes("Pendente");
        }

        private void todasTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearText();
            resetDataSourceDGV();
        }
    }
}
