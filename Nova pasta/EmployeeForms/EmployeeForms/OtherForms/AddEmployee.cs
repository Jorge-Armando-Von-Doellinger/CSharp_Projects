using EmployeeForms.DataContract;
using EmployeeForms.OtherForms.UserControls;
using EmployeeForms.OtherForms.Validation;
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

namespace EmployeeForms.OtherForms
{
    public partial class AddEmployee : MetroFramework.Forms.MetroForm
    {
        private bool next = false;
        private AddDataBasic _dataBasic;
        private AddDataWork _dataWork;
        private EmployeeRequest _employeeRequest;
        private Form1 _principal;
        public AddEmployee(Form1 primcipal)
        {
            InitializeComponent();
            _dataBasic = new AddDataBasic();
            _dataWork = new AddDataWork();
            _employeeRequest = new EmployeeRequest();
            metroPanel1.Controls.Clear();
            metroPanel1.Controls.Add(_dataBasic);
            _principal = primcipal;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private async void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!next)
                {
                    
                    _employeeRequest.FirstName = _dataBasic.FirstName;
                    _employeeRequest.LastName = _dataBasic.LastName;
                    _employeeRequest.CPF = _dataBasic.CPF ;
                    _employeeRequest.Email = _dataBasic.Email;
                    _employeeRequest.DateBirth = _dataBasic.DateBirth.ToString("yyyy-MM-dd");
                    _employeeRequest.PhoneNumber = _dataBasic.PhoneNumber;
                    
                    if (await RequestValidation.ValidateBasicData(_employeeRequest))
                    {
                        next = true;

                        // Atualizando o painel na thread da UI
                        if (InvokeRequired)
                        {
                            Invoke(new Action(() =>
                            {
                                metroPanel1.Controls.Clear();
                                metroPanel1.Controls.Add(_dataWork);
                                metroPanel1.Refresh();
                            }));
                        }
                        else
                        {
                            metroPanel1.Controls.Clear();
                            metroPanel1.Controls.Add(_dataWork);
                            metroPanel1.Refresh();
                        }
                    }
                    else
                        MessageBox.Show(_employeeRequest.CPF.ToString());
                }
                else
                {
                    _employeeRequest.StartWork = _dataWork.StartWork.ToString("hh:mm:ss");
                    _employeeRequest.EndtWork = _dataWork.EndWork.ToString("hh:mm:ss");
                    _employeeRequest.LunchTime = _dataWork.LunchTime.ToString("hh:mm:ss");
                    _employeeRequest.PositionWork = _dataWork.PositionWork;
                    _employeeRequest.SocialIntegrationProgramNumber = _dataWork.SocialIntegrationProgramNumber;
                    _employeeRequest.Department = _dataWork.Department;
                    //Validation --- Futuramente? -----
                    EmployeeResponse response = await new EmployeeService().AddEmployee(_employeeRequest);
                    if (response != null)
                    {
                        _principal.PopulateGrid(await new EmployeeService().GetEmployees());
                        MessageBox.Show("Empregado adicionado com sucesso!");
                    }
                    else
                        throw new Exception("Erro ao adicionar funcionario!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
    }
}
