using EmployeeForms.DataContract;
using EmployeeForms.Services;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeForms.OtherForms
{
    public partial class ViewManageEmployee : MetroFramework.Forms.MetroForm
    {
        private Form1 _principal;
        private EmployeeUpdateRequest _employeeRequest;
        private Int16 Clicks = 0;
        public ViewManageEmployee(Form1 principal, EmployeeUpdateRequest employee)
        {
            InitializeComponent();
            this._principal = principal;
            _employeeRequest = employee;
            Populate();
        }

        private void EnableAll()
        {
            textbox_name.Enabled = true;
            textbox_lastname.Enabled = true;
            textbox_email.Enabled = true;
            textbox_cpf.Enabled = true;
            textbox_startWork.Enabled = true;
            textbox_lunchTime.Enabled = true;
            textbox_endWork.Enabled = true;
            textbox_positionWork.Enabled = true;
            textbox_phoneNumber.Enabled = true;
            textbox_department.Enabled = true;
            numUpDown_PIS.Enabled = true;
            dateTime_dateBirth.Enabled = true;
        }

        private void Populate()
        {
            textbox_name.Text = _employeeRequest.FirstName;
            textbox_lastname.Text = _employeeRequest.LastName;
            textbox_email.Text = _employeeRequest.Email;
            textbox_cpf.Text = _employeeRequest.CPF.ToString();
            textbox_startWork.Text = _employeeRequest.StartWork;
            textbox_lunchTime.Text = _employeeRequest.LunchTime;
            textbox_endWork.Text = _employeeRequest.EndtWork;
            textbox_positionWork.Text = _employeeRequest.PositionWork;  
            textbox_phoneNumber.Text = _employeeRequest.PhoneNumber;
            textbox_department.Text = _employeeRequest.Department;
            numUpDown_PIS.Value = (decimal)_employeeRequest.SocialIntegrationProgramNumber;
            dateTime_dateBirth.Value = DateTime.Parse(_employeeRequest.DateBirth);
        }

        private async void metroButton1_Click(object sender, EventArgs e)
        {
            EnableAll();
            Clicks++;
            metroButton1.Text = "Confirmar";
            try
            {
                if (Clicks >= 2)
                {
                    MessageBox.Show(dateTime_dateBirth.Value.ToString("dd/MM/yyyy"));
                    string CPF = Regex.Replace(textbox_cpf.Text, "[^0-9]", "");
                    EmployeeUpdateRequest employeeUpdateRequest = new EmployeeUpdateRequest()
                    {
                        FirstName = textbox_name.Text,
                        LastName = textbox_lastname.Text,
                        Email = textbox_email.Text,
                        PositionWork = textbox_positionWork.Text,
                        StartWork = textbox_startWork.Text + ":00",
                        EndtWork = textbox_endWork.Text + ":00",
                        LunchTime = textbox_lunchTime.Text + ":00",
                        CPF = Int64.Parse(CPF),
                        DateBirth = dateTime_dateBirth.Value.ToString("dd/MM/yyyy"),
                        SocialIntegrationProgramNumber = Int64.Parse(numUpDown_PIS.Value.ToString()),
                        Department = textbox_department.Text,
                        PhoneNumber = textbox_phoneNumber.Text,
                        ID = _employeeRequest.ID
                    };
                    EmployeeResponse response = await new EmployeeService().UpdateEmployee(employeeUpdateRequest);
                    if (response != null)
                    {
                        _principal.PopulateGrid();
                        MessageBox.Show(response.ToString());
                        Close();
                    } else
                    {
                        MessageBox.Show(response.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Test");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private async void metroButton4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza?", "Excluir funcionario!", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;
            try
            {
                if (await new EmployeeService().DeleteEmployee(_employeeRequest.ID))
                {
                    _principal.PopulateGrid();
                    MessageBox.Show("Empregado demitido/apagado com sucesso!");
                    Close();
                }
                else
                    throw new Exception("Erro ao demitir/apagar empregado!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
