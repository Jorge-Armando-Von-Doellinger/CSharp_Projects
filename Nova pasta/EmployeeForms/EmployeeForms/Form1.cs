using EmployeeForms.DataContract;
using EmployeeForms.OtherForms;
using EmployeeForms.Services;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeForms
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            PopulateGrid();
        }

        private void CombineColumns()
        {
            // Adiciona uma nova coluna para os valores combinados
            //metroGrid1.Columns.Add("NomeCompleto", "Nome Completo");

            // Percorre cada linha e combina os valores das colunas "Nome" e "Sobrenome"
            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                if (row.IsNewRow) continue; // Ignora a linha nova

                string nome = row.Cells["firstName"].Value?.ToString();
                string sobrenome = row.Cells["LastName"].Value?.ToString();

                // Combina os valores e insere na nova coluna
                row.Cells["nameComplete"].Value = $"{nome} {sobrenome}";
            }
        }

        public async void PopulateGrid(List<EmployeeResponse> data = null)
        {
            data = data ?? await new EmployeeService().GetEmployees();
            metroGrid1.DataSource = data;
            //MessageBox.Show(data[0].PositionWork);
            metroGrid1.Columns["id"].Visible = false;
            metroGrid1.Columns["id"].Name = "ID";
            metroGrid1.Columns["firstName"].HeaderText = "Nome";
            metroGrid1.Columns["firstName"].Visible = false;
            
            metroGrid1.Columns["LastName"].HeaderText = "Sobrenome";
            metroGrid1.Columns["LastName"].Visible = false;
            metroGrid1.Columns["yearsOld"].HeaderText = "Idade";
            metroGrid1.Columns["phoneNumber"].HeaderText = "N° p/ contato";
            metroGrid1.Columns["email"].HeaderText = "Email";
            metroGrid1.Columns["email"].Visible = false;
            metroGrid1.Columns["cpf"].DefaultCellStyle.Format = "000\\.000\\.000\\-00";
            metroGrid1.Columns["cpf"].HeaderText = "CPF";
            metroGrid1.Columns["cpf"].Visible = false;
            metroGrid1.Columns["department"].HeaderText = "Departamento";
            metroGrid1.Columns["startWork"].DefaultCellStyle.Format = "hh:mm";
            metroGrid1.Columns["lunchTime"].DefaultCellStyle.Format = "hh:mm";
            metroGrid1.Columns["endtWork"].DefaultCellStyle.Format = "hh:mm";
            metroGrid1.Columns["startWork"].HeaderText = "Hora de saída";
            metroGrid1.Columns["lunchTime"].HeaderText = "Hora de saída";
            metroGrid1.Columns["endtWork"].HeaderText = "Hora de saída";
            metroGrid1.Columns["startWork"].Visible = false;
            metroGrid1.Columns["lunchTime"].Visible = false;
            metroGrid1.Columns["endtWork"].Visible = false;
            metroGrid1.Columns["PositionWork"].HeaderText = "Cargo";
            metroGrid1.Columns["socialIntegrationProgramNumber"].HeaderText = "PIS";
            metroGrid1.Columns["socialIntegrationProgramNumber"].Visible = false;
            metroGrid1.Columns["updatedAt"].HeaderText = "Atualizado em";
            metroGrid1.Columns["updatedAt"].DisplayIndex = metroGrid1.Columns.Count - 1;
            metroGrid1.Columns.Add("nameComplete", "Nome Completo");
            metroGrid1.Columns["nameComplete"].DisplayIndex = 0;
            CombineColumns();
        }

        private async void metroGrid1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridView senderConverted = (DataGridView)sender;
                if (senderConverted.SelectedRows.Count > 0)
                {
                    Int64 index = Int64.Parse(senderConverted.SelectedRows[0].Cells["ID"].Value.ToString());
                    EmployeeResponse employee = await new EmployeeService().GetEmployeesByID(index);
                    EmployeeUpdateRequest employeeResquestMap = new EmployeeUpdateRequest()
                    {
                        ID = employee.ID,
                        Email = employee.Email,
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,   
                        CPF = employee.CPF,
                        DateBirth = employee.DateBirth,
                        Department = employee.Department,
                        EndtWork = employee.EndtWork,
                        LunchTime = employee.LunchTime,
                        PhoneNumber = employee.PhoneNumber,
                        PositionWork = employee.PositionWork,
                        SocialIntegrationProgramNumber = employee.SocialIntegrationProgramNumber,   
                        StartWork = employee.StartWork,
                        YearsOld = employee.YearsOld
                    };
                    new ViewManageEmployee(this, employeeResquestMap).ShowDialog();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void adicionarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddEmployee(this).ShowDialog();
        }
    }
}
