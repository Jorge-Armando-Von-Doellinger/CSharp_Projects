using PatientFoms.Data.Entities;
using PatientFoms.Services;

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

namespace PatientFoms.OtherForms
{
    public partial class F_InsertPatient : MetroFramework.Forms.MetroForm
    {
        private readonly Form1 _pricipal;
        public F_InsertPatient(Form1 principal)
        {
            InitializeComponent();
            _pricipal = principal;
        }

        private async void AddPatient_ButtonClick(object sender, EventArgs e)
        {
            string regexReplace = Regex.Replace(textBox_CPF.Text, "[^0-9]", "");
            if (Int64.TryParse(regexReplace, out Int64 cpf))
            {
                PatientRequest insertRequest = new PatientRequest()
                {
                    CPF = cpf,
                    DateBirth = metroDateTime1.Value,
                    Email = textBox_Email.Text,
                    FirstName = textBox_FirstName.Text,
                    LastName = textBox_LastName.Text,
                    PhoneNumber = textBox_PhoneNumber.Text
                };
                PatientResponse insertResponse = await new PatientService().CreatePatient(insertRequest);
                if (insertResponse != null)
                {
                    if (insertResponse.ID != null && insertResponse.ID != 0)
                    {
                        _pricipal.PopulateGrid();
                    }
                    return;
                }
            }
            else
            {
                MessageBox.Show("Cpf invalido!");
                return;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
