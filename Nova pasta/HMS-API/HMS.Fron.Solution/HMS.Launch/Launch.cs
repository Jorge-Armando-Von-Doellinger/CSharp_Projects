using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HMS.CommunicationAPI.Entities.Response;
using HMS.CommunicationAPI.Services;
using HMS.Launch.Views.Patients;


namespace HMS.Launch
{
    public partial class Launch : MetroFramework.Forms.MetroForm
    {
        public Launch()
        {
            InitializeComponent();
            
            ButtonPatientClick();
            //metroGrid1.DataSource = null;
            //1teste();
        }

        private void ButtonPatientClick()
        {
            //panel2.Controls.Clear();
            new PatientViewData().ShowDialog();
        }


    }
}
