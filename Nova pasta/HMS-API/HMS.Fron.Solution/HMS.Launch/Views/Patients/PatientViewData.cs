using HMS.CommunicationAPI.Entities.Response;
using HMS.CommunicationAPI.Services;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Launch.Views.Patients
{
    public partial class PatientViewData : MetroFramework.Forms.MetroForm
    {
        public PatientViewData()
        {
            InitializeComponent();
            PopulateGridOnListPatients();
        }

        public async void PopulateGridOnListPatients()
        {
            List<PatientResponse> patients = await PatientServices.GetPatients();
            metroGrid1.DataSource = patients;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
