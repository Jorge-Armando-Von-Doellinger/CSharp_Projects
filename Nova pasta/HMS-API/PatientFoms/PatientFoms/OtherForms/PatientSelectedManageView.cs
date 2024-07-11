using PatientFoms.Data.Entities;
using PatientFoms.Mapper;
using PatientFoms.Services;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientFoms.OtherForms
{
    public partial class PatientSelectedManageView : MetroFramework.Forms.MetroForm
    {
        private readonly PatientResponse _patientResponse;
        private readonly Int64 ID;
        private readonly Form1 _principal;
        public PatientSelectedManageView(PatientResponse patientResponse, Form1 principal)
        {
            InitializeComponent();
            _principal = principal;
            _patientResponse = patientResponse;
            ID = _patientResponse.ID;
            PopulateBoxs();
            SetReadOnlyOrNot();
            
        }

        private void UpdatePrincipal()
        {
            _principal.PopulateGrid();
        }

        private void PopulateBoxs()
        {
            //var a = await new PatientService().GetPatientById(10);
            //MessageBox.Show(a.ID.ToString());
            textBox_CPF.Text = _patientResponse.CPF.ToString();
            textBox_Email.Text = _patientResponse.Email;
            textBox_FirstName.Text = _patientResponse.FirstName;
            textBox_LastName.Text = _patientResponse.LastName;
            textBox_PhoneNumber.Text = _patientResponse.PhoneNumber;
            metroDateTime1.Value = _patientResponse.DateBirth;
        }

        private async Task<bool> SetReadOnlyOrNot()
        {
            textBox_CPF.Enabled = textBox_CPF.Enabled == true ? false : true;
            textBox_Email.Enabled = textBox_Email.Enabled == true ? false : true;
            textBox_FirstName.Enabled = textBox_FirstName.Enabled == true ? false : true;
            textBox_LastName.Enabled = textBox_LastName.Enabled == true ? false : true;
            textBox_PhoneNumber.Enabled = textBox_PhoneNumber.Enabled == true ? false : true;
            metroDateTime1.Enabled = metroDateTime1.Enabled == true ? false : true;
            bool allEnable = metroDateTime1.Enabled && 
                metroDateTime1.Enabled && 
                textBox_CPF.Enabled && 
                textBox_Email.Enabled &&
                textBox_FirstName.Enabled &&
                textBox_LastName.Enabled && 
                textBox_PhoneNumber.Enabled;
            return await Task.FromResult(allEnable); 
        }

        private async void UpdatePatientButtonClick(object sender, EventArgs e)
        {
            if (SetReadOnlyOrNot().Result == false)
            {
                bool result = MessageBox.Show("Confirmar", "Realmente deseja atualizar as informações desse paciente?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes;
                if (!result)
                    return;
                //PatientRequest patientMapped = PatientMapper.Mapper(_patientResponse);
                PatientRequest patientRequest = new PatientRequest()
                {
                    ID = _patientResponse.ID,
                    CPF = Convert.ToInt64(textBox_CPF.Text),
                    DateBirth = metroDateTime1.Value,
                    Email = textBox_Email.Text,
                    FirstName = textBox_FirstName.Text,
                    LastName = textBox_LastName.Text,
                    PhoneNumber = textBox_PhoneNumber.Text
                };
                PatientResponse response = await new PatientService().UpdatePatient(patientRequest);
                MessageBox.Show(response.ToString());
                SetReadOnlyOrNot();
                UpdatePrincipal();
            }
        }

        private async void DeletePatientButtonClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deletar paciente?", "Confirmar exclusão", MessageBoxButtons.YesNoCancel);
                if(result != DialogResult.Yes)
                    return;
                PatientRequest patientMapped = PatientMapper.Mapper(_patientResponse);
                PatientResponse patientDeleted = await new PatientService().DeletePatient(patientMapped);
                if (patientDeleted == null || patientDeleted == default)
                    MessageBox.Show("Paciente deletado com sucesso!");
                else
                    MessageBox.Show("Paciente deletado com erros!");
                UpdatePrincipal();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
